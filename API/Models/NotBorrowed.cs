using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class NotBorrowed
    {
        public int ISBN { get; set; }
        public string Title { get; set; }


        public NotBorrowed(int bISBN, string bTitle)
        {
            ISBN = bISBN;
            Title = bTitle;
            

        }

        public NotBorrowed()
        {

        }
    }
}