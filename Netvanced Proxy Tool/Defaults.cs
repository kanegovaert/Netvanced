using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Netvanced_Proxy_Tool
{
    class Defaults
    {
        public Regex REGEX = new Regex(@"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\:[0-9]{1,5}\b");
        public List<string> Sources = new List<string>();
    }
}
