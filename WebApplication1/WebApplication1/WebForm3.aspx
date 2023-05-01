<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
/*        body {
            background-color: bisque;
        }*/

        .input {
            padding: 5px 20px;
        }

        #button1 {
            text-decoration: none;
            border: 1px solid black;
            padding: 5px 10px;
            color: black;
            background-color: aquamarine;
            border-radius: 10%;
        }

        .list {
            padding: 5px;
        }

        #LinkButton1 {
            text-decoration: none;
            color:black;
            border:1px solid black;
            background-color: aqua;
            border-radius:10%;
            padding:5px;

        }
        .button1{
              text-decoration: none;
            border: 1px solid black;
            padding: 5px 10px;
            color: black;
            background-color: aquamarine;
            border-radius: 10%;
        }
    </style>
</head>
<body>
    <h1>Register</h1>
    <form id="form1" runat="server">
        <table>

            <tr>
                <td>
                    <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Name" runat="server" required="true" class="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelMail" runat="server" Text="Email ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Email" runat="server" TextMode="Email" class="input"></asp:TextBox></td>
            </tr>


            <tr>
                <td>
                    <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Age" runat="server" TextMode="Number" class="input"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelHobby" runat="server" Text="Choose Hobby"></asp:Label></td>
                <td>
                    <asp:CheckBox ID="Programming" runat="server" Text="Programming" />
                    <asp:CheckBox ID="Gaming" runat="server" Text="Gaming" />
                    <asp:CheckBox ID="Music" runat="server" Text="Music" />
                    <asp:CheckBox ID="Reading" runat="server" Text="Reading" />
                    <asp:CheckBox ID="Walking" runat="server" Text="Walking" />
                    <asp:CheckBox ID="Running" runat="server" Text="Running" />
                    <asp:CheckBox ID="Dancing" runat="server" Text="Dancing" />
                    <asp:CheckBox ID="Coding" runat="server" Text="Coding" />
                    <asp:CheckBox ID="Acting" runat="server" Text="Acting" />
                    <asp:CheckBox ID="Movies" runat="server" Text="Movies" />
                    <asp:CheckBox ID="Travelling" runat="server" Text="Travelling" />
                </td>
            </tr>
            <tr>

                <td>
                    <asp:Label ID="LableGender" runat="server" Text="Choose Gender"></asp:Label>
                </td>
                <td>

                    <table>
                        <tr>
                            <td>
                                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />

                            </td>
                        </tr>
                        <tr>
                            <td>

                                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />
                            </td>
                        </tr>
                        <tr>
                            <td>

                                <asp:RadioButton ID="RadioButton3" runat="server" Text="Other" GroupName="gender" />
                            </td>
                        </tr>
                    </table>
                </td>


            </tr>

            <tr>
                <td>
                    <asp:Label ID="LabelConatct" runat="server" Text="Contact"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Conatct" runat="server" TextMode="Number" class="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelDepartment" runat="server" Text="Choose Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="Department" runat="server" class="lis">
                        <asp:ListItem class="list">Marketing</asp:ListItem>
                        <asp:ListItem class="list">Development</asp:ListItem>
                        <asp:ListItem class="list">Bussiness Analysis</asp:ListItem>
                        <asp:ListItem class="list">QA</asp:ListItem>
                        <asp:ListItem class="list">HR</asp:ListItem>

                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelDesgination" runat="server" Text="Designation"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Desingnation" runat="server" class="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="Pass" runat="server" TextMode="Password" class="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Confirm Password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="Cpass" runat="server" TextMode="Password" class="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-primary" class="button1" OnClick="register_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
