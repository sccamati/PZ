using lab12lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab12Form
{
    public partial class Form1 : Form  
    {
        List<Contact> contacts = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
            contactBindingSource.DataSource = contacts;
            dataGridView1.DataSource = contactBindingSource;
        }

        private void toXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "Pliki xml (.xml)|*.xml";
            dlg.ShowDialog();

            using (FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create))
            {
                SaveFileDialog sfd = new SaveFileDialog();

                XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));

                    serializer.Serialize(fileStream, contacts);
            }
        }

        private void fromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Pliki xml (.xml)|*.xml"
            };
            dlg.ShowDialog();

            using (FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open))
            {

                XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));

                    contacts = (List<Contact>)serializer.Deserialize(fileStream);

            }

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
                    .Where(type => type.IsClass && type.GetInterface("IContact") != null)
                    .ToArray();
                foreach (Type type in types)
                {
                    IContact plugin = (IContact)Activator.CreateInstance(type);
                    ToolStripItem saveItem = new ToolStripMenuItem("to " + plugin.Format);
                    saveToolStripMenuItem.DropDownItems.Add(saveItem);
                    saveItem.Click += (s, ea) =>
                    {
                        SaveFileDialog dlg = new SaveFileDialog();
                        dlg.ShowDialog();

                        plugin.Save(contacts, dlg.FileName);
                    };

                    ToolStripItem loadItem = new ToolStripMenuItem("from " + plugin.Format);
                    loadToolStripMenuItem.DropDownItems.Add(loadItem);
                    loadItem.Click += (s, ea) =>
                    {
                        OpenFileDialog dlg = new OpenFileDialog
                        {
                            Multiselect = false
                        };
                        dlg.ShowDialog();

                        contactBindingSource.DataSource = null;
                        contactBindingSource.DataSource = plugin.Load(dlg.FileName);

                    };
                    ToolStripItem item = new ToolStripMenuItem(plugin.Format);
                    helpToolStripMenuItem.DropDownItems.Add(item);
                    item.Click += (s, ea) =>
                    {
                        AuthorAttribute author = (AuthorAttribute)type.GetCustomAttribute(typeof(AuthorAttribute));
                        MessageBox.Show("Author info \n\nName: "+author.Name+"\nAge"+author.Age);
                    };
                    

                }
            }


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
