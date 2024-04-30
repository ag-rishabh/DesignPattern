using LibraryMangementSystem.Book;

namespace LibraryMangementSystem.Searcher
{
    public class AuthorBasedBookSearcher : IBookSearcher
    {
        private readonly List<string> _author;

        public AuthorBasedBookSearcher(List<string> author)
        {
            _author = author;
        }

        public List<Book.Book> Search()
        {
            throw new NotImplementedException();
        }
       
    }
}
