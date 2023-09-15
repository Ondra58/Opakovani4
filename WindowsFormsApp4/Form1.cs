using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sportovec_profesional sportovec_Profesional;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                string jmeno = textBox1.Text;
                double obvodpasu = (double)numericUpDown1.Value;
                double vyska = (double)numericUpDown2.Value;
                DateTime datumvzniku = dateTimePicker1.Value;
                double bazal = double.Parse(textBox2.Text);
                int stupenvykonnosti = int.Parse(textBox3.Text);
                int pocethodin = 10;
                sportovec_Profesional = new Sportovec_profesional(jmeno, obvodpasu, vyska, datumvzniku, bazal, stupenvykonnosti, pocethodin);
                MessageBox.Show(sportovec_Profesional.ToString());
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Chyba", "Chyba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sportovec_Profesional.Trenuj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sportovec_Profesional.ToString());
        }
    }
}
