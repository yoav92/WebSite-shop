using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class connexion : System.Web.UI.Page
{
    
    protected void BtnReg_Click(object sender, EventArgs e)
    {
        GlobalFunc.LoadUsers();
        var ArrUsers = Application["ArrU"] as List<Users>;
        string Error="";

        for (int i = 0; i < ArrUsers.Count; i++)
        {

            if (TxtMail.Text == ArrUsers[i].email && TxtPass.Text == ArrUsers[i].password)
            {
                Session["Login"] = ArrUsers[i].lname;
                Response.Redirect("showProducts.aspx");
            }
            else
            {
                Error= "<span style='color: red; '>Bad information,try again</span>";
                LtlProds.Text = Error;

            }

        }
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["message"] != null)
        {
            String message = Session["message"].ToString();
            Success.Text = message;
        }
    }
}