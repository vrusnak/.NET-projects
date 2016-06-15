using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace AssignmentSigma
{
    /// <summary>
    /// Summary description for BookStoreWebService
    /// </summary>
    [WebService(Namespace = "http://sigmaassignment.org/webservices", Description = "Book Store Web Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookStoreWebService : System.Web.Services.WebService
    {
        XmlNodeList nodes;
        List<Book> bookList;
        Book book;

        public BookStoreWebService()
        {
            nodes = LoadXML().DocumentElement.SelectNodes("/catalog/book");
            bookList = new List<Book>();
        }

        [WebMethod(Description = "Returns a list of books containing the queried name of author.")]
        public List<Book> GetAuthor(string query)
        {
            foreach (XmlNode node in nodes)
            {
                string nodeTitleTag = node.SelectSingleNode("author").InnerText.ToLower();

                if (nodeTitleTag.Contains(query.ToLower()))
                    CreateBookItem(node);
            }

            return bookList;
        }

        [WebMethod(Description = "Returns a list of books containing the queried title.")]
        public List<Book> GetTitle(string query)
        {
            XmlNodeList nodes = LoadXML().DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodes)
            {
                string nodeTitleTag = node.SelectSingleNode("title").InnerText.ToLower();

                if (nodeTitleTag.Contains(query.ToLower()))
                    CreateBookItem(node);
            }

            return bookList;
        }

        [WebMethod(Description = "Returns a list of books containing the queried genre.")]
        public List<Book> GetGenre(string query)
        {
            XmlNodeList nodes = LoadXML().DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodes)
            {
                string nodeTitleTag = node.SelectSingleNode("genre").InnerText.ToLower();

                if (nodeTitleTag.Contains(query.ToLower()))
                    CreateBookItem(node);
            }

            return bookList;
        }

        [WebMethod(Description = "Returns a list of books containing the queried book-id.")]
        public List<Book> GetID(string query)
        {
            XmlNodeList nodes = LoadXML().DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodes)
            {
                string nodeAttributeValue = node.Attributes["id"].Value.ToLower();

                if (nodeAttributeValue.Contains(query.ToLower()))
                    CreateBookItem(node);
            }

            return bookList;
        }

        [WebMethod(Description = "Returns a list of all books in the catalog.")]
        public List<Book> GetAll()
        {
            XmlNodeList nodes = LoadXML().DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodes)
                CreateBookItem(node);

            return bookList;
        }

        public void CreateBookItem(XmlNode node)
        {
            book = new Book();

            book.Id = node.Attributes["id"].Value;
            book.Author = node.SelectSingleNode("author").InnerText;
            book.Title = node.SelectSingleNode("title").InnerText;
            book.Genre = node.SelectSingleNode("genre").InnerText;

            double priceValue = double.Parse(node.SelectSingleNode("price").InnerText.Replace(".", ","));
            book.Price = priceValue;

            DateTime dateValue = DateTime.Parse(node.SelectSingleNode("publish_date").InnerText);
            book.PublishDate = dateValue;

            book.Description = node.SelectSingleNode("description").InnerText;

            bookList.Add(book);
        }

        public XmlDocument LoadXML()
        {
            XmlDocument doc = new XmlDocument();
            string path = Server.MapPath("books.xml");

            doc.Load(path);

            return doc;
        }
    }
}
