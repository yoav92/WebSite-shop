using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Constitution : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Verif = "";
        string Vide = "";
        var Cart = Session["Cart"] as Cart;

        if (Session["Login"] == null)
        {
            Verif += "<li><a href='connexion.aspx'>Connexion</a></li>";
            Verif += "<li><a href='Inscription.aspx'>Inscription</a></li>";
            LtlConn.Text = Verif;
        }
        else
        {
            Verif += "<li><a href='deconnexion.aspx'>Deconnexion</a></li>";
            LtlConn.Text = Verif;
        }
        
        if (Cart != null)
        {
            
            Vide += "<li><a href='ShowMyCart.aspx'><span class='glyphicon glyphicon-shopping-cart' aria-hidden='true'></span></a></li>";
            LtlPan.Text = Vide;
        }
        else
        {
            Vide += "<li><a href='#'>empty cart</a></li>";
            LtlPan.Text = Vide;
        }
    }
}
