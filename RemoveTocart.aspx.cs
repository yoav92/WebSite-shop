using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RemoveTocart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int Pid = int.Parse(Request["pid"]);
        var ArrProd = Application["ArrP"] as Product[];
        var Cart = Session["Cart"] as Cart;
        if  (Cart!= null)
        {
            Cart.RemoveFromCart(Pid);
            Session["Cart"] = Cart;
            Response.Redirect("ShowMyCart.aspx");
        }
        
        

    }
}