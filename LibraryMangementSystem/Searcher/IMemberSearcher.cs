using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMangementSystem.Users;

namespace LibraryMangementSystem.Searcher
{
    public interface IMemberSearcher
    {
        List<Member> Search();
    }
}
