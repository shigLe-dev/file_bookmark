using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_bookmark
{
	public partial class file_click_box : UserControl
	{
		public file_click_box()
		{
			InitializeComponent();
		}

		//ファイルのパス
		public string file_path = "";

		//ファイル名
		public string text
		{
			get
			{
				return (this.label1.Text);
			}
			set
			{
				this.label1.Text = value;
			}
		}

		private void file_click_box_Load(object sender, EventArgs e)
		{
			//画像表示
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			this.pictureBox1.Image = Resource1.image_logo;
		}

		//このボタンがクリックされたら
		private void box_clicked(object sender,EventArgs e)
		{
			if(file_path != "")
			{
				//ファイルを開く
				var p = new Process();
				p.StartInfo = new ProcessStartInfo(file_path)
				{
					UseShellExecute = true
				};
				p.Start();
			}
		}



		//削除ボタンのクリックの時に色を変更
		private void label2_MouseDown(object sender, MouseEventArgs e)
		{
			this.label2.ForeColor = Color.FromArgb(200, 0, 35);
		}

		private void label2_MouseUp(object sender, MouseEventArgs e)
		{
			this.label2.ForeColor = Color.FromArgb(255, 0, 85);
		}

		
		//ボタンクリック時に色を変更
		private void boxmouse_up(object sender,MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(45,45,45);
			label1.ForeColor = Color.FromArgb(0, 255, 136);
		}

		private void boxmouse_down(object sender,MouseEventArgs e)
		{
			this.BackColor = Color.FromArgb(30,30,30);
			label1.ForeColor = Color.FromArgb(0, 150, 77);
		}
	}
}
