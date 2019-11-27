using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Borrower
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        public string DOB { get; set; }

        public Borrower(int bid, string bsurname, string bfirstname, string bDOB)
        {
            id = bid;
            surname = bsurname;
            firstname = bfirstname;
            DOB = bDOB;


        }

        public Borrower()
        {

        }
    }
}