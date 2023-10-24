using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "")
            {
                try
                {
                    DateTime DiaNasc;
                    DateTime DiaHoje;
                    DiaNasc = DateTime.Parse(textBox3.Text);
                    DiaHoje = System.DateTime.Today;
                    int AnoNasc = DateTime.Parse(textBox3.Text).Year;
                    int AnoAtual = System.DateTime.Now.Year;
                    int AnoIdade = AnoAtual - AnoNasc;

                    if(DiaNasc.DayOfYear > DiaHoje.DayOfYear)
                    {
                        AnoIdade = AnoIdade - 1;
                    }
                    if(AnoIdade <= 17)
                    {
                        MessageBox.Show("Apenas maiores de idade");
                    }
                    else
                    {
                        MessageBox.Show("Parabéns");
                    }

                    int QtdeDiaVida = (DiaHoje.DayOfYear - DiaNasc.DayOfYear);
                    MessageBox.Show("Data válida");
                }
                catch
                {
                    MessageBox.Show("Data inválida");
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Data é um campo obrigatório");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkcondesp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdomasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdofem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}