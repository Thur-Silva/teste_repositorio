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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(8, 8);

            if (UsuarioGlobal.NomeUsuario== null || UsuarioGlobal.FuncaoUsuario== null)
            {
                 MessageBox.Show("Por favor, faça login para ter acesso à tela PROCESSO", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                TXTusuario.Text= UsuarioGlobal.NomeUsuario.ToString();
                TXTfuncao.Text = UsuarioGlobal.FuncaoUsuario.ToString();
               
            }


        }

        int menu = 1;
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
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void Form3_Click(object sender, EventArgs e)
        {

            menu = 1;

            MenuBar.Enabled = false;
            MenuBar.Hide();

            pictureBox1.Location = new Point(8, 8);

        }
    }
}
