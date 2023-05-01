<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

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
                    <td>
                        <asp:Label ID="LabelMail" runat="server" Text="Email ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Email" runat="server" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="Pass" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td></td>
                    <td>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="Button1_Click" />
                    </td>
                </tr>
                  <tr>
                    <td></td>
                    <td>
                        <br />
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="linkRegister">Register</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
