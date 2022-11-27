using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace file_bookmark
{

	public partial class u_button_1 : UserControl
	{
		//ボタンの文字列のプロパティ
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

		public u_button_1()
		{
			InitializeComponent();
		}

		private void u_button_1_Load(object sender, EventArgs e)
		{
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			this.pictureBox1.Image = Resource1.button_1;
		}
	}
}
