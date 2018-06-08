<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApptest1.website.user.registration" %>

<asp:Content Id="content1" ContentPlaceHolderID="c1" runat="server">

    <table>

        <tr>
            <td>name</td>
            <td><asp:TextBox ID="nameBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>email</td>
            <td><asp:TextBox ID="emailBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>password</td>
            <td><asp:TextBox ID="passwordBox" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>pin</td>
            <td><asp:TextBox ID="pinBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>phone</td>
            <td><asp:TextBox ID="phoneBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>

    </table>

</asp:Content>
