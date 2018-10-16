using System;
using System.Collections.Generic;

namespace Paper
{
    public class Paper
    {
        private Dictionary<String, String> paperValues;

        public Paper() {

        }

        public List<String>  getValueKeys() {
            return new List<string>(paperValues.Keys);
        }

        public String getValue(String key) {
            String outp = "";
            paperValues.TryGetValue(key, out outp);
            return outp;
        }

    }
}
