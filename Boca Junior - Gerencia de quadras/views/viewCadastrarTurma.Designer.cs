namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewCadastrarTurma
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
            this.components = new System.ComponentModel.Container();
            this.cbInstrutorTurma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeriodoTurma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoriaTurma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorTurma = new System.Windows.Forms.ErrorProvider(this.components);
            this.bntAddAluno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBannerCadastroCliente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTurma)).BeginInit();
            this.gbOpcao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInstrutorTurma
            // 
            this.cbInstrutorTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstrutorTurma.FormattingEnabled = true;
            this.cbInstrutorTurma.Location = new System.Drawing.Point(190, 136);
            this.cbInstrutorTurma.Name = "cbInstrutorTurma";
            this.cbInstrutorTurma.Size = new System.Drawing.Size(267, 29);
            this.cbInstrutorTurma.TabIndex = 1;
            this.cbInstrutorTurma.SelectedIndexChanged += new System.EventHandler(this.cbInstrutorTurma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrutor*:";
            // 
            // cbPeriodoTurma
            // 
            this.cbPeriodoTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodoTurma.FormattingEnabled = true;
            this.cbPeriodoTurma.Items.AddRange(new object[] {
            "MANHÃ",
            "TARDE"});
            this.cbPeriodoTurma.Location = new System.Drawing.Point(190, 236);
            this.cbPeriodoTurma.Name = "cbPeriodoTurma";
            this.cbPeriodoTurma.Size = new System.Drawing.Size(267, 29);
            this.cbPeriodoTurma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Periodo*:";
            // 
            // cbCategoriaTurma
            // 
            this.cbCategoriaTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaTurma.FormattingEnabled = true;
            this.cbCategoriaTurma.Items.AddRange(new object[] {
            "MIRIM",
            "JUNIOR"});
            this.cbCategoriaTurma.Location = new System.Drawing.Point(190, 189);
            this.cbCategoriaTurma.Name = "cbCategoriaTurma";
            this.cbCategoriaTurma.Size = new System.Drawing.Size(267, 29);
            this.cbCategoriaTurma.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria*:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_exit_delete_delete_12417;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(539, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "CA&NCELAR/SAIR";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_floppy_12557;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(539, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "&SALVAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(1049, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.txtCodTurma);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cbCategoriaTurma);
            this.groupBox5.Controls.Add(this.cbPeriodoTurma);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cbInstrutorTurma);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtNomeTurma);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(12, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(488, 279);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DADOS:";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(298, 37);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(153, 17);
            this.label31.TabIndex = 25;
            this.label31.Text = "* - Campos Obrigatorios";
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodTurma.Enabled = false;
            this.txtCodTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTurma.Location = new System.Drawing.Point(190, 37);
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.ReadOnly = true;
            this.txtCodTurma.Size = new System.Drawing.Size(102, 25);
            this.txtCodTurma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo da Turma*:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTurma.Location = new System.Drawing.Point(190, 86);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(267, 28);
            this.txtNomeTurma.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome da Turma*:";
            // 
            // errorTurma
            // 
            this.errorTurma.ContainerControl = this;
            // 
            // bntAddAluno
            // 
            this.bntAddAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntAddAluno.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.vermelho18;
            this.bntAddAluno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bntAddAluno.ForeColor = System.Drawing.Color.Transparent;
            this.bntAddAluno.Location = new System.Drawing.Point(17, 31);
            this.bntAddAluno.Name = "bntAddAluno";
            this.bntAddAluno.Size = new System.Drawing.Size(211, 39);
            this.bntAddAluno.TabIndex = 11;
            this.bntAddAluno.Text = "ADICIONAR ALUNO";
            this.bntAddAluno.UseVisualStyleBackColor = false;
            this.bntAddAluno.Click += new System.EventHandler(this.bntAddAluno_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_insert_append_12492;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(17, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "NOVA TURMA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gbOpcao
            // 
            this.gbOpcao.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo1;
            this.gbOpcao.Controls.Add(this.button2);
            this.gbOpcao.Controls.Add(this.bntAddAluno);
            this.gbOpcao.Enabled = false;
            this.gbOpcao.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbOpcao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbOpcao.Location = new System.Drawing.Point(522, 198);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(244, 136);
            this.gbOpcao.TabIndex = 13;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "OPÇÕES";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.panel2.Controls.Add(this.lblBannerCadastroCliente);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 137);
            this.panel2.TabIndex = 24;
            // 
            // lblBannerCadastroCliente
            // 
            this.lblBannerCadastroCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBannerCadastroCliente.AutoSize = true;
            this.lblBannerCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblBannerCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBannerCadastroCliente.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBannerCadastroCliente.Location = new System.Drawing.Point(12, 28);
            this.lblBannerCadastroCliente.Name = "lblBannerCadastroCliente";
            this.lblBannerCadastroCliente.Size = new System.Drawing.Size(548, 78);
            this.lblBannerCadastroCliente.TabIndex = 23;
            this.lblBannerCadastroCliente.Text = "Cadastro de Turma";
            this.lblBannerCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(570, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(517, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 25);
            this.label26.TabIndex = 24;
            this.label26.Text = "USUÁRIO:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOperador.Location = new System.Drawing.Point(520, 177);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(61, 16);
            this.lblOperador.TabIndex = 23;
            this.lblOperador.Text = "Operador";
            // 
            // viewCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(781, 489);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbOpcao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewCadastrarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Turma";
            this.Load += new System.EventHandler(this.viewCadastrarTurma_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTurma)).EndInit();
            this.gbOpcao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ComboBox cbInstrutorTurma;
        public System.Windows.Forms.ComboBox cbPeriodoTurma;
        public System.Windows.Forms.ComboBox cbCategoriaTurma;
        public System.Windows.Forms.TextBox txtNomeTurma;
        public System.Windows.Forms.ErrorProvider errorTurma;
        public System.Windows.Forms.TextBox txtCodTurma;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntAddAluno;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBannerCadastroCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label lblOperador;
    }
}