<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="view_cart.aspx.cs" Inherits="WebApptest1.website.user.view_cart" %>

<asp:Content Id="content1" ContentPlaceHolderID="c1" runat="server">
    <div>
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td> <img src="<%#Eval("product_images") %>" height="100" width="100" /></td>
                    <td> <%#Eval("product_name") %></td>
                    <td> <%#Eval("product_desc") %></td>
                    <td> <%#Eval("product_price") %></td>
                    <td> <%#Eval("product_qty") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
    </div>
</asp:Content>