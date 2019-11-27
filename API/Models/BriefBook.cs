using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class BriefBook
    {
        public int ISBN { get; set; }
        public string Title { get; set; }

        public BriefBook(int bbISBN, string bbTitle)
        {
            ISBN = bbISBN;
            Title = bbTitle;
         

        }

        public BriefBook()
        {

        }
    }
}