<%@ Page Title="" Language="C#" MasterPageFile="~/Constitution.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" Runat="Server">
    <a class='btn btn-default marge' href='ShowMyCart.aspx'><span class='glyphicon glyphicon-arrow-left' aria-hidden='true'></span>Return to the cart</a>
    <h1 class="co text-center">My Order <span class='glyphicon glyphicon-lock' aria-hidden='true'></span></h1><br /><br />
    
    <asp:Literal ID="LtlProds" runat="server"></asp:Literal>
    
    <asp:Button ID="BtnContact" class="btn btn-success btn-lg btn-block" runat="server" Text="Finish the process" OnClick="Thank_Click" /><br />
    
</asp:Content>

