namespace ISpan.BookSystem
{
	partial class UserForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Addbutton = new System.Windows.Forms.Button();
			this.readerUserIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.manageUserIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.readerUserIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manageUserIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dataGridView1.DataSource = this.userIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(55, 119);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.Size = new System.Drawing.Size(991, 351);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ReadId";
			this.dataGridViewTextBoxColumn2.HeaderText = "ReadId";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "RdAccount";
			this.dataGridViewTextBoxColumn3.HeaderText = "帳號";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "RdName";
			this.dataGridViewTextBoxColumn4.HeaderText = "姓名";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Mail";
			this.dataGridViewTextBoxColumn5.HeaderText = "Mail";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 150;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn6.HeaderText = "手機";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 150;
			// 
			// userIndexVMBindingSource
			// 
			this.userIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.UserIndexVM);
			// 
			// Addbutton
			// 
			this.Addbutton.Location = new System.Drawing.Point(962, 45);
			this.Addbutton.Name = "Addbutton";
			this.Addbutton.Size = new System.Drawing.Size(75, 35);
			this.Addbutton.TabIndex = 0;
			this.Addbutton.Text = "Add";
			this.Addbutton.UseVisualStyleBackColor = true;
			this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.userform;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1094, 635);
			this.Controls.Add(this.Addbutton);
			this.Controls.Add(this.dataGridView1);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "帳號管理系統";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.readerUserIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manageUserIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Addbutton;
		private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn readIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rdAccountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rdNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource readerUserIndexVMBindingSource;
		private System.Windows.Forms.BindingSource manageUserIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource;
	}
}