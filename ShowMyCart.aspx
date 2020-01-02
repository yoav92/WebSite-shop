<%@ Page Title="" Language="C#" MasterPageFile="~/Constitution.master" AutoEventWireup="true" CodeFile="ShowMyCart.aspx.cs" Inherits="ShowMyCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" Runat="Server">
    <a class='btn btn-default marge' href='ShowProducts.aspx'><span class='glyphicon glyphicon-arrow-left' aria-hidden='true'></span>Return to the products</a>
    <h1 class="co text-center">My Cart <span class='glyphicon glyphicon-shopping-cart' aria-hidden='true'></span></h1>

    <div class="text-center"><asp:Literal ID="LtlProds" runat="server"></asp:Literal></div>
    <a class='btn btn-danger btn-xs' href='reset.aspx'>Empty all your cart</a>
    <div class="text-center"><a href="order.aspx" class="btn btn-success btn-lg btn-block" role="button" aria-pressed="true">Proceed to checkout</a></div>
   
    
</asp:Content>

