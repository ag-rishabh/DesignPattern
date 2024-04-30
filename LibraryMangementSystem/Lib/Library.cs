using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryMangementSystem.Book;
using LibraryMangementSystem.Users;


/// this class with call data acess layer
namespace LibraryMangementSystem.Lib
{
    public class Library
    {
        public void AddBook(Book.Book book)
        {

        }

        public void DeleteBook(Book.Book book)
        {

        }

        public void BlockMember(Member member) { }

        public void IssueBook(Book.Book book, Member member) { }

        public void SubmitBook(Book.Book book, Member member) { }

        public Member GetBorrower(Book.Book book) { return null; }

        public List<Book.Book> GetBorrowerBook(Member member) { return null; }
    }
}
