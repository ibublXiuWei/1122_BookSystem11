namespace ISpan.BookSystem
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.帳號管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.書籍管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.書本借閱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.借閱總覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.借書紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.書籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.使用者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帳號管理ToolStripMenuItem1,
            this.書籍管理ToolStripMenuItem1,
            this.書本借閱ToolStripMenuItem,
            this.借閱總覽ToolStripMenuItem,
            this.登出ToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1719, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 帳號管理ToolStripMenuItem1
			// 
			this.帳號管理ToolStripMenuItem1.Name = "帳號管理ToolStripMenuItem1";
			this.帳號管理ToolStripMenuItem1.Size = new System.Drawing.Size(98, 27);
			this.帳號管理ToolStripMenuItem1.Text = "帳號管理";
			this.帳號管理ToolStripMenuItem1.Click += new System.EventHandler(this.帳號管理ToolStripMenuItem1_Click);
			// 
			// 書籍管理ToolStripMenuItem1
			// 
			this.書籍管理ToolStripMenuItem1.Name = "書籍管理ToolStripMenuItem1";
			this.書籍管理ToolStripMenuItem1.Size = new System.Drawing.Size(98, 27);
			this.書籍管理ToolStripMenuItem1.Text = "書籍管理";
			this.書籍管理ToolStripMenuItem1.Click += new System.EventHandler(this.書籍管理ToolStripMenuItem1_Click);
			// 
			// 書本借閱ToolStripMenuItem
			// 
			this.書本借閱ToolStripMenuItem.Name = "書本借閱ToolStripMenuItem";
			this.書本借閱ToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
			this.書本借閱ToolStripMenuItem.Text = "書本借閱";
			this.書本借閱ToolStripMenuItem.Click += new System.EventHandler(this.書本借閱ToolStripMenuItem_Click);
			// 
			// 借閱總覽ToolStripMenuItem
			// 
			this.借閱總覽ToolStripMenuItem.Name = "借閱總覽ToolStripMenuItem";
			this.借閱總覽ToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
			this.借閱總覽ToolStripMenuItem.Text = "借閱總覽";
			this.借閱總覽ToolStripMenuItem.Click += new System.EventHandler(this.借閱總攬ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem1
			// 
			this.登出ToolStripMenuItem1.Name = "登出ToolStripMenuItem1";
			this.登出ToolStripMenuItem1.Size = new System.Drawing.Size(62, 27);
			this.登出ToolStripMenuItem1.Text = "登出";
			this.登出ToolStripMenuItem1.Click += new System.EventHandler(this.登出ToolStripMenuItem1_Click);
			// 
			// 借書紀錄ToolStripMenuItem
			// 
			this.借書紀錄ToolStripMenuItem.Name = "借書紀錄ToolStripMenuItem";
			this.借書紀錄ToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
			this.借書紀錄ToolStripMenuItem.Text = "借書紀錄";
			// 
			// 書籍管理ToolStripMenuItem
			// 
			this.書籍管理ToolStripMenuItem.Name = "書籍管理ToolStripMenuItem";
			this.書籍管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
			this.書籍管理ToolStripMenuItem.Text = "書籍管理";
			// 
			// 使用者管理ToolStripMenuItem
			// 
			this.使用者管理ToolStripMenuItem.Name = "使用者管理ToolStripMenuItem";
			this.使用者管理ToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
			this.使用者管理ToolStripMenuItem.Text = "使用者管理";
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
			this.登出ToolStripMenuItem.Text = "登出";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources._3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1719, 847);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ISPAN LIBRARAY 首頁";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 使用者管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 借書紀錄ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 書籍管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帳號管理ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 書籍管理ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 書本借閱ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 借閱總覽ToolStripMenuItem;
	}
}