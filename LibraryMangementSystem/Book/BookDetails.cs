using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Book
{
    public class BookDetails
    {
        public string Name { get; private set; }

        public DateOnly PublicationDate {  get; private set; }
        
        public List<string> Authors { get; private set; }

        public BookDetails(string name, DateOnly publicationDate, List<String> authors) 
        {
            Name = name;
            PublicationDate = publicationDate;
            Authors = authors;
        }
    }
}
