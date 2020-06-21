using System;
using System.Collections.Generic;
using System.Text;

namespace lab12lib
{
    public interface IContact
    {
        string Format { get; }

        void Save(List<Contact> contacts, string path);
        List<Contact> Load(string path);

    }
}
