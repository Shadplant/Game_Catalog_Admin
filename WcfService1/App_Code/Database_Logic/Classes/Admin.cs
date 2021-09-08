using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Admin
    {
        private int id;
        private string email;
        private string passhash;

        public Admin() { }

        public Admin(int id, string email, string passhash) 
        {
            this.Id = id;
            this.Email = email;
            this.Passhash = passhash;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Passhash
        {
            get { return passhash; }
            set { passhash = value; }
        }

    }
}