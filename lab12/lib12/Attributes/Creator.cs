using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib12.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class Creator : Attribute
    {
        public string Name { get; set; }

    }
}
