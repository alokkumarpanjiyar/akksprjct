<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login_Page.aspx.vb" Inherits="Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LBL_USERNM" runat="server" Text="Username:  "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TXT_USERNM" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LBL_PASSWORD" runat="server" Text="Password:  "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TXT_PASSWORD" runat="server" type="password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Log In" />
    
    </div>
    </form>
</body>
</html>
