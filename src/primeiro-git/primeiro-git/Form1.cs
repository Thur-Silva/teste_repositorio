﻿using System;
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
            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();
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
            try
            {
                   QUERY_MYSQL(CONFIG_CONEXAO_BD, "SELECT nome FROM usuario WHERE user='"+ TXTusuario.Text + "' AND senha='"+ TXTsenha.Text + "'");
                   MessageBox.Show("Login efetuado!", "SENAI", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao procurar pelos dados!", "SENAI", MessageBoxButtons.OK);
            }
            
        }
    }
}
