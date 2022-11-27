namespace file_bookmark
{
	partial class win1_pin
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dragdrop1 = new file_bookmark.dragdrop();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(188, 113);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "選択...";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
			this.label2.Location = new System.Drawing.Point(145, 299);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "file name";
			// 
			// dragdrop1
			// 
			this.dragdrop1.AllowDrop = true;
			this.dragdrop1.Location = new System.Drawing.Point(62, 136);
			this.dragdrop1.Name = "dragdrop1";
			this.dragdrop1.Size = new System.Drawing.Size(256, 275);
			this.dragdrop1.TabIndex = 0;
			this.dragdrop1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragdrop1_DragDrop);
			this.dragdrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragdrop1_DragEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
			this.label1.Location = new System.Drawing.Point(62, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "ブックマークフォルダ:";
			// 
			// win1_pin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dragdrop1);
			this.Name = "win1_pin";
			this.Size = new System.Drawing.Size(365, 397);
			this.Load += new System.EventHandler(this.win1_pin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ComboBox comboBox1;
		private Label label2;
		private dragdrop dragdrop1;
		private Label label1;
	}
}
