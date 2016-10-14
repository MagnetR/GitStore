<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="HRWebApplication.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="HRStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div background-color: #33CCFF;>
        <asp:Button id= "btnHome" Text = "   Home   " style="background-color: #00FFFF" OnClick="btnHome_Click" runat="server"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnVision" Text= " Our Vision  " style="background-color: #00FFFF" OnClick="btnVision_Click" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnHistory" Text= "    Our History " style="background-color: #00FFFF" OnClick="btnHistory_Click" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnValues" Text= " Our Values  " style="background-color: #00FFFF" OnClick="btnValues_Click" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnContacts" Text= "   Contact Us  " style="background-color: #00FFFF" OnClick="btnContacts_Click" runat="server"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnRegister" Text= "   Registration    " style="background-color: #00FFFF" OnClick="btnRegister_Click" runat="server" />
    </div>

    <div>
        <h1>Our History</h1>
    </div>
    </form>
</body>
</html>
