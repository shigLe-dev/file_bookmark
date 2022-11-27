namespace file_bookmark
{
	partial class dragdrop
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.u_button_11 = new file_bookmark.u_button_1();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 220);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
			this.label1.Location = new System.Drawing.Point(37, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "ここにファイルをドラッグ＆ドロップ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
			this.label2.Location = new System.Drawing.Point(103, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "または";
			// 
			// u_button_11
			// 
			this.u_button_11.Location = new System.Drawing.Point(81, 117);
			this.u_button_11.Name = "u_button_11";
			this.u_button_11.Size = new System.Drawing.Size(85, 33);
			this.u_button_11.TabIndex = 3;
			this.u_button_11.text = "ファイルを選択";
			// 
			// dragdrop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.u_button_11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "dragdrop";
			this.Size = new System.Drawing.Size(256, 275);
			this.Load += new System.EventHandler(this.dragdrop_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private u_button_1 u_button_11;
	}
}
