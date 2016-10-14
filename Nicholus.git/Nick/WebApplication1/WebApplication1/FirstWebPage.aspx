<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstWebPage.aspx.cs" Inherits="WebApplication1.FirstWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Liberty</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Liberty Holding (Pty) Ltd</h1> 
        <br />
        <br />
        Enter Your Name:<br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnName" runat="server" Text="Display Name" />
        <br />
        <br />
        <asp:Label ForeColor="DarkBlue" ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
