using ISpan.BookSystem.ViewModels;
using ISpan.BookSystem.ViewModels.Services;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	public partial class EditBorrorRecordForm : Form
	{
		private int id;
		public EditBorrorRecordForm(int id)
		{
			InitializeComponent();
			this.Load += EditBorrorRecordForm_Load;
			this.id = id;
		}
		private void EditBorrorRecordForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			RentBookVM model = new BorrowService().Get(id);
			//從帳號找到ID
			//string findaccount = AccounttextBox.Text;
			string sql = @"SELECT RdName FROM RentBookList rb
join ReaderUser on rb.reader_Id=ReaderUser.ReadId 
where reader_Id=(select reader_Id FROM RentBookList rb 
where RentOrderId=@RentOrderId)";
			var parametersname = new SqlParameterBuider()
				.AddInt("RentOrderId", id)
				.Buid();
			var username = new SqlDbHelper("default").Select(sql, parametersname);
			string name = username.Rows[0].Field<string>("RdName");

			string sql2 = @"SELECT RdAccount FROM RentBookList rb
join ReaderUser on rb.reader_Id=ReaderUser.ReadId 
where reader_Id=(select reader_Id FROM RentBookList rb 
where RentOrderId=@RentOrderId)";
			var parametersAccount = new SqlParameterBuider()
				.AddInt("RentOrderId", id)
				.Buid();
			var useraccount = new SqlDbHelper("default").Select(sql2, parametersAccount);
			string account = useraccount.Rows[0].Field<string>("RdAccount");

			string sql3 = @"SELECT BookName FROM RentBookList rb 
join book on book.BookId=rb.book_id
where book_id=(select book_id FROM RentBookList rb 
where RentOrderId=@RentOrderId)";
			var parametersbook = new SqlParameterBuider()
				.AddInt("RentOrderId", id)
				.Buid();
			var bookname = new SqlDbHelper("default").Select(sql3, parametersbook);
			string book = bookname.Rows[0].Field<string>("BookName");

			string sql4 = @"select 
convert(nvarchar(50),categories_id)+'.'+convert(nvarchar(50),book.Author_Id)+'.'+convert(nvarchar(50),BookId) as Callnumber 
from RentBookList 
join Book on RentBookList.book_id= Book.BookId
  join Categories on Book.categories_id=Categories.Id
join BookAuthor on Book.author_id=BookAuthor.AuthorId
where RentOrderId=@RentOrderId";
			var parameterscallnumber = new SqlParameterBuider()
				.AddInt("RentOrderId", id)
				.Buid();
			var number = new SqlDbHelper("default").Select(sql4, parameterscallnumber);
			string callnumber = number.Rows[0].Field<string>("Callnumber");

			// 再將 viewModel值繫結到各控制項
			AccounttextBox.Text = account;
			NametextBox.Text = name;
			CallnumbertextBox.Text = callnumber;
			BookNametextBox.Text = book;

			
		}
		private void SaveButton_Click(object sender, EventArgs e)
		{
			bool backbook=true;
			if(radioButtonyes.Checked)
			{
				backbook = true;
			}
			if(radioButtonno.Checked)
			{
				backbook=false;
				this.Close();
				return;
			}
			RentBookVM model = new BorrowService().Get(id);
			RentBookVM rent = new RentBookVM()
			{
				RentOrderId=id,
				reader_Id = model.reader_Id,
				book_id = model.book_id,
				ReturnBook = backbook,
			};
			try
			{
				new BorrowService().Update(rent);
				MessageBox.Show("更新成功");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要取消借閱嗎?",
						"借閱取消",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new BorrowService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	
	}
}
