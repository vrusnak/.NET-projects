﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentSigma
{
    public class Book
    {
        private string id, author, title, genre, description;
        private double price;
        private DateTime publishDate;

        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
    }
}