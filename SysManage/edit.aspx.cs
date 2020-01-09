using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class SysManage_edit : System.Web.UI.Page
{
    public object UploadPicName { get; private set; }
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int Nid = int.Parse(Request["pid"]);
            GlobalFunc.LoadProds();

            var ArrProd = Application["ArrP"] as List<Product>;

            for (int i = 0; i < ArrProd.Count; i++)
            {
                if (ArrProd[i].Pid == Nid)
                {

                    string ConnStr = "Provider=SQLOLEDB;Data Source=DESKTOP-SB7PUAD\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=SSPI";

                    string Sql = "SELECT * FROM Products where Id=" + Nid + "";


                    OleDbConnection Conn = new OleDbConnection(ConnStr); // creation d'objet de type 'connection'-lien avec base de donnee
                    Conn.Open();// ouverture du lien avec base de donnee
                    OleDbCommand Cmd = new OleDbCommand();// creation d'objet de type 'commande'

                    Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
                    Cmd.CommandText = Sql;//initialisation de la commande sql
                  

                    OleDbDataReader Dr = Cmd.ExecuteReader();
                    List<Product> ArrProd2 = new List<Product>();// יצרנו רשימה מסוג מוצר, בשלב זה עדיין אין איברים ברשימה

                    Product Temp2;//= new Product();
                                 ////  List<int> Arr = new List<int>();
                                 //ArrProd.Add(Temp);                                         //  Arr.Add()

                    while (Dr.Read() == true)
                    {

                        // ArrProd זו רשימה מקושרת של מוצרים
                        // ArrProd.Add הוספת מוצר לרשימה המקושרת של מוצרים
                        Temp2 = new Product((int)Dr["Id"], (string)Dr["Pname"], (string)Dr["Description"], (int)Dr["Price"], (string)Dr["Picname"]);
                        ArrProd2.Add(Temp2);


                    }
                    
                    RptProds.DataSource = ArrProd2;
                    RptProds.DataBind();
                    Conn.Close();



                    //Item C_Product = new Item(Nid, ArrProd[i].Pname, ArrProd[i].Description, ArrProd[i].Price, ArrProd[i].Picname);

                    //string Tmp = "";


                    //Tmp += "<form method='post'><div class='text-center'>Name :<input type = 'text'  id = 'name' name='name' dirname=" + C_Product.Pname + "  /></div><br/><br/>";



                    //Tmp += "<div class='text-center'>Price :<input type = 'text'  id = 'price' name='price' value=" + C_Product.Price + "  /></div><br/><br/>";

                    //Tmp += "<div class='text-center'>Description :<input type = 'text'  id = 'description' name='description' value=" + C_Product.Description + "  /></div><br/><br/>";

                    //Tmp += "<div class='text-center'>Picture :<input type = 'text'  id = 'picname' name='picname' value=" + C_Product.Picname + "  /></div><br/><br/></form";



                    //LtlProds.Text = Tmp;

                }
            }
        }
       
    }
    
    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        int Nid = int.Parse(Request["pid"]);
        //GlobalFunc.LoadProds();
        //var ArrProd = Application["ArrP"] as List<Product>;

        //for (int i = 0; i < ArrProd.Count; i++)
        //{
        //    if (ArrProd[i].Pid == Nid)
        //    {

        //string name = Request.Form["name"];
        //string price = Request.Form["price"];
        //string desc = Request.Form["description"];

        string ConnStr = "Provider=SQLOLEDB;Data Source=DESKTOP-SB7PUAD\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=SSPI";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונ

        foreach (RepeaterItem item in RptProds.Items)
        {
            TextBox Name = item.FindControl("name") as TextBox;
            TextBox Price = item.FindControl("price") as TextBox;
            TextBox Desc = item.FindControl("description") as TextBox;
            TextBox Np = item.FindControl("namePic") as TextBox;
            string Nom = Name.Text;
            string Prix = Price.Text;
            string Descr = Desc.Text;
            string Pic = Np.Text;



            if (!string.IsNullOrEmpty(Nom))
            {
                

                string Sql2 = "insert into Products(Pname,Description,Price,Picname) values ('";
                Sql2 += Nom + "','" + Descr + "','" + Prix + "','" + Pic + "')";


                OleDbConnection Conn2 = new OleDbConnection(ConnStr); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
                Conn2.Open();// פתיחת החיבור לבסיס הנתונים
                OleDbCommand Cmd2 = new OleDbCommand();// יצירת אובייקט מסוג פקודה

                Cmd2.Connection = Conn2;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
                Cmd2.CommandText = Sql2;//הגדרת משפט הפקודה אותו יש לבצע
                Cmd2.ExecuteNonQuery();
                Conn2.Close();

            }
        }

        
                  

                    //string Sql2 = "UPDATE Products SET Pname=? ,Description=? ,Price=? WHERE Pid=?";
                    //string Sql2 = "UPDATE [Products] " + "SET [Pname] = @Pname, [Description]= @Description, [Price] =@Price  " + "WHERE [Pid]=@Pid";



                    string Sql = "DELETE FROM Products where Id=" + Nid + "";


                    OleDbConnection Conn = new OleDbConnection(ConnStr); // creation d'objet de type 'connection'-lien avec base de donnee
                    Conn.Open();// ouverture du lien avec base de donnee
                    OleDbCommand Cmd = new OleDbCommand();// creation d'objet de type 'commande'

                    Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
                    Cmd.CommandText = Sql;//initialisation de la commande sql
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                    GlobalFunc.LoadProds();
                    Response.Redirect("ProductList.aspx");

        //    }
        //}
                
     
   }
}