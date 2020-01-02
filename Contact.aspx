<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/css/bootstrap.min.css" integrity="sha384-Zug+QiDoJOrZ5t4lssLdxGhVrurbmBWopoEl+M6BdEfwnCJZtKxi1KgxUyJq13dy" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/js/bootstrap.min.js" integrity="sha384-a5N7Y/aK3qNeh15eJKGWxsqtnX/wWdSZSKp+81YjTmS15nvnvxKHuzaWwXHDli+4" crossorigin="anonymous"></script>
</head>
<body style="background-image:url(img/fond.jpg); >
    <form id="form1" runat="server">
    <div>
       <h1 class="text-center"> keep a link with us</h1>
         <div class="container">
            <div class="form-group">
                <asp:TextBox ID="TxtFullName" class="form-control" runat="server" Placeholder="Name"/><br />
            </div>
            <div class="form-group">
               
        <asp:TextBox ID="TextPhone" class="form-control" runat="server" Placeholder="Telephone" /><br />
            </div>
            <div class="form-group">
                
        <asp:TextBox ID="TextEmail" class="form-control" runat="server" Placeholder="Mail"/><br />
            </div>
            <div class="form-group">
              
        <asp:TextBox ID="TextMessage" class="form-control" runat="server" Placeholder="Subject"/><br />
            </div>
        <asp:Button ID="BtnContact" class="btn btn-success btn-lg btn-block" runat="server" Text="keep contact" OnClick="BtnContact_Click" /><br />
        </div>
        <asp:Literal ID="LtlMsg" runat="server" />
    </div> 
    </form>
</body>
</html>
