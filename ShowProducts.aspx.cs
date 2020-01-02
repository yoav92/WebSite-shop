using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] != null)
        {
            GlobalFunc.LoadProds();
            var ArrProd = Application["ArrP"] as List<Product>;
            RptProd.DataSource = ArrProd;
            RptProd.DataBind();
        }
        else
        {
            Response.Redirect("connexion.aspx");
        }
    }
}