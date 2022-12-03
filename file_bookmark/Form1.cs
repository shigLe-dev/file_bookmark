using System.Text;

namespace file_bookmark
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			this.MaximumSize = this.Size;
			this.MinimumSize = this.Size;

			//bookmark.csvが存在しなかったら作成
			if (!System.IO.File.Exists("./bookmark.csv"))
			{

				using (FileStream fs = File.Create("./bookmark.csv")) ;

				System.IO.StreamWriter sw = new System.IO.StreamWriter("./bookmark.csv",false, System.Text.Encoding.UTF8);
				//TextBox1.Textの内容を書き込む
				sw.Write("bookmark");
				//閉じる
				sw.Close();
			}

			menu_bar1.winmode_1 += new EventHandler(winmode_1);
			menu_bar1.winmode_2 += new EventHandler(winmode_2);
		}

		private void dragdrop1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		//window modeを変える
		private void winmode_1(object sender, EventArgs e)
		{
			this.win1_pin1.Visible = true;
			this.win2_list1.Visible = false;
		}

		private void winmode_2(object sender, EventArgs e)
		{
			this.win1_pin1.Visible = false;
			this.win2_list1.Visible = true;

			//画面が変わったら更新
			this.win2_list1.combo_reset();
		}

		private void menu_bar1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("hoge");
		}
	}
}