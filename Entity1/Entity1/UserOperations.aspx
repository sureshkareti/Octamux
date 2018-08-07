<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserOperations.aspx.cs" Inherits="Entity1.UserOperations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td align="right" colspan="2">Name:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" colspan="2">Mobile No:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="Button1_Click" />
                </td>
                <td colspan="2">
                    <asp:Button ID="btnUdate" runat="server" Text="Update" OnClick="btnUdate_Click"  />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
