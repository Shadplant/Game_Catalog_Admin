using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class User
{
    private int id;
    private string username;
    private string email;
    private string passhash;
    private byte[] image;

    public User() { }

    public User(int id, string username, string email, string passhash, byte[] image)
    {
        this.Id = id;
        this.Username = username;
        this.Email = email;
        this.Passhash = passhash;
        this.Image = image;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Username
    {
        get { return username; }
        set { username = value; }
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

    public byte[] Image
    {
        get { return image; }
        set { image = value; }
    }

}