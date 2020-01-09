<%@ Application Language="C#" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<%@ import Namespace="System.Data.SqlClient" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-SB7PUAD\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;");
        string sql2 = "Select * From Users";
        sqlCon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter(sql2,sqlCon);
        DataTable dtbl = new DataTable();
        sqlda.Fill(dtbl);




        //string ConnStr2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\users.accdb";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים
        //OleDbConnection Conn2 = new OleDbConnection(ConnStr2); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        //Conn2.Open();// פתיחת החיבור לבסיס הנתונים

        //OleDbCommand Cmd2 = new OleDbCommand();// יצירת אובייקט מסוג פקודה



        //Cmd2.Connection = Conn2;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו


        //Cmd2.CommandText = sql2;//הגדרת משפט הפקודה אותו יש לבצע


        //OleDbDataReader Hz = Cmd2.ExecuteReader();


        List<Users> ArrUsers = new List<Users>();

        Users Coco;

        foreach(DataRow row in dtbl.Rows)
        {
            Coco = new Users((int)row["Id"],(string)row["Ufname"],(string)row["Ulname"],(string)row["Ucity"],(string)row["Uemail"],(int)row["Uphone"],(string)row["Upassword"]);
            ArrUsers.Add(Coco);
        }

        Application["ArrU"]= ArrUsers;

        SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-SB7PUAD\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;");
        string sql1 = "Select * From Products";
        sqlCon2.Open();
        SqlDataAdapter sqlda2 = new SqlDataAdapter(sql1,sqlCon2);
        DataTable dtb2 = new DataTable();
        sqlda2.Fill(dtb2);



        //string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\users.accdb";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים
        //OleDbConnection Conn = new OleDbConnection(ConnStr); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        //Conn.Open();// פתיחת החיבור לבסיס הנתונים
        //OleDbCommand Cmd = new OleDbCommand();// יצירת אובייקט מסוג פקודה
        //string Sql = "Select * From Products";// הגדרת מחרוזת שמכילה שאילתא
        //Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
        //Cmd.CommandText = Sql;//הגדרת משפט הפקודה אותו יש לבצע
        //OleDbDataReader Dr = Cmd.ExecuteReader();
        List<Product> ArrProd = new List<Product>();// יצרנו רשימה מסוג מוצר, בשלב זה עדיין אין איברים ברשימה

        Product Temp;//= new Product();
        ////  List<int> Arr = new List<int>();
        //ArrProd.Add(Temp);                                         //  Arr.Add()


        foreach(DataRow row in dtb2.Rows)
        {
            Temp = new Product((int)row["Id"], (string)row["Pname"], (string)row["Description"],(int)row["Price"], (string)row["Picname"]);
            ArrProd.Add(Temp);
        }

        
        //Conn.Close();
        Application["ArrP"] = ArrProd;

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

</script>
