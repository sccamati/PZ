using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6FormsApp
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;

            button4.Click += delegate (object sender, EventArgs e)
            {
                wynik4.Text = (int.Parse(left4.Text) / int.Parse(right4.Text)).ToString();
            };

            button5.Click += (sender, e) => wynik5.Text = (int.Parse(left5.Text) % int.Parse(right5.Text)).ToString();

       
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            wynik3.Text = (int.Parse(left3.Text) * int.Parse(right3.Text)).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            wynik2.Text = (int.Parse(left2.Text) - int.Parse(right2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wynik1.Text = (int.Parse(left1.Text) + int.Parse(right1.Text)).ToString();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Zostaw nie wpisuj");
        }


        private void Kalkulator_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("NIE RUSZAJ");
        }

        private void Kalkulator_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Zostaw");
        }

        private void Kalkulator_LocationChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Po co to przesuwasz?");
        }
    }
}
