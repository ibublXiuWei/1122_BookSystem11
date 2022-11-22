using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels
{
	public class UserIndexVM
	{
		
			//public string UserType { get; set; }
			public int ReadId { get; set; }
			public string RdAccount { get; set; }
			public string Password { get; set; }
			public string RdName { get; set; }

			public string Mail { get; set; }
			public string Phone { get; set; }
	}
	public class ReaderUserVM
	{
		public string UserType { get; set; }
		public int ReadId { get; set; }

		[Required(ErrorMessage = "帳號必填")]
		public string RdAccount { get; set; }

		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }

		[Required(ErrorMessage = "姓名必填")]
		public string RdName { get; set; }
		[EmailAddress(ErrorMessage = "mail格式錯誤")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "手機必填")]
		[StringLength(10, ErrorMessage = "號碼長度不超過10")]
		public string Phone { get; set; }
	}
}
