using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class DatabaseConnectionSingleton
    {
        private static DatabaseConnectionSingleton instance;
        private static string connectionString;
        private DatabaseConnectionSingleton() { }

        public static DatabaseConnectionSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnectionSingleton();
                if (ConfigurationManager.ConnectionStrings != null)
                    connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            }
            return instance;
        }

        public string getConnectionString()
        {
            return connectionString;
        }
    }
}