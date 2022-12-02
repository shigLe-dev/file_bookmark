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
	public partial class file_click_box : UserControl
	{
		public file_click_box()
		{
			InitializeComponent();
		}

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
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			this.pictureBox1.Image = Resource1.image_logo;
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
	}
}
