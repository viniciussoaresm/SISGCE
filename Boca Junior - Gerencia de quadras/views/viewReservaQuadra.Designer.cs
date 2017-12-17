namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewReservaQuadra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntExcluirReserva = new System.Windows.Forms.Button();
            this.gbAdicionar = new System.Windows.Forms.GroupBox();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.dtpHorarioSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbQuadraReserva = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntAdcionarHorario = new System.Windows.Forms.Button();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReservaNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntPesquisa = new System.Windows.Forms.Button();
            this.txtReservaCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntContrato = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.codReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quadra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAdicionar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntExcluirReserva
            // 
            this.bntExcluirReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntExcluirReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExcluirReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.bntExcluirReserva.ForeColor = System.Drawing.Color.White;
            this.bntExcluirReserva.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.vermelho18;
            this.bntExcluirReserva.Location = new System.Drawing.Point(413, 306);
            this.bntExcluirReserva.Name = "bntExcluirReserva";
            this.bntExcluirReserva.Size = new System.Drawing.Size(198, 51);
            this.bntExcluirReserva.TabIndex = 14;
            this.bntExcluirReserva.Text = "EXCLUIR RESERVA";
            this.bntExcluirReserva.UseVisualStyleBackColor = false;
            this.bntExcluirReserva.Click += new System.EventHandler(this.button5_Click);
            // 
            // gbAdicionar
            // 
            this.gbAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.gbAdicionar.Controls.Add(this.dtpHorarioSaida);
            this.gbAdicionar.Controls.Add(this.dtpHorarioEntrada);
            this.gbAdicionar.Controls.Add(this.label5);
            this.gbAdicionar.Controls.Add(this.cbQuadraReserva);
            this.gbAdicionar.Controls.Add(this.label4);
            this.gbAdicionar.Controls.Add(this.bntAdcionarHorario);
            this.gbAdicionar.Controls.Add(this.dtpDataReserva);
            this.gbAdicionar.Controls.Add(this.label3);
            this.gbAdicionar.Controls.Add(this.label2);
            this.gbAdicionar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.gbAdicionar.ForeColor = System.Drawing.Color.White;
            this.gbAdicionar.Location = new System.Drawing.Point(743, 237);
            this.gbAdicionar.Name = "gbAdicionar";
            this.gbAdicionar.Size = new System.Drawing.Size(430, 289);
            this.gbAdicionar.TabIndex = 13;
            this.gbAdicionar.TabStop = false;
            this.gbAdicionar.Text = "ADICIONAR:";
            this.gbAdicionar.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // bntAlterar
            // 
            this.bntAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntAlterar.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAlterar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.bntAlterar.ForeColor = System.Drawing.Color.Transparent;
            this.bntAlterar.Location = new System.Drawing.Point(217, 306);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(188, 51);
            this.bntAlterar.TabIndex = 31;
            this.bntAlterar.Text = "ALTERAR HORA";
            this.bntAlterar.UseVisualStyleBackColor = false;
            this.bntAlterar.Click += new System.EventHandler(this.bntAlterar_Click);
            // 
            // dtpHorarioSaida
            // 
            this.dtpHorarioSaida.CustomFormat = "HH:mm";
            this.dtpHorarioSaida.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.dtpHorarioSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioSaida.Location = new System.Drawing.Point(194, 75);
            this.dtpHorarioSaida.Name = "dtpHorarioSaida";
            this.dtpHorarioSaida.ShowUpDown = true;
            this.dtpHorarioSaida.Size = new System.Drawing.Size(81, 32);
            this.dtpHorarioSaida.TabIndex = 30;
            // 
            // dtpHorarioEntrada
            // 
            this.dtpHorarioEntrada.CustomFormat = "HH:mm";
            this.dtpHorarioEntrada.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.dtpHorarioEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioEntrada.Location = new System.Drawing.Point(194, 22);
            this.dtpHorarioEntrada.Name = "dtpHorarioEntrada";
            this.dtpHorarioEntrada.ShowUpDown = true;
            this.dtpHorarioEntrada.Size = new System.Drawing.Size(81, 32);
            this.dtpHorarioEntrada.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Horario Saida*:";
            // 
            // cbQuadraReserva
            // 
            this.cbQuadraReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.cbQuadraReserva.FormattingEnabled = true;
            this.cbQuadraReserva.Items.AddRange(new object[] {
            "QUADRA 1",
            "QUADRA 2",
            "QUADRA ARREIA"});
            this.cbQuadraReserva.Location = new System.Drawing.Point(212, 179);
            this.cbQuadraReserva.Name = "cbQuadraReserva";
            this.cbQuadraReserva.Size = new System.Drawing.Size(134, 33);
            this.cbQuadraReserva.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Selecione a quadra*:";
            // 
            // bntAdcionarHorario
            // 
            this.bntAdcionarHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntAdcionarHorario.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.FUNDO_VERDE1;
            this.bntAdcionarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdcionarHorario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAdcionarHorario.ForeColor = System.Drawing.Color.White;
            this.bntAdcionarHorario.Location = new System.Drawing.Point(6, 239);
            this.bntAdcionarHorario.Name = "bntAdcionarHorario";
            this.bntAdcionarHorario.Size = new System.Drawing.Size(192, 35);
            this.bntAdcionarHorario.TabIndex = 25;
            this.bntAdcionarHorario.Text = "ADICIONAR HORARIO";
            this.bntAdcionarHorario.UseVisualStyleBackColor = false;
            this.bntAdcionarHorario.Click += new System.EventHandler(this.bntAdcionarHorario_Click);
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.dtpDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReserva.Location = new System.Drawing.Point(194, 125);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(152, 32);
            this.dtpDataReserva.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selecione a data*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Horario Entrada*:";
            // 
            // txtReservaNome
            // 
            this.txtReservaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservaNome.Enabled = false;
            this.txtReservaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservaNome.Location = new System.Drawing.Point(85, 70);
            this.txtReservaNome.Name = "txtReservaNome";
            this.txtReservaNome.Size = new System.Drawing.Size(343, 22);
            this.txtReservaNome.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bntPesquisa);
            this.groupBox1.Controls.Add(this.txtReservaNome);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtReservaCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 515);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE:";
            // 
            // bntPesquisa
            // 
            this.bntPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntPesquisa.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPesquisa.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.bntPesquisa.ForeColor = System.Drawing.Color.White;
            this.bntPesquisa.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.Blue_search_find_12583;
            this.bntPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPesquisa.Location = new System.Drawing.Point(529, 30);
            this.bntPesquisa.Name = "bntPesquisa";
            this.bntPesquisa.Size = new System.Drawing.Size(179, 66);
            this.bntPesquisa.TabIndex = 15;
            this.bntPesquisa.Text = "PESQUISAR CLIENTE";
            this.bntPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPesquisa.UseVisualStyleBackColor = false;
            this.bntPesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReservaCPF
            // 
            this.txtReservaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservaCPF.Location = new System.Drawing.Point(180, 30);
            this.txtReservaCPF.Name = "txtReservaCPF";
            this.txtReservaCPF.Size = new System.Drawing.Size(248, 29);
            this.txtReservaCPF.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF DO CLIENTE*:";
            // 
            // bntContrato
            // 
            this.bntContrato.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntContrato.ForeColor = System.Drawing.Color.White;
            this.bntContrato.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.bluepaper_azu_12590;
            this.bntContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntContrato.Location = new System.Drawing.Point(17, 306);
            this.bntContrato.Name = "bntContrato";
            this.bntContrato.Size = new System.Drawing.Size(182, 51);
            this.bntContrato.TabIndex = 16;
            this.bntContrato.Text = "CONTRATO";
            this.bntContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntContrato.UseVisualStyleBackColor = true;
            this.bntContrato.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.bntAlterar);
            this.groupBox3.Controls.Add(this.bntExcluirReserva);
            this.groupBox3.Controls.Add(this.bntContrato);
            this.groupBox3.Controls.Add(this.dgvReservas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(23, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 367);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESERVAS:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToResizeColumns = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codReserva,
            this.codCliente,
            this.quadra,
            this.data,
            this.HorarioEntrada,
            this.HorarioSaida});
            this.dgvReservas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReservas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvReservas.Location = new System.Drawing.Point(17, 26);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            this.dgvReservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.ShowCellErrors = false;
            this.dgvReservas.ShowCellToolTips = false;
            this.dgvReservas.ShowEditingIcon = false;
            this.dgvReservas.ShowRowErrors = false;
            this.dgvReservas.Size = new System.Drawing.Size(594, 274);
            this.dgvReservas.TabIndex = 15;
            this.dgvReservas.TabStop = false;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 116);
            this.panel1.TabIndex = 30;
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
            this.label27.Size = new System.Drawing.Size(699, 82);
            this.label27.TabIndex = 23;
            this.label27.Text = "RESERVA DE QUADRAS";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1031, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(737, 160);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 25);
            this.label26.TabIndex = 32;
            this.label26.Text = "USUÁRIO:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOperador.Location = new System.Drawing.Point(740, 185);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(61, 16);
            this.lblOperador.TabIndex = 31;
            this.lblOperador.Text = "Operador";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_home_house_12608;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.Location = new System.Drawing.Point(1039, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 49);
            this.button6.TabIndex = 17;
            this.button6.Text = "HOME";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // codReserva
            // 
            this.codReserva.HeaderText = "codReserva";
            this.codReserva.Name = "codReserva";
            this.codReserva.ReadOnly = true;
            this.codReserva.Visible = false;
            // 
            // codCliente
            // 
            this.codCliente.HeaderText = "codCliente";
            this.codCliente.Name = "codCliente";
            this.codCliente.ReadOnly = true;
            this.codCliente.Visible = false;
            // 
            // quadra
            // 
            this.quadra.HeaderText = "Quadra";
            this.quadra.Name = "quadra";
            this.quadra.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 189;
            // 
            // HorarioEntrada
            // 
            this.HorarioEntrada.HeaderText = "Horario de Entrada";
            this.HorarioEntrada.Name = "HorarioEntrada";
            this.HorarioEntrada.ReadOnly = true;
            this.HorarioEntrada.Width = 150;
            // 
            // HorarioSaida
            // 
            this.HorarioSaida.HeaderText = "Horairio de Saida";
            this.HorarioSaida.Name = "HorarioSaida";
            this.HorarioSaida.ReadOnly = true;
            this.HorarioSaida.Width = 150;
            // 
            // viewReservaQuadra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1212, 673);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.gbAdicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewReservaQuadra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Quadra";
            this.Load += new System.EventHandler(this.viewReservaQuadra_Load);
            this.gbAdicionar.ResumeLayout(false);
            this.gbAdicionar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntExcluirReserva;
        private System.Windows.Forms.GroupBox gbAdicionar;
        private System.Windows.Forms.TextBox txtReservaNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReservaCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntPesquisa;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button bntContrato;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DateTimePicker dtpHorarioSaida;
        private System.Windows.Forms.DateTimePicker dtpHorarioEntrada;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbQuadraReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntAdcionarHorario;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn quadra;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioSaida;
    }
}