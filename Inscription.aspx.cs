using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Inscription : System.Web.UI.Page
{
    

    protected void BtnReg_Click(object sender, EventArgs e)
    {
     
        int telephone = int.Parse(TxtTel.Text);


        string ConnStr = "Provider=SQLOLEDB;Data Source=DESKTOP-SB7PUAD\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=SSPI";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים

        string Sql = "insert into Users(Ufname,Ulname,Ucity,Uemail,Uphone,Upassword) values ('";
        Sql += TxtFname.Text + "','" + TxtLname.Text + "','" + TxtCity.Text + "','" + TxtMail.Text + "','" + telephone + "','" + TxtPass.Text + "')";


        OleDbConnection Conn = new OleDbConnection(ConnStr); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        Conn.Open();// פתיחת החיבור לבסיס הנתונים
        OleDbCommand Cmd = new OleDbCommand();// יצירת אובייקט מסוג פקודה

        Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
        Cmd.CommandText = Sql;//הגדרת משפט הפקודה אותו יש לבצע
        Cmd.ExecuteNonQuery();
        Conn.Close();
       

        Session["Login"] = TxtFname.Text;
        Session["message"] = "registration completed! Please connect ";
        Response.Redirect("connexion.aspx");


    }
}