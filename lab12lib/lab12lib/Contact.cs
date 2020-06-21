using System;

namespace lab12lib
{
    [Serializable()]
    public class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
    }
}
