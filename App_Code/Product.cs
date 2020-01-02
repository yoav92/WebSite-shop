using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    private int pid;
    public int Pid
    {
        get { return pid; }
        set { pid = value; }
    }
    private string pname;
    public string Pname
    {
        get { return pname; }
        set { pname = value; }
    }

    private string description;
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    private int price;
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
    private string picname;
    public string Picname
    {
        get { return picname; }
        set { picname = value; }
    }
    public Product(int Pid,string Pname,string Description,int Price,string Picname)
    {
        this.Pid = Pid;
        this.Pname = Pname;
        this.Description = Description;
        this.Price = Price;
        this.Picname = Picname;
       
    }
    public Product(int Pid, string Pname, string Description, int Price)
    {
        this.Pid = Pid;
        this.Pname = Pname;
        this.Description = Description;
        this.Price = Price;
        

    }
}