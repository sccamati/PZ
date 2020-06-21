using lib12.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib12.Interfaces
{
    public interface ISerializeContact
    {
        void Save(List<Contact> contacts, string filePath);
        List<Contact> Load(string filePath);
        string Format { get; }

    }
}
