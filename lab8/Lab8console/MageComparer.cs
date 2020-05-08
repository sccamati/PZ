using lab8lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8console
{
    class MageComparer : IComparer<Mage>
    {
        public int Compare(Mage x, Mage y)
        {
            return x.Strength.CompareTo(y.Strength);
        }
    }
}
