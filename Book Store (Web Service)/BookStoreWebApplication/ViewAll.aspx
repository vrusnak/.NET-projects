<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAll.aspx.cs" Inherits="BookStoreWebApplication.ViewAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family: Arial; font-size: 20px">
                <tr>
                    <td>
                        <asp:Button ID="btnBack" runat="server" Text="Go back" OnClick="btnBack_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <asp:Label ID="lblItemsCount" runat="server" Font-Italic="true" Font-Size="Medium"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <asp:Label ID="lblResults" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
