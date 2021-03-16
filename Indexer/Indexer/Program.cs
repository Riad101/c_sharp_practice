﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        public class HttpCookie
        {
            private readonly Dictionary<string, string> _dictionary;

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }
            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
            public DateTime Expiry { get; set; }

        }
        static void Main(string[] args)
        {
            var Cookie = new HttpCookie();
            Cookie["name"] = "john";
            Console.WriteLine(Cookie["name"]);
        }
    }
}
