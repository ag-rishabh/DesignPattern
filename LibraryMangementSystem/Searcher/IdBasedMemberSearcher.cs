using LibraryMangementSystem.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Searcher
{
    public class IdBasedMemberSearcher : IMemberSearcher
    {
        private readonly int _id;

        public IdBasedMemberSearcher(int id)
        {
            _id = id;
        }

        public List<Member> Search()
        {
            throw new NotImplementedException();
        }
    }
}
