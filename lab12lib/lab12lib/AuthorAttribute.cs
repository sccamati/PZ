using System;
using System.Collections.Generic;
using System.Text;


namespace lab12lib
{
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
