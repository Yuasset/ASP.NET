<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ASPWebApplication.register" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" CancelSelectOnNullParameter="True" ValidateRequestMode="Inherit"></asp:SqlDataSource>
    <h1 style="color: white">KAYIT SAYFASI</h1>
    <div class="in_body">
        <table class="table_div">
            <tr>
                <td>
                    <asp:Label runat="server" Text="Kullanıcı"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="regUserID"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Şifre"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="regPassword"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="E-Mail"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="regEMail" TextMode="Email"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Ad</td>
                <td>
                    <asp:TextBox runat="server" ID="regName"/></td>
            </tr>
            <tr>
                <td>Soyad</td>
                <td>
                    <asp:TextBox runat="server" ID="regSurname"/></td>
            </tr>
            <tr>
                <td>Cinsiyet</td>
                <td>
                    <asp:RadioButtonList runat="server" ID="regSex" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem Value="0">Erkek</asp:ListItem>
                        <asp:ListItem Value="1">Kadın</asp:ListItem>
                        <asp:ListItem Value="2">Eşsiz</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Telefon</td>
                <td>
                    <asp:TextBox runat="server" ID="regPhone" TextMode="Phone"/></td>
            </tr>
            <tr>
                <td>
                    

                </td>
                <td>
                    <asp:Button runat="server" Text="Gönder" OnClick="Register_Button_Click" width="166px"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Sonuc" runat="server" Text="Sonuc"></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
