using ISpan.BookSystem.ViewModels;
using ISpan.BookSystem.ViewModels.Services;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.BookSystem
{
	public partial class BorrowRecordForm : Form
	{
		private RentBookIndexVM[] rentlists = null;
		private int id;

		public BorrowRecordForm(int id)
		{
			InitializeComponent();
			label1.Text = $"Hi,{id}這是你的借閱紀錄";
			DisplayBorrowRecord(id);
			this.id = id;
	
		}
		public void DisplayBorrowRecord(int id)
		{
			string sql = @"select RentOrderId,reader_Id,RdName ,BookName ,returnbook
,convert(nvarchar(50),book.Categories_Id)+'.'+convert(nvarchar(50),book.Author_Id)+'.'+convert(nvarchar(50),BookId) as Callnumber 
,BorrowDateTime, ReturnDateTime,Phone,Mail 
from RentBookList rb
join ReaderUser ru on rb.reader_Id=ru.ReadId
join book on book.BookId= rb.book_id
 where reader_Id=@reader_Id
";
			sql += @" and ReturnBook=0   ";

			SqlParameter[] parameters = new SqlParameter[] { };
			parameters = new SqlParameterBuider()
				.AddInt("reader_Id", id).Buid();
			
			var dbhelper = new SqlDbHelper("default");
			rentlists = dbhelper.Select(sql, parameters)
						.AsEnumerable()
						.Select(rows => ParseToIndexVM(rows))
						.ToArray();
			BindData(rentlists);
		}
		
		public void BindData(RentBookIndexVM[] rentlists)
		{
			dataGridView1.DataSource = rentlists;
		}
		private RentBookIndexVM ParseToIndexVM(DataRow rows)
		{
			return new RentBookIndexVM
			{
				RentOrderId = rows.Field<int>("RentOrderId"),
				BookName = rows.Field<string>("BookName"),
				RdName = rows.Field<string>("RdName"),
				callnumber = rows.Field<string>("callnumber"),
				Phone = rows.Field<string>("Phone"),
				Mail = rows.Field<string>("Mail"),
				ReturnBook = rows.Field<bool>("ReturnBook"),
				BorrowDateTime = rows.Field<DateTime>("BorrowDateTime"),
				ReturnDateTime = rows.Field<DateTime>("ReturnDateTime")

			};
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;
			if (rowindex < 0) return;

			RentBookIndexVM row = this.rentlists[rowindex];
			int borrowId = row.RentOrderId;
			var frm = new EditBorrorRecordForm(borrowId);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayBorrowRecord(this.id);
			}
		}

	}
}
