<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employeepage.aspx.cs" Inherits="WebApplication1.employeepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>welmcome to employee page</h1>
            <table>

                <tr>
                    <td>
                        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Name" runat="server" required="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelEmail" runat="server" Text="Email ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Email" runat="server" TextMode="Email"></asp:TextBox></td>
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Age" runat="server" TextMode="Number"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                  <td>
                        <asp:Label ID="LabelGender" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Gender" runat="server" ></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelConatct" runat="server" Text="Contact"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Conatct" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="LabelDepartment" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Department" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelDesingnation" runat="server" Text="Designation"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Desingnation" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                <td></td>
                <td>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-primary"  />
                </td>
            </tr>
            </table>
        </div>
    </form>
</body>
</html>
