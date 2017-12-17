namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewRelatorioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewRelatorioCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntSalvarListaCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtClienteCPF = new System.Windows.Forms.TextBox();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntClientePesquisa = new System.Windows.Forms.Button();
            this.dgvClienteRelatorio = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntClienteExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteRelatorio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSalvarListaCliente
            // 
            this.bntSalvarListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntSalvarListaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntSalvarListaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntSalvarListaCliente.BackgroundImage")));
            this.bntSalvarListaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvarListaCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvarListaCliente.ForeColor = System.Drawing.Color.Transparent;
            this.bntSalvarListaCliente.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.Excel2_35735;
            this.bntSalvarListaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSalvarListaCliente.Location = new System.Drawing.Point(270, 554);
            this.bntSalvarListaCliente.Name = "bntSalvarListaCliente";
            this.bntSalvarListaCliente.Size = new System.Drawing.Size(176, 50);
            this.bntSalvarListaCliente.TabIndex = 15;
            this.bntSalvarListaCliente.Text = "EXPORTAR";
            this.bntSalvarListaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSalvarListaCliente.UseVisualStyleBackColor = false;
            this.bntSalvarListaCliente.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtClienteCPF);
            this.groupBox3.Controls.Add(this.txtClienteNome);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 87);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILTROS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button1.Location = new System.Drawing.Point(702, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtClienteCPF
            // 
            this.txtClienteCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteCPF.Location = new System.Drawing.Point(447, 45);
            this.txtClienteCPF.Name = "txtClienteCPF";
            this.txtClienteCPF.Size = new System.Drawing.Size(234, 29);
            this.txtClienteCPF.TabIndex = 1;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNome.Location = new System.Drawing.Point(10, 46);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(404, 29);
            this.txtClienteNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // bntClientePesquisa
            // 
            this.bntClientePesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntClientePesquisa.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntClientePesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClientePesquisa.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClientePesquisa.ForeColor = System.Drawing.Color.Transparent;
            this.bntClientePesquisa.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.Blue_search_find_12583;
            this.bntClientePesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntClientePesquisa.Location = new System.Drawing.Point(12, 220);
            this.bntClientePesquisa.Name = "bntClientePesquisa";
            this.bntClientePesquisa.Size = new System.Drawing.Size(172, 41);
            this.bntClientePesquisa.TabIndex = 13;
            this.bntClientePesquisa.Text = "PESQUISAR";
            this.bntClientePesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntClientePesquisa.UseVisualStyleBackColor = false;
            this.bntClientePesquisa.Click += new System.EventHandler(this.bntCliente_Click);
            // 
            // dgvClienteRelatorio
            // 
            this.dgvClienteRelatorio.AllowUserToAddRows = false;
            this.dgvClienteRelatorio.AllowUserToDeleteRows = false;
            this.dgvClienteRelatorio.AllowUserToResizeColumns = false;
            this.dgvClienteRelatorio.AllowUserToResizeRows = false;
            this.dgvClienteRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClienteRelatorio.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClienteRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClienteRelatorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nome_cliente,
            this.cpf_cliente,
            this.telefone_cliente,
            this.celular_cliente,
            this.dataNascCliente});
            this.dgvClienteRelatorio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClienteRelatorio.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvClienteRelatorio.Location = new System.Drawing.Point(12, 267);
            this.dgvClienteRelatorio.MultiSelect = false;
            this.dgvClienteRelatorio.Name = "dgvClienteRelatorio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteRelatorio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClienteRelatorio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClienteRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClienteRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteRelatorio.ShowCellErrors = false;
            this.dgvClienteRelatorio.ShowCellToolTips = false;
            this.dgvClienteRelatorio.ShowEditingIcon = false;
            this.dgvClienteRelatorio.ShowRowErrors = false;
            this.dgvClienteRelatorio.Size = new System.Drawing.Size(846, 281);
            this.dgvClienteRelatorio.TabIndex = 13;
            this.dgvClienteRelatorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteRelatorio_CellContentClick);
            this.dgvClienteRelatorio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteRelatorio_CellDoubleClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.MaxInputLength = 20;
            this.idCliente.Name = "idCliente";
            this.idCliente.Visible = false;
            // 
            // nome_cliente
            // 
            this.nome_cliente.HeaderText = "Nome";
            this.nome_cliente.MaxInputLength = 8000;
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.Width = 300;
            // 
            // cpf_cliente
            // 
            this.cpf_cliente.HeaderText = "CPF";
            this.cpf_cliente.Name = "cpf_cliente";
            this.cpf_cliente.Width = 150;
            // 
            // telefone_cliente
            // 
            this.telefone_cliente.HeaderText = "Telefone";
            this.telefone_cliente.Name = "telefone_cliente";
            this.telefone_cliente.Width = 110;
            // 
            // celular_cliente
            // 
            this.celular_cliente.HeaderText = "Celular";
            this.celular_cliente.Name = "celular_cliente";
            this.celular_cliente.Width = 110;
            // 
            // dataNascCliente
            // 
            this.dataNascCliente.HeaderText = "Data de Nascimento";
            this.dataNascCliente.Name = "dataNascCliente";
            // 
            // bntClienteExcluir
            // 
            this.bntClienteExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntClienteExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntClienteExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntClienteExcluir.BackgroundImage")));
            this.bntClienteExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClienteExcluir.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClienteExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.bntClienteExcluir.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_refuse_remove_delete_12601;
            this.bntClienteExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntClienteExcluir.Location = new System.Drawing.Point(12, 554);
            this.bntClienteExcluir.Name = "bntClienteExcluir";
            this.bntClienteExcluir.Size = new System.Drawing.Size(237, 50);
            this.bntClienteExcluir.TabIndex = 16;
            this.bntClienteExcluir.Text = "EXCLUIR CLIENTE";
            this.bntClienteExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntClienteExcluir.UseVisualStyleBackColor = false;
            this.bntClienteExcluir.Click += new System.EventHandler(this.bntClienteExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 116);
            this.panel1.TabIndex = 22;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Candara", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label27.Location = new System.Drawing.Point(3, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(684, 90);
            this.label27.TabIndex = 23;
            this.label27.Text = "Relatório de Clientes";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(692, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.button3.Location = new System.Drawing.Point(716, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 48);
            this.button3.TabIndex = 31;
            this.button3.Text = "HOME";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewRelatorioCliente
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(862, 612);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntClientePesquisa);
            this.Controls.Add(this.bntClienteExcluir);
            this.Controls.Add(this.bntSalvarListaCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvClienteRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewRelatorioCliente";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewRelatorioCliente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteRelatorio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSalvarListaCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntClientePesquisa;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClienteRelatorio;
        private System.Windows.Forms.TextBox txtClienteCPF;
        private System.Windows.Forms.Button bntClienteExcluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}