<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="check_order_details.aspx.cs" Inherits="WebApptest1.website.user.check_order_details" %>

<asp:Content Id="content1" ContentPlaceHolderID="c1" runat="server">
    <table>
        <tr>
            <td>Name : </td>
            <td><asp:Label ID="nameLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Email : </td>
            <td><asp:Label ID="emailLabel" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Phone : </td>
            <td><asp:Label ID="phoneLabel" runat="server" Text=""></asp:Label></td>
        </tr>

        <tr>
            <td colspan="2" align="center"><asp:Button ID="b1" runat="server" Text="Continue" OnClick="b1_Click" /></td>
        </tr>
    </table>
</asp:Content>