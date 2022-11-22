namespace ISpan.BookSystem
{
	partial class EditBorrorRecordForm
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CallnumbertextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BookNametextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.radioButtonno = new System.Windows.Forms.RadioButton();
			this.radioButtonyes = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.rentBookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(225, 420);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 34);
			this.SaveButton.TabIndex = 2;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(225, 104);
			this.AccounttextBox.Margin = new System.Windows.Forms.Padding(4);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.ReadOnly = true;
			this.AccounttextBox.Size = new System.Drawing.Size(229, 29);
			this.AccounttextBox.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(123, 108);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 25;
			this.label1.Text = "帳號：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(123, 226);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 23;
			this.label2.Text = "索書號：";
			// 
			// CallnumbertextBox
			// 
			this.CallnumbertextBox.Location = new System.Drawing.Point(225, 221);
			this.CallnumbertextBox.Margin = new System.Windows.Forms.Padding(4);
			this.CallnumbertextBox.Name = "CallnumbertextBox";
			this.CallnumbertextBox.ReadOnly = true;
			this.CallnumbertextBox.Size = new System.Drawing.Size(229, 29);
			this.CallnumbertextBox.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(123, 292);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 18);
			this.label4.TabIndex = 23;
			this.label4.Text = "書名：";
			// 
			// BookNametextBox
			// 
			this.BookNametextBox.Location = new System.Drawing.Point(225, 286);
			this.BookNametextBox.Margin = new System.Windows.Forms.Padding(4);
			this.BookNametextBox.Name = "BookNametextBox";
			this.BookNametextBox.ReadOnly = true;
			this.BookNametextBox.Size = new System.Drawing.Size(229, 29);
			this.BookNametextBox.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(123, 356);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 18);
			this.label5.TabIndex = 23;
			this.label5.Text = "還書：";
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(379, 420);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(75, 34);
			this.Deletebutton.TabIndex = 3;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// radioButtonno
			// 
			this.radioButtonno.AutoSize = true;
			this.radioButtonno.Location = new System.Drawing.Point(367, 352);
			this.radioButtonno.Name = "radioButtonno";
			this.radioButtonno.Size = new System.Drawing.Size(51, 22);
			this.radioButtonno.TabIndex = 1;
			this.radioButtonno.Tag = "0";
			this.radioButtonno.Text = "否";
			this.radioButtonno.UseVisualStyleBackColor = true;
			// 
			// radioButtonyes
			// 
			this.radioButtonyes.AutoSize = true;
			this.radioButtonyes.Checked = true;
			this.radioButtonyes.Location = new System.Drawing.Point(265, 352);
			this.radioButtonyes.Name = "radioButtonyes";
			this.radioButtonyes.Size = new System.Drawing.Size(51, 22);
			this.radioButtonyes.TabIndex = 0;
			this.radioButtonyes.TabStop = true;
			this.radioButtonyes.Tag = "1";
			this.radioButtonyes.Text = "是";
			this.radioButtonyes.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(123, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 23;
			this.label3.Text = "姓名：";
			// 
			// NametextBox
			// 
			this.NametextBox.Location = new System.Drawing.Point(225, 162);
			this.NametextBox.Margin = new System.Windows.Forms.Padding(4);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.ReadOnly = true;
			this.NametextBox.Size = new System.Drawing.Size(229, 29);
			this.NametextBox.TabIndex = 26;
			// 
			// rentBookIndexVMBindingSource
			// 
			this.rentBookIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.Services.RentBookIndexVM);
			// 
			// EditBorrorRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.returnbook_editborrow;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(978, 554);
			this.Controls.Add(this.radioButtonno);
			this.Controls.Add(this.radioButtonyes);
			this.Controls.Add(this.BookNametextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.CallnumbertextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.SaveButton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditBorrorRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯借閱紀錄";
			this.Load += new System.EventHandler(this.EditBorrorRecordForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource rentBookIndexVMBindingSource;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CallnumbertextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox BookNametextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.RadioButton radioButtonno;
		private System.Windows.Forms.RadioButton radioButtonyes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NametextBox;
	}
}