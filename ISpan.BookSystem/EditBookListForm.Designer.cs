namespace ISpan.BookSystem
{
	partial class EditBookListForm
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
			this.BooktextBox = new System.Windows.Forms.TextBox();
			this.AuthortextBox = new System.Windows.Forms.TextBox();
			this.categorynametextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.AuthorcomboBox = new System.Windows.Forms.ComboBox();
			this.bookAuthorVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.CategoryIdcomboBox = new System.Windows.Forms.ComboBox();
			this.bookCategoriesVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.UpdateBookbutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Updatecategorybutton = new System.Windows.Forms.Button();
			this.Updateauthorbutton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.deleteauthorbutton = new System.Windows.Forms.Button();
			this.deletecategorybutton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bookAuthorVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoriesVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// BooktextBox
			// 
			this.BooktextBox.Location = new System.Drawing.Point(577, 308);
			this.BooktextBox.Margin = new System.Windows.Forms.Padding(4);
			this.BooktextBox.Name = "BooktextBox";
			this.BooktextBox.Size = new System.Drawing.Size(259, 29);
			this.BooktextBox.TabIndex = 6;
			// 
			// AuthortextBox
			// 
			this.AuthortextBox.Location = new System.Drawing.Point(577, 245);
			this.AuthortextBox.Margin = new System.Windows.Forms.Padding(4);
			this.AuthortextBox.Name = "AuthortextBox";
			this.AuthortextBox.Size = new System.Drawing.Size(259, 29);
			this.AuthortextBox.TabIndex = 4;
			// 
			// categorynametextBox
			// 
			this.categorynametextBox.Location = new System.Drawing.Point(577, 130);
			this.categorynametextBox.Margin = new System.Windows.Forms.Padding(4);
			this.categorynametextBox.Name = "categorynametextBox";
			this.categorynametextBox.Size = new System.Drawing.Size(259, 29);
			this.categorynametextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(497, 313);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 13;
			this.label1.Text = "書名：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(497, 206);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 14;
			this.label3.Text = "作者：";
			// 
			// AuthorcomboBox
			// 
			this.AuthorcomboBox.DataSource = this.bookAuthorVMBindingSource;
			this.AuthorcomboBox.DisplayMember = "AuthorName";
			this.AuthorcomboBox.FormattingEnabled = true;
			this.AuthorcomboBox.Location = new System.Drawing.Point(577, 201);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(497, 91);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 15;
			this.label2.Text = "分類：";
			// 
			// CategoryIdcomboBox
			// 
			this.CategoryIdcomboBox.DataSource = this.bookCategoriesVMBindingSource;
			this.CategoryIdcomboBox.DisplayMember = "CategoriesName";
			this.CategoryIdcomboBox.FormattingEnabled = true;
			this.CategoryIdcomboBox.Location = new System.Drawing.Point(577, 86);
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
			// UpdateBookbutton
			// 
			this.UpdateBookbutton.Location = new System.Drawing.Point(908, 308);
			this.UpdateBookbutton.Margin = new System.Windows.Forms.Padding(4);
			this.UpdateBookbutton.Name = "UpdateBookbutton";
			this.UpdateBookbutton.Size = new System.Drawing.Size(112, 34);
			this.UpdateBookbutton.TabIndex = 7;
			this.UpdateBookbutton.Text = "Update";
			this.UpdateBookbutton.UseVisualStyleBackColor = true;
			this.UpdateBookbutton.Click += new System.EventHandler(this.UpdateBookbutton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(1029, 308);
			this.Deletebutton.Margin = new System.Windows.Forms.Padding(4);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(112, 34);
			this.Deletebutton.TabIndex = 8;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
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
			this.dataGridView1.ColumnHeadersHeight = 34;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.categoriesNameDataGridViewTextBoxColumn,
            this.callnumberDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bookIndexVMBindingSource;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.Location = new System.Drawing.Point(350, 446);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(845, 165);
			this.dataGridView1.TabIndex = 25;
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
			this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.bookIdDataGridViewTextBoxColumn.Width = 93;
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
			// Updatecategorybutton
			// 
			this.Updatecategorybutton.Location = new System.Drawing.Point(908, 86);
			this.Updatecategorybutton.Margin = new System.Windows.Forms.Padding(4);
			this.Updatecategorybutton.Name = "Updatecategorybutton";
			this.Updatecategorybutton.Size = new System.Drawing.Size(112, 34);
			this.Updatecategorybutton.TabIndex = 2;
			this.Updatecategorybutton.Text = "Update";
			this.Updatecategorybutton.UseVisualStyleBackColor = true;
			this.Updatecategorybutton.Click += new System.EventHandler(this.Updatecategorybutton_Click);
			// 
			// Updateauthorbutton
			// 
			this.Updateauthorbutton.Location = new System.Drawing.Point(908, 199);
			this.Updateauthorbutton.Margin = new System.Windows.Forms.Padding(4);
			this.Updateauthorbutton.Name = "Updateauthorbutton";
			this.Updateauthorbutton.Size = new System.Drawing.Size(112, 34);
			this.Updateauthorbutton.TabIndex = 5;
			this.Updateauthorbutton.Text = "Update";
			this.Updateauthorbutton.UseVisualStyleBackColor = true;
			this.Updateauthorbutton.Click += new System.EventHandler(this.Updateauthorbutton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1029, 201);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 8;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// deleteauthorbutton
			// 
			this.deleteauthorbutton.Location = new System.Drawing.Point(1029, 199);
			this.deleteauthorbutton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteauthorbutton.Name = "deleteauthorbutton";
			this.deleteauthorbutton.Size = new System.Drawing.Size(112, 34);
			this.deleteauthorbutton.TabIndex = 8;
			this.deleteauthorbutton.Text = "Delete";
			this.deleteauthorbutton.UseVisualStyleBackColor = true;
			this.deleteauthorbutton.Click += new System.EventHandler(this.deleteauthorbutton_Click);
			// 
			// deletecategorybutton
			// 
			this.deletecategorybutton.Location = new System.Drawing.Point(1029, 86);
			this.deletecategorybutton.Margin = new System.Windows.Forms.Padding(4);
			this.deletecategorybutton.Name = "deletecategorybutton";
			this.deletecategorybutton.Size = new System.Drawing.Size(112, 34);
			this.deletecategorybutton.TabIndex = 8;
			this.deletecategorybutton.Text = "Delete";
			this.deletecategorybutton.UseVisualStyleBackColor = true;
			this.deletecategorybutton.Click += new System.EventHandler(this.deletecategorybutton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditBookListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ISpan.BookSystem.Properties.Resources.editbook;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1255, 695);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Updateauthorbutton);
			this.Controls.Add(this.Updatecategorybutton);
			this.Controls.Add(this.UpdateBookbutton);
			this.Controls.Add(this.deletecategorybutton);
			this.Controls.Add(this.deleteauthorbutton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.BooktextBox);
			this.Controls.Add(this.AuthortextBox);
			this.Controls.Add(this.categorynametextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AuthorcomboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CategoryIdcomboBox);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditBookListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯書籍";
			this.Load += new System.EventHandler(this.EditBookListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bookAuthorVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoriesVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox BooktextBox;
		private System.Windows.Forms.TextBox AuthortextBox;
		private System.Windows.Forms.TextBox categorynametextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox AuthorcomboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CategoryIdcomboBox;
		private System.Windows.Forms.Button UpdateBookbutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource bookIndexVMBindingSource;
		private System.Windows.Forms.Button Updatecategorybutton;
		private System.Windows.Forms.Button Updateauthorbutton;
		private System.Windows.Forms.BindingSource bookAuthorVMBindingSource;
		private System.Windows.Forms.BindingSource bookCategoriesVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoriesNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn callnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button deleteauthorbutton;
		private System.Windows.Forms.Button deletecategorybutton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}