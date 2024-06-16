using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser.Data
{
    public interface ITokenizer
    {
        List<KeyValuePair<string, string>> Tokenize(string text);
    }
}
