<%@ Page Title="" Language="C#" MasterPageFile="~/Constitution.master" AutoEventWireup="true" CodeFile="ShowProducts.aspx.cs" Inherits="Default2" %>

        
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" Runat="Server">
     <asp:Literal ID="LoginWelcome" runat="server" />
    
        
        
            
    <asp:Repeater ID="RptProd" runat="server">

    <ItemTemplate>
        <row>
           <div class="col-lg-4 text-center space">
               <img width="200" height="200" src="img/<%#Eval("PicName") %>" class="img-rounded" />
               <span class="des co"> <%#Eval("PName") %></span><br /><br />
                <span > <%#Eval("Description") %></span><br /><br />
               <span class="co"> <%#Eval("Price") %>$</span><br />
              
               
              

                <a href='AddTocart.aspx?Pid=<%#Eval("Pid") %>' class="btn btn-success " role="button" aria-pressed="true" ><span class='glyphicon glyphicon-shopping-cart' aria-hidden='true'></span> Add to Cart</a>
           </div>
        </row>
  </ItemTemplate>
        
    </asp:Repeater>
</asp:Content>

