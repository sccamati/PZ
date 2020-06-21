using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7console
{
   public partial class  Dragon
    {
        partial void OnFireBreathedPartial(int value)
        {
            CurrentMP -= value;
            Console.WriteLine("WRR pfufuuuuuu zium siup");
        }
    }
}
