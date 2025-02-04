namespace primeiro_git
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInicial = new System.Windows.Forms.GroupBox();
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNmostrar = new System.Windows.Forms.Button();
            this.menuInicial.SuspendLayout();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuInicial
            // 
            this.menuInicial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuInicial.Controls.Add(this.BTNmostrar);
            this.menuInicial.Controls.Add(this.label3);
            this.menuInicial.Controls.Add(this.label2);
            this.menuInicial.Controls.Add(this.label1);
            this.menuInicial.Controls.Add(this.TXTsenha);
            this.menuInicial.Controls.Add(this.TXTusuario);
            this.menuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuInicial.Location = new System.Drawing.Point(248, 46);
            this.menuInicial.Name = "menuInicial";
            this.menuInicial.Size = new System.Drawing.Size(297, 356);
            this.menuInicial.TabIndex = 0;
            this.menuInicial.TabStop = false;
            this.menuInicial.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TXTusuario
            // 
            this.TXTusuario.Location = new System.Drawing.Point(66, 150);
            this.TXTusuario.Multiline = true;
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(176, 27);
            this.TXTusuario.TabIndex = 0;
            // 
            // TXTsenha
            // 
            this.TXTsenha.Location = new System.Drawing.Point(66, 240);
            this.TXTsenha.Multiline = true;
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.Size = new System.Drawing.Size(176, 27);
            this.TXTsenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(115, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(118, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Botão para conectar com o Arduino UNO";
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(551, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBar.Controls.Add(this.button4);
            this.MenuBar.Controls.Add(this.button3);
            this.MenuBar.Controls.Add(this.button2);
            this.MenuBar.Enabled = false;
            this.MenuBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuBar.Location = new System.Drawing.Point(0, 1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(242, 452);
            this.MenuBar.TabIndex = 6;
            this.MenuBar.TabStop = false;
            this.MenuBar.Text = "MENU";
            this.MenuBar.Visible = false;
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Botão para conectar com o Arduino UNO";
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(61, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cadastro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "Botão para conectar com o Arduino UNO";
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(63, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Processo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "Botão para conectar com o Arduino UNO";
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(61, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::primeiro_git.Properties.Resources.icons8_cardápio_30;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(750, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTNmostrar
            // 
            this.BTNmostrar.BackColor = System.Drawing.Color.Transparent;
            this.BTNmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmostrar.Location = new System.Drawing.Point(186, 273);
            this.BTNmostrar.Name = "BTNmostrar";
            this.BTNmostrar.Size = new System.Drawing.Size(56, 23);
            this.BTNmostrar.TabIndex = 28;
            this.BTNmostrar.Text = "Mostrar";
            this.BTNmostrar.UseVisualStyleBackColor = false;
            this.BTNmostrar.Click += new System.EventHandler(this.BTNmostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuInicial);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuInicial.ResumeLayout(false);
            this.menuInicial.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuInicial;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.TextBox TXTusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox MenuBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNmostrar;
    }
}

