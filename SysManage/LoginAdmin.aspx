<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginAdmin.aspx.cs" Inherits="SysManage_LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="css/design2.css" runat="server" />
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">


</head>
<body >
    
     


    <div class = "container">
	<div class="wrapper">
		<form id="form1" runat="server">    
		    <h3 class="form-signin-heading">Welcome Back! Please Connect</h3>
			  <hr class="colorgraph"><br>
			  
			  <asp:TextBox type="text" class="form-control" name="Username" ID="TxtUser" runat="server" placeholder="Username" required="" autofocus="" />
			  <asp:TextBox type="password" class="form-control" name="Password" ID="TxtPass" runat="server" placeholder="Password" required=""/>     		  
			 
			  <asp:Button ID="BtnLogin" class="btn btn-lg btn-primary btn-block" runat="server" Text="Connexion" name="Submit" value="Login" type="Submit" OnClick="BtnLogin_Click"></asp:Button>  	
            <br /> <asp:Literal ID="LtlMsg" runat="server" />
		</form>			
	</div>
</div>

</body>
</html>
