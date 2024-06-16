

namespace JsonParser.Data
{
    public class JSON
    {
        private readonly Dictionary<string, JSON> keyToValue;

        public JSON(Dictionary<string, JSON> keyToValue)
        {
            this.keyToValue = keyToValue;
        }

        public JSON Get(string key) 
        {
            return keyToValue[key];
        }

        public List<string> GetAllKeys()
        {
            List<string> keys = new List<string>();

            foreach (var key in keyToValue.Keys)
            {
                keys.Add(key);
            }
            return keys;
        }
    }
}
