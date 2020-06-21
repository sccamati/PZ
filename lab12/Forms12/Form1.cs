using lib12.Attributes;
using lib12.Classes;
using lib12.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Forms12
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
            contactBindingSource.DataSource = contacts;
            dataGridView1.DataSource = contactBindingSource;
            contactBindingSource.DataSource = null;
            contactBindingSource.DataSource = contacts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo("Plugins");
            foreach (FileInfo file in directory.GetFiles())
            {
                Assembly assembly = Assembly.LoadFrom(file.FullName);
                Type[] types = assembly.GetTypes()
                    .Where(type => type.IsClass && type.GetInterface("ISerializeContact") != null).ToArray();

                foreach (Type type in types)
                {
                    ISerializeContact plugin = (ISerializeContact)Activator.CreateInstance(type);
                    ToolStripMenuItem saveItem = new ToolStripMenuItem("to " + plugin.Format);
                    ToolStripMenuItem loadItem = new ToolStripMenuItem("from " + plugin.Format);
                    ToolStripMenuItem helpItem = new ToolStripMenuItem("info " + plugin.Format);
                    saveToolStripMenuItem.DropDownItems.Add(saveItem);
                    loadToolStripMenuItem.DropDownItems.Add(loadItem);
                    helpToolStripMenuItem.DropDownItems.Add(helpItem);

                    saveItem.Click += (s, ea) =>
                    {
                        SaveFileDialog dlg = new SaveFileDialog();
                        dlg.DefaultExt = ".xml";
                        dlg.Filter = "File xml (.xml)|*.xml";
                        dlg.ShowDialog();

                        plugin.Save(contacts, dlg.FileName);
                    };

                    loadItem.Click += (s, ea) =>
                    {
                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.DefaultExt = ".xml";
                        dlg.Filter = "File xml (.xml)|*.xml";
                        dlg.ShowDialog();

                        contactBindingSource.DataSource = null;
                        contactBindingSource.DataSource = plugin.Load(dlg.FileName);
                    };

                    helpItem.Click += (s, ea) =>
                    {
                        Creator creator = (Creator)type.GetCustomAttribute(typeof(Creator));
                        MessageBox.Show("Author info \n\n Name: " + creator.Name);
                    };
                }
            }
        }

        private void toXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "File xml (.xml)|*.xml";
            dlg.ShowDialog();

            FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));

            serializer.Serialize(fileStream, contacts);
        }

        private void fromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "File xml (.xml)|*.xml";
            dlg.ShowDialog();

            FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));

            contacts = (List<Contact>)serializer.Deserialize(fileStream);

            contactBindingSource.DataSource = null;
            contactBindingSource.DataSource = contacts;
        }

        private void infoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author info \n\n Name: Mateusz");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}