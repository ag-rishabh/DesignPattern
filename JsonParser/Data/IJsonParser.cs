using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser.Data
{
    public interface IJsonParser
    {
        JSON Parse(string jsonText);

        string ToString(JSON json);
    }
}
