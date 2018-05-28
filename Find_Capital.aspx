<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Find_Capital.aspx.vb" Inherits="Find_Capital" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter State Name : <asp:TextBox ID="TXT_STATENM" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <br />
        <br />
        Capital Is:  <asp:Label ID="LBL_CAPITALNM" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
