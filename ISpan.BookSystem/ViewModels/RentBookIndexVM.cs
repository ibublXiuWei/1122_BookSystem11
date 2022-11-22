using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels.Services
{
	public class RentBookIndexVM
	{
		public int RentOrderId { get; set; }
		//public int reader_Id { get; set; }
		public string RdName { get; set; }
		public string BookName { get; set; }
		public string callnumber { get; set; }
		public DateTime BorrowDateTime { get; set; }
		public DateTime ReturnDateTime { get; set; }
		public bool ReturnBook { get; set; }
		public string Phone { get; set; }
		public string Mail { get; set; }

	}
	public class RentBookVM
	{
		public int RentOrderId { get; set; }
		public int reader_Id { get; set; }
		public int book_id { get; set; }
		public DateTime BorrowDateTime { get; set; }
		public DateTime ReturnDateTime { get; set; }
		public bool ReturnBook { get; set; }
	}
}
