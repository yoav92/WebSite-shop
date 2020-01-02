<%@ Page Language="C#" AutoEventWireup="true" CodeFile="connexion.aspx.cs" Inherits="connexion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="/css/design.css" runat="server" />
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous"/>

</head>
<body style="background-image:url(img/fond5.jpg);">
    <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      
        <a href='SysManage/LoginAdmin.aspx' type="button" class="btn btn-default navbar-btn">Administration</a>
      
    </div>
  </div>
</nav>

    <form id="form1" runat="server">
        <div class="main">
            <h1>WELCOME TO MYSHOP</h1><br />
            <div class="container">
                <div class="form-group">
                    <asp:TextBox class="form-control" ID="TxtMail" runat="server" Placeholder="Email"  />
               
                </div>
                <div class="form-group">
                    <asp:TextBox class="form-control" ID="TxtPass" runat="server" TextMode="Password" Placeholder="Password" />
     	        
               
                 </div>
        
                   <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"  />
                   <div ><asp:Button ID="BtnReg" runat="server" Text="Ok" class="btn btn-success" OnClick="BtnReg_Click" /></div><br />
                   <asp:Literal ID="LtlMsg" runat="server" />
                   <asp:Literal ID="LtlProds" runat="server"></asp:Literal>
                </div>
            <h2>Not a member yet?</h2>
            <a href='Inscription.aspx' class="btn btn-success">Register now !</a>
        </div>
    </form>
</body>
</html>
