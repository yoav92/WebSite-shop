using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowMyCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var Cart = Session["Cart"] as Cart;// שולפים את סל הקניות מתוך הסשן
        string Tmp = "";
        string Pic = "";
        int total = 0;
        if (Cart != null)
        {
            for (int i = 0; i < Cart.Size; i++)// במידה וקיים סל קניות, עוברים עליו ומייצרים את רשימת המוצרים בסל בפורמט HTML
            {
                Tmp +="<span class='co'>  " + Cart.ArrItem[i].Pname + "</span><br/>";
                Tmp += "<span class='co'>  Price: " + Cart.ArrItem[i].Price + "$ </span><br/>";
                if (Cart.ArrItem[i].Amount < 1)
                {
                    Cart.ArrItem[i].Amount = 1;
                    
                }
                Tmp += "<span class='co'> Amount: " +  Cart.ArrItem[i].Amount  + "</span><br />";
                Tmp += "<a class='btn btn-default btn-xs ' href='Add.aspx?Pid=" + Cart.ArrItem[i].Pid + "'><span class='glyphicon glyphicon-plus' aria-hidden='true'></span></a>";
                Tmp += "<a class='btn btn-default btn-xs ' href='Remove.aspx?Pid=" + Cart.ArrItem[i].Pid + "'><span class='glyphicon glyphicon-minus' aria-hidden='true'></span></a><br /><br />";
                Tmp += "<img width='50' height='50' src='img/" + Cart.ArrItem[i].Picname + "'>" + "<br/>";
               
                total += Cart.ArrItem[i].Price * Cart.ArrItem[i].Amount;// חישוב הערך הכולל של סל הקניות
                Tmp += "<a class='btn btn-default btn-xs' href='RemoveTocart.aspx?Pid=" + Cart.ArrItem[i].Pid + "'><span class='glyphicon glyphicon-trash' aria-hidden='true'></span></a><br /><br />";
                
            }
            
           
            Tmp += "<br /><span class='co grand'>Total price: " + total + "$ </span>";// הצגת תוכן  דף סל הקניות
            LtlProds.Text = Tmp;
        }
        else
        {
            Response.Redirect("ShowProducts.aspx");
        }
       
    }

}