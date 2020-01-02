<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageManage.master" AutoEventWireup="true" CodeFile="AddNewProduct.aspx.cs" Inherits="SysManage_AddNewProductaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="text-center">ENTER A NEW PRODUCT</h1>
    <br /><br /><br />
 
<form id="form1"  runat="server" >
  <div class="form-group">
     <asp:TextBox ID="TxtPname" class="form-control" runat="server" placeholder="Product name" /><br />
  </div>
  <div class="form-group">
     <asp:TextBox ID="TxtPrice" class="form-control" runat="server" placeholder="Price" /><br />
  </div>
    <div class="form-group">
     <asp:TextBox ID="TxtShortDesc" class="form-control" runat="server" placeholder="Short description"/><br />
  </div>
  <div class="form-group">
    <label for="exampleInputFile">File input</label>
    <asp:FileUpload ID="UploadPicName" runat="server" />
    <p class="help-block">Find picture in your computer.</p>
  </div>
  
  <div class="text-center"><asp:Button ID="BtnSave" runat="server" Text="Save product" class="btn btn-default" OnClick="BtnSave_Click" /></div>

</form>
    <asp:Literal ID="LtlMsg" runat="server" />
</asp:Content>

