﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddtoCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        int Pid = int.Parse(Request["pid"]);//recupere l'id du produit

        
        var ArrProd = Application["ArrP"] as List<Product>;//recupere tous les produits

        
        for (int i=0;i<ArrProd.Count;i++)
        {
            if(ArrProd[i].Pid==Pid)
            {
                var Cart = Session["Cart"] as Cart;
                if(Cart==null)
                {
                    Cart = new Cart();
                }

                
                for (int j = 0; j < Cart.Size; j++)
                {
                    if (Cart.ArrItem[j].Pid == Pid)//si le produit rajoute existe deja dans le panier-->augmenter l'amount
                    {

                          Cart.ArrItem[j].Amount = Cart.ArrItem[j].Amount + 1;
                          Session["Cart"] = Cart;
                          Response.Redirect("ShowMyCart.aspx");
                    }
                }
                
                Item tmp = new Item(Pid,ArrProd[i].Pname,1, ArrProd[i].Price,ArrProd[i].Picname);//si produit n'existe pas dans le panier,creation article grace a la classe produit
                Cart.AddtoCart(tmp);
                Session["Cart"] = Cart;
                Response.Redirect("ShowMyCart.aspx");
            }
        }
    }
}