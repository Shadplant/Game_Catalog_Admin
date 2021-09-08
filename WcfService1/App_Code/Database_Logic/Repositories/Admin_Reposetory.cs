using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Admin_Reposetory
    {
        public bool Check_Email(string Email)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                if (conn.Query("EXEC Check_Admin_Email \'"+Email+"\'").FirstOrDefault() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string Login_Admin(string Email, string Password)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return conn.Query<string>("EXEC Login_Admin \'"+Email+"\' ,\'"+Password+"\'").FirstOrDefault();
            }
        }
    }
}