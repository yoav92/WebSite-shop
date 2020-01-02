using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Description résumée de Users
/// </summary>
public class Users
{
    private int Uid;
    public int uid
    {
        get { return Uid; }
        set { Uid = value; }
    }


    private string fname;
    public string Fname
    {
        get { return fname; }
        set { Fname = value; }
    }
    
    private string Lname;
    public string lname
    {
        get { return Lname; }
        set { Lname = value; }
    }
    private string Email;
    public string email
    {
        get { return Email; }
        set { Email = value; }
    }
    private string City;
    public string city
    {
        get { return City; }
        set { City = value; }
    }
    private int Telephone;
    public int telephone
    {
        get { return Telephone; }
        set { Telephone = value; }
    }
    private string Password;
    public string password
    {
        get { return Password; }
        set { Password = value; }
    }
    public Users()
        {
            Fname = "Israel";
            Email = "israel@Israeli.co.il";

        }
    public Users(int uid,string fname, string lname, string city, string email, int telephone,string password)
        {
            this.uid = uid;
            this.fname = fname;
            this.lname = lname;
            this.city = city;
            this.email = email;
            this.telephone = telephone;
            this.password = password;

        }

    public Users(string fname, string lname, string city, string email, int telephone)
        {
            this.fname = fname;
            this.lname = lname;
            this.city = city;
            this.email = email;
            this.telephone = telephone;
        }

    public string Print()
        {
            return " Last name :" + Fname + " First name: " + Lname + " Your email is " + Email;
        }
  

}