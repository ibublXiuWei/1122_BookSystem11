using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels.Services
{
	public class BookService
	{
		public BookVM Get(int id)
		{
			string sql = "SELECT * FROM Book WHERE BookId=@BookId";
			var parameters = new SqlParameterBuider()
				.AddInt("BookId", id)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToBookVM(data.Rows[0]);
		}
		
		private BookVM ToBookVM(DataRow row)
		{
			return new BookVM
			{
				BookId = row.Field<int>("BookId"),
				BookName = row.Field<string>("BookName"),
				Categories_id = row.Field<int>("Categories_id"),
				Author_Id = row.Field<int>("Author_Id"),
			};
		}
		public void Create(BookVM model)
		{
			string sql = @"INSERT INTO Book
(BookName,Categories_id, Author_Id)
VALUES
(@BookName,@Categories_id, @Author_Id)";
			var parameters = new SqlParameterBuider()
				//.AddInt("BookId", model.BookId)
				.AddNvarchar("BookName", 100, model.BookName)
				.AddInt("Categories_id", model.Categories_id)
				.AddInt("Author_Id", model.Author_Id)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public void Update(BookVM model)
		{
			string sql = @"UPDATE Book
			SET BookName=@BookName, Categories_id=@Categories_id, Author_Id=@Author_Id,Mail=@Mail,Phone=@Phone
			WHERE BookId=@BookId";

			var parameters = new SqlParameterBuider()

				.AddNvarchar("BookName", 100, model.BookName)
				.AddInt("Categories_id", model.Categories_id)
				.AddInt("Author_Id", model.Author_Id)
				.AddInt("BookId", model.BookId)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
		internal void Delete(int id)
		{
			string sql = @"DELETE FROM Book WHERE BookId=@BookId";

			var parameters = new SqlParameterBuider()
				.AddInt("BookId", id)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
		//public BookVM Get(string account)
		//{
		//	string sql = "SELECT * FROM Book WHERE BookId=@BookId";
		//	var parameters = new SqlParameterBuider()
		//		.AddInt("BookId", id)
		//		.Buid();

		//	DataTable data = new SqlDbHelper("default").Select(sql, parameters);

		//	if (data.Rows.Count == 0)
		//	{
		//		return null;
		//	}

		//	// 將找到的一筆記錄由DataTable 轉換到 UserVM
		//	return ToBookVM(data.Rows[0]);
		//}
	}
}
