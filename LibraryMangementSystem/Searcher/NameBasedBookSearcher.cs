using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Searcher
{
    public class NameBasedBookSearcher : IBookSearcher
    {
        private readonly string _bookName;

        public NameBasedBookSearcher(string bookName)
        {
            _bookName = bookName;
        }

        public List<Book.Book> Search()
        {
            throw new NotImplementedException();
        }
    }
}
