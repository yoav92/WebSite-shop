using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_Remove_product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int Nid = int.Parse(Request["pid"]);

        var ArrProd = Application["ArrP"] as List<Product>;

        for (int i = 0; i < ArrProd.Count; i++)
        {
            if (ArrProd[i].Pid == Nid)
            {
                string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\users.accdb";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים
               

                string Sql = "DELETE FROM Products where Pid=" +Nid +"";


                OleDbConnection Conn = new OleDbConnection(ConnStr); // creation d'objet de type 'connection'-lien avec base de donnee
                Conn.Open();// ouverture du lien avec base de donnee
                OleDbCommand Cmd = new OleDbCommand();// creation d'objet de type 'commande'

                Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
                Cmd.CommandText = Sql;//initialisation de la commande sql
                Cmd.ExecuteNonQuery();
                Conn.Close();
                GlobalFunc.LoadProds();
                Response.Redirect("ProductList.aspx");




            }
        }
    }
}