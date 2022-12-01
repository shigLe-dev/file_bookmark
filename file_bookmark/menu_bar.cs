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
	public partial class menu_bar : UserControl
	{

		public event EventHandler winmode_1;
		public event EventHandler winmode_2;

		public menu_bar()
		{
			InitializeComponent();
		}

		private void u_button_22_Load(object sender, EventArgs e)
		{

		}

		private void menu_bar_Load(object sender, EventArgs e)
		{
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

			this.pictureBox1.Image = Resource1.more_button;

			u_button_21.button_click += new EventHandler(u_button_21_Click);
			u_button_22.button_click += new EventHandler(u_button_22_Click);
		}

		private void u_button_21_Click(object sender, EventArgs e)
		{
			winmode_1(this,e);
		}

		private void u_button_22_Click(object sender, EventArgs e)
		{
			winmode_2(this,e);
		}
	}
}
