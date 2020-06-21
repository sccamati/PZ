using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab13
{
    public partial class Form1 : Form
    {
        public List<Warrior> worriors = new List<Warrior>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DefineXML()
        {
            XElement WorriorsGuild =
              new XElement("Guild",
                  new XElement("Worrior",
                      new XAttribute("Gender", "Man"),
                      new XElement("Name", "Marcin"),
                      new XElement("Strength", "20"),
                      new XElement("Health", "120"),
                      new XElement("Troph", "Ant")),

                  new XElement("Worrior",
                      new XAttribute("Gender", "Woman"),
                      new XElement("Name", "Paulina"),
                      new XElement("Strength", "25"),
                      new XElement("Health", "130"),
                      new XElement("Troph", "Dragon")),

                  new XElement("Worrior",
                      new XAttribute("Gender", "Man"),
                      new XElement("Name", "Pawel"),
                      new XElement("Strength", "30"),
                      new XElement("Health", "150"),
                      new XElement("Troph", "Dragon")));

            WorriorsGuild.Save("WorriorsGuild.xml");
        }

        private void fromXMLToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            XDocument WorriorsGuild = XDocument.Load("WorriorsGuild.xml");

            var guild = WorriorsGuild.Descendants("Worrior").Select(w => w);

            worriors.Clear();

            foreach (var w in guild)
            {
                Warrior worrior = new Warrior();
                worrior.Gender = w.Attribute("Gender").Value;
                worrior.Name = w.Element("Name").Value;
                worrior.Strength = w.Element("Strength").Value;
                worrior.Health = w.Element("Health").Value;
                worrior.Troph = w.Element("Troph").Value;

                worriors.Add(worrior);
            }

            warriorBindingSource2.DataSource = null;
            warriorBindingSource2.DataSource = worriors;
        }

        private void toXMLToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Warrior[] warriorsArray = worriors.ToArray();

            XElement guild = new XElement("Guild",
                warriorsArray.Select(w => new XElement("Worrior",
                new XAttribute("Genre", w.Gender),
                new XElement("Name", w.Name),
                new XElement("Strength", w.Strength),
                new XElement("Health", w.Health),
                new XElement("Troph", w.Troph)
                ))
             );

            guild.Save("WorriorsGuild.xml");
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var w = (Warrior)comboBox1.SelectedItem;
            if (w == null)
            {
            }
            else
            {
                genderBox.Text = w.Gender;
                nameBox.Text = w.Name;
                strengthBox.Text = w.Strength;
                healthBox.Text = w.Health;
                trophBox.Text = w.Troph;
            }
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
        }

        private void label4_Click(object sender, System.EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            DefineXML();
            genderBox.Items.Add("Man");
            genderBox.Items.Add("Woman");

            
            sortBox.DataSource = typeof(Warrior).GetProperties();
            sortBox.DisplayMember = "Name";

            warriorBindingSource2.DataSource = worriors;
            dataGridView1.DataSource = warriorBindingSource2;
            comboBox1.DataSource = warriorBindingSource2;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (worriors.Any(w => w.Name.ToLower().Equals(nameBox.Text.ToLower())))
            {
            }
            else
            {
                Warrior warrior = new Warrior
                {
                    Gender = genderBox.Text,
                    Name = nameBox.Text,
                    Health = healthBox.Text,
                    Strength = strengthBox.Text,
                    Troph = trophBox.Text
                };

                genderBox.Text = "";
                nameBox.Text = "";
                healthBox.Text = "";
                strengthBox.Text = "";
                trophBox.Text = "";

                worriors.Add(warrior);

                warriorBindingSource2.DataSource = null;
                warriorBindingSource2.DataSource = worriors;
                ((CurrencyManager)BindingContext[worriors]).Refresh();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            worriors.Remove(worriors.Single(w => w.Name.Equals(comboBox1.Text)));
            genderBox.Text = "";
            nameBox.Text = "";
            healthBox.Text = "";
            strengthBox.Text = "";
            trophBox.Text = "";
            warriorBindingSource2.DataSource = null;
            warriorBindingSource2.DataSource = worriors;
            ((CurrencyManager)BindingContext[worriors]).Refresh();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {

            var worrior = (Warrior)comboBox1.SelectedItem;
            worrior.Name = nameBox.Text;
            worrior.Gender = genderBox.Text;
            worrior.Health = healthBox.Text;
            worrior.Strength = strengthBox.Text;
            worrior.Troph = trophBox.Text;

            genderBox.Text = "";
            nameBox.Text = "";
            healthBox.Text = "";
            strengthBox.Text = "";
            trophBox.Text = "";

            warriorBindingSource2.DataSource = null;
            warriorBindingSource2.DataSource = worriors;
            ((CurrencyManager)BindingContext[worriors]).Refresh();
        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {
        }

        private void sortB_Click(object sender, System.EventArgs e)
        {
            var sort = (PropertyInfo)sortBox.SelectedItem;

            if (radioButton1.Checked)
            {
                worriors = worriors.OrderBy(w => sort.GetValue(w)).ToList();
            }
            else if (radioButton2.Checked)
            {
                worriors = worriors.OrderByDescending(w => sort.GetValue(w)).ToList();
            }

         

            warriorBindingSource2.DataSource = null;
            warriorBindingSource2.DataSource = worriors;
            ((CurrencyManager)BindingContext[worriors]).Refresh();
        }

        private void groupBox3_Enter(object sender, System.EventArgs e)
        {
        }

        private void showNames_Click(object sender, System.EventArgs e)
        {
            XDocument WorriorsGuild = XDocument.Load("WorriorsGuild.xml");

            var n = WorriorsGuild.Descendants("Name");
            string names = "";

            foreach (var item in n)
            {
                names += item.Value + "\n";
            }

            MessageBox.Show(names, "All names");
        }

        private void ShowGender_Click(object sender, System.EventArgs e)
        {
            XDocument WorriorsGuild = XDocument.Load("WorriorsGuild.xml");
            string gender = genderBox.Text;
            string strength = strengthBox.Text;

            if (gender == null || strength == null)
            {
                MessageBox.Show("choose gender or write strength", "Error");
            }

            var n = WorriorsGuild.Descendants("Worrior").Where(w => w.Attribute("Gender").Value.Equals(gender) && Int32.Parse(w.Element("Strength").Value) > Int32.Parse(strength)).Select(w => w.Element("Name"));
            string names = "";

            foreach (var item in n)
            {
                names += item.Value + "\n";
            }

            MessageBox.Show(names, "All names");
        }

        private void deleteWorriors_Click(object sender, EventArgs e)
        {
            string health = healthBox.Text;

            if (health == null)
            {
                MessageBox.Show("write health", "Error");
            }
            else
            {
                XDocument WorriorsGuild = XDocument.Load("WorriorsGuild.xml");
                WorriorsGuild.Descendants("Worrior").Where(w => Int32.Parse(w.Element("Health").Value) < Int32.Parse(health)).Remove();
                WorriorsGuild.Save("WorriorsGuild.xml");
            }
        }

        private void AddWorriorAfter_Click(object sender, EventArgs e)
        {
            var w = (Warrior)comboBox1.SelectedItem;
            if (w == null)
            {
                MessageBox.Show("select worrior", "Error");
            }

            XDocument WorriorsGuild = XDocument.Load("WorriorsGuild.xml");

            WorriorsGuild.Changing += (s, err) =>
            {
                MessageBox.Show($"Adding new element to xml");
            };

            if (WorriorsGuild.Descendants("Worrior").Any(wor => wor.Element("Name").Value.Equals(nameBox.Text)))
            {
                MessageBox.Show("This worrior already exist", "Error");
            }
            else
            {
                XElement worrior =
                new XElement("Worrior",
                      new XAttribute("Gender", genderBox.Text),
                      new XElement("Name", nameBox.Text),
                      new XElement("Strength", strengthBox.Text),
                      new XElement("Health", healthBox.Text),
                      new XElement("Troph", trophBox.Text));

                genderBox.Text = "";
                nameBox.Text = "";
                healthBox.Text = "";
                strengthBox.Text = "";
                trophBox.Text = "";

                WorriorsGuild.Descendants("Worrior");

                XElement wAfter = WorriorsGuild.Descendants("Worrior").Single(warr => warr.Element("Name").Value.Equals(comboBox1.Text));

                wAfter.AddAfterSelf(worrior);

                WorriorsGuild.Save("WorriorsGuild.xml");
            }
        }
    }
}