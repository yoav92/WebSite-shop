<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inscription.aspx.cs" Inherits="Inscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <title>Inscription</title>
</head>
<body style="background-image:url(img/fond5.jpg);">
    <nav class="navbar navbar-inverse">
    <div class="container-fluid">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="connexion.aspx">MyShop</a>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      
      
      <ul class="nav navbar-nav navbar-right">
        
        <asp:Literal ID="LtlPan" runat="server"></asp:Literal>
        <asp:Literal ID="LtlConn" runat="server"></asp:Literal>
        <li ><a href="connexion.aspx">Return to the home page <span class="sr-only">(current)</span></a></li>
        
      </ul>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav><br /><br />

    <form id="form1" runat="server">
        
        <h1 class="text-center">INSCRIPTION</h1>
            <br /><br />
        
            <div class="form-group">
                
                <asp:TextBox class="form-control" ID="TxtLname" runat="server" Placeholder="Last name"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  Text="*" ErrorMessage="enter your last name" ControlToValidate="TxtLname" />
            </div>
            <div class="form-group">
               
                <asp:TextBox class="form-control" ID="TxtFname" runat="server" Placeholder="First name"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  Text="*" ErrorMessage="enter your first name" ControlToValidate="TxtFname" />
            </div>
            <div class="form-group">
              
                <asp:TextBox class="form-control" ID="TxtAdress" runat="server" Placeholder="Adress"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  Text="*" ErrorMessage="enter your adress" ControlToValidate="TxtAdress" />
            </div>
            <div class="form-group">
               
                <asp:TextBox class="form-control" ID="TxtCity" runat="server" Placeholder="City"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  Text="*" ErrorMessage="enter your city" ControlToValidate="TxtCity" />
            </div>
            <div class="form-group">
                
                <asp:TextBox class="form-control" ID="TxtTel" runat="server" Placeholder="Telephone"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  Text="*" ErrorMessage="entrer your tel" ControlToValidate="TxtTel" />
            </div>
            <div class="form-group">
               
                <asp:TextBox class="form-control" ID="TxtMail" runat="server" Placeholder="Mail"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"  Text="*" ErrorMessage="enter a validate mail" ControlToValidate="TxtMail" ValidationExpression=".*@.*"/>
            </div>
            <div class="form-group">
                
                <asp:TextBox class="form-control" ID="TxtPass" runat="server" Placeholder="Password" TextMode="Password"/>
     	        <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server"  Text="*" ErrorMessage="Enter a password" ControlToValidate="TxtPass" />
                <asp:CompareValidator ID="RequiredFieldValidator7" runat="server"  Text="*" ErrorMessage="two passwords are not the same" ControlToValidate="TxtVerif" ControlToCompare="TxtPass"></asp:CompareValidator>
             </div>
            <div class="form-group">
           
                <asp:TextBox class="form-control" ID="TxtVerif" runat="server" Placeholder="Verification Password" TextMode="Password"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"  Text="*" ControlToValidate="TxtVerif" />
            </div>
               <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"  />
               <div class="text-center"><asp:Button ID="BtnReg" runat="server" Text="Inscription" class="btn btn-success" OnClick="BtnReg_Click" /></div><br />
               <asp:Literal ID="LtlMsg" runat="server" />
            </div>
    </form>
</body>
</html>
