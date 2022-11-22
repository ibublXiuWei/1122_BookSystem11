namespace ISpan.BookSystem
{
	partial class BorrowBookForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.SearchbooktextBox = new System.Windows.Forms.TextBox();
			this.Searchbutton = new System.Windows.Forms.Button();
			this.CategoryIdcomboBox = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.borrowBookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rentBookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.rentBookIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowBookIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "書名：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "分類：";
			// 
			// SearchbooktextBox
			// 
			this.SearchbooktextBox.Location = new System.Drawing.Point(97, 97);
			this.SearchbooktextBox.Name = "SearchbooktextBox";
			this.SearchbooktextBox.Size = new System.Drawing.Size(148, 22);
			this.SearchbooktextBox.TabIndex = 1;
			// 
			// Searchbutton
			// 
			this.Searchbutton.Location = new System.Drawing.Point(259, 43);
			this.Searchbutton.Name = "Searchbutton";
			this.Searchbutton.Size = new System.Drawing.Size(75, 23);
			this.Searchbutton.TabIndex = 2;
			this.Searchbutton.Text = "Search";
			this.Searchbutton.UseVisualStyleBackColor = true;
			this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
			// 
			// CategoryIdcomboBox
			// 
			this.CategoryIdcomboBox.DisplayMember = "CategoriesName";
			this.CategoryIdcomboBox.FormattingEnabled = true;
			this.CategoryIdcomboBox.Location = new System.Drawing.Point(97, 43);
			this.CategoryIdcomboBox.Name = "CategoryIdcomboBox";
			this.CategoryIdcomboBox.Size = new System.Drawing.Size(148, 20);
			this.CategoryIdcomboBox.TabIndex = 0;
			this.CategoryIdcomboBox.ValueMember = "Id";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.categoriesNameDataGridViewTextBoxColumn,
            this.callnumberDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.borrowBookIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(36, 166);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.Size = new System.Drawing.Size(717, 231);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// borrowBookIndexVMBindingSource
			// 
			this.borrowBookIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.BorrowBookIndexVM);
			// 
			// rentBookIndexVMBindingSource
			// 
			this.rentBookIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.Services.RentBookIndexVM);
			// 
			// bookIndexVMBindingSource
			// 
			this.bookIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.BookIndexVM);
			// 
			// bookIndexVMBindingSource1
			// 
			this.bookIndexVMBindingSource1.DataSource = typeof(ISpan.BookSystem.ViewModels.BookIndexVM);
			// 
			// rentBookIndexVMBindingSource1
			// 
			this.rentBookIndexVMBindingSource1.DataSource = typeof(ISpan.BookSystem.ViewModels.Services.RentBookIndexVM);
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
			this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.bookIdDataGridViewTextBoxColumn.Width = 150;
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
			// authorNameDataGridViewTextBoxColumn
			// 
			this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
			this.authorNameDataGridViewTextBoxColumn.HeaderText = "作者";
			this.authorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
			this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.authorNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// categoriesNameDataGridViewTextBoxColumn
			// 
			this.categoriesNameDataGridViewTextBoxColumn.DataPropertyName = "CategoriesName";
			this.categoriesNameDataGridViewTextBoxColumn.HeaderText = "分類";
			this.categoriesNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.categoriesNameDataGridViewTextBoxColumn.Name = "categoriesNameDataGridViewTextBoxColumn";
			this.categoriesNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.categoriesNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// callnumberDataGridViewTextBoxColumn
			// 
			this.callnumberDataGridViewTextBoxColumn.DataPropertyName = "Callnumber";
			this.callnumberDataGridViewTextBoxColumn.HeaderText = "索書號";
			this.callnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.callnumberDataGridViewTextBoxColumn.Name = "callnumberDataGridViewTextBoxColumn";
			this.callnumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.callnumberDataGridViewTextBoxColumn.Width = 150;
			// 
			// BorrowBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.borrowbooklist;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(785, 425);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SearchbooktextBox);
			this.Controls.Add(this.Searchbutton);
			this.Controls.Add(this.CategoryIdcomboBox);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BorrowBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "借書";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowBookIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rentBookIndexVMBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SearchbooktextBox;
		private System.Windows.Forms.Button Searchbutton;
		private System.Windows.Forms.ComboBox CategoryIdcomboBox;
		private System.Windows.Forms.BindingSource bookIndexVMBindingSource;
		private System.Windows.Forms.BindingSource rentBookIndexVMBindingSource;
		private System.Windows.Forms.BindingSource bookIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource rentBookIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource borrowBookIndexVMBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoriesNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn callnumberDataGridViewTextBoxColumn;
	}
}