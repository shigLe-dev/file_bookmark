namespace file_bookmark
{
	partial class menu_bar
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.u_button_21 = new file_bookmark.u_button_2();
			this.u_button_22 = new file_bookmark.u_button_2();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// u_button_21
			// 
			this.u_button_21.Location = new System.Drawing.Point(0, 0);
			this.u_button_21.Name = "u_button_21";
			this.u_button_21.Size = new System.Drawing.Size(112, 33);
			this.u_button_21.TabIndex = 0;
			this.u_button_21.text = "ファイルをピン止め";
			// 
			// u_button_22
			// 
			this.u_button_22.Location = new System.Drawing.Point(93, 0);
			this.u_button_22.Name = "u_button_22";
			this.u_button_22.Size = new System.Drawing.Size(102, 33);
			this.u_button_22.TabIndex = 1;
			this.u_button_22.text = "ファイル一覧";
			this.u_button_22.Load += new System.EventHandler(this.u_button_22_Load);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(201, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// menu_bar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.u_button_22);
			this.Controls.Add(this.u_button_21);
			this.Name = "menu_bar";
			this.Size = new System.Drawing.Size(265, 40);
			this.Load += new System.EventHandler(this.menu_bar_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private u_button_2 u_button_21;
		private u_button_2 u_button_22;
		private PictureBox pictureBox1;
	}
}
