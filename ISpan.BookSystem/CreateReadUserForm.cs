using ISpan.BookSystem.Extensions;
using ISpan.BookSystem.ViewModels.Services;
using ISpan.BookSystem.ViewModels;
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
	public partial class CreateReadUserForm : Form
	{
		public CreateReadUserForm()
		{
			InitializeComponent();
		}

		private void Savebutton_Click(object sender, EventArgs e)
		{
			string account = AccounttextBox.Text;
			string password = PasswordtextBox.Text;
			string name = NametextBox.Text;
			string mail = MailtextBox.Text;
			string phone = PhonetextBox.Text;

			ReaderUserVM model = new ReaderUserVM()
			{
				RdAccount = account,
				Password = password,
				RdName = name,
				Mail = mail,
				Phone = phone,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"RdAccount",AccounttextBox } ,
				{"Password",PasswordtextBox } ,
				{"RdName",NametextBox } ,
				{"Mail",MailtextBox },
				{"Phone",PhonetextBox },

			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new ReaderUserService().Create(model);
				this.DialogResult = DialogResult.OK;
				MessageBox.Show("成功新增借閱帳號");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
