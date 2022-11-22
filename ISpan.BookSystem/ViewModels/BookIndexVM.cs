using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels
{

	public class BookIndexVM
	{
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string AuthorName { get; set; }
		public string CategoriesName { get; set; }
		public string Callnumber { get; set; }
	}
	public class BorrowBookIndexVM
	{
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string AuthorName { get; set; }
		public string CategoriesName { get; set; }
		public string Callnumber { get; set; }
		public bool? ReturnBook { get; set; }
	}

	public class BookVM
	{
		public int BookId { get; set; }
		[Required(ErrorMessage = "書名必填")]
		public string BookName { get; set; }
		public int Categories_id { get; set; }
		public int Author_Id { get; set; }
	}
}
