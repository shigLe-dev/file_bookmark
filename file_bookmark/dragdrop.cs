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
	public partial class dragdrop : UserControl
	{
		public dragdrop()
		{
			InitializeComponent();
		}

		private void dragdrop_Load(object sender, EventArgs e)
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
			g.DrawRectangle(p, penb, penb, this.pictureBox1.Width - penb*3, this.pictureBox1.Height - penb*3);

			//リソースを解放する
			p.Dispose();
			g.Dispose();

			//PictureBox1に表示する
			this.pictureBox1.Image = canvas;
		}
	}
}
