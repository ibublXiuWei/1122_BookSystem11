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
	public partial class BorrowBookForm : Form
	{
		private BorrowBookIndexVM[] booklists = null;
		public BorrowBookForm()
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
			string sql = @"select distinct BookId ,BookName,AuthorName,CategoriesName ,
convert(nvarchar(50),categories_id)+'.'+convert(nvarchar(50),book.Author_Id)+'.'+convert(nvarchar(50),BookId) as Callnumber 
,ReturnBook
from Book 
left join Categories on Book.categories_id=Categories.Id
left join BookAuthor on Book.author_id=BookAuthor.AuthorId
left join RentBookList on RentBookList.book_id= Book.BookId
";
			
			SqlParameter[] parameters = new SqlParameter[] { };
			int categoryId = ((BookCategoriesVM)CategoryIdcomboBox.SelectedItem).Id;
			string searchbook = SearchbooktextBox.Text;
			sql += $" where(ReturnBook=1 or ReturnBook is null ) ";
			//if (categoryId > 199)
			//{
			//	sql += " and  Id=@Id ";
			//	parameters = new SqlParameterBuider()
			//				.AddInt("Id", categoryId)
			//				.Buid();
			//}

			if (categoryId > 0 || searchbook != String.Empty)
			{
				sql += $" AND categories_id=@categories_id and  BookName like '%{searchbook}%'";//記得保留空格

				parameters = new SqlParameterBuider()
							.AddInt("categories_id", categoryId)
							.Buid();
			}
			var dbhelper = new SqlDbHelper("default");
			booklists = dbhelper.Select(sql, parameters)
						.AsEnumerable()
						.Select(rows => ParseToIndexVM(rows))
						.ToArray();
			BindData(booklists);
		}

		private void BindData(BorrowBookIndexVM[] booklists)
		{
			dataGridView1.DataSource = booklists;
		}

		private BorrowBookIndexVM ParseToIndexVM(DataRow rows)
		{
			return new BorrowBookIndexVM
			{
				BookId = rows.Field<int>("BookId"),
				BookName = rows.Field<string>("BookName"),
				AuthorName = rows.Field<string>("AuthorName"),
				CategoriesName = rows.Field<string>("CategoriesName"),
				Callnumber = rows.Field<string>("Callnumber"),
				ReturnBook= rows.Field<bool?>("ReturnBook")

			};
		}

		private void Searchbutton_Click(object sender, EventArgs e)
		{

			DisplayBooks();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;

			if (rowindex < 0) return;

			BorrowBookIndexVM row = this.booklists[rowindex]; //使用者點到的那一筆紀錄
			int id = row.BookId; //使用者點到的那一筆紀錄的 Id

			//把Id 傳給編輯表單的建構函數
			var frm = new CreateBorrorRecordForm(id);
			//frm.Show();
			//DisplayBooks();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayBooks(); //重回更新後回到的dataGridView1，展示產品列表
			}
		}
	}
}
