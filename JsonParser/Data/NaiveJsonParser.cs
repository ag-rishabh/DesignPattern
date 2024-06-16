using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser.Data
{
    public class NaiveJsonParser : IJsonParser
    {
        private readonly ITokenizer _tokenizer;

        public NaiveJsonParser(ITokenizer tokenizer)
        {
            _tokenizer = tokenizer;
        }

        public JSON Parse(string jsonText)
        {
            if (jsonText == null) throw new Exception("Invalid jsonText");

            Dictionary<string, JSON> keyToValue = new Dictionary<string, JSON>();

            if (!jsonText.Contains(StringConstant.STARTING_PARAN_STRING))
            {
                jsonText = jsonText.Trim().Replace(StringConstant.DOUBLE_QUOTES_STRING, string.Empty);
                keyToValue.Add(jsonText, null);
                return new JSON(keyToValue);
            }

            List<KeyValuePair<string, string>> keyValuePairs = _tokenizer.Tokenize(jsonText);

            foreach (KeyValuePair<string, string> keyValue in keyValuePairs) 
            { 
                keyToValue.Add(keyValue.Key, Parse(keyValue.Value));
            }


            return new JSON(keyToValue);
        }

        public string ToString(JSON json)
        {
            string jsonText = StringConstant.STARTING_PARAN_STRING;
            List<string> keys = json.GetAllKeys();
            foreach (string key in keys)
            {
                jsonText += StringConstant.DOUBLE_QUOTES + key + StringConstant.DOUBLE_QUOTES;
                jsonText += StringConstant.COLON;
                jsonText += ToString(json.Get(key));
                jsonText += StringConstant.COMMA;
            }

            if(jsonText.EndsWith(StringConstant.COMMA))
            {
                jsonText = jsonText.Substring(0, jsonText.Length - 1);
            }

            jsonText += StringConstant.CLOSEING_PARAN_STRING;
            throw new NotImplementedException();
        }
    }
}
