<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="HRWebApplication.Contacts" %>

<!DOCTYPE html>

<script>

    

    }

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style8 {
            margin-left: 40px;
        }
    </style>
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
            <br/>  
            <br/>
            <br/>
            <br/>                                                        
    </div>
    <div>
    
        <br />
    
        <table style="width: 100%; height: 286px;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Physical Address"></asp:Label>
                </td>
                <td class="auto-style2">1 Ameshoff Street</td>
                <td class="auto-style6">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Stakeholders"></asp:Label>
                </td>
                <td>Shane Bloomer</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">Braamfontein</td>
                <td class="auto-style6">&nbsp;</td>
                <td>Nazli Hsu</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">Johannesburg</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">South Africa</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">2001</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Web Site"></asp:Label>
                </td>
                <td class="auto-style2">www.liberty.co.za</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Email"></asp:Label>
                </td>
                <td class="auto-style2">Nicholus.Ramahuta@Liberty.co.za</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Cell"></asp:Label>
                </td>
                <td class="auto-style4">072&nbsp; 723 4452</td>
                <td class="auto-style7"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Tell"></asp:Label>
                </td>
                <td class="auto-style2">011 408 1887</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
