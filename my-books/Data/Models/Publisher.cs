using System.Collections.Generic;

namespace my_books.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation properties: Props that are used to define the relationships between models
        public List<Book> Books { get; set; }
    }
}
