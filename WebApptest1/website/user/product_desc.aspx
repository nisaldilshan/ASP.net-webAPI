<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="product_desc.aspx.cs" Inherits="WebApptest1.website.user.product_desc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>

            <div style="height:300px; width:600px; border-style:solid; border-width:1px;">
                <div style="height:300px; width:200px; float:left; border-style:solid; border-width:1px;">
                <img src="<%#Eval("product_images") %>" height="300" width="200" />
                </div>
                <div style="height:300px; width:395px; float:left; border-style:solid; border-width:1px;">
                item name = <%#Eval("product_name") %> <br />
                product desc = <%#Eval("product_desc") %><br />
                product price = <%#Eval("product_price") %><br />
                product qty = <%#Eval("product_qty") %><br />
                </div>
            </div>
            
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
    <br />

    <table border="2" cellpadding="10" cellspacing="15" style="font-size: 20px">
        <tr>
            <td colspan="3"><asp:Label ID="Label1" runat="server" ForeColor="Red" Text="01"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label2" runat="server" ForeColor="Red" Text="02"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label3" runat="server" ForeColor="Red" Text="03"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label4" runat="server" ForeColor="Red" Text="04"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3"><asp:Label ID="Label5" runat="server" ForeColor="Red" Text="05"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label6" runat="server" ForeColor="Red" Text="06"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label7" runat="server" ForeColor="Red" Text="07"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label8" runat="server" ForeColor="Red" Text="08"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3"><asp:Label ID="Label9" runat="server" ForeColor="Red" Text="09"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label10" runat="server" ForeColor="Red" Text="10"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label11" runat="server" ForeColor="Red" Text="11"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label12" runat="server" ForeColor="Red" Text="12"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3"><asp:Label ID="Label13" runat="server" ForeColor="Red" Text="13"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label14" runat="server" ForeColor="Red" Text="14"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label15" runat="server" ForeColor="Red" Text="15"></asp:Label></td>
            <td colspan="3"><asp:Label ID="Label16" runat="server" ForeColor="Red" Text="16"></asp:Label></td>
        </tr>
    </table>

    <table>
        <tr>
            <td>Enter Quantity</td>
            <td><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
            <td><asp:Button ID="b1" runat="server" Text="Add to cart" OnClick="B1_Click" /></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="l1" runat="server" ForeColor="Red" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    
</asp:Content>
