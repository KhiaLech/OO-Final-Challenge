using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Books
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int Borrower { get; set; }
        public int Author { get; set; }

        public Books(int bISBN, string bTitle, int bBorrower, int bAuthor)
        {
            ISBN = bISBN;
            Title = bTitle;
            Borrower = bBorrower;
            Author = bAuthor;

        }

        public Books()
        {

        }
    }
}