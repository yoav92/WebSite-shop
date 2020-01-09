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
        var Cart = Session["Cart"] as Cart;// recuperation du panier par session
        string Tmp = "";
        string Pic = "";
        int total = 0;
        if (Cart != null)
        {
            for (int i = 0; i < Cart.Size; i++)// si il y a un panier--->afficher les produits
            {
                Tmp +="<span class='co'>  " + Cart.ArrItem[i].Pname + "</span><br/>";
                Tmp += "<span class='co'>  Price: " + Cart.ArrItem[i].Price + "$ </span><br/>";
                if (Cart.ArrItem[i].Amount < 1)
                {
                    Cart.ArrItem[i].Amount = 1;
                    
                }
                Tmp += "<span class='co'> Amount: " +  Cart.ArrItem[i].Amount  + "</span><br />";
                Tmp += "<a class='btn btn-default btn-xs ' href='Add.aspx?Pid=" + Cart.ArrItem[i].Pid + "'><span class='glyphicon glyphicon-plus' aria-hidden='true'></span></a>";//le plus pour rajouter de l'amount
                Tmp += "<a class='btn btn-default btn-xs ' href='Remove.aspx?Pid=" + Cart.ArrItem[i].Pid + "'><span class='glyphicon glyphicon-minus' aria-hidden='true'></span></a><br /><br />";//le moins pour enlever de l'amount
                Tmp += "<img width='50' height='50' src='img/" + Cart.ArrItem[i].Picname + "'>" + "<br/>";
               
                total += Cart.ArrItem[i].Price * Cart.ArrItem[i].Amount;// calcul le prix total du panier
                Tmp += "<a class='btn btn-default btn-xs' href='RemoveTocart.aspx?Pid=" + Cart.ArrItem[i].Pid + "'><span class='glyphicon glyphicon-trash' aria-hidden='true'></span></a><br /><br />";//supprimer complement l'article
                
            }
            
           
            Tmp += "<br /><span class='co grand'>Total price: " + total + "$ </span>";// affichage total du prix du panier
            LtlProds.Text = Tmp;
        }
        else
        {
            Response.Redirect("ShowProducts.aspx");
        }
       
    }

}