<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="lists.aspx.cs" Inherits="ASPWebApplication.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="in_body">
    <h1 style="color: white">LİSTELEME SAYFASI</h1>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="ID"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="ID"></asp:TextBox><asp:Button runat="server" ID="ProcessButton" Text="Listele" OnClick="ListsButton_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Kullanıcı"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="UserID" ReadOnly="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Şifre"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Password" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="E-Mail"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="EMail" ReadOnly="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Ad"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Name" ReadOnly="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Soyad"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Surname" ReadOnly="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Cinsiyet"></asp:Label></td>
                <td>
                    <asp:RadioButtonList runat="server" ID="regSex" RepeatDirection="Horizontal" RepeatLayout="Flow" onclick="return false;">
                        <asp:ListItem Value="0">Erkek</asp:ListItem>
                        <asp:ListItem Value="1">Kadın</asp:ListItem>
                        <asp:ListItem Value="2">Eşsiz</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Telefon"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Phone" ReadOnly="true" TextMode="Phone"></asp:TextBox></td>
            </tr>
        </table>
    </div>

</asp:Content>
