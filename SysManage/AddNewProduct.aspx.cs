using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_AddNewProductaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {

        string ConnStr = "Provider=SQLOLEDB;Data Source=DESKTOP-SB7PUAD\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=SSPI";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים
        string FileName = GlobalFunc.GetRandomFileName(6);
        string t1 = UploadPicName.FileName;
        string FullPath = Server.MapPath("/img/");
        string FileExt = System.IO.Path.GetExtension(UploadPicName.PostedFile.FileName);
        FileName += FileExt;// הוספת הסימן נקודה והסימת של קובץ התמונה שהועלתה
        FullPath += FileName;// הוספה לנתיב התיקייה של התמונות את שם התמונה החדשה
        UploadPicName.SaveAs(FullPath);// שמירה של הקובץ
        LtlMsg.Text = FullPath;

        string Sql = "insert into Products(Pname,Price,Description,PicName) values ('";
        Sql += TxtPname.Text + "','" + TxtPrice.Text + "','" + TxtShortDesc.Text + "','" + FileName + "')";


        OleDbConnection Conn = new OleDbConnection(ConnStr); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        Conn.Open();// פתיחת החיבור לבסיס הנתונים
        OleDbCommand Cmd = new OleDbCommand();// יצירת אובייקט מסוג פקודה

        Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
        Cmd.CommandText = Sql;//הגדרת משפט הפקודה אותו יש לבצע
        Cmd.ExecuteNonQuery();
        Conn.Close();
        GlobalFunc.LoadProds();

        Response.Redirect("ProductList.aspx");


        
    }
}