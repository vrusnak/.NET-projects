using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreWebApplication
{
    public partial class AuthorSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BookStoreService.BookStoreWebServiceSoapClient client = new BookStoreService.BookStoreWebServiceSoapClient();

            lblItemsCount.Text = string.Empty;
            lblResults.Text = string.Empty;

            var result = client.GetAuthor(txtBoxAuthor.Text);

            lblResults.Text = ItemBuilder.BuildString(result);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookStore.aspx");
        }
    }
}