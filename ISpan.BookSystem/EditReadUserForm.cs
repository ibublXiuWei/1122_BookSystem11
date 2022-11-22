using ISpan.BookSystem.Extensions;
using ISpan.BookSystem.ViewModels;
using ISpan.BookSystem.ViewModels.Services;
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
	
	public partial class EditReadUserForm : Form
	{
		private int id;
		public EditReadUserForm(int id)
		{
			InitializeComponent();

			this.Load += EditReadUserForm_Load;
			this.id = id;
		}
		private void EditReadUserForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			ReaderUserVM model = new ReaderUserService().Get(id);

			// 再將 viewModel值繫結到各控制項
			AccounttextBox.Text = model.RdAccount;
			PasswordtextBox.Text = model.Password;
			NametextBox.Text = model.RdName;
			MailtextBox.Text = model.Mail;
			PhonetextBox.Text = model.Phone;
		}
		private void Updatebutton_Click(object sender, EventArgs e)
		{
			string account = AccounttextBox.Text;
			string password = PasswordtextBox.Text;
			string name = NametextBox.Text;
			string mail = MailtextBox.Text;
			string phone = PhonetextBox.Text;

			ReaderUserVM model = new ReaderUserVM()
			{
				ReadId =this.id,
				RdAccount = account,
				Password = password,
				RdName = name,
				Mail = mail,
				Phone = phone,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{//不確定這邊的用途
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
				new ReaderUserService().Update(model);
				this.DialogResult = DialogResult.OK;
				MessageBox.Show("修改紀錄成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new ReaderUserService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}

		
	}
}
