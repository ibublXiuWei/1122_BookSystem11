namespace ISpan.BookSystem
{
	partial class LoginForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Loginbutton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(295, 267);
			this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(4);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.PasswordChar = '*';
			this.PasswordtextBox.Size = new System.Drawing.Size(216, 29);
			this.PasswordtextBox.TabIndex = 1;
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(295, 213);
			this.AccounttextBox.Margin = new System.Windows.Forms.Padding(4);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.Size = new System.Drawing.Size(216, 29);
			this.AccounttextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 270);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 13;
			this.label2.Text = "密碼：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(225, 216);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 14;
			this.label1.Text = "帳號：";
			// 
			// Loginbutton
			// 
			this.Loginbutton.Location = new System.Drawing.Point(334, 334);
			this.Loginbutton.Margin = new System.Windows.Forms.Padding(4);
			this.Loginbutton.Name = "Loginbutton";
			this.Loginbutton.Size = new System.Drawing.Size(143, 34);
			this.Loginbutton.TabIndex = 2;
			this.Loginbutton.Text = "Login";
			this.Loginbutton.UseVisualStyleBackColor = true;
			this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.login2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Loginbutton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登入";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PasswordtextBox;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Loginbutton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}