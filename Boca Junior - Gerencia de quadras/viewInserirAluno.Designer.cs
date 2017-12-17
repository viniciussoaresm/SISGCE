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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRgAluno = new System.Windows.Forms.TextBox();
            this.bntRetirar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdcionarAluno)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtNomeAluno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRgAluno);
            this.groupBox1.Controls.Add(this.bntRetirar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bntIncluirAluno);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(10, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 175);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(341, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Location = new System.Drawing.Point(72, 71);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(286, 20);
            this.txtNomeAluno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome:";
            // 
            // txtRgAluno
            // 
            this.txtRgAluno.Location = new System.Drawing.Point(72, 31);
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.Size = new System.Drawing.Size(254, 20);
            this.txtRgAluno.TabIndex = 3;
            // 
            // bntRetirar
            // 
            this.bntRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bntRetirar.Enabled = false;
            this.bntRetirar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRetirar.ForeColor = System.Drawing.Color.Transparent;
            this.bntRetirar.Location = new System.Drawing.Point(256, 119);
            this.bntRetirar.Name = "bntRetirar";
            this.bntRetirar.Size = new System.Drawing.Size(102, 33);
            this.bntRetirar.TabIndex = 11;
            this.bntRetirar.Text = "Retirar";
            this.bntRetirar.UseVisualStyleBackColor = false;
            this.bntRetirar.Click += new System.EventHandler(this.bntRetirar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "RG:";
            // 
            // bntIncluirAluno
            // 
            this.bntIncluirAluno.BackColor = System.Drawing.Color.DarkGreen;
            this.bntIncluirAluno.Enabled = false;
            this.bntIncluirAluno.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIncluirAluno.ForeColor = System.Drawing.Color.White;
            this.bntIncluirAluno.Location = new System.Drawing.Point(128, 119);
            this.bntIncluirAluno.Name = "bntIncluirAluno";
            this.bntIncluirAluno.Size = new System.Drawing.Size(102, 33);
            this.bntIncluirAluno.TabIndex = 11;
            this.bntIncluirAluno.Text = "Incluir";
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
            this.dgvAdcionarAluno.Location = new System.Drawing.Point(10, 222);
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
            this.dgvAdcionarAluno.Size = new System.Drawing.Size(544, 254);
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
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Perido:";
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblCodTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.ForeColor = System.Drawing.Color.White;
            this.lblCodTurma.Location = new System.Drawing.Point(84, 27);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(13, 16);
            this.lblCodTurma.TabIndex = 19;
            this.lblCodTurma.Text = "-";
            this.lblCodTurma.Click += new System.EventHandler(this.lblCodTurma_Click);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.ForeColor = System.Drawing.Color.White;
            this.lblNomeTurma.Location = new System.Drawing.Point(84, 57);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(13, 16);
            this.lblNomeTurma.TabIndex = 20;
            this.lblNomeTurma.Text = "-";
            // 
            // lblPeriodoTurma
            // 
            this.lblPeriodoTurma.AutoSize = true;
            this.lblPeriodoTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodoTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoTurma.ForeColor = System.Drawing.Color.White;
            this.lblPeriodoTurma.Location = new System.Drawing.Point(84, 88);
            this.lblPeriodoTurma.Name = "lblPeriodoTurma";
            this.lblPeriodoTurma.Size = new System.Drawing.Size(13, 16);
            this.lblPeriodoTurma.TabIndex = 21;
            this.lblPeriodoTurma.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "categoria:";
            // 
            // lblCategoriaTurma
            // 
            this.lblCategoriaTurma.AutoSize = true;
            this.lblCategoriaTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaTurma.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaTurma.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaTurma.Location = new System.Drawing.Point(84, 113);
            this.lblCategoriaTurma.Name = "lblCategoriaTurma";
            this.lblCategoriaTurma.Size = new System.Drawing.Size(13, 16);
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
            this.groupBox2.Location = new System.Drawing.Point(570, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 175);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turma";
            // 
            // viewInserirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(859, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvAdcionarAluno);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewInserirAluno";
            this.Text = "Adicionar Aluno";
            this.Load += new System.EventHandler(this.viewInserirAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdcionarAluno)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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

    }
}