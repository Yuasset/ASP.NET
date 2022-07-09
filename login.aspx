<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ASPWebApplication.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="in_body">
    <h1 style="color: white">GİRİŞ SAYFASI</h1>
    <div>
        <table center="true">
            <tr>
                <td>
                    <asp:Label Text="Kullanıcı" runat="server" />
                </td>
                <td>
                    <asp:TextBox runat="server" ID="loginID" TextMode="SingleLine" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Şifre" runat="server" />
                </td>
                <td>
                    <asp:TextBox runat="server" ID="loginPW" TextMode="Password" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button runat="server" ID="loginButton" Text="Giriş" OnClick="loginButton_Click" Style="width: 120px; height: 20px" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
