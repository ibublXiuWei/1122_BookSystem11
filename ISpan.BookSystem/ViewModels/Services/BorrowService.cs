using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels.Services
{
	public class BorrowService
	{
		public RentBookVM Get(int id)
		{
			string sql = "SELECT * FROM RentBookList WHERE RentOrderId=@RentOrderId";
			var parameters = new SqlParameterBuider()
				.AddInt("RentOrderId", id)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToRentBookVM(data.Rows[0]);
		}
		
		private RentBookVM ToRentBookVM(DataRow row)
		{
			return new RentBookVM
			{
				
				RentOrderId = row.Field<int>("RentOrderId"),
				reader_Id = row.Field<int>("reader_Id"),
				book_id = row.Field<int>("book_id"),
				BorrowDateTime = row.Field<DateTime>("BorrowDateTime"),
				ReturnDateTime = row.Field<DateTime>("ReturnDateTime"),
				ReturnBook = row.Field<bool>("ReturnBook"),
			};
		}
		public void Create(RentBookVM model)
		{
			bool isExists = callnumberExists(model);
			if (isExists) throw new Exception("書本已被借出，請選擇其他本");
			string sql = @"INSERT INTO RentBookList
(reader_Id,book_id, ReturnBook)
VALUES
(@reader_Id,@book_id, @ReturnBook)";
			var parameters = new SqlParameterBuider()

				.AddInt("reader_Id", model.reader_Id)
				.AddInt("book_id", model.book_id)
				.AddBool("ReturnBook", model.ReturnBook)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public void Update(RentBookVM model)
		{
			

			string sql = @"UPDATE RentBookList
			SET reader_Id=@reader_Id, book_id=@book_id, ReturnBook=@ReturnBook
			WHERE RentOrderId=@RentOrderId";

			var parameters = new SqlParameterBuider()
				.AddInt("RentOrderId", model.RentOrderId)
				.AddInt("reader_Id", model.reader_Id)
				.AddInt("book_id", model.book_id)
				.AddBool("ReturnBook", model.ReturnBook)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool callnumberExists(RentBookVM model)
		{
			string sql = @"SELECT Count(*)as count FROM RentBookList WHERE book_id=@book_id AND ReturnBook=0";
			var parameters = new SqlParameterBuider()
				
				.AddInt("book_id", model.book_id)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 1;
		}
		internal void Delete(int id)
		{
			string sql = @"DELETE FROM RentBookList WHERE RentOrderId=@RentOrderId";

			var parameters = new SqlParameterBuider()
				.AddInt("RentOrderId", id)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
	}
}
