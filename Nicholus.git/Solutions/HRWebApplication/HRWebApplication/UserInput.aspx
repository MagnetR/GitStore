<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInput.aspx.cs" Inherits="HRWebApplication.UserInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 253px;
        }
        .auto-style2 {
            width: 267px;
        }
        .auto-style3 {
            width: 307px;
        }
    </style>
    <link href="HRStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 628px; margin-bottom: 4px;" >
    <form id="form1" runat="server">
        <div background-color: #33CCFF;>
        <asp:Button id= "btnHome" Text = "   Home   " style="background-color: #00FFFF" OnClick="btnHome_Click" runat="server"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnVision" Text= " Our Vision  " style="background-color: #00FFFF" OnClick="btnVision_Click" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnHistory" Text= "    Our History " style="background-color: #00FFFF" OnClick="btnHistory_Click" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnValues" Text= " Our Values  " style="background-color: #00FFFF" OnClick="btnValues_Click" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnContacts" Text= "   Contact Us  " style="background-color: #00FFFF" OnClick="btnContacts_Click" runat="server"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button id= "btnRegister" Text= "   Registration    " style="background-color: #00FFFF" OnClick="btnRegister_Click" runat="server" />
    </div>
    <h1>Please Enter User's Information Below:</h1>
    <div aria-autocomplete="inline" aria-expanded="true" aria-haspopup="True" spellcheck="True" style="height: 330px; background-color: #33CCFF; background-image: inherit; background-attachment: scroll; z-index: auto; margin-top: 0px; font-family: Verdana;">
    
        <br />
        <asp:Label ID="LblUserInfor" runat="server" BorderColor="#CCCCFF" BorderStyle="None" Font-Bold="True" ForeColor="#000066" Text="User Information"></asp:Label>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
        <asp:TextBox ID="txtFirstName" runat="server" TabIndex="1" Width="238px"></asp:TextBox>
                </td>
                <td class="auto-style3">
        <asp:Label ID="Label5" runat="server" Text="Nationality:"></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:TextBox ID="txtNational" runat="server" TabIndex="5" style="margin-top: 8px" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
        <asp:Label ID="Label2" runat="server" Text="Second Name:"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
        <asp:TextBox ID="txtSecondName" runat="server" TabIndex="2" Width="238px"></asp:TextBox>
                </td>
                <td class="auto-style3">
        <asp:Label ID="Label6" runat="server" Text="ID Number:"></asp:Label>
                </td>
                <td class="auto-style3">
        <asp:TextBox ID="txtIDNumber" runat="server" TabIndex="6" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
        <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2" style="margin-left: 40px">
        <asp:TextBox ID="txtLastName" runat="server" TabIndex="3" Width="238px"></asp:TextBox>
                </td>
                <td class="auto-style3" style="margin-left: 40px">
        <asp:Label ID="Label7" runat="server" Text="Phone Number:"></asp:Label>
                </td>
                <td class="auto-style3" style="margin-left: 40px">
        <asp:TextBox ID="txtPhoneNumber" runat="server" TabIndex="7" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
        <asp:Label ID="Label4" runat="server" Text="Gender:"></asp:Label>
                </td>
                <td class="auto-style2" style="margin-left: 40px">
        <asp:DropDownList ID="DropDownList1" runat="server" TabIndex="4" Height="18px" Width="238px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td class="auto-style3" style="margin-left: 40px">
        <asp:Label ID="Label8" runat="server" Text="Email Address:"></asp:Label>
                </td>
                <td class="auto-style3" style="margin-left: 40px">
        <asp:TextBox ID="txtEmail" runat="server" TabIndex="8" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                </td>
                <td class="auto-style2" style="margin-left: 40px">&nbsp;</td>
                <td class="auto-style3" style="margin-left: 40px">
        <asp:Label ID="Label9" runat="server" Text="Residential Address:"></asp:Label>
                </td>
                <td class="auto-style3" style="margin-left: 40px">
        <asp:TextBox ID="txtResAddress" runat="server" BorderStyle="Inset" TabIndex="9" TextMode="MultiLine" Height="53px" Width="238px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <p>
        </p>  
    </div>
    </form>
</body>
</html>
