namespace primeiro_git
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuInicial = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTfuncao = new System.Windows.Forms.TextBox();
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.MenuBar = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.BTNprocesso = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuInicial.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuInicial
            // 
            this.menuInicial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuInicial.Controls.Add(this.button1);
            this.menuInicial.Controls.Add(this.label3);
            this.menuInicial.Controls.Add(this.label2);
            this.menuInicial.Controls.Add(this.label1);
            this.menuInicial.Controls.Add(this.TXTfuncao);
            this.menuInicial.Controls.Add(this.TXTusuario);
            this.menuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuInicial.Location = new System.Drawing.Point(260, 51);
            this.menuInicial.Name = "menuInicial";
            this.menuInicial.Size = new System.Drawing.Size(297, 356);
            this.menuInicial.TabIndex = 1;
            this.menuInicial.TabStop = false;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Botão para conectar com o Arduino UNO";
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(92, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONECTAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(118, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Função";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROCESSO";
            // 
            // TXTfuncao
            // 
            this.TXTfuncao.Enabled = false;
            this.TXTfuncao.Location = new System.Drawing.Point(66, 240);
            this.TXTfuncao.Multiline = true;
            this.TXTfuncao.Name = "TXTfuncao";
            this.TXTfuncao.Size = new System.Drawing.Size(176, 27);
            this.TXTfuncao.TabIndex = 1;
            this.TXTfuncao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTusuario
            // 
            this.TXTusuario.Enabled = false;
            this.TXTusuario.Location = new System.Drawing.Point(66, 150);
            this.TXTusuario.Multiline = true;
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(176, 27);
            this.TXTusuario.TabIndex = 0;
            this.TXTusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBar.Controls.Add(this.button4);
            this.MenuBar.Controls.Add(this.BTNprocesso);
            this.MenuBar.Controls.Add(this.button2);
            this.MenuBar.Enabled = false;
            this.MenuBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuBar.Location = new System.Drawing.Point(1, -1);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(253, 453);
            this.MenuBar.TabIndex = 23;
            this.MenuBar.TabStop = false;
            this.MenuBar.Text = "MENU";
            this.MenuBar.Visible = false;
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
            // BTNprocesso
            // 
            this.BTNprocesso.AccessibleDescription = "Botão para conectar com o Arduino UNO";
            this.BTNprocesso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNprocesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNprocesso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNprocesso.Location = new System.Drawing.Point(63, 206);
            this.BTNprocesso.Name = "BTNprocesso";
            this.BTNprocesso.Size = new System.Drawing.Size(116, 40);
            this.BTNprocesso.TabIndex = 8;
            this.BTNprocesso.Text = "Processo";
            this.BTNprocesso.UseVisualStyleBackColor = false;
            this.BTNprocesso.Click += new System.EventHandler(this.button3_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(579, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADOS";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Conecte para exibir os resultados.";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.menuInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PieceTracker";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form3_Click);
            this.menuInicial.ResumeLayout(false);
            this.menuInicial.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTfuncao;
        private System.Windows.Forms.TextBox TXTusuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox MenuBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTNprocesso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}