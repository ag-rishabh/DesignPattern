
using LibraryMangementSystem.Auth;
using LibraryMangementSystem.Book;
using LibraryMangementSystem.Lib;
using LibraryMangementSystem.Searcher;
using System.Diagnostics.Metrics;
using LibraryMangementSystem.Users;


// this is api layer
public class Tester
{
    public List<Book> SearchBookByBookName(string bookName)
    {
        if(bookName == null)
        {
            throw new ArgumentNullException("Book name can't be null");
        }
        IBookSearcher bookSearcher = new NameBasedBookSearcher(bookName);
        return bookSearcher.Search();
    }

    public List<Book> SearchBookByAuthorNames(List<string> authorNames)
    {
        if(authorNames == null || authorNames.Count == 0)
        {
            throw new ArgumentNullException("author name can't be null or empty");
        }

        IBookSearcher bookSearcher = new AuthorBasedBookSearcher(authorNames);
        return bookSearcher.Search();
    }

    public List<Member> SearchMemberbyMemberName(string memberName, string adminToken)
    {
        if(!UserAuthenticator.IsAdmin(adminToken))
        {
            throw new UnauthorizedAccessException("Operation forbidden");
        }
        IMemberSearcher memberSearcher = new NameBasedMemberSearcher(memberName);
        return memberSearcher.Search();
    }

    public void AddBook(string  bookName, DateOnly publicationDate,  List<string> authorName, string adminToken)
    {
        if (!UserAuthenticator.IsAdmin(adminToken))
        {
            throw new UnauthorizedAccessException("Operation forbidden");
        }

        BookDetails bookDetails = new BookDetails(bookName, publicationDate, authorName);

        Book book = new Book(1, bookDetails);

        Library library = new Library();
        library.AddBook(book);
    }

    public void DeleteBook(int bookId, string adminToken)
    {
        //validation
        IBookSearcher bookSearcher = new IdBasedBookSearcher(bookId);
        Book? book = bookSearcher.Search().FirstOrDefault();
        if(book == null)
        {
            throw new Exception("No book with given id");
        }
        new Library().DeleteBook(book);
    }

    public void IssueBook(int bookId, int memberId,string adminToken)
    {
        IBookSearcher bookSearcher = new IdBasedBookSearcher(bookId);
        Book? book = bookSearcher.Search().FirstOrDefault();

        IMemberSearcher memberSearcher = new IdBasedMemberSearcher(memberId);
        Member member = memberSearcher.Search().FirstOrDefault();
        new Library().IssueBook(book, member);
    }

    public void SubmitBook(int bookId, int memberId, string adminToken)
    {
        IBookSearcher bookSearcher = new IdBasedBookSearcher(bookId);
        Book? book = bookSearcher.Search().FirstOrDefault();

        IMemberSearcher memberSearcher = new IdBasedMemberSearcher(memberId);
        Member member = memberSearcher.Search().FirstOrDefault();

        new Library().SubmitBook(book, member);
    }
}
