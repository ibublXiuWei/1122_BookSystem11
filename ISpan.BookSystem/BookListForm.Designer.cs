namespace ISpan.BookSystem
{
	partial class BookListForm
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
			this.CategoryIdcomboBox = new System.Windows.Forms.ComboBox();
			this.bookCategoriesVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Searchbutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddBookButton = new System.Windows.Forms.Button();
			this.SearchbooktextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoriesVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// CategoryIdcomboBox
			// 
			this.CategoryIdcomboBox.DataSource = this.bookCategoriesVMBindingSource;
			this.CategoryIdcomboBox.DisplayMember = "CategoriesName";
			this.CategoryIdcomboBox.FormattingEnabled = true;
			this.CategoryIdcomboBox.Location = new System.Drawing.Point(155, 111);
			this.CategoryIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
			this.CategoryIdcomboBox.Name = "CategoryIdcomboBox";
			this.CategoryIdcomboBox.Size = new System.Drawing.Size(220, 26);
			this.CategoryIdcomboBox.TabIndex = 0;
			this.CategoryIdcomboBox.ValueMember = "Id";
			// 
			// bookCategoriesVMBindingSource
			// 
			this.bookCategoriesVMBindingSource.DataSource = typeof(ISpan.BookSystem.ViewModels.BookCategoriesVM);
			// 
			// Searchbutton
			// 
			this.Searchbutton.Location = new System.Drawing.Point(399, 111);
			this.Searchbutton.Margin = new System.Windows.Forms.Padding(4);
			this.Searchbutton.Name = "Searchbutton";
			this.Searchbutton.Size = new System.Drawing.Size(112, 34);
			this.Searchbutton.TabIndex = 2;
			this.Searchbutton.Text = "Search";
			this.Searchbutton.UseVisualStyleBackColor = true;
			this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.categoriesNameDataGridViewTextBoxColumn,
            this.callnumberDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bookIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(57, 291);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1155, 343);
			this.dataGridView1.TabIndex = 2;
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
			// AddBookButton
			// 
			this.AddBookButton.Location = new System.Drawing.Point(590, 111);
			this.AddBookButton.Margin = new System.Windows.Forms.Padding(4);
			this.AddBookButton.Name = "AddBookButton";
			this.AddBookButton.Size = new System.Drawing.Size(99, 34);
			this.AddBookButton.TabIndex = 3;
			this.AddBookButton.Text = "Add Book";
			this.AddBookButton.UseVisualStyleBackColor = true;
			this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
			// 
			// SearchbooktextBox
			// 
			this.SearchbooktextBox.Location = new System.Drawing.Point(155, 192);
			this.SearchbooktextBox.Margin = new System.Windows.Forms.Padding(4);
			this.SearchbooktextBox.Name = "SearchbooktextBox";
			this.SearchbooktextBox.Size = new System.Drawing.Size(220, 29);
			this.SearchbooktextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 115);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "分類：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 197);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "書名：";
			// 
			// BookListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.booklistform;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1301, 694);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SearchbooktextBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.AddBookButton);
			this.Controls.Add(this.Searchbutton);
			this.Controls.Add(this.CategoryIdcomboBox);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BookListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "維護書籍總表";
			((System.ComponentModel.ISupportInitialize)(this.bookCategoriesVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CategoryIdcomboBox;
		private System.Windows.Forms.Button Searchbutton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button AddBookButton;
		private System.Windows.Forms.TextBox SearchbooktextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource bookIndexVMBindingSource;
		private System.Windows.Forms.BindingSource bookCategoriesVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoriesNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn callnumberDataGridViewTextBoxColumn;
	}
}