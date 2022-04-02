using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramZaliczenieSosnowski
{
    public partial class Form1 : Form
    {
        readonly Sprawdzaniejednostek spr = new Sprawdzaniejednostek();
        public Form1()
        {
            InitializeComponent();
            lista.DataSource = spr.Jednostkiwzrost;
            listawaga.DataSource = spr.Jednostkiwaga;
        }

        

        private void PoleWejsciowe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PoleWzrost_TextChanged(object sender, EventArgs e)
        {

        }

        readonly BMI bemii = new BMI();



        private void BtnOblicz_Click(object sender, EventArgs e)
        {
            string jakajednostkawzrostu = lista.SelectedItem.ToString();
            string jakajednostkawagi = listawaga.SelectedItem.ToString();

            if (poleWaga.Text == "" || poleWzrost.Text=="")
            {
                MessageBox.Show("Okno waga lub wzrost jest puste");
                
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else { 
            poleWyjsciowe.Text = bemii.Liczbmi(spr.Przeliczwaga(jakajednostkawagi, float.Parse(poleWaga.Text)), spr.Przeliczwzrost(jakajednostkawzrostu, float.Parse(poleWzrost.Text))).ToString();
            }
           

            jestes.Text = bemii.Katogkategoryzuj(float.Parse(poleWyjsciowe.Text));


        }

        private void PoleWyjsciowe_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
