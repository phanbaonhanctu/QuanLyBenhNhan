using AspWebMvc.Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspWebMvc.Models
{
    public class AccountModel
    {
        private DataDBContext dbContext;

        public AccountModel()
        {
            dbContext = new DataDBContext();
        }

        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
            new SqlParameter("@UserName", userName),
            new SqlParameter("@Password", password)
            };

            var res = dbContext.Database.SqlQuery<bool>("EXEC sp_CheckLogin @UserName, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }

}