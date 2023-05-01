<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication1.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>welcome to admin panel
            </h1>

            <asp:DataGrid ID="DataGrid1" runat="server">
            </asp:DataGrid>
        </div>
        <div>
            <h3>Enter a Id you want to delete</h3>
            <table>

                <tr>
                    <td>
                        <asp:Label ID="LableNumber" runat="server" Text="Enter ID Number"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Numebr" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div>
             <h3>Enter a Id you want to Update</h3>
            <table>

                <tr>
                    <td>
                        <asp:Label ID="LabelNumber2" runat="server" Text="Enter ID Number"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="NumberEdit" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
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
                        <asp:TextBox ID="Conatct" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="LabelDepartment" runat="server" Text="Choose Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="Department" runat="server" SelectionMode="Multiple">

                        <asp:ListItem id="Marketing" Selected="False">Marketing</asp:ListItem>
                        <asp:ListItem id="Development" Selected="False">Development</asp:ListItem>
                        <asp:ListItem id="Bussiness" Selected="False" >Bussiness Analysis</asp:ListItem>
                        <asp:ListItem id="QA" Selected="False">QA</asp:ListItem>
                        <asp:ListItem id="HR" Selected="False">HR</asp:ListItem>

                    </asp:DropDownList>
                </td>
            </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelDesingnation" runat="server" Text="Designation"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Desingnation" runat="server"></asp:TextBox></td>
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
                        <asp:Button ID="Button2" runat="server" Text="Submit Id" CssClass="btn btn-primary" OnClick="Submit_Id" />
                    </td>
                    <td>

                        <asp:Button ID="Button3" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="Update_Id" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
