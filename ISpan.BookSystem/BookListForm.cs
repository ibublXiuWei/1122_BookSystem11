using ISpan.BookSystem.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	public partial class BookListForm : Form
	{
		private BookIndexVM[] booklists = null;
		public BookListForm()
		{
			InitializeComponent();
			InitForm();
			DisplayBooks();
		}
		private void InitForm()
		{//ComboBox 選單建立
			CategoryIdcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = @"select * from Categories order by Id";
			var dbhelper = new SqlDbHelper("default");
			List<BookCategoriesVM> categories = dbhelper.Select(sql, null)
											.AsEnumerable()
											.Select(row => ToCategoryVM(row)) //轉型成 ProductCategoryVM
											.Prepend(new BookCategoriesVM { Id = 0, CategoriesName = string.Empty }) //空白選全部
											.ToList();

			this.CategoryIdcomboBox.DataSource = categories;
		}
		private BookCategoriesVM ToCategoryVM(DataRow row)
		{
			return new BookCategoriesVM
			{
				Id = row.Field<int>("Id"),
				CategoriesName = row.Field<string>("CategoriesName"),
				
			};
		}

		private void DisplayBooks()
		{
			string sql = @"select BookId ,BookName,AuthorName,CategoriesName ,
convert(nvarchar(50),categories_id)+'.'+convert(nvarchar(50),author_id)+'.'+convert(nvarchar(50),BookId) as Callnumber 
from Book
join Categories on Book.categories_id=Categories.Id
join BookAuthor on Book.author_id=BookAuthor.AuthorId
";

			SqlParameter[] parameters = new SqlParameter[] { };
			string searchbook=SearchbooktextBox.Text;
			int categoryId = ((BookCategoriesVM)CategoryIdcomboBox.SelectedItem).Id;
			//if (categoryId > 199)
			//{
			//	sql += $" where categories_id=@categories_id ";//記得保留空格
			//	parameters = new SqlParameterBuider()
			//				.AddInt("categories_id", categoryId)
			//				.Buid();
			//}
			if (categoryId > 199 || searchbook != String.Empty)
			{
				sql += $" where categories_id=@categories_id  and  BookName like '%{searchbook}%'";//記得保留空格

				parameters = new SqlParameterBuider()
							.AddInt("categories_id", categoryId)
							.Buid();
			}
			//else if(categoryId <1 && searchbook != null)
			//{
			//	sql += $" WHERE  BookName like '{searchbook}'";//記得保留空格
			//}
			



			var dbhelper = new SqlDbHelper("default");
			booklists = dbhelper.Select(sql, parameters)
						.AsEnumerable()
						.Select(rows => ParseToIndexVM(rows))
						.ToArray();
			BindData(booklists);
		}

		private void BindData(BookIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private BookIndexVM ParseToIndexVM(DataRow rows)
		{
			return new BookIndexVM
			{
				BookId = rows.Field<int>("BookId"),
				BookName = rows.Field<string>("BookName"),
				AuthorName = rows.Field<string>("AuthorName"),
				CategoriesName = rows.Field<string>("CategoriesName"),
				Callnumber = rows.Field<string>("Callnumber")

			};
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;

			if (rowindex < 0) return;

			BookIndexVM row = this.booklists[rowindex]; //使用者點到的那一筆紀錄
			int id = row.BookId; //使用者點到的那一筆紀錄的 Id

			//把Id 傳給編輯表單的建構函數
			var frm = new EditBookListForm(id);
			//frm.Show();
			//DisplayBooks();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayBooks(); //重回更新後回到的dataGridView1，展示產品列表
				InitForm();
			}
		}

		private void Searchbutton_Click(object sender, EventArgs e)
		{
			DisplayBooks();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateBookListForm();
			//frm.Show();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayBooks(); //重回更新後回到的dataGridView1，展示產品列表
			}
		}
	}
}
