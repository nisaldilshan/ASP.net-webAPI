<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="WebApptest1.website.admin.adminlogin" %>

<!DOCTYPE html>
<html >
  <head>
    <meta charset="UTF-8">
    <title>Admin Login</title>
    
    
    
    
        <link rel="stylesheet" href="logincss/style.css">

    
    
    
    
  </head>

  <body>

    
<form id="f1" runat="server">
  <header>Login</header>
  <label>Username <span>*</span></label>
  <asp:TextBox ID="t1" runat="server"></asp:TextBox>
  <label>Password <span>*</span></label>
  <asp:TextBox ID="t2" runat="server"></asp:TextBox>
  <br />
    <asp:Button ID="b1" runat="server" Text="Login" OnClick="b1_Click" />
    <br />
    <asp:Label ID="l1" runat="server" Text =""></asp:Label>
    <br />
</form>
    
    
    
    
  </body>
</html>
