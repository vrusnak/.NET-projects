<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IDSearch.aspx.cs" Inherits="BookStoreWebApplication.IDSearch" %>

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
                        <b>Search the catalog for a book-id:</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtBoxID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                        <asp:Button ID="btnBack" runat="server" Text="Go back" OnClick="btnBack_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <b>Results:
                        </b>
                        <br />
                        <asp:Label ID="lblItemsCount" runat="server" Font-Italic="true" Font-Size="Medium"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblResults" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
