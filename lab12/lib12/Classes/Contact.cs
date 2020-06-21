using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib12.Classes
{
    [Serializable]
    public class Contact 
    {
        public Contact()
        {
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }


    }
}
