using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
/// <summary>
/// Summary description for GlobalFunc
/// </summary>
public static class GlobalFunc
{
    public static void SendEmail(string FromEmail,string ToEmail,string Subject,string Body)
    {
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.Credentials = new NetworkCredential("yoav.cohen92@gmail.com", "Yoavcohen1992");
        smtpClient.EnableSsl = true;
        //smtpClient.Credentials = new System.Net.NetworkCredential("XXXX@gmail.com", "GMAIL PASSWORD");

        MailMessage Mail = new MailMessage();
        Mail.From = new MailAddress(FromEmail);
        Mail.To.Add(new MailAddress(ToEmail));
        Mail.Subject = Subject;
        Mail.Body = Body;
        Mail.IsBodyHtml = true;
        smtpClient.Send(Mail);
    }
    public static int GetMax(int num1,int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
    public static void LoadProds()
    {
        SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-SB7PUAD\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;");
        string sql1 = "Select * From Products";
        sqlCon2.Open();
        SqlDataAdapter sqlda2 = new SqlDataAdapter(sql1, sqlCon2);
        DataTable dtbl2 = new DataTable();
        sqlda2.Fill(dtbl2);



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


        foreach (DataRow row in dtbl2.Rows)
        {
            Temp = new Product((int)row["Id"], (string)row["Pname"], (string)row["Description"], (int)row["Price"], (string)row["Picname"]);
            ArrProd.Add(Temp);
        }


        //Conn.Close();
        
        HttpContext.Current.Application["ArrP"] = ArrProd;

    }
    public static void LoadUsers()
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-SB7PUAD\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;");
        string sql2 = "Select * From Users";
        sqlCon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter(sql2, sqlCon);
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

        foreach (DataRow row in dtbl.Rows)
        {
            Coco = new Users((int)row["Id"], (string)row["Ufname"], (string)row["Ulname"], (string)row["Ucity"], (string)row["Uemail"], (int)row["Uphone"], (string)row["Upassword"]);
            ArrUsers.Add(Coco);
        }

        HttpContext.Current.Application["ArrU"] = ArrUsers;






        
    }

    public static string GetRandomFileName(int Size)
    {
        string Ret = "";
        string St = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int i, num;
        Random rnd = new Random();
        for (i = 0; i < Size; i++)
        {
            num = rnd.Next(1, St.Length);// הגרלת מספר בין אחד לבין עשרים ושש
            Ret += St.Substring(num, 1);// שליפת התו מהמחרוזת במיקום של המספר שהוגרל
        }
        return Ret;
    }


}