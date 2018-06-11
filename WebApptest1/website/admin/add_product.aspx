<%@ Page Language="C#" MasterPageFile="~/website/admin/admin.Master" AutoEventWireup="true" CodeBehind="add_product.aspx.cs" Inherits="WebApptest1.website.admin.add_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <h3> Add Product Page </h3>
    <table>
        <tr>
        <td>product name</td>
        <td><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>product description</td>
        <td><asp:TextBox ID="t2" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>product price</td>
        <td><asp:TextBox ID="t3" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>product quantity</td>
        <td><asp:TextBox ID="t4" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
        <td>-</td>
        </tr>

        <tr>
        <td colspan="2" align="center">
            <asp:Calendar ID="Calendar1" runat="server" Width="238px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </td>
        </tr>

        <tr>
        <td>-</td>
        </tr>

        <tr>
        <td>Date : </td>
        <td><asp:Label ID="dateLabel" runat="server" Text="Please Select a Date" ForeColor="Red"></asp:Label></td>
            
        </tr>

        <tr>
        <td>product image</td>
        <td><asp:FileUpload ID="f1" runat="server" /></td>
        </tr>

        

        <tr>
        <td colspan="2" align="center">
            <asp:Button ID="b1" runat="server" Text="upload" OnClick="b1_Click" />
        </td>
        </tr>
    </table>
</asp:Content>