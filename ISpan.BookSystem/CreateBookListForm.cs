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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	public partial class CreateBookListForm : Form
	{
		private BookIndexVM[] booklists = null;
		public CreateBookListForm()
		{
			InitializeComponent();
			InitFormCategory();
			InitFormAuthor();
			DisplayBooks();
			dataGridView1.AutoResizeColumns();
		}
		
		private void InitFormCategory()
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
		private void InitFormAuthor()
		{//ComboBox 選單建立
			AuthorcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = @"select * from BookAuthor order by AuthorId";
			var dbhelper = new SqlDbHelper("default");
			List<BookAuthorVM> categories = dbhelper.Select(sql, null)
											.AsEnumerable()
											.Select(row => ToAuthorVM(row)) //轉型成 ProductCategoryVM
											.Prepend(new BookAuthorVM { AuthorId = 0, AuthorName = string.Empty }) //空白選全部
											.ToList();

			this.AuthorcomboBox.DataSource = categories;
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
		private void AddCategoryButton_Click(object sender, EventArgs e)
		{
			BookCategoriesVM category = new BookCategoriesVM()
			{
				CategoriesName = categorynametextBox.Text

			};
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"CategoriesName",categorynametextBox } ,
			};
			bool isValid = ValidationHelper.Validate(category, map, errorProvider1);
			if (!isValid) return;

			string categoriesName = categorynametextBox.Text;
			string sql = @"INSERT INTO Categories(CategoriesName)
							VALUES (@CategoriesName)";

			var parameters = new SqlParameterBuider().AddNvarchar("CategoriesName", 50, categoriesName)
													.Buid();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("分類已新增");

			//this.DialogResult = DialogResult.OK; //傳回Ok
			InitFormCategory();
		}

		private  void AddAuthorbutton_Click(object sender, EventArgs e)
		{
			BookAuthorVM author = new BookAuthorVM()
			{
				AuthorName = AuthortextBox.Text,

			};
			Dictionary<string, Control> map1 = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"AuthorName",AuthortextBox } ,
			};
			bool isValid = ValidationHelper.Validate(author, map1, errorProvider1);
			if (!isValid) return;

			//this.DialogResult = DialogResult.OK; //傳回Ok
			
			string authorName = AuthortextBox.Text;
			string sql = @"INSERT INTO BookAuthor(AuthorName)
							VALUES (@AuthorName)";

			var parameters = new SqlParameterBuider().AddNvarchar("AuthorName", 50, authorName)
													.Buid();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("作者已新增");
			InitFormAuthor();

		}
		
		private void Addbookbutton_Click(object sender, EventArgs e)
		{
			
			//取得表單的個欄位值
			int categoryId = ((BookCategoriesVM)this.CategoryIdcomboBox.SelectedItem).Id;
			int authorId = ((BookAuthorVM)this.AuthorcomboBox.SelectedItem).AuthorId;
			string bookName = BooktextBox.Text;
			string authorName = AuthortextBox.Text;
			string categoriesName = categorynametextBox.Text;
			//將他們繫結到ViewModel
			BookVM model = new BookVM()
			{
				BookId = categoryId,
				BookName = bookName,
				Categories_id = categoryId,
				Author_Id = authorId,
			};
			BookCategoriesVM aumodel = new BookCategoriesVM()
			{
				CategoriesName = categoriesName,
				
			};

			//針對ViewModel做欄位驗證
			string errMsg = string.Empty;
			if (string.IsNullOrEmpty(model.BookName)) errMsg += "請輸入書籍名稱\r\n";
			//if (model.ListPrice < 0) errMsg += "牌價請輸入大於或等於零的整數\r\n";
			if(string.IsNullOrEmpty(authorName)&& authorId==0) errMsg += "請輸入或選擇作者\r\n";
			if (string.IsNullOrEmpty(categoriesName) && categoryId == 0) errMsg += "請輸入或選擇分類\r\n";
			if (string.IsNullOrEmpty(errMsg) == false)
			{//表示至少有一欄有錯誤
				MessageBox.Show(errMsg);
				return;
			}
			if (categoryId == 0 && authorId != 0) AddCategoryButton_Click(sender, e); InitFormCategory();
			if (categoryId != 0 && authorId == 0) AddAuthorbutton_Click(sender, e);InitFormAuthor();
			
			//如果通過驗證，就新增紀錄
			string sql = @"INSERT INTO Book(BookName,Categories_id,Author_Id)
							VALUES (@BookName,@Categories_id,@Author_Id)";

			var parameters = new SqlParameterBuider()
													.AddNvarchar("BookName", 50, model.BookName)
													.AddInt("Categories_id", model.Categories_id)
													.AddInt("Author_Id", model.Author_Id)
													.Buid();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("書籍已新增");
			this.DialogResult = DialogResult.OK;
			DisplayBooks(); //重回更新後回到的dataGridView1，展示產品列表
			
		}

		private void DisplayBooks()
		{
			string sql = @"select Top(1) BookId ,BookName,AuthorName,CategoriesName ,
convert(nvarchar(50),categories_id)+'.'+convert(nvarchar(50),author_id)+'.'+convert(nvarchar(50),BookId) as Callnumber 
from Book
join Categories on Book.categories_id=Categories.Id
join BookAuthor on Book.author_id=BookAuthor.AuthorId
";

			SqlParameter[] parameters = new SqlParameter[] { };
			
			int categoryId = ((BookCategoriesVM)CategoryIdcomboBox.SelectedItem).Id;
			if (categoryId > 199)
			{
				sql += $" where categories_id=@categories_id ";//記得保留空格
				parameters = new SqlParameterBuider()
							.AddInt("categories_id", categoryId)
							.Buid();
			}

			sql += " ORDER BY BookId desc"; //order 前面要加空白，在串接語法時才沒有問題
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
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;

			if (rowindex < 0) return;

			BookIndexVM row = this.booklists[rowindex]; //使用者點到的那一筆紀錄
			int id = row.BookId; //使用者點到的那一筆紀錄的 Id

			//把Id 傳給編輯表單的建構函數
			var frm = new EditBookListForm(id);
			//frm.Show();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayBooks(); //重回更新後回到的dataGridView1，展示產品列表
				InitFormCategory();
				InitFormAuthor();
			}
		}
	}
}
