﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Remove : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int Pid = int.Parse(Request["pid"]);

        // recupere le panier
        var Cart = Session["Cart"] as Cart;

        // localise le item grace a l'id
        for (int i = 0; i < Cart.Size; i++)
        {
            if (Cart.ArrItem[i].Pid == Pid)
            {

                Cart.ArrItem[i].Amount = Cart.ArrItem[i].Amount - 1 ;
                Session["Cart"] = Cart;
                Response.Redirect("ShowMyCart.aspx");
            }
        }

    }
}