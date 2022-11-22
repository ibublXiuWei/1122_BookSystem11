namespace ISpan.BookSystem
{
	partial class CreateBookListForm
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
			this.CategoryIdcomboBox = new System.Windows.Forms.ComboBox();
			this.bookCategoriesVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddCategoryButton = new System.Windows.Forms.Button();
			this.categorynametextBox = new System.Windows.Forms.TextBox();
			this.AuthorcomboBox = new System.Windows.Forms.ComboBox();
			this.bookAuthorVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.AddAuthorbutton = new System.Windows.Forms.Button();
			this.AuthortextBox = new System.Windows.Forms.TextBox();
			this.BooktextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Addbookbutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bookCategoriesVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookAuthorVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "分類：";
			// 
			// CategoryIdcomboBox
			// 
			this.CategoryIdcomboBox.DataSource = this.bookCategoriesVMBindingSource;
			this.CategoryIdcomboBox.DisplayMember = "CategoriesName";
			this.CategoryIdcomboBox.FormattingEnabled = true;
			this.CategoryIdcomboBox.Location = new System.Drawing.Point(134, 52);
			this.CategoryIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
			this.CategoryIdcomboBox.Name = "CategoryIdcomboBox";
			this.CategoryIdcomboBox.Size = new System.Drawing.Size(259, 26);
			this.CategoryIdcomboBox.TabIndex = 0;
			this.CategoryIdcomboBox.ValueMember = "Id";
			// 
			// bookCategoriesVMBindingSource
			// 
			this.bookCategoriesVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.BookCategoriesVM);
			// 
			// AddCategoryButton
			// 
			this.AddCategoryButton.Location = new System.Drawing.Point(236, 174);
			this.AddCategoryButton.Margin = new System.Windows.Forms.Padding(4);
			this.AddCategoryButton.Name = "AddCategoryButton";
			this.AddCategoryButton.Size = new System.Drawing.Size(159, 34);
			this.AddCategoryButton.TabIndex = 2;
			this.AddCategoryButton.Text = "Add Categories";
			this.AddCategoryButton.UseVisualStyleBackColor = true;
			this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
			// 
			// categorynametextBox
			// 
			this.categorynametextBox.Location = new System.Drawing.Point(134, 114);
			this.categorynametextBox.Margin = new System.Windows.Forms.Padding(4);
			this.categorynametextBox.Name = "categorynametextBox";
			this.categorynametextBox.Size = new System.Drawing.Size(259, 29);
			this.categorynametextBox.TabIndex = 1;
			// 
			// AuthorcomboBox
			// 
			this.AuthorcomboBox.DataSource = this.bookAuthorVMBindingSource;
			this.AuthorcomboBox.DisplayMember = "AuthorName";
			this.AuthorcomboBox.FormattingEnabled = true;
			this.AuthorcomboBox.Location = new System.Drawing.Point(513, 52);
			this.AuthorcomboBox.Margin = new System.Windows.Forms.Padding(4);
			this.AuthorcomboBox.Name = "AuthorcomboBox";
			this.AuthorcomboBox.Size = new System.Drawing.Size(259, 26);
			this.AuthorcomboBox.TabIndex = 3;
			this.AuthorcomboBox.ValueMember = "AuthorId";
			// 
			// bookAuthorVMBindingSource
			// 
			this.bookAuthorVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.BookAuthorVM);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(434, 57);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "作者：";
			// 
			// AddAuthorbutton
			// 
			this.AddAuthorbutton.Location = new System.Drawing.Point(615, 174);
			this.AddAuthorbutton.Margin = new System.Windows.Forms.Padding(4);
			this.AddAuthorbutton.Name = "AddAuthorbutton";
			this.AddAuthorbutton.Size = new System.Drawing.Size(159, 34);
			this.AddAuthorbutton.TabIndex = 5;
			this.AddAuthorbutton.Text = "Add Author";
			this.AddAuthorbutton.UseVisualStyleBackColor = true;
			this.AddAuthorbutton.Click += new System.EventHandler(this.AddAuthorbutton_Click);
			// 
			// AuthortextBox
			// 
			this.AuthortextBox.Location = new System.Drawing.Point(513, 114);
			this.AuthortextBox.Margin = new System.Windows.Forms.Padding(4);
			this.AuthortextBox.Name = "AuthortextBox";
			this.AuthortextBox.Size = new System.Drawing.Size(259, 29);
			this.AuthortextBox.TabIndex = 4;
			// 
			// BooktextBox
			// 
			this.BooktextBox.Location = new System.Drawing.Point(910, 52);
			this.BooktextBox.Margin = new System.Windows.Forms.Padding(4);
			this.BooktextBox.Name = "BooktextBox";
			this.BooktextBox.Size = new System.Drawing.Size(259, 29);
			this.BooktextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(831, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "書名：";
			// 
			// Addbookbutton
			// 
			this.Addbookbutton.Location = new System.Drawing.Point(1012, 114);
			this.Addbookbutton.Margin = new System.Windows.Forms.Padding(4);
			this.Addbookbutton.Name = "Addbookbutton";
			this.Addbookbutton.Size = new System.Drawing.Size(159, 34);
			this.Addbookbutton.TabIndex = 7;
			this.Addbookbutton.Text = "Add Book";
			this.Addbookbutton.UseVisualStyleBackColor = true;
			this.Addbookbutton.Click += new System.EventHandler(this.Addbookbutton_Click);
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
			this.dataGridView1.DataSource = this.bookIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(76, 242);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1120, 417);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
			this.categoriesNameDataGridViewTextBoxColumn.HeaderText = "分類名稱";
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
			// bookIndexVMBindingSource
			// 
			this.bookIndexVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.BookIndexVM);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateBookListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 712);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Addbookbutton);
			this.Controls.Add(this.BooktextBox);
			this.Controls.Add(this.AuthortextBox);
			this.Controls.Add(this.categorynametextBox);
			this.Controls.Add(this.AddAuthorbutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddCategoryButton);
			this.Controls.Add(this.AuthorcomboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CategoryIdcomboBox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CreateBookListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增書籍";
			((System.ComponentModel.ISupportInitialize)(this.bookCategoriesVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookAuthorVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CategoryIdcomboBox;
		private System.Windows.Forms.Button AddCategoryButton;
		private System.Windows.Forms.TextBox categorynametextBox;
		private System.Windows.Forms.ComboBox AuthorcomboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button AddAuthorbutton;
		private System.Windows.Forms.TextBox AuthortextBox;
		private System.Windows.Forms.TextBox BooktextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Addbookbutton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource bookCategoriesVMBindingSource;
		private System.Windows.Forms.BindingSource bookIndexVMBindingSource;
		private System.Windows.Forms.BindingSource bookAuthorVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoriesNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn callnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}