using MySql.Data.MySqlClient;
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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form1 telalogin = new Form1();
            telalogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEmail.Text == "" || txtCpf.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            else if (int.TryParse(txtNome.Text, out _) == true || float.TryParse(txtNome.Text, out _) == true)
            {
            MessageBox.Show("Um ou mais campo estão incorretos!");
            }
            else
            {
                MySqlConnection meuSql = new MySqlConnection("server=localhost;database=dbCadastro;uid=root;pwd=etec");
                meuSql.Open();
                MySqlCommand comando = new MySqlCommand("insert into tbCliente(Nome,cpf,email)values(" + "'" + txtNome.Text + "','" + txtCpf.Text + "','" + txtEmail.Text + "');", meuSql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro inserido com sucesso!");
                txtNome.Text = "";
                txtCpf.Text = "";
                txtEmail.Text = "";

                Form1 telalogin = new Form1();
                telalogin.Show();
                this.Hide();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}