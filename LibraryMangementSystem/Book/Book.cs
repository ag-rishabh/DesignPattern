using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Book
{
    public class Book
    {
        public int Id { get; private set; }

        public BookDetails BookDetails { get; private set; }

        public Book(int id, BookDetails bookDetails)
        {
            Id = id;
            BookDetails = bookDetails;
        }

    }
}
