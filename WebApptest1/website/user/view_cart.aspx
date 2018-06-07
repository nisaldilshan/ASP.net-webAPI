<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="view_cart.aspx.cs" Inherits="WebApptest1.website.user.view_cart" %>

<asp:Content Id="content1" ContentPlaceHolderID="c1" runat="server">
    <div>
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table border="2">
                    <tr style="background-color:silver; color:white; font-weight:bold">
                        <td> _-product image-_ </td>
                        <td> _-product name-_ </td>
                        <td> _-product description-_ </td>
                        <td> _-product price-_ </td>
                        <td> _-product quantity-_ </td>
                        <td> _-delete-_ </td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td> <img src="<%#Eval("product_images") %>" height="100" width="100" /></td>
                    <td> <%#Eval("product_name") %></td>
                    <td> <%#Eval("product_desc") %></td>
                    <td> <%#Eval("product_price") %></td>
                    <td> <%#Eval("product_qty") %></td>
                    <td>
                        <a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
        <br />
        <p align="center">
            <asp:Label ID="l1" runat="server"></asp:Label><br />
            <asp:Button ID="b1" runat="server" Text="Checkout" OnClick="b1_Click" />
        </p>
    </div>
</asp:Content>