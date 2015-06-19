using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
    public class NewtonJson
    {
        public static JObject ParseJson(string sJson)
        {
            var jObject = JObject.Parse(sJson);
            return jObject;
        }
    }
}
