<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rams2.aspx.cs" Inherits="Rams.rams2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
