using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels
{
	public class BookCategoriesVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "分類必填")]
		public string CategoriesName { get; set; }
	}
}
