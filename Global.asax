<%@ Application Language="C#" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {


        string ConnStr2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\users.accdb";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים
        OleDbConnection Conn2 = new OleDbConnection(ConnStr2); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        Conn2.Open();// פתיחת החיבור לבסיס הנתונים

        OleDbCommand Cmd2 = new OleDbCommand();// יצירת אובייקט מסוג פקודה

        string sql2 = "Select * From Users";

        Cmd2.Connection = Conn2;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו


        Cmd2.CommandText = sql2;//הגדרת משפט הפקודה אותו יש לבצע


        OleDbDataReader Hz = Cmd2.ExecuteReader();


        List<Users> ArrUsers = new List<Users>();

        Users Coco;

        while (Hz.Read()==true)
        {
            Coco = new Users((int)Hz["Uid"],(string)Hz["Ufname"],(string)Hz["Ulname"],(string)Hz["Ucity"],(string)Hz["Uemail"],(int)Hz["Utelephone"],(string)Hz["Upassword"]);
            ArrUsers.Add(Coco);
        }
        Conn2.Close();
        Application["ArrU"]= ArrUsers;

        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\users.accdb";// הגדרת מחרוזת שתחזיק את מחרוזת ההתחברות לבסיס הנתונים
        OleDbConnection Conn = new OleDbConnection(ConnStr); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        Conn.Open();// פתיחת החיבור לבסיס הנתונים
        OleDbCommand Cmd = new OleDbCommand();// יצירת אובייקט מסוג פקודה
        string Sql = "Select * From Products";// הגדרת מחרוזת שמכילה שאילתא
        Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
        Cmd.CommandText = Sql;//הגדרת משפט הפקודה אותו יש לבצע
        OleDbDataReader Dr = Cmd.ExecuteReader();
        List<Product> ArrProd = new List<Product>();// יצרנו רשימה מסוג מוצר, בשלב זה עדיין אין איברים ברשימה

        Product Temp;//= new Product();
        ////  List<int> Arr = new List<int>();
        //ArrProd.Add(Temp);                                         //  Arr.Add()

        while (Dr.Read() == true)
        {

            // ArrProd זו רשימה מקושרת של מוצרים
            // ArrProd.Add הוספת מוצר לרשימה המקושרת של מוצרים
            Temp = new Product((int)Dr["Pid"], (string)Dr["Pname"], (string)Dr["Description"],(int)Dr["Price"], (string)Dr["Picname"]);
            ArrProd.Add(Temp);


        }
        Conn.Close();
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
