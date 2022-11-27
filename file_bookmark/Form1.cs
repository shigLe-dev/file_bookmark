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
		}

		private void dragdrop1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}