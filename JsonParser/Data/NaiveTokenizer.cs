using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser.Data
{
    public class NaiveTokenizer : ITokenizer
    {
        public List<KeyValuePair<string, string>> Tokenize(string text)
        {
            text = PreProcess(text);
            int startIdx = 0;
            int endIdx;
            List<string> keyValPair = new List<string>();
            while (text.Length > 0) 
            {
                endIdx = GetEndIdx(text);
                keyValPair.Add(text.Substring(startIdx, endIdx));
                if(endIdx >= text.Length) break;
                text = text.Substring(endIdx + 1);
            }

            List<KeyValuePair<string, string>> tokens = new List<KeyValuePair<string, string>>();

            foreach (string k in keyValPair)
            {
                int idx = k.IndexOf(':');
                string key = k.Substring(0, idx).Trim().Replace(StringConstant.DOUBLE_QUOTES_STRING, "");
                string val = k.Substring(idx + 1);
                tokens.Add(new KeyValuePair<string, string>(key, val));
            }

            return tokens;
        }

        private int GetEndIdx(string text)
        {
            int idx = text.IndexOf(StringConstant.COLON);
            int endIdx = idx + 1;
            while (text[endIdx] == ' ')
            {
                endIdx++;
            }
            return endIdx;
        }

        private string PreProcess(string text)
        {
            text = text.Trim().Substring(1, text.Length - 1).Trim();
            return text;
        }
    }
}
