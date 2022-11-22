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
	public partial class MainForm : Form
	{
		private int id;
		public MainForm(int userid)
		{
			InitializeComponent();
			this.IsMdiContainer = true;
			this.id = userid;
		}

		private void 帳號管理ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var frm = new UserForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 書籍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var frm = new BookListForm();
			frm.MdiParent = this;
			frm.Show();
		}


		private void 登出ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}

		private void 書本借閱ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new BorrowBookForm();
			frm.MdiParent = this;
			frm.Show(); 
		}

		public void 借閱總攬ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new BorrowRecordForm(id);
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
