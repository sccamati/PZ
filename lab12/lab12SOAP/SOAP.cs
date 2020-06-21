using lib12.Attributes;
using lib12.Classes;
using lib12.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;

namespace lab12SOAP
{
    [Serializable]
    [Creator(Name = "Mateusz")]
    public class SOAP : ISerializeContact
    {
        public string Format => "SOAP";

        public List<Contact> Load(string filePath)
        {
            SoapFormatter soapFormatter = new SoapFormatter();

            Stream fStream = File.OpenRead(filePath);

            return ((Contact[])soapFormatter.Deserialize(fStream)).ToList();
        }

        public void Save(List<Contact> contacts, string filePath)
        {
            SoapFormatter soapFormatter = new SoapFormatter();

            Stream fStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);

            soapFormatter.Serialize(fStream, contacts.ToArray());
        }
    }
}