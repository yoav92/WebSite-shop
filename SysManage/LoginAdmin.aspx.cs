using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_LoginAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string Error = "";
        if (TxtPass.Text == "1" && TxtUser.Text == "1")
        {
            Session["Login"] = "ok";
            Response.Redirect("Default.aspx");

        }
        else
        {
            Error = "<span style='color: red; '>Name or password not correct,try again</span>";
            LtlMsg.Text = Error;

            
        }
    }
}