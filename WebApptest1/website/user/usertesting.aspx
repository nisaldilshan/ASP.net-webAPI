<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="usertesting.aspx.cs" Inherits="WebApptest1.website.user.usertesting" %>


<asp:Content Id="content1" ContentPlaceHolderID="c1" runat="server">
    <br />
    <asp:Button ID="b1" runat="server" Text="cookies store" OnClick="b1_Click" />
    <asp:Button ID="b2" runat="server" Text="cookies display" OnClick="b2_Click" />
    <asp:Button ID="b3" runat="server" Text="cookies update" OnClick="b3_Click" />
    <asp:Button ID="b4" runat="server" Text="cookies display using array" OnClick="b4_Click" />
</asp:Content>