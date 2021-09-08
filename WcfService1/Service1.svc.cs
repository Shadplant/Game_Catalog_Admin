using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void Add_Game(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID)
        {

        }

        public bool Check_Email(string Email)
        {
            using (SqlConnection conn = new SqlConnection(""))
            {
                if (conn.Query($"EXEC Check_Admin_Email '{Email}'").FirstOrDefault() != null)
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
            using (SqlConnection conn = new SqlConnection(""))
            {
                return conn.Query<string>($"EXEC Login_Admin '{Email}', '{Password}'").FirstOrDefault();
            }
        }
    }
}
