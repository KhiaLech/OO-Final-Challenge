using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class SelectedBorrower
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        public string DOB { get; set; }
        public Books books { get; set; }

        public SelectedBorrower(int sbid, string sbsurname, string sbfirstname, string sbDOB, Books bbooks)
        {
            id = sbid;
            surname = sbsurname;
            firstname = sbfirstname;
            DOB = sbDOB;
            books = bbooks;


        }

        public SelectedBorrower()
        {

        }
    }
}