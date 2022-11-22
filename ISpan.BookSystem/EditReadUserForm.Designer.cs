namespace ISpan.BookSystem
{
	partial class EditReadUserForm
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
			this.PhonetextBox = new System.Windows.Forms.TextBox();
			this.MailtextBox = new System.Windows.Forms.TextBox();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.Updatebutton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// PhonetextBox
			// 
			this.PhonetextBox.Location = new System.Drawing.Point(601, 440);
			this.PhonetextBox.Margin = new System.Windows.Forms.Padding(4);
			this.PhonetextBox.Name = "PhonetextBox";
			this.PhonetextBox.Size = new System.Drawing.Size(229, 29);
			this.PhonetextBox.TabIndex = 4;
			// 
			// MailtextBox
			// 
			this.MailtextBox.Location = new System.Drawing.Point(601, 356);
			this.MailtextBox.Margin = new System.Windows.Forms.Padding(4);
			this.MailtextBox.Name = "MailtextBox";
			this.MailtextBox.Size = new System.Drawing.Size(229, 29);
			this.MailtextBox.TabIndex = 3;
			// 
			// NametextBox
			// 
			this.NametextBox.Location = new System.Drawing.Point(601, 263);
			this.NametextBox.Margin = new System.Windows.Forms.Padding(4);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(229, 29);
			this.NametextBox.TabIndex = 2;
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(601, 171);
			this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(4);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.PasswordChar = '*';
			this.PasswordtextBox.Size = new System.Drawing.Size(229, 29);
			this.PasswordtextBox.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(499, 445);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 18);
			this.label5.TabIndex = 24;
			this.label5.Text = "Phone：";
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(601, 92);
			this.AccounttextBox.Margin = new System.Windows.Forms.Padding(4);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.Size = new System.Drawing.Size(229, 29);
			this.AccounttextBox.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(499, 361);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 18);
			this.label4.TabIndex = 25;
			this.label4.Text = "Email：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(499, 267);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 26;
			this.label3.Text = "姓名：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(499, 176);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 27;
			this.label2.Text = "密碼：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(499, 97);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 18);
			this.label1.TabIndex = 28;
			this.label1.Text = "修改帳號：";
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(721, 536);
			this.Deletebutton.Margin = new System.Windows.Forms.Padding(4);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(109, 34);
			this.Deletebutton.TabIndex = 6;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// Updatebutton
			// 
			this.Updatebutton.Location = new System.Drawing.Point(601, 536);
			this.Updatebutton.Margin = new System.Windows.Forms.Padding(4);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(109, 34);
			this.Updatebutton.TabIndex = 5;
			this.Updatebutton.Text = "Update";
			this.Updatebutton.UseVisualStyleBackColor = true;
			this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditReadUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.Edituser;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1051, 633);
			this.Controls.Add(this.PhonetextBox);
			this.Controls.Add(this.MailtextBox);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.Updatebutton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditReadUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改使用者資料";
			this.Load += new System.EventHandler(this.EditReadUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PhonetextBox;
		private System.Windows.Forms.TextBox MailtextBox;
		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.TextBox PasswordtextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}