using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class Book
    {
        //Shortcut to create property: Write "prop" and double tab
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRead { get; set; }

        //To make a property optional in C#, just add ? at the end of the datatype
        public DateTime? DateRead { get; set; }

        public int? Rate { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        public string CoverUrl { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
