namespace file_bookmark
{
	partial class file_click_box
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
			this.label1.Location = new System.Drawing.Point(49, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "file_name";
			this.label1.Click += new System.EventHandler(this.box_clicked);
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxmouse_down);
			this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxmouse_up);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
			this.label2.Location = new System.Drawing.Point(183, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "削除";
			this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
			this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
			// 
			// file_click_box
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "file_click_box";
			this.Size = new System.Drawing.Size(239, 34);
			this.Load += new System.EventHandler(this.file_click_box_Load);
			this.Click += new System.EventHandler(this.box_clicked);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxmouse_down);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxmouse_up);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
	}
}
