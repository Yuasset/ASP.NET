<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="ASPWebApplication.update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="in_body">
    <h1 style="color: white">DÜZENLEME SAYFASI</h1>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="ID"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="ID" TextMode="Number"></asp:TextBox>
                    <asp:Button runat="server" ID="SelectButton" Text="Getir" OnClick="SelectButton_Click" Enabled="true" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Kullanıcı"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="UserID" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Şifre"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Password" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="E-Mail"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="EMail" TextMode="Email" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Ad"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Name" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Soyad"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="Surname" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cinsiyet</td>
                <td>
                    <asp:RadioButtonList runat="server" ID="regSex" RepeatDirection="Horizontal" Enabled="false" ValidateRequestMode="Enabled" RepeatLayout="Flow">
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
                    <asp:TextBox runat="server" ID="Phone" TextMode="Phone" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="İşlem" /></td>
                <td>
                    <asp:DropDownList runat="server" ID="ProcessSelect" OnSelectedIndexChanged="Process_SelectedIndexChanged" AutoPostBack="True" Enabled="false">
                        <asp:ListItem Text="" Value="" Selected="True" />
                        <asp:ListItem Text="Güncelle" Value="Update" />
                        <asp:ListItem Text="Kaldır" Value="Delete" />
                    </asp:DropDownList>
                    <asp:Button runat="server" ID="ProcessButton" Text="İşlem" OnClick="ProcessButton_Click" Enabled="false" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="Sonuc" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>


</asp:Content>
