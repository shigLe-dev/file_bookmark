using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace file_bookmark
{
	public partial class win1_pin : UserControl
	{
		//bookmarkのファイルのデータ()
		/*
		 *["ブックマークバー1","ファイル1のパス","ファイル2のパス"],
		 *["ブックマークバー2","ファイル3のパス"]
		 */
		public List<List<string>> file_data = new List<List<string>>();

		public win1_pin()
		{
			InitializeComponent();
		}

		private void win1_pin_Load(object sender, EventArgs e)
		{
			//コンボボックス初期化
			combo_reset();

			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			this.pictureBox1.Image = Resource1.add_folder;
		}

		private void dragdrop1_DragDrop(object sender, DragEventArgs e)
		{
			//drag&dropされたファイルのパスを表示
			if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

			string[] dragFilePathArr = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			label2.Text = dragFilePathArr[0];

			readcsv();
			if(comboBox1.SelectedItem != null)
			{
				for (int i = 0; i < file_data.Count; i++)
				{
					if (file_data[i][0] == comboBox1.SelectedItem.ToString())
					{
						file_data[i].Add(dragFilePathArr[0]);
						break;
					}
				}
			}
			else
			{
				label2.Text = "Error:ブックマークフォルダを選択してください。";
			}

			writecsv();

		}

		private void dragdrop1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		//add folder button
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			string folder_name = Interaction.InputBox("新規フォルダの名前を入力してください。");

			//入力されていたら追加
			if(folder_name != "")
			{
				List<string> add_list = new List<string>();

				add_list.Add(folder_name);

				readcsv();
				file_data.Add(add_list);
			}

			writecsv();

			combo_reset();
		}



		//csvを読んでfile_dataに二次元配列として入れる
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

		//二次元配列をcsvとして保存
		private void writecsv()
		{
			string outstr = "";
			for(int i = 0;i < file_data.Count; i++)
			{
				for(int j = 0;j < file_data[i].Count; j++)
				{
					outstr += file_data[i][j];

					if(j != file_data[i].Count-1)
					{
						outstr += ",";
					}
				}
				if(i != file_data.Count-1)
				{
					outstr += "\n";
				}
			}

			System.IO.StreamWriter sw = new System.IO.StreamWriter("./bookmark.csv", false, System.Text.Encoding.UTF8);
			sw.Write(outstr);
			//閉じる
			sw.Close();
		}

		//コンボボックスをリセット
		public void combo_reset()
		{

			comboBox1.Items.Clear();

			readcsv();

			for (int i = 0; i < file_data.Count; i++)
			{
				comboBox1.Items.Add(file_data[i][0]);
			}

			comboBox1.SelectedIndex = 0;
		}

	}
}
