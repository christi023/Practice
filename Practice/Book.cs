using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
