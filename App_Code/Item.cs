using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{
   
    private int pid;
    public int Pid
    {
        get{ return pid;}
        set{ pid = value;}
    }
    private string pname;
    public string Pname
    {
        get { return pname; }
        set { pname = value; }
    }
    private int amount;
    public int Amount
    {
        get { return amount; }
        set { amount = value; }
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

    public Item(int pid,string pname,int amount,int price, string picname)
    {
        Pid = pid;
        Pname = pname;
        Price = price;
        Amount = amount;
        Picname = picname;
    }

    public Item(int pid, string pname, string description, int price, string picname)
    {
        Pid = pid;
        Pname = pname;
        Description = description;
        Price = price;
        Picname = picname;
    }

    public Item( int amount)
    {       
        Amount = amount;
    }


}