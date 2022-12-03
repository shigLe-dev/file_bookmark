using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_bookmark
{
	public partial class win2_list : UserControl
	{

		public List<List<string>> file_data = new List<List<string>>();

		public void combo_reset()
		{

			comboBox1.Items.Clear();

			readcsv();

			for (int i = 0; i < file_data.Count; i++)
			{
				comboBox1.Items.Add(file_data[i][0]);
			}

			comboBox1.SelectedIndex = 0;

			//ブックマークのリストを表示する
			file_list_box1.display_list(comboBox1.SelectedItem.ToString());
		}

		public win2_list()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			file_list_box1.display_list(comboBox1.SelectedItem.ToString());
		}

		private void readcsv()
		{
			//初期化
			file_data = new List<List<string>>();

			// 読み込みたいCSVファイルのパスを指定して開く
			StreamReader sr = new StreamReader("./bookmark.csv");
			{
				// 末尾まで繰り返す
				while (!sr.EndOfStream)
				{
					// CSVファイルの一行を読み込む
					string line = sr.ReadLine();
					// 読み込んだ一行をカンマ毎に分けて配列に格納する
					string[] values = line.Split(',');

					// 配列からリストに格納する
					List<string> lists = new List<string>();
					lists.AddRange(values);

					//リストに追加
					file_data.Add(lists);
				}
			}

			sr.Close();
		}
	}
}
