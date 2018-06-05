<%@ Page Language="C#" MasterPageFile="~/website/user/user.Master" AutoEventWireup="true" CodeBehind="display_item.aspx.cs" Inherits="WebApptest1.website.user.display_item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <ul>
                <li class="last">
                    <a href="#"><img src="<%#Eval("product_images") %>"" alt=""</a>
                    <div class="product-info">
                        <h3> <%#Eval("product_name") %> </h3>
                        <div class="product-desc">
                            <h4><%#Eval("product_qty") %> Available</h4>
                            <p><%#Eval("product_desc") %></p>
                            <strong class="price">$<%#Eval("product_price") %></strong>
                        </div>
                    </div>
                </li>
            </ul>
        </ItemTemplate>
        <FooterTemplate>
            </ul> 
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>