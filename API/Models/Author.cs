using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Author
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        

        public Author(int id, string surname, string firstname)
        {
        }

        public Author()
        {

        }
    }
}