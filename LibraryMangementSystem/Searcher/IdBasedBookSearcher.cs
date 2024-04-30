using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMangementSystem.Book;

namespace LibraryMangementSystem.Searcher
{
    public class IdBasedBookSearcher : IBookSearcher
    {
        private readonly int _id;

        public IdBasedBookSearcher(int id)
        {
            _id = id;
        }

        public List<Book.Book> Search()
        {
            throw new NotImplementedException();
        }
    }
}
