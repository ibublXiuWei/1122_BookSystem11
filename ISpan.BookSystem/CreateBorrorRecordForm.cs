using ISpan.BookSystem.Extensions;
using ISpan.BookSystem.ViewModels;
using ISpan.BookSystem.ViewModels.Services;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	public partial class CreateBorrorRecordForm : Form
	{
		private int id;
		public CreateBorrorRecordForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}

		private void BindData(int id)
		{
			BookVM model = new BookService().Get(id);
			booktextBox.Text = model.BookName;

			borrowdatelabel.Text = DateTime.Today.ToString();
			returndatelabel.Text = DateTime.Today.AddMonths(1).ToString();
			
		}

		private void saveborrowbutton_Click(object sender, EventArgs e)
		{
			if (radioButtonno.Checked)
			{
				this.Close();
				return;
			}
			LoginVM model = new LoginVM()
			{
				RdAccount = AccounttextBox.Text,
				Password = PasswordtextBox.Text,
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"RdAccount",AccounttextBox } ,
				{"Password",PasswordtextBox } ,
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			//判斷帳密是否正確
			bool result = new ReaderUserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}
			//從帳號找到ID
			string findaccount = AccounttextBox.Text;
			string sql = "SELECT ReadId FROM ReaderUser WHERE RdAccount=@RdAccount";
			var parameters = new SqlParameterBuider()
				.AddNvarchar("RdAccount",50, findaccount)
				.Buid();
			var user = new SqlDbHelper("default").Select(sql, parameters);
			int userid = user.Rows[0].Field<int>("ReadId");
			
			RentBookVM rent = new RentBookVM()
			{
				reader_Id = userid,
				book_id = this.id,
				ReturnBook = !radioButtonborrow.Checked
			};
			rent.BorrowDateTime = Convert.ToDateTime(borrowdatelabel.Text);
			rent.ReturnDateTime = Convert.ToDateTime(returndatelabel.Text);
			try
			{
				new BorrowService().Create(rent);
				this.DialogResult = DialogResult.OK;
				MessageBox.Show("成功新增借閱");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
