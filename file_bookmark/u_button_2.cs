using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_bookmark
{
	public partial class u_button_2 : UserControl
	{

		public event EventHandler button_click;

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
		public u_button_2()
		{
			InitializeComponent();
		}

		private void u_button_2_Load(object sender, EventArgs e)
		{
			int penb = 3;

			// 描画をクリア
			this.pictureBox1.Image = null;

			//描画先とするImageオブジェクトを作成する
			Bitmap canvas = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			Graphics g = Graphics.FromImage(canvas);

			//Penオブジェクトの作成(幅1の黒色)
			//(この場合はPenを作成せずに、Pens.Blackを使っても良い)
			Pen p = new Pen(Color.FromArgb(0, 255, 136), penb);
			//位置(10, 20)に100x80の長方形を描く
			g.DrawRectangle(p, penb, penb, this.pictureBox1.Width - penb * 3, this.pictureBox1.Height - penb * 3);

			//リソースを解放する
			p.Dispose();
			g.Dispose();

			//PictureBox1に表示する
			this.pictureBox1.Image = canvas;
		}

		//マウスクリックによってラベルの色を変える
		private void label1_MouseUp(object sender, MouseEventArgs e)
		{
			label1.ForeColor = Color.FromArgb(0, 255, 136);
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			label1.ForeColor = Color.FromArgb(0, 150, 77);
		}


		//button click event
		//親のコントロールでクリックイベントを操作できるようにする
		private void label1_Click(object sender, EventArgs e)
		{
			if(button_click != null)
			{
				this.button_click(this, e);
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (button_click != null)
			{
				this.button_click(this, e);
			}
		}
	}
}
