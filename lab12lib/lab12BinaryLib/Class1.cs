using lab12lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab12BinaryLib
{
    [Serializable]
    [Author(Age = 25, Name = "Anonimowy")]
    public class Class1 : IContact
    {
        public string Format => "Binary";

        public List<Contact> Load(string path)
        {
            BinaryFormatter binary = new BinaryFormatter();

            using (Stream stream = File.OpenRead(path))
            {
                List<Contact> contacts = (List<Contact>)binary.Deserialize(stream);
                return contacts;
            }
        }

        public void Save(List<Contact> contacts, string path)
        {
            BinaryFormatter binary = new BinaryFormatter();
            using(Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binary.Serialize(stream, contacts);
            }
        }
    }
}
