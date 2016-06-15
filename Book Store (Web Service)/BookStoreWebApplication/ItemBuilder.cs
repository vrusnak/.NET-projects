using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreWebApplication
{
    public class ItemBuilder
    {
        public static string BuildString(BookStoreService.Book[] list)
        {
            if (!list.Any())
                return  "<br/>No items found..";
            else
            {
                string res = "(Items found: " + list.Count() + ")<br/><br/>";

                foreach (var item in list)
                {
                    string book =
                        "Book ID: " + item.Id + "<br/>" +
                        "Author: " + item.Author + "<br/>" +
                        "Title: " + item.Title + "<br/>" +
                        "Genre: " + item.Genre + "<br/>" +
                        "Price: " + item.Price.ToString("0.00") + "<br/>" +
                        "Publish date: " + item.PublishDate.ToString("dd/MM/yyyy") + "<br/>" +
                        "Description: " + item.Description + "<br/>" +
                        "<br/><br/>";

                    res += book;
                }

                return res;
            }
        }
    }
}