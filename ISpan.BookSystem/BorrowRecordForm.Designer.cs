namespace ISpan.BookSystem
{
	partial class BorrowRecordForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.rentOrderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.borrowDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.returnDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.returnBookDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rentBookIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.rentBookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentOrderIdDataGridViewTextBoxColumn,
            this.rdNameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.callnumberDataGridViewTextBoxColumn,
            this.borrowDateTimeDataGridViewTextBoxColumn,
            this.returnDateTimeDataGridViewTextBoxColumn,
            this.returnBookDataGridViewCheckBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.rentBookIndexVMBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(36, 258);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.Size = new System.Drawing.Size(1179, 351);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 206);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hi,  這是你的借閱紀錄";
			// 
			// rentOrderIdDataGridViewTextBoxColumn
			// 
			this.rentOrderIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.rentOrderIdDataGridViewTextBoxColumn.DataPropertyName = "RentOrderId";
			this.rentOrderIdDataGridViewTextBoxColumn.FillWeight = 10F;
			this.rentOrderIdDataGridViewTextBoxColumn.HeaderText = "RentOrderId";
			this.rentOrderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.rentOrderIdDataGridViewTextBoxColumn.Name = "rentOrderIdDataGridViewTextBoxColumn";
			this.rentOrderIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.rentOrderIdDataGridViewTextBoxColumn.Width = 130;
			// 
			// rdNameDataGridViewTextBoxColumn
			// 
			this.rdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.rdNameDataGridViewTextBoxColumn.DataPropertyName = "RdName";
			this.rdNameDataGridViewTextBoxColumn.FillWeight = 50F;
			this.rdNameDataGridViewTextBoxColumn.HeaderText = "讀者姓名";
			this.rdNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.rdNameDataGridViewTextBoxColumn.Name = "rdNameDataGridViewTextBoxColumn";
			this.rdNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.rdNameDataGridViewTextBoxColumn.Width = 116;
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "書名";
			this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.bookNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// callnumberDataGridViewTextBoxColumn
			// 
			this.callnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.callnumberDataGridViewTextBoxColumn.DataPropertyName = "callnumber";
			this.callnumberDataGridViewTextBoxColumn.FillWeight = 50F;
			this.callnumberDataGridViewTextBoxColumn.HeaderText = "索書號";
			this.callnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.callnumberDataGridViewTextBoxColumn.Name = "callnumberDataGridViewTextBoxColumn";
			this.callnumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.callnumberDataGridViewTextBoxColumn.Width = 98;
			// 
			// borrowDateTimeDataGridViewTextBoxColumn
			// 
			this.borrowDateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.borrowDateTimeDataGridViewTextBoxColumn.DataPropertyName = "BorrowDateTime";
			this.borrowDateTimeDataGridViewTextBoxColumn.HeaderText = "借閱時間";
			this.borrowDateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.borrowDateTimeDataGridViewTextBoxColumn.Name = "borrowDateTimeDataGridViewTextBoxColumn";
			this.borrowDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.borrowDateTimeDataGridViewTextBoxColumn.Width = 116;
			// 
			// returnDateTimeDataGridViewTextBoxColumn
			// 
			this.returnDateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.returnDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ReturnDateTime";
			this.returnDateTimeDataGridViewTextBoxColumn.HeaderText = "借閱到期時間";
			this.returnDateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.returnDateTimeDataGridViewTextBoxColumn.Name = "returnDateTimeDataGridViewTextBoxColumn";
			this.returnDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.returnDateTimeDataGridViewTextBoxColumn.Width = 108;
			// 
			// returnBookDataGridViewCheckBoxColumn
			// 
			this.returnBookDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.returnBookDataGridViewCheckBoxColumn.DataPropertyName = "ReturnBook";
			this.returnBookDataGridViewCheckBoxColumn.FillWeight = 50F;
			this.returnBookDataGridViewCheckBoxColumn.HeaderText = "還書";
			this.returnBookDataGridViewCheckBoxColumn.MinimumWidth = 50;
			this.returnBookDataGridViewCheckBoxColumn.Name = "returnBookDataGridViewCheckBoxColumn";
			this.returnBookDataGridViewCheckBoxColumn.ReadOnly = true;
			this.returnBookDataGridViewCheckBoxColumn.Width = 50;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.FillWeight = 80F;
			this.phoneDataGridViewTextBoxColumn.HeaderText = "手機號碼";
			this.phoneDataGridViewTextBoxColumn.MinimumWidth = 90;
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneDataGridViewTextBoxColumn.Width = 91;
			// 
			// mailDataGridViewTextBoxColumn
			// 
			this.mailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
			this.mailDataGridViewTextBoxColumn.FillWeight = 50F;
			this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
			this.mailDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
			this.mailDataGridViewTextBoxColumn.ReadOnly = true;
			this.mailDataGridViewTextBoxColumn.Width = 77;
			// 
			// rentBookIndexVMBindingSource1
			// 
			this.rentBookIndexVMBindingSource1.DataSource = typeof(ISpan.BookSystem.ViewModels.Services.RentBookIndexVM);
			// 
			// rentBookIndexVMBindingSource
			// 
			this.rentBookIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.Services.RentBookIndexVM);
			// 
			// BorrowRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.rentrecordbooklist;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1252, 671);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BorrowRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "借閱紀錄";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn readerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource rentBookIndexVMBindingSource;
		private System.Windows.Forms.BindingSource rentBookIndexVMBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn rentOrderIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rdNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn callnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn returnDateTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn returnBookDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
	}
}