using ISpan.BookSystem.Extensions;
using ISpan.BookSystem.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	
	public partial class EditBookListForm : Form
	{
		private int bookid;
		private BookIndexVM[] booklists = null;
		
		public EditBookListForm(int id)
		{
			InitializeComponent();
			this.bookid = id;
			
			InitFormCategory();
			InitFormAuthor();
			DisplayBooks();
			
		}
		
		private void EditBookListForm_Load(object sender, EventArgs e)
		{
			BindData(this.bookid);
		}
		private void BindData(int bookid)
		{
			string sql = @"select * from Book 
							where BookId=@BookId
							";
			var parameters = new SqlParameterBuider().AddInt("BookId", bookid)
													.Buid();
			var dbhelper = new SqlDbHelper("default");
			//List <BookIndexVM> data = new SqlDbHelper("default").Select(sql, parameters).AsEnumerable().ToList();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉找不到要編輯的資料");
				//this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}

			DataRow row = data.Rows[0];
			
			AuthorcomboBox.SelectedItem=row.Field<int>("Author_Id");
			CategoryIdcomboBox.SelectedItem = row.Field<int>("Categories_Id");
			BooktextBox.Text = row.Field<string>("BookName");
		}
		private void InitFormCategory()
		{//ComboBox 選單建立

			//string sql1 = @"select Id from book
			//   join Categories on book.Categories_Id=Categories.Id
			//   where BookId=@BookId";
			//var parametersId = new SqlParameterBuider()
			//	.AddInt("BookId", bookid)
			//	.Buid();
			//var cateid = new SqlDbHelper("default").Select(sql1, parametersId);
			//int categoryId = cateid.Rows[0].Field<int>("Id");
			//CategoryIdcomboBox.SelectionStart = categoryId;


			//SqlParameter[] parameters = new SqlParameter[] { };
			//parameters = new SqlParameterBuider()
			//				.AddInt("Id", categoryId)
			//				.Buid();
			CategoryIdcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = @"select * from Categories order by Id";//where Id=@Id
			var dbhelper = new SqlDbHelper("default");
			List<BookCategoriesVM> categories = dbhelper.Select(sql, null)
											.AsEnumerable()
											.Select(row => ToCategoryVM(row)) 
											.ToList();
			
			this.CategoryIdcomboBox.DataSource = categories;
		}
		private void InitFormAuthor()
		{//ComboBox 選單建立
//			string sql1 = @"select AuthorId from book
//join BookAuthor on book.Author_Id=BookAuthor.AuthorId
//where BookId=@BookId";
//			var parametersId = new SqlParameterBuider()
//				.AddInt("BookId", bookid)
//				.Buid();
//			var authid = new SqlDbHelper("default").Select(sql1, parametersId);
//			int authorId = authid.Rows[0].Field<int>("AuthorId");

//			SqlParameter[] parameters = new SqlParameter[] { };
//			parameters = new SqlParameterBuider()
//							.AddInt("AuthorId", authorId)
//							.Buid();
			AuthorcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = @"select * from BookAuthor order by AuthorId";//where  AuthorId=@AuthorId
			var dbhelper = new SqlDbHelper("default");
			List<BookAuthorVM> authors = dbhelper.Select(sql, null)
											.AsEnumerable()
											.Select(row => ToAuthorVM(row)) 
											//.Append(new BookAuthorVM { AuthorId = authorId }) //空白選全部
											.ToList();

			this.AuthorcomboBox.DataSource = authors;
		}
		private BookAuthorVM ToAuthorVM(DataRow row)
		{
			return new BookAuthorVM
			{
				AuthorId = row.Field<int>("AuthorId"),
				AuthorName = row.Field<string>("AuthorName"),
			};
		}
		private BookCategoriesVM ToCategoryVM(DataRow row)
		{
			return new BookCategoriesVM
			{
				Id = row.Field<int>("Id"),
				CategoriesName = row.Field<string>("CategoriesName"),
			};
		}
		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除書籍嗎？", "刪除紀錄",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return; //若沒有回傳Yes,就回到原本的Update頁
			}

			string sql = @"DELETE FROM Book  
						WHERE BookId=@BookId";

			var parameters = new SqlParameterBuider().AddInt("BookId", this.bookid)
													.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");

			this.DialogResult = DialogResult.OK;
		}
		private void DisplayBooks()
		{
			string sql = @"select BookId ,BookName,AuthorName,CategoriesName ,
convert(nvarchar(50),categories_id)+'.'+convert(nvarchar(50),author_id)+'.'+convert(nvarchar(50),BookId) as Callnumber 
from Book
join Categories on Book.categories_id=Categories.Id
join BookAuthor on Book.author_id=BookAuthor.AuthorId
 where BookId=@BookId 
";

			SqlParameter[] parameters = new SqlParameter[] { };
			
			//int categoryId = ((BookCategoriesVM)CategoryIdcomboBox.SelectedItem).Id;
			//if (categoryId > 199)
			//{
			//	sql += $" where categories_id=@categories_id ";//記得保留空格
			//	parameters = new SqlParameterBuider()
			//				.AddInt("categories_id", categories_id)
			//				.Buid();
			//}
				//sql += $" where BookId=@BookId ";//記得保留空格
				parameters = new SqlParameterBuider()
							.AddInt("BookId", bookid)
							.Buid();

			//sql += " ORDER BY BookId "; //order 前面要加空白，在串接語法時才沒有問題
			var dbhelper = new SqlDbHelper("default");
			booklists = dbhelper.Select(sql, parameters)
						.AsEnumerable()
						.Select(rows => ParseToIndexVM(rows))
						.ToArray();
			BindData(booklists);
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
		private void BindData(BookIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void Updatecategorybutton_Click(object sender, EventArgs e)
		{
			
			int categoryId = ((BookCategoriesVM)this.CategoryIdcomboBox.SelectedItem).Id;
			string categoriesName = categorynametextBox.Text;
			string sql = @"Update Categories
							set CategoriesName=@CategoriesName
							where Id=@Id";

			BookCategoriesVM aumodel = new BookCategoriesVM()
			{
				Id= categoryId,
				CategoriesName = categoriesName,
			};

			var parameters = new SqlParameterBuider().AddInt("Id", categoryId)
													.AddNvarchar("CategoriesName", 50, categoriesName)
													.Buid();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("分類已修改");

			this.DialogResult = DialogResult.OK; //傳回Ok
			//InitFormCategory();
		}

		private void Updateauthorbutton_Click(object sender, EventArgs e)
		{
			int authorId = ((BookAuthorVM)this.AuthorcomboBox.SelectedItem).AuthorId;
			string authorName = AuthortextBox.Text;
			string sql = @"Update BookAuthor
set AuthorName=@AuthorName
							where AuthorId=@AuthorId";

			BookAuthorVM aumodel = new BookAuthorVM()
			{
				AuthorId = authorId,
				AuthorName = authorName,
			};

			var parameters = new SqlParameterBuider().AddInt("AuthorId", authorId)
				.AddNvarchar("AuthorName", 50, authorName)
													.Buid();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("作者已修改");

			this.DialogResult = DialogResult.OK; //傳回Ok
			InitFormAuthor();
		}

		private void UpdateBookbutton_Click(object sender, EventArgs e)
		{
			int categoryId = ((BookCategoriesVM)this.CategoryIdcomboBox.SelectedItem).Id;
			int authorId = ((BookAuthorVM)this.AuthorcomboBox.SelectedItem).AuthorId;
			string sql = @"Update  Book 
set BookName=@BookName,Categories_id=@Categories_id ,Author_Id=@Author_Id
							where BookId=@BookId
							";
			BookVM model = new BookVM()
			{
				BookId = bookid,
				BookName = BooktextBox.Text,
				Categories_id = categoryId,
				Author_Id = authorId,
			};
			
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"BookName",BooktextBox } ,
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			var parameters = new SqlParameterBuider().AddInt("BookId", bookid)
													.AddNvarchar("BookName", 50, model.BookName)
													.AddInt("Categories_id", model.Categories_id)
													.AddInt("Author_Id", model.Author_Id)
													.Buid();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			MessageBox.Show("書籍已修改");

			this.DialogResult = DialogResult.OK;

			//DataRow row = data.Rows[0];
			//((BookCategoriesVM)this.CategoryIdcomboBox.SelectedItem).Id = row.Field<int>("Categories_id");
			//((BookAuthorVM)this.AuthorcomboBox.SelectedItem).AuthorId=row.Field<int>("Author_Id");
			////categorynametextBox.Text = row.Field<string>("CategoryName");
			////AuthortextBox.Text = row.Field<string>("AuthorName");
			//BooktextBox.Text = row.Field<string>("BookName");

			/////////////////////////////////////////////////////////////////////////
			//int categoryId = ((BookCategoriesVM)this.CategoryIdcomboBox.SelectedItem).Id ;
			//int authorId = ((BookAuthorVM)this.AuthorcomboBox.SelectedItem).AuthorId;

			string bookName = BooktextBox.Text;
			string authorName = AuthortextBox.Text;
			string categoriesName = categorynametextBox.Text;
			//將他們繫結到ViewModel
			BookVM model2 = new BookVM()
			{
				BookId = this.bookid,
				BookName = bookName,
				Categories_id = categoryId,
				Author_Id = authorId,
			};
			BookCategoriesVM camodel = new BookCategoriesVM()
			{
				CategoriesName = categoriesName,
			};
			BookAuthorVM aumodel = new BookAuthorVM()
			{
				AuthorName = authorName,
			};


			//針對ViewModel做欄位驗證
			string errMsg = string.Empty;
			if (string.IsNullOrEmpty(model.BookName)) errMsg += "請輸入書籍名稱\r\n";

			if (string.IsNullOrEmpty(authorName) && authorId == 0) errMsg += "請輸入或選擇作者\r\n";
			//f (string.IsNullOrEmpty(categoriesName) && categoryId == 0) errMsg += "請輸入或選擇分類\r\n";
			if (string.IsNullOrEmpty(errMsg) == false)
			{//表示至少有一欄有錯誤
				MessageBox.Show(errMsg);
				return;
			}
			//if (categoryId == 0 && authorId != 0) AddCategoryButton_Click(sender, e); InitFormCategory();
			//if (categoryId != 0 && authorId == 0) AddAuthorbutton_Click(sender, e); InitFormAuthor();

			//如果通過驗證，就新增紀錄
			sql = @"update Book
							set	BookName=@BookName,Categories_id=@Categories_id,Author_Id=@Author_Id
							where BookId=@BookId";

			parameters = new SqlParameterBuider().AddInt("BookId", bookid)
												   .AddNvarchar("BookName", 50, model.BookName)
												   .AddInt("Categories_id", model.Categories_id)
												   .AddInt("Author_Id", model.Author_Id)
												   .Buid();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("書籍已新增");
			this.DialogResult = DialogResult.OK;
			DisplayBooks();
		}

		private void deletecategorybutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除書籍嗎？", "刪除紀錄",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return; //若沒有回傳Yes,就回到原本的Update頁
			}
			int categoryId = ((BookCategoriesVM)this.CategoryIdcomboBox.SelectedItem).Id;

			string sql = @"DELETE FROM Categories 
						WHERE Id=@Id";

			var parameters = new SqlParameterBuider().AddInt("Id", categoryId)
													.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			

			this.DialogResult = DialogResult.OK;
		}

		private void deleteauthorbutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除書籍嗎？", "刪除紀錄",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return; //若沒有回傳Yes,就回到原本的Update頁
			}
			int authorId = ((BookAuthorVM)this.AuthorcomboBox.SelectedItem).AuthorId;
			string sql = @"DELETE FROM BookAuthor  
						WHERE AuthorId=@AuthorId";

			var parameters = new SqlParameterBuider().AddInt("AuthorId", authorId)
													.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");

			this.DialogResult = DialogResult.OK;
		}
	}
}
