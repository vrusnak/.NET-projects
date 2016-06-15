<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookStore.aspx.cs" Inherits="BookStoreWebApplication.BookStore" %>

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
                        <p>Search for <a href="AuthorSearch.aspx"><b>author</b></a></p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Search for <a href="TitleSearch.aspx"><b>title</b></a></p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Search for <a href="GenreSearch.aspx"><b>genre</b></a></p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Search for <a href="IDSearch.aspx"><b>book-id</b></a></p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <p><a href="ViewAll.aspx"><i>View all books</i></a></p>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
