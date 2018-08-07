<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rams.aspx.cs" Inherits="Rams.Rams" %>

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
                <td>Id</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td><asp:RequiredFieldValidator runat="server" ID="rfvvalidator" ControlToValidate="TextBox1" ErrorMessage="Don't leave " Display="Dynamic" /><br />
                
                    <br />
                    <asp:RegularExpressionValidator ID="rev" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Enter Numbers only"
                         ValidationExpression="^[0-9]{4}$" EnableClientScript="false"/></td>
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
