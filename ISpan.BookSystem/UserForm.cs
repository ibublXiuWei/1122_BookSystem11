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
	public partial class UserForm : Form
	{
		private UserIndexVM[] users = null;
		public UserForm()
		{
			InitializeComponent();
			DisplayUsers();
		}
		private void DisplayUsers()
		{
			users = new ReaderUserService().GetAll().ToArray();
			BindData(users);
		}

		public void BindData(UserIndexVM[] users)
		{//BindData甚麼意思
			dataGridView1.DataSource = users;
		}
		private void Addbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateReadUserForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;
			if (rowindex < 0) return;

			UserIndexVM row = this.users[rowindex];
			int id = row.ReadId;
			var frm = new EditReadUserForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
	}
}
