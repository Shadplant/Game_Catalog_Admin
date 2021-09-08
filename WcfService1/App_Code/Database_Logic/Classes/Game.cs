using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Game
    {
        private int id;
        private string name;
        private string imageurl;
        private string description;
        private int publishingadmin;

        public Game() { }

        public Game(int id, string name, string imageurl, string description, int publishingadmin)
        {
            this.Id = id;
            this.Name = name;
            this.ImageUrl = imageurl;
            this.Description = description;
            this.PublishingAdmin = publishingadmin;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ImageUrl
        {
            get { return imageurl; }
            set { imageurl = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int PublishingAdmin
        {
            get { return publishingadmin; }
            set { publishingadmin = value; }
        }
    }
}