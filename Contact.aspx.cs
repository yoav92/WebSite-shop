using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnContact_Click(object sender, EventArgs e)
    {
        string Msg = "";
        Msg += "complete name:" + TxtFullName.Text;
        Msg += "phone:" + TextPhone.Text;
        Msg += "Mail:" + TextEmail.Text;
        Msg += "Message:" + TextMessage.Text;
        GlobalFunc.SendEmail("yoav.cohen92@gmail.com", "yoav.cohen92@gmail.com", "MyShop", Msg);
        LtlMsg.Text = "Contact succes";
        TextEmail.Text = "";
        TxtFullName.Text = "";
        TextPhone.Text = "";
        TextMessage.Text = "";
        Response.Redirect("ShowProducts.aspx");


    }
    
}