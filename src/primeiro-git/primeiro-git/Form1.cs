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

namespace primeiro_git
{
    public partial class Form1 : Form
    {
        public Form1()
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

        public static class UsuarioGlobal
        {
            // Propriedade estática para armazenar o nome do usuário
            public static string NomeUsuario { get; set; }

            // Propriedade estática para armazenar a função do usuário
            public static string FuncaoUsuario { get; set; }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(8,8);
            TXTsenha.PasswordChar = '*';
        }
        int menu =1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
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

        }

        private void Form1_Click(object sender, EventArgs e)
        {

            menu = 1;
       
                MenuBar.Enabled = false;
                MenuBar.Hide();

                pictureBox1.Location = new Point(8, 8);
            
        }
        bool senhaVisivel = true;

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                TXTsenha.PasswordChar = '*'; 
                senhaVisivel = false;
                BTNmostrar.Text = "Mostrar Senha";
            }
            else
            {
                
                TXTsenha.PasswordChar = '\0';
                senhaVisivel = true;
                BTNmostrar.Text = "Ocultar Senha"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTusuario.Text) || string.IsNullOrEmpty(TXTsenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
             
                string query = "SELECT nome, funcao FROM usuario WHERE user=@user AND senha=@senha";

                try
                {
                    using (var conexao = new MySqlConnection(CONFIG_CONEXAO_BD))
                    {
                        conexao.Open();
                        using (var comando = new MySqlCommand(query, conexao))
                        {
                            
                            comando.Parameters.AddWithValue("@user", TXTusuario.Text);
                            comando.Parameters.AddWithValue("@senha", TXTsenha.Text);

                            using (var reader = comando.ExecuteReader())
                            {
                                if (reader.Read())  
                                {
                                   
                                    UsuarioGlobal.NomeUsuario = reader["nome"].ToString();
                                    UsuarioGlobal.FuncaoUsuario = reader["funcao"].ToString();

                                   
                                    MessageBox.Show("Usuário '" + UsuarioGlobal.NomeUsuario + "' autenticado com sucesso!",
                                                    "Sucesso",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                                    // Abre o Form3
                                    Form3 form3 = new Form3();
                                    form3.Show();

                                    // Esconde o Form de Login
                                    this.Hide();
                                }
                                else
                                {
                                    // Se não encontrar o usuário, exibe mensagem de erro
                                    MessageBox.Show("Usuário ou senha inválidos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Em caso de erro na execução da consulta, exibe uma mensagem de erro
                    MessageBox.Show("Erro ao consultar o banco de dados: " + ex.Message,
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }


        }

        private void TXTsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
