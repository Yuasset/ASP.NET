<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="ASPWebApplication.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="in_body">
    <h1 style="color: white;">ANASAYFA</h1>
    <div>
        <asp:Label runat="server" ID="lblBilgi"></asp:Label>







    </div>
</asp:Content>
