using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace file_bookmark
{
	public partial class file_list_box : UserControl
	{
		public file_list_box()
		{
			InitializeComponent();
		}

		public string bookmarkbar = "";

		//bookmarkのファイルのデータ()
		/*
		 *["ブックマークバー1","ファイル1のパス","ファイル2のパス"],
		 *["ブックマークバー2","ファイル3のパス"]
		 */
		public List<List<string>> file_data = new List<List<string>>();

		//ファイルリストを表示するためのやつ
		public void display_list(string bbar /*bookmark bar*/)
		{
			//前の表示をリセット
			this.Controls.Clear();

			readcsv();

			//fcb_listにあるコントロール(古いやつ)は削除

			//file_dataから情報を取り出す

			int bbar_pos = -1; //bookmark bar の場所

			for(int i = 0;i < file_data.Count; i++)
			{
				if(file_data[i][0].Contains(bbar))
				{
					bbar_pos = i;
					break;
				}
			}

			//そのブックマークが存在しなかったらやめる
			if(bbar_pos == -1)
			{
				//MessageBox.Show("hoge");
				return;
			}

			//フォルダの位置を把握
			List<string> data_tmp = file_data[bbar_pos];

			//0番目はブックマークフォルダなので消す
			data_tmp.RemoveAt(0);

			//ブックマークが存在しないならやめる
			if(data_tmp.Count == 0)
			{
				return;
			}

			file_click_box fcb_tmp = new file_click_box();
			
			for(int i = 0;i < data_tmp.Count; i++)
			{
				fcb_tmp = new file_click_box();
				fcb_tmp.Name = "fcb"+i.ToString();
				fcb_tmp.text = get_filename(data_tmp[i]); //ファイル名を取得して代入
				fcb_tmp.file_path = data_tmp[i]; //ファイルのパス
				fcb_tmp.label2.Click += box_clicked;
				fcb_tmp.Left = 0;
				fcb_tmp.Top = i*34;
				fcb_tmp.Width = 239;
				fcb_tmp.Height = 34;
				this.Controls.Add(fcb_tmp);
			}
		}


		private void file_list_box_Load(object sender, EventArgs e)
		{

		}

		//削除ボタンがクリックされたら消す
		private void box_clicked(object sender, EventArgs e)
		{
			//表示から消す
			Label objtmp = (Label)sender;

			//controlをfile_click_boxに変換
			file_click_box fcb_ctr = (file_click_box)this.Controls.Find(objtmp.Parent.Name, true)[0];

			Control control = this.Controls.Find(objtmp.Parent.Name, true)[0];
			this.Controls.Remove(control);
			control.Dispose();

			readcsv();

			for (int i = 0; i < file_data.Count; i++)
			{
				if (file_data[i][0] == bookmarkbar)
				{
					for (int j = 1;j < file_data[i].Count;j++) 
					{
						if (file_data[i][j] == fcb_ctr.file_path)
						{
							file_data[i].RemoveAt(j);
						}
					}
					break;
				}
			}

			writecsv();

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
		//二次元配列をcsvとして保存
		private void writecsv()
		{
			string outstr = "";
			for (int i = 0; i < file_data.Count; i++)
			{
				for (int j = 0; j < file_data[i].Count; j++)
				{
					outstr += file_data[i][j];

					if (j != file_data[i].Count - 1)
					{
						outstr += ",";
					}
				}
				if (i != file_data.Count - 1)
				{
					outstr += "\n";
				}
			}

			System.IO.StreamWriter sw = new System.IO.StreamWriter("./bookmark.csv", false, System.Text.Encoding.UTF8);
			sw.Write(outstr);
			//閉じる
			sw.Close();
		}

		//パス to ファイル名
		private string get_filename(string input_str)
		{
			string str = input_str;

			int sp = str.LastIndexOf("\\")+1;

			string ret_str = str.Substring(sp);

			return ret_str;
		}
	}
}
