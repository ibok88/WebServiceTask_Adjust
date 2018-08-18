<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientUI.aspx.cs" Inherits="OneToXClient.ClientUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <table style="font-family: Arial">
            <tr>
                <td colspan="2"> Return JSONArray </td>
            </tr>
            <tr>
                <td>Input Number:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;<asp:Button ID="BtnGet" runat="server" Text="Trigger" OnClick="BtnGet_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label></td>
            </tr>
        </table>
        
    </form>
</body>
</html>
