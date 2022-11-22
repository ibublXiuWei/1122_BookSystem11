using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.BookSystem.ViewModels.Services
{

	public class ReaderUserService
	{
		public void Create(ReaderUserVM model)
		{
			bool isExists = AccountExists(model.RdAccount);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"INSERT INTO ReaderUser
(RdAccount,Password, RdName,Mail,Phone)
VALUES
(@RdAccount,@Password, @RdName,@Mail,@Phone)";

			var parameters = new SqlParameterBuider()
				
				.AddNvarchar("RdAccount", 50, model.RdAccount)
				.AddNvarchar("Password", 50, model.Password)
				.AddNvarchar("RdName", 50, model.RdName)
				.AddNvarchar("Mail", 50, model.Mail)
				.AddNvarchar("Phone", 50, model.Phone)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public IEnumerable<UserIndexVM> GetAll()
		{
			string sql = @"select ReadId
      ,[RdAccount]
      ,[Password]
      ,[RdName]
      ,[Mail]
      ,[Phone] from ReaderUser ";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				;
			
		}
		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				//UserType = row.Field<string>("UserType"),
				ReadId = row.Field<int>("ReadId"),
				RdAccount = row.Field<string>("RdAccount"),
				RdName = row.Field<string>("RdName"),
				Mail = row.Field<string>("Mail"),
				Phone = row.Field<string>("Phone"),
			};
		}
		private bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM ReaderUser WHERE RdAccount=@RdAccount";

			var parameters = new SqlParameterBuider()
				.AddNvarchar("RdAccount", 50, account)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		//private ReaderUserVM GetAccountId(string account)
		//{
		//	string sql = @"SELECT ReadId as count FROM ReaderUser WHERE RdAccount=@RdAccount";

		//	var parameters = new SqlParameterBuider()
		//		.AddNvarchar("RdAccount", 50, account)
		//		.Buid();

		//	DataTable data = new SqlDbHelper("default").Select(sql, parameters);
		//	return data.Rows[0].Field<int>("ReadId") ;
		//}
		internal void Delete(int id)
		{
			string sql = @"DELETE FROM ReaderUser WHERE ReadId=@ReadId";

			var parameters = new SqlParameterBuider()
				.AddInt("ReadId", id)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
		public void Update(ReaderUserVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"UPDATE ReaderUser
			SET RdAccount=@RdAccount, Password=@Password, RdName=@RdName,Mail=@Mail,Phone=@Phone
			WHERE ReadId=@ReadId";

			var parameters = new SqlParameterBuider()
				
				.AddNvarchar("RdAccount", 50, model.RdAccount)
				.AddNvarchar("Password", 50, model.Password)
				.AddNvarchar("RdName", 50, model.RdName)
				.AddNvarchar("Mail", 50, model.Mail)
				.AddNvarchar("Phone", 50, model.Phone)
				.AddInt("ReadId", model.ReadId)
				.Buid();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
		private bool AccountExists(ReaderUserVM model)
		{
			string sql = @"SELECT Count(*) as count FROM ReaderUser WHERE RdAccount=@RdAccount AND ReadId!=@ReadId";

			var parameters = new SqlParameterBuider()
				.AddNvarchar("RdAccount", 50, model.RdAccount)
				.AddInt("ReadId", model.ReadId)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public ReaderUserVM Get(int id)
		{
			string sql = "SELECT * FROM ReaderUser WHERE ReadId=@ReadId";
			var parameters = new SqlParameterBuider()
				.AddInt("ReadId", id)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
				//MessageBox.Show("抱歉, 找不到要編輯的記錄");
				//this.DialogResult = DialogResult.Abort;

				//return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToUserVM(data.Rows[0]);
		}

		private ReaderUserVM ToUserVM(DataRow row)
		{
			return new ReaderUserVM
			{
				//UserType=row.Field<string>("UserType"),
				ReadId = row.Field<int>("ReadId"),
				RdAccount = row.Field<string>("RdAccount"),
				Password = row.Field<string>("Password"),
				RdName = row.Field<string>("RdName"),
				Mail = row.Field<string>("Mail"),
				Phone = row.Field<string>("Phone"),
			};
		}
		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.RdAccount);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}
		public ReaderUserVM Get(string account)
		{
			string sql = "SELECT * FROM ReaderUser WHERE RdAccount=@RdAccount";
			var parameters = new SqlParameterBuider()
				.AddNvarchar("RdAccount", 50, account)
				.Buid();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserVM(data.Rows[0]);
		}


	}
}
