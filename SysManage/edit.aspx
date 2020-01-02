<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageManage.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="SysManage_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="text-center"><a class='btn btn-default' href='ProductList.aspx'><span class='glyphicon glyphicon-arrow-left' aria-hidden='true'></span>Return to the products</a></div><br />
    <div class="text-center">
           <h1 class="text-center">EDIT PRODUCT</h1>
    <br /><br />
        <form id="form1" runat="server">
      <%--<div class="text-center"><asp:Literal ID="LtlProds" runat="server"></asp:Literal></div>
       <div class="text-center"><asp:Button ID="BtnReg" runat="server" Text="Edit" class="btn btn-success" OnClick="BtnEdit_Click" /></div><br />--%>
  <asp:repeater runat="server" id="RptProds">
        <headerTemplate>
            <div class="container">
                <div class="row">
                            <div class="col-md-2 h3">Picture</div>
                            <div class="col-md-2 h3">Picture name</div>
                            <div class="col-md-2 h3">Product name</div>
                            <div class="col-md-2 h3">Price</div>
                            <div class="col-md-2 h3">Description</div>
                            
                </div>
            
        </headerTemplate>
        <ItemTemplate>
          <div class="row">
              
                            <div class="col-md-2"><img src="../img/<%#Eval("Picname") %>" width="60" height="60" /></div>
                            <div class="col-md-2"><asp:textbox ID="namePic" name="name" text='<%#Eval("Picname") %>' runat="server"/></div>
                            <div class="col-md-2"><asp:textbox ID="name" name="name" text='<%#Eval("Pname") %>' runat="server"/></div>
                            <div class="col-md-2"><asp:textbox ID="price" name="price" text='<%#Eval("Price") %>' runat="server"/></div>
                            <div class="col-md-2"><asp:textbox ID="description" name="description" text='<%#Eval("Description") %>' width="200px" runat="server"/></div>
                            <div class="col-md-2"><asp:Button ID="BtnReg" runat="server" Text="Edit" class="btn btn-success" OnClick="BtnEdit_Click" /></div><br />
                    
                            
                            
           </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:repeater>
    </form>  
     </div>
</asp:Content>


      
     