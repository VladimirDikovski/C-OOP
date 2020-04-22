using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Linq;

namespace Telephony
{
    public class Smartphone : IBrowse,ICall
    {
        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {url}!";
            }
        }

        public string Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            else
            {
                if (number.Length == 10)
                {
                    return $"Calling... {number}";
                }
                else
                {
                    return $"Dialing... {number}";
                }
             
            }
        }
    }
}
