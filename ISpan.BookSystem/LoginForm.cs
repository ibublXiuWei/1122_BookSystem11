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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void Loginbutton_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM()
			{
				RdAccount = AccounttextBox.Text,
				Password = PasswordtextBox.Text,
			};

			//驗證欄位輸入是否正確
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
			string sql = @"SELECT ReadId FROM ReaderUser 
 where RdAccount=@RdAccount";
			var parameters = new SqlParameterBuider()
				.AddNvarchar("RdAccount",50, AccounttextBox.Text)
				.Buid();
			var user = new SqlDbHelper("default").Select(sql, parameters);
			int userid = user.Rows[0].Field<int>("ReadId");
			//MessageBox.Show(userid.ToString());
			//若正確就開啟mainForm
			AccounttextBox.Text = String.Empty;
			PasswordtextBox.Text = String.Empty;
			var frm = new MainForm(userid);
			frm.Owner = this;

			frm.Show();
			this.Hide();
		}
	}
}
