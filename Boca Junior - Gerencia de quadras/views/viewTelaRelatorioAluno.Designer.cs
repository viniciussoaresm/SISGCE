namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewTelaRelatorioAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewTelaRelatorioAluno));
            this.txtRg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvRelatorioAluno = new System.Windows.Forms.DataGridView();
            this.codAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioAluno)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRg
            // 
            this.txtRg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRg.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(541, 125);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(232, 32);
            this.txtRg.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.Blue_search_find_12583;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "PESQUISAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(11, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(762, 32);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "RG:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlunos.BackColor = System.Drawing.Color.Transparent;
            this.dgvAlunos.Controls.Add(this.button6);
            this.dgvAlunos.Controls.Add(this.cbTurma);
            this.dgvAlunos.Controls.Add(this.txtRg);
            this.dgvAlunos.Controls.Add(this.txtNome);
            this.dgvAlunos.Controls.Add(this.label4);
            this.dgvAlunos.Controls.Add(this.label3);
            this.dgvAlunos.Controls.Add(this.label1);
            this.dgvAlunos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlunos.ForeColor = System.Drawing.Color.White;
            this.dgvAlunos.Location = new System.Drawing.Point(12, 129);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(970, 168);
            this.dgvAlunos.TabIndex = 6;
            this.dgvAlunos.TabStop = false;
            this.dgvAlunos.Text = "FILTROS";
            this.dgvAlunos.Enter += new System.EventHandler(this.dgvAlunos_Enter);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(798, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 60);
            this.button6.TabIndex = 12;
            this.button6.Text = "LIMPAR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbTurma
            // 
            this.cbTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Items.AddRange(new object[] {
            "Todas as Turmas"});
            this.cbTurma.Location = new System.Drawing.Point(11, 124);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(331, 33);
            this.cbTurma.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Turma:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.Excel2_35735;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(263, 669);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 56);
            this.button5.TabIndex = 11;
            this.button5.Text = "EXPORTAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_refuse_remove_delete_12601;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 56);
            this.button2.TabIndex = 14;
            this.button2.Text = "EXCLUIR ALUNO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvRelatorioAluno
            // 
            this.dgvRelatorioAluno.AllowUserToAddRows = false;
            this.dgvRelatorioAluno.AllowUserToDeleteRows = false;
            this.dgvRelatorioAluno.AllowUserToResizeColumns = false;
            this.dgvRelatorioAluno.AllowUserToResizeRows = false;
            this.dgvRelatorioAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelatorioAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRelatorioAluno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRelatorioAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAluno,
            this.nome,
            this.rg,
            this.idade,
            this.dataNascimento,
            this.codTurma,
            this.nomeTurma});
            this.dgvRelatorioAluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRelatorioAluno.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvRelatorioAluno.Location = new System.Drawing.Point(12, 350);
            this.dgvRelatorioAluno.MultiSelect = false;
            this.dgvRelatorioAluno.Name = "dgvRelatorioAluno";
            this.dgvRelatorioAluno.ReadOnly = true;
            this.dgvRelatorioAluno.RowHeadersVisible = false;
            this.dgvRelatorioAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRelatorioAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorioAluno.ShowCellErrors = false;
            this.dgvRelatorioAluno.ShowCellToolTips = false;
            this.dgvRelatorioAluno.ShowEditingIcon = false;
            this.dgvRelatorioAluno.ShowRowErrors = false;
            this.dgvRelatorioAluno.Size = new System.Drawing.Size(970, 294);
            this.dgvRelatorioAluno.TabIndex = 16;
            this.dgvRelatorioAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorioAluno_CellContentClick);
            this.dgvRelatorioAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorioAluno_CellDoubleClick);
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
            this.codTurma.HeaderText = "Turma";
            this.codTurma.Name = "codTurma";
            this.codTurma.ReadOnly = true;
            this.codTurma.Visible = false;
            // 
            // nomeTurma
            // 
            this.nomeTurma.HeaderText = "Turma";
            this.nomeTurma.Name = "nomeTurma";
            this.nomeTurma.ReadOnly = true;
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
            this.button3.Location = new System.Drawing.Point(840, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 48);
            this.button3.TabIndex = 32;
            this.button3.Text = "HOME";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 116);
            this.panel1.TabIndex = 33;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Candara", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label27.Location = new System.Drawing.Point(9, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(725, 82);
            this.label27.TabIndex = 23;
            this.label27.Text = "RELATÓRIO DE ALUNOS";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(813, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // viewTelaRelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(994, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvRelatorioAluno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewTelaRelatorioAluno";
            this.Text = "Relatorio de aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewTelaRelatorioAluno_Load);
            this.dgvAlunos.ResumeLayout(false);
            this.dgvAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioAluno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dgvAlunos;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvRelatorioAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTurma;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox1;
       
    }
}