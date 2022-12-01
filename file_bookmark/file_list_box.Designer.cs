namespace file_bookmark
{
	partial class file_list_box
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
			this.file_click_box1 = new file_bookmark.file_click_box();
			this.SuspendLayout();
			// 
			// file_click_box1
			// 
			this.file_click_box1.Location = new System.Drawing.Point(0, 0);
			this.file_click_box1.Name = "file_click_box1";
			this.file_click_box1.Size = new System.Drawing.Size(239, 41);
			this.file_click_box1.TabIndex = 0;
			// 
			// file_list_box
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.file_click_box1);
			this.Name = "file_list_box";
			this.Size = new System.Drawing.Size(239, 220);
			this.ResumeLayout(false);

		}

		#endregion

		private file_click_box file_click_box1;
	}
}
