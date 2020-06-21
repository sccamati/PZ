using lab12lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;

namespace lab12LibSOAP
{
    [Serializable]
    [Author(Age = 23, Name = "Dobry ziomek")]
    public class Class1 : IContact
    {
        public string Format => "SOAP";

        public List<Contact> Load(string path)
        {
            SoapFormatter soap = new SoapFormatter();

            using (Stream stream = File.OpenRead(path))
            {
                Contact[] contacts = (Contact[]) soap.Deserialize(stream);
                return contacts.ToList();
            }
        }

        public void Save(List<Contact> contacts, string path)
        {
            SoapFormatter soapFormatter = new SoapFormatter();

            using(Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(stream, contacts.ToArray());
            }
        }
    }
}
