<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageManage.master" AutoEventWireup="true" CodeFile="UploadFiles.aspx.cs" Inherits="SysManage_UploadFiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FileUpload ID="FUMain" runat="server" />
    <asp:Literal ID="ltlmsg" runat="server" />
    <asp:Button ID="BtnUp" runat="server" Text="Save picture" OnClick="BtnUp_Click" />
</asp:Content>

