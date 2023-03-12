using Microsoft.EntityFrameworkCore;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbContext:DbContext
    {
        //Shortcut to create constructor: Write "ctor" and double tab
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
