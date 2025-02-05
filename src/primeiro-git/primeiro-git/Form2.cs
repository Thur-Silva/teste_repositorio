using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static primeiro_git.Form1;
namespace primeiro_git
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string CONFIG_CONEXAO_BD = "server=127.0.0.1;userid=root;password=;database=gordaodopc";
        public void QUERY_MYSQL(string server, string query)
        {
            MySqlConnection conexao = new MySqlConnection(server);
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = conexao;
            conexao.Open();
            Query.CommandText = query;
            Query.ExecuteNonQuery();

            conexao.Close();

        }

        private void menuInicial_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(8, 8);

            menuInicial.Location = new Point(200, 12);

            TXTsenha.PasswordChar = '*';
            TXTverifi.PasswordChar = '*';

        }

        int menu = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            menuInicial.Location = new Point(255, 12);
            menu++;
            if (menu % 2 == 0)
            {
                MenuBar.Enabled = true;
                MenuBar.Show();

                pictureBox1.Location = new Point(750, 12);

            }
            if (menu % 2 != 0)
            {
                MenuBar.Enabled = false;
                MenuBar.Hide();

                pictureBox1.Location = new Point(8, 8);
                menuInicial.Location = new Point(200, 12);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (UsuarioGlobal.NomeUsuario == null || UsuarioGlobal.FuncaoUsuario == null)
            {
                MessageBox.Show("Por favor, faça login para ter acesso à tela PROCESSO", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                 Form3 form3 = new Form3();
            form3.Show();

            this.Hide();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void Form2_Click(object sender, EventArgs e)
        {

            menu = 1;

            MenuBar.Enabled = false;
            MenuBar.Hide();

            pictureBox1.Location = new Point(8, 8);
            menuInicial.Location = new Point(200, 12);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
             
                if (string.IsNullOrEmpty(TXTnome.Text) ||
                    string.IsNullOrEmpty(TXTsobre.Text) ||
                    string.IsNullOrEmpty(CBfuncao.Text) ||
                    string.IsNullOrEmpty(TXTsenha.Text) ||
                    string.IsNullOrEmpty(TXTlogin.Text) ||
                    string.IsNullOrEmpty(TXTuser.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                if(TXTsenha.Text != TXTverifi.Text)
                {
                    MessageBox.Show("Por favor, escreva a sua exatamente igual nos dois campos de senha.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                QUERY_MYSQL(CONFIG_CONEXAO_BD, "INSERT INTO usuario (Nome, Sobrenome, funcao, Senha, login, user) values ('" + TXTnome.Text + "','" + TXTsobre.Text + "','" + CBfuncao.Text + "','" + TXTsenha.Text + "','" + TXTlogin.Text + "','" + TXTuser.Text + "')");
                MessageBox.Show("Dados cadastrados com sucesso!", "SENAI", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! \n" + ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TXTnome_TextChanged(object sender, EventArgs e)
        {

        }

        bool senhaVisivel = true;

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                TXTverifi.PasswordChar = '*';
                TXTsenha.PasswordChar = '*';
                senhaVisivel = false;
                BTNmostrar.Text = "Mostrar Senha";
            }
            else
            {
                TXTverifi.PasswordChar = '\0';
                TXTsenha.PasswordChar = '\0';
                senhaVisivel = true;
                BTNmostrar.Text = "Ocultar Senha";
            }
        }
    }
}
