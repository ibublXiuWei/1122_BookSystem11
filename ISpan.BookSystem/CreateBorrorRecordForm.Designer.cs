namespace ISpan.BookSystem
{
	partial class CreateBorrorRecordForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.booktextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButtonborrow = new System.Windows.Forms.RadioButton();
			this.radioButtonno = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.saveborrowbutton = new System.Windows.Forms.Button();
			this.borrowdatelabel = new System.Windows.Forms.Label();
			this.returndatelabel = new System.Windows.Forms.Label();
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(520, 227);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 10;
			this.label2.Text = "書名：";
			// 
			// booktextBox
			// 
			this.booktextBox.Location = new System.Drawing.Point(616, 223);
			this.booktextBox.Margin = new System.Windows.Forms.Padding(4);
			this.booktextBox.Name = "booktextBox";
			this.booktextBox.ReadOnly = true;
			this.booktextBox.Size = new System.Drawing.Size(229, 29);
			this.booktextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(484, 299);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "借閱時間：";
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(616, 97);
			this.AccounttextBox.Margin = new System.Windows.Forms.Padding(4);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.Size = new System.Drawing.Size(229, 29);
			this.AccounttextBox.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(520, 101);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 18);
			this.label6.TabIndex = 18;
			this.label6.Text = "帳號：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(484, 349);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 18);
			this.label3.TabIndex = 20;
			this.label3.Text = "還書時間：";
			// 
			// radioButtonborrow
			// 
			this.radioButtonborrow.AutoSize = true;
			this.radioButtonborrow.Checked = true;
			this.radioButtonborrow.Location = new System.Drawing.Point(662, 417);
			this.radioButtonborrow.Name = "radioButtonborrow";
			this.radioButtonborrow.Size = new System.Drawing.Size(51, 22);
			this.radioButtonborrow.TabIndex = 3;
			this.radioButtonborrow.TabStop = true;
			this.radioButtonborrow.Tag = "0";
			this.radioButtonborrow.Text = "是";
			this.radioButtonborrow.UseVisualStyleBackColor = true;
			// 
			// radioButtonno
			// 
			this.radioButtonno.AutoSize = true;
			this.radioButtonno.Location = new System.Drawing.Point(764, 417);
			this.radioButtonno.Name = "radioButtonno";
			this.radioButtonno.Size = new System.Drawing.Size(51, 22);
			this.radioButtonno.TabIndex = 4;
			this.radioButtonno.Tag = "1";
			this.radioButtonno.Text = "否";
			this.radioButtonno.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(484, 417);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 18);
			this.label4.TabIndex = 20;
			this.label4.Text = "是否借閱：";
			// 
			// saveborrowbutton
			// 
			this.saveborrowbutton.Location = new System.Drawing.Point(770, 478);
			this.saveborrowbutton.Name = "saveborrowbutton";
			this.saveborrowbutton.Size = new System.Drawing.Size(75, 33);
			this.saveborrowbutton.TabIndex = 5;
			this.saveborrowbutton.Text = "借書";
			this.saveborrowbutton.UseVisualStyleBackColor = true;
			this.saveborrowbutton.Click += new System.EventHandler(this.saveborrowbutton_Click);
			// 
			// borrowdatelabel
			// 
			this.borrowdatelabel.AutoSize = true;
			this.borrowdatelabel.Location = new System.Drawing.Point(614, 299);
			this.borrowdatelabel.Name = "borrowdatelabel";
			this.borrowdatelabel.Size = new System.Drawing.Size(50, 18);
			this.borrowdatelabel.TabIndex = 23;
			this.borrowdatelabel.Text = "label7";
			// 
			// returndatelabel
			// 
			this.returndatelabel.AutoSize = true;
			this.returndatelabel.Location = new System.Drawing.Point(614, 341);
			this.returndatelabel.Name = "returndatelabel";
			this.returndatelabel.Size = new System.Drawing.Size(50, 18);
			this.returndatelabel.TabIndex = 23;
			this.returndatelabel.Text = "label7";
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(616, 161);
			this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(4);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.PasswordChar = '*';
			this.PasswordtextBox.Size = new System.Drawing.Size(229, 29);
			this.PasswordtextBox.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(520, 163);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 18);
			this.label7.TabIndex = 25;
			this.label7.Text = "密碼：";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateBorrorRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.createborrowbook;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1012, 591);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.returndatelabel);
			this.Controls.Add(this.borrowdatelabel);
			this.Controls.Add(this.saveborrowbutton);
			this.Controls.Add(this.radioButtonno);
			this.Controls.Add(this.radioButtonborrow);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.booktextBox);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateBorrorRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增借閱";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox booktextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButtonborrow;
		private System.Windows.Forms.RadioButton radioButtonno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveborrowbutton;
		private System.Windows.Forms.Label borrowdatelabel;
		private System.Windows.Forms.Label returndatelabel;
		private System.Windows.Forms.TextBox PasswordtextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}