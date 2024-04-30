using LibraryMangementSystem.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Searcher
{
    public class NameBasedMemberSearcher : IMemberSearcher
    {
        private readonly string _memberName;

        public NameBasedMemberSearcher(string memberName)
        {
            _memberName = memberName;
        }

        public List<Member> Search()
        {
            throw new NotImplementedException();
        }
    }
}
