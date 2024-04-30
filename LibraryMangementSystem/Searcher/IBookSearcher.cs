using LibraryMangementSystem.Book;

namespace LibraryMangementSystem.Searcher
{
    public interface IBookSearcher
    {
        List<Book.Book> Search();
    }
}
