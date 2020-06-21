using lib12.Attributes;
using lib12.Classes;
using lib12.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab12Binary
{
    [Serializable]
    [Creator(Name = "Mateusz")]
    public class Binary : ISerializeContact
    {
        public string Format => "Binary";

        public List<Contact> Load(string filePath)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            Stream fStream = File.OpenRead(filePath);

            return (List<Contact>)binFormat.Deserialize(fStream);
        }

        public void Save(List<Contact> contacts, string filePath)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            Stream fStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            binFormat.Serialize(fStream, contacts);
        }
    }
}