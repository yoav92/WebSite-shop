using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class SysManage_UploadFiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnUp_Click(object sender, EventArgs e)
    {
        //   FUMain.SaveAs(Server.MapPath("/pics/")+ FUMain.FileName);
        string newfname = GlobalFunc.GetRandomFileName(8);
        string FileExt = Path.GetExtension(FUMain.FileName);
        FUMain.SaveAs(Server.MapPath("/img/") + newfname + FileExt);
        ltlmsg.Text = "success";
    }
}