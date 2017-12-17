namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewInserirAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewInserirAluno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRgAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntRetirar = new System.Windows.Forms.Button();
            this.bntIncluirAluno = new System.Windows.Forms.Button();
            this.dgvAdcionarAluno = new System.Windows.Forms.DataGridView();
            this.codAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.lblPeriodoTurma = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCategoriaTurma = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBannerInstrutor = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdcionarAluno)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtNomeAluno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRgAluno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 136);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALUNO:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.Blue_search_find_12583;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(445, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 58);
            this.button5.TabIndex = 12;
            this.button5.Text = "PESQUISAR ALUNO";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(86, 80);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(286, 29);
            this.txtNomeAluno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome:";
            // 
            // txtRgAluno
            // 
            this.txtRgAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgAluno.Location = new System.Drawing.Point(56, 32);
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.Size = new System.Drawing.Size(316, 29);
            this.txtRgAluno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "RG:";
            // 
            // bntRetirar
            // 
            this.bntRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntRetirar.Enabled = false;
            this.bntRetirar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.bntRetirar.ForeColor = System.Drawing.Color.Transparent;
            this.bntRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntRetirar.Location = new System.Drawing.Point(458, 320);
            this.bntRetirar.Name = "bntRetirar";
            this.bntRetirar.Size = new System.Drawing.Size(175, 33);
            this.bntRetirar.TabIndex = 11;
            this.bntRetirar.Text = "RETIRAR ALUNO";
            this.bntRetirar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntRetirar.UseVisualStyleBackColor = false;
            this.bntRetirar.Click += new System.EventHandler(this.bntRetirar_Click);
            // 
            // bntIncluirAluno
            // 
            this.bntIncluirAluno.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.FUNDO_VERDE1;
            this.bntIncluirAluno.Enabled = false;
            this.bntIncluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntIncluirAluno.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.bntIncluirAluno.ForeColor = System.Drawing.Color.White;
            this.bntIncluirAluno.Location = new System.Drawing.Point(14, 320);
            this.bntIncluirAluno.Name = "bntIncluirAluno";
            this.bntIncluirAluno.Size = new System.Drawing.Size(174, 33);
            this.bntIncluirAluno.TabIndex = 11;
            this.bntIncluirAluno.Text = "INCLUIR ALUNO";
            this.bntIncluirAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntIncluirAluno.UseVisualStyleBackColor = false;
            this.bntIncluirAluno.Click += new System.EventHandler(this.bntIncluirAluno_Click);
            // 
            // dgvAdcionarAluno
            // 
            this.dgvAdcionarAluno.AllowUserToAddRows = false;
            this.dgvAdcionarAluno.AllowUserToDeleteRows = false;
            this.dgvAdcionarAluno.AllowUserToResizeColumns = false;
            this.dgvAdcionarAluno.AllowUserToResizeRows = false;
            this.dgvAdcionarAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdcionarAluno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAdcionarAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdcionarAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAluno,
            this.nome,
            this.rg,
            this.idade,
            this.dataNascimento,
            this.codTurma});
            this.dgvAdcionarAluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdcionarAluno.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvAdcionarAluno.Location = new System.Drawing.Point(14, 386);
            this.dgvAdcionarAluno.MultiSelect = false;
            this.dgvAdcionarAluno.Name = "dgvAdcionarAluno";
            this.dgvAdcionarAluno.ReadOnly = true;
            this.dgvAdcionarAluno.RowHeadersVisible = false;
            this.dgvAdcionarAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAdcionarAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdcionarAluno.ShowCellErrors = false;
            this.dgvAdcionarAluno.ShowCellToolTips = false;
            this.dgvAdcionarAluno.ShowEditingIcon = false;
            this.dgvAdcionarAluno.ShowRowErrors = false;
            this.dgvAdcionarAluno.Size = new System.Drawing.Size(619, 226);
            this.dgvAdcionarAluno.TabIndex = 15;
            this.dgvAdcionarAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdcionarAluno_CellContentClick);
            this.dgvAdcionarAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdcionarAluno_CellDoubleClick);
            // 
            // codAluno
            // 
            this.codAluno.FillWeight = 1000F;
            this.codAluno.HeaderText = "codAluno";
            this.codAluno.MaxInputLength = 600;
            this.codAluno.Name = "codAluno";
            this.codAluno.ReadOnly = true;
            this.codAluno.Visible = false;
            this.codAluno.Width = 1000;
            // 
            // nome
            // 
            this.nome.FillWeight = 200F;
            this.nome.HeaderText = "Nome";
            this.nome.MaxInputLength = 50000;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            // 
            // dataNascimento
            // 
            this.dataNascimento.HeaderText = "Data de Nascimento";
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            // 
            // codTurma
            // 
            this.codTurma.HeaderText = "turma";
            this.codTurma.Name = "codTurma";
            this.codTurma.ReadOnly = true;
            this.codTurma.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "PERÍODO:";
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblCodTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.ForeColor = System.Drawing.Color.White;
            this.lblCodTurma.Location = new System.Drawing.Point(7, 74);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(15, 19);
            this.lblCodTurma.TabIndex = 19;
            this.lblCodTurma.Text = "-";
            this.lblCodTurma.Click += new System.EventHandler(this.lblCodTurma_Click);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.ForeColor = System.Drawing.Color.White;
            this.lblNomeTurma.Location = new System.Drawing.Point(7, 143);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(15, 19);
            this.lblNomeTurma.TabIndex = 20;
            this.lblNomeTurma.Text = "-";
            // 
            // lblPeriodoTurma
            // 
            this.lblPeriodoTurma.AutoSize = true;
            this.lblPeriodoTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodoTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoTurma.ForeColor = System.Drawing.Color.White;
            this.lblPeriodoTurma.Location = new System.Drawing.Point(7, 202);
            this.lblPeriodoTurma.Name = "lblPeriodoTurma";
            this.lblPeriodoTurma.Size = new System.Drawing.Size(15, 19);
            this.lblPeriodoTurma.TabIndex = 21;
            this.lblPeriodoTurma.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "CATEGORIA:";
            // 
            // lblCategoriaTurma
            // 
            this.lblCategoriaTurma.AutoSize = true;
            this.lblCategoriaTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaTurma.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaTurma.Location = new System.Drawing.Point(7, 269);
            this.lblCategoriaTurma.Name = "lblCategoriaTurma";
            this.lblCategoriaTurma.Size = new System.Drawing.Size(15, 19);
            this.lblCategoriaTurma.TabIndex = 23;
            this.lblCategoriaTurma.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCategoriaTurma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblPeriodoTurma);
            this.groupBox2.Controls.Add(this.lblCodTurma);
            this.groupBox2.Controls.Add(this.lblNomeTurma);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(653, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 309);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TURMA SELECIONADA:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblBannerInstrutor);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 151);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(682, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lblBannerInstrutor
            // 
            this.lblBannerInstrutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBannerInstrutor.AutoSize = true;
            this.lblBannerInstrutor.BackColor = System.Drawing.Color.Transparent;
            this.lblBannerInstrutor.Font = new System.Drawing.Font("Candara", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerInstrutor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBannerInstrutor.Location = new System.Drawing.Point(10, 32);
            this.lblBannerInstrutor.Name = "lblBannerInstrutor";
            this.lblBannerInstrutor.Size = new System.Drawing.Size(535, 90);
            this.lblBannerInstrutor.TabIndex = 23;
            this.lblBannerInstrutor.Text = "INSERIR ALUNO";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(651, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 25);
            this.label26.TabIndex = 26;
            this.label26.Text = "USUÁRIO:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOperador.Location = new System.Drawing.Point(654, 204);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(61, 16);
            this.lblOperador.TabIndex = 25;
            this.lblOperador.Text = "Operador";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_home_house_12608;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(653, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 48);
            this.button3.TabIndex = 31;
            this.button3.Text = "HOME";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewInserirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(910, 618);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvAdcionarAluno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntIncluirAluno);
            this.Controls.Add(this.bntRetirar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewInserirAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Aluno";
            this.Load += new System.EventHandler(this.viewInserirAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdcionarAluno)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


       

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRgAluno;
        private System.Windows.Forms.Button bntRetirar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntIncluirAluno;
        public System.Windows.Forms.DataGridView dgvAdcionarAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblCodTurma;
        public System.Windows.Forms.Label lblNomeTurma;
        public System.Windows.Forms.Label lblPeriodoTurma;
        public System.Windows.Forms.Label lblCategoriaTurma;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTurma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBannerInstrutor;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button button3;

    }
}