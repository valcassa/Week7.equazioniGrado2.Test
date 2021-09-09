using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.EquazioniGrado2.core;

namespace WinForm
{
    public partial class Form1 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            B = (string.IsNullOrEmpty(textBox1.Text)) ? 0 : double.Parse(textBox2.Text);

            operation[0] = double.Parse(textBox1.Text);
            operation[1] = double.Parse(textBox1.Text);
            operation[2] = double.Parse(textBox1.Text);

            var risultato = Equation.RisolviEquazioneDiSecondoGrado(operation[0], operation[1], operation[2]);

            if (risultato == null)
            {
                textBox1 = "Caso Impossibile";

            }
            else if (risultato.Length == 1)
            {
                textBox1.Text = $"Soluzione unica:{risultato[0]}";

            }
            else if (risultato.Length == 2)
            {
                textBox2 = $"Soluzione distinta: {risultato[0]} e {risultato[1]}";
            }

        }
    }
}
