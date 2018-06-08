<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApptest1.website.user.login" %>

<asp:Content Id="content1" ContentPlaceHolderID="c1" runat="server">

    <table>

        <tr>
            <td>Email </td>
            <td><asp:TextBox ID="emailBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password </td>
            <td><asp:TextBox ID="passwordBox" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>

    </table>

</asp:Content>