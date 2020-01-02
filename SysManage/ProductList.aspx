<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageManage.master" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="SysManage_ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="text-center"><a class="btn btn-default btn-lg" href="AddNewProduct.aspx">Add a new product</a></div>
    <br /><br /><br />
    <asp:repeater runat="server" id="RptProds">
        <headerTemplate>
            <div class="text-center container">
                <div class="row">
                         <div class="col-md-2 h3">Picture</div>
                         <div class="col-md-2 h3">Product name</div>
                         <div class="col-md-2 h3">Price</div>
                         <div class="col-md-2 h3">Description</div>
                            
                </div><br />
            
        </headerTemplate>
        <ItemTemplate>
          <div class="row">
                            <div class="col-md-2"><img src="../img/<%#Eval("Picname") %>" width="60" height="60" /></div>
                            <div class="col-md-2"><%#Eval("Pname") %></div>
                            <div class="col-md-2"><%#Eval("Price") %></div>
                            <div class="col-md-2"><%#Eval("Description") %></div>
                            <div class="col-md-2"> <a href='edit.aspx?Pid=<%#Eval("Pid") %>' class="btn btn-success btn-sm" role="button" aria-pressed="true" ><span class='glyphicon glyphicon-wrench' aria-hidden='true'></span> Edit</a></div>
                            <div class="col-md-2"> <a href='Remove_product.aspx?Pid=<%#Eval("Pid") %>' class="btn btn-danger btn-sm" role="button" aria-pressed="true" ><span class='glyphicon glyphicon-remove' aria-hidden='true'></span> Remove</a></div>
                            
           </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:repeater>
</asp:Content>

