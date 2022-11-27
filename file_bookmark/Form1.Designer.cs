namespace file_bookmark
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.win1_pin1 = new file_bookmark.win1_pin();
			this.menu_bar1 = new file_bookmark.menu_bar();
			this.SuspendLayout();
			// 
			// win1_pin1
			// 
			this.win1_pin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.win1_pin1.Location = new System.Drawing.Point(-13, -35);
			this.win1_pin1.Name = "win1_pin1";
			this.win1_pin1.Size = new System.Drawing.Size(371, 399);
			this.win1_pin1.TabIndex = 0;
			// 
			// menu_bar1
			// 
			this.menu_bar1.Location = new System.Drawing.Point(51, 23);
			this.menu_bar1.Name = "menu_bar1";
			this.menu_bar1.Size = new System.Drawing.Size(259, 40);
			this.menu_bar1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(345, 354);
			this.Controls.Add(this.menu_bar1);
			this.Controls.Add(this.win1_pin1);
			this.Font = new System.Drawing.Font("游ゴシック Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private win1_pin win1_pin1;
		private menu_bar menu_bar1;
	}
}