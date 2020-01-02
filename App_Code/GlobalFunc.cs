using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for GlobalFunc
/// </summary>
public static class GlobalFunc
{
    public static void SendEmail(string FromEmail,string ToEmail,string Subject,string Body)
    {
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.Credentials = new NetworkCredential("yoav.cohen92@gmail.com", "friends92");
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
        HttpContext.Current.Application["ArrP"] = ArrProd;
    }
    public static void LoadUsers()
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

        while (Hz.Read() == true)
        {
            Coco = new Users((int)Hz["Uid"], (string)Hz["Ufname"], (string)Hz["Ulname"], (string)Hz["Ucity"], (string)Hz["Uemail"], (int)Hz["Utelephone"], (string)Hz["Upassword"]);
            ArrUsers.Add(Coco);
        }
        Conn2.Close();
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