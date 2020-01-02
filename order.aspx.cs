using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var Cart = Session["Cart"] as Cart;// שולפים את סל הקניות מתוך הסשן
        string Tmp = "";
        string Pic = "";
        int total = 0;
        if (Cart != null)// בודקים האם קיים סל או שמדובר בסל קניות ריק
        {
            for (int i = 0; i < Cart.Size; i++)// במידה וקיים סל קניות, עוברים עליו ומייצרים את רשימת המוצרים בסל בפורמט HTML
            {
                Tmp += "<span class='co t'>" + Cart.ArrItem[i].Pname + "</span>";
                Tmp += "<span class='co t'> Price: " + Cart.ArrItem[i].Price + "$</span>";
                Tmp += "<span class='co t'> Amount: " + Cart.ArrItem[i].Amount + "<br /></span>";
                Tmp += "<img width='100' height='100' src='img/" + Cart.ArrItem[i].Picname + "'>" + "<br/>";
                total += Cart.ArrItem[i].Price * Cart.ArrItem[i].Amount;// חישוב הערך הכולל של סל הקניות
                
            }
            Tmp += "<br /><span class='co grand'>Total price: " + total + "$</span>";// הצגת תוכן  דף סל הקניות
            LtlProds.Text = Tmp;

        }


    }
    protected void Thank_Click(object sender, EventArgs e)
    {
        string Msg = "Thank you for your order";
     
        GlobalFunc.SendEmail("yoav.cohen92@gmail.com", "yoav.cohen92@gmail.com", "MyShop", Msg);
        Response.Redirect("OrderThanks.aspx");
        var Cart = Session["Cart"] as Cart;
        if (Cart != null)
        {
            Cart.EmptyCart();
            Session["Cart"] = Cart;
   
        }



    }
}