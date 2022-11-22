using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels
{
	public class BookAuthorVM
	{
		public int AuthorId { get; set; }
		[Required(ErrorMessage = "作者必填")]
		public string AuthorName { get; set; }
	}
}
