using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class BorrowedBooks
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
    
        public Borrower borrower { get; set; }
        

        public BorrowedBooks(int bISBN, string bTitle, Borrower bbBorrower)
        {
            ISBN = bISBN;
            Title = bTitle;
            borrower = bbBorrower;
          

        }

        public BorrowedBooks()
        {

        }
    }}