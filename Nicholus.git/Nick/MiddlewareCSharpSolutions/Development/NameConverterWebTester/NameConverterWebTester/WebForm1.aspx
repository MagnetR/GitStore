<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NameConverterWebTester.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Your Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnReverse" runat="server" OnClick="btnReverse_Click" Text="Reverse Name" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server" BorderStyle="Dotted" Font-Size="X-Large" Width="109px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
