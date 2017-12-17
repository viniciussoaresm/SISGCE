namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewCadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCadastroAluno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.mtbDataNascAluno = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.gbSexoAluno = new System.Windows.Forms.GroupBox();
            this.rbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.rbSexoFeminino = new System.Windows.Forms.RadioButton();
            this.txtRgAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeResponsavelAluno = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbParentescoResponsavel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mtbCpfResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntAdcionarResponsavel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorFormAluno = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.gbSexoAluno.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFormAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.mtbDataNascAluno);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNomeAluno);
            this.groupBox1.Controls.Add(this.gbSexoAluno);
            this.groupBox1.Controls.Add(this.txtRgAluno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS:";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(619, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(153, 17);
            this.label31.TabIndex = 24;
            this.label31.Text = "* - Campos Obrigatorios";
            // 
            // mtbDataNascAluno
            // 
            this.mtbDataNascAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbDataNascAluno.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataNascAluno.Location = new System.Drawing.Point(521, 152);
            this.mtbDataNascAluno.Mask = "00/00/0000";
            this.mtbDataNascAluno.Name = "mtbDataNascAluno";
            this.mtbDataNascAluno.Size = new System.Drawing.Size(251, 29);
            this.mtbDataNascAluno.TabIndex = 2;
            this.mtbDataNascAluno.ValidatingType = typeof(System.DateTime);
            this.mtbDataNascAluno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDataNascCliente_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(717, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(50, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(75, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "*";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAluno.Location = new System.Drawing.Point(13, 55);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(759, 32);
            this.txtNomeAluno.TabIndex = 0;
            // 
            // gbSexoAluno
            // 
            this.gbSexoAluno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSexoAluno.BackColor = System.Drawing.Color.Transparent;
            this.gbSexoAluno.Controls.Add(this.rbSexoMasculino);
            this.gbSexoAluno.Controls.Add(this.rbSexoFeminino);
            this.gbSexoAluno.ForeColor = System.Drawing.Color.White;
            this.gbSexoAluno.Location = new System.Drawing.Point(157, 130);
            this.gbSexoAluno.Name = "gbSexoAluno";
            this.gbSexoAluno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbSexoAluno.Size = new System.Drawing.Size(353, 51);
            this.gbSexoAluno.TabIndex = 3;
            this.gbSexoAluno.TabStop = false;
            this.gbSexoAluno.Text = "Sexo";
            // 
            // rbSexoMasculino
            // 
            this.rbSexoMasculino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSexoMasculino.AutoSize = true;
            this.rbSexoMasculino.Location = new System.Drawing.Point(17, 21);
            this.rbSexoMasculino.Name = "rbSexoMasculino";
            this.rbSexoMasculino.Size = new System.Drawing.Size(125, 29);
            this.rbSexoMasculino.TabIndex = 2;
            this.rbSexoMasculino.TabStop = true;
            this.rbSexoMasculino.Text = "Masculino";
            this.rbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // rbSexoFeminino
            // 
            this.rbSexoFeminino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSexoFeminino.AutoSize = true;
            this.rbSexoFeminino.Location = new System.Drawing.Point(232, 21);
            this.rbSexoFeminino.Name = "rbSexoFeminino";
            this.rbSexoFeminino.Size = new System.Drawing.Size(115, 29);
            this.rbSexoFeminino.TabIndex = 1;
            this.rbSexoFeminino.TabStop = true;
            this.rbSexoFeminino.Text = "Feminino";
            this.rbSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // txtRgAluno
            // 
            this.txtRgAluno.Location = new System.Drawing.Point(13, 148);
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.Size = new System.Drawing.Size(138, 32);
            this.txtRgAluno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(516, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "RG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_floppy_12557;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(823, 613);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 49);
            this.button5.TabIndex = 7;
            this.button5.Text = "&SALVAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_exit_delete_delete_12417;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(824, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 51);
            this.button4.TabIndex = 10;
            this.button4.Text = "CA&NCELAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome(Responsavel):";
            // 
            // txtNomeResponsavelAluno
            // 
            this.txtNomeResponsavelAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeResponsavelAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeResponsavelAluno.Enabled = false;
            this.txtNomeResponsavelAluno.Location = new System.Drawing.Point(13, 134);
            this.txtNomeResponsavelAluno.Name = "txtNomeResponsavelAluno";
            this.txtNomeResponsavelAluno.Size = new System.Drawing.Size(499, 32);
            this.txtNomeResponsavelAluno.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbParentescoResponsavel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.mtbCpfResponsavel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.bntAdcionarResponsavel);
            this.groupBox3.Controls.Add(this.txtNomeResponsavelAluno);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 259);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS DO RESPONSAVEL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(130, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(203, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(185, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "*";
            // 
            // cbParentescoResponsavel
            // 
            this.cbParentescoResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbParentescoResponsavel.Enabled = false;
            this.cbParentescoResponsavel.FormattingEnabled = true;
            this.cbParentescoResponsavel.Items.AddRange(new object[] {
            "PAI",
            "MÃE",
            "IRMÃO",
            "PADRASTO",
            "RESPONSAVEL LEGAL"});
            this.cbParentescoResponsavel.Location = new System.Drawing.Point(15, 212);
            this.cbParentescoResponsavel.Name = "cbParentescoResponsavel";
            this.cbParentescoResponsavel.Size = new System.Drawing.Size(242, 33);
            this.cbParentescoResponsavel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parentesco:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.vermelho18;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(544, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "CADASTRAR CLIENTE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mtbCpfResponsavel
            // 
            this.mtbCpfResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCpfResponsavel.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfResponsavel.Location = new System.Drawing.Point(15, 58);
            this.mtbCpfResponsavel.Mask = "999,999,999-99";
            this.mtbCpfResponsavel.Name = "mtbCpfResponsavel";
            this.mtbCpfResponsavel.Size = new System.Drawing.Size(303, 29);
            this.mtbCpfResponsavel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPF(Responsavel):";
            // 
            // bntAdcionarResponsavel
            // 
            this.bntAdcionarResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAdcionarResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntAdcionarResponsavel.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntAdcionarResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdcionarResponsavel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAdcionarResponsavel.ForeColor = System.Drawing.Color.Transparent;
            this.bntAdcionarResponsavel.Location = new System.Drawing.Point(324, 52);
            this.bntAdcionarResponsavel.Name = "bntAdcionarResponsavel";
            this.bntAdcionarResponsavel.Size = new System.Drawing.Size(198, 38);
            this.bntAdcionarResponsavel.TabIndex = 5;
            this.bntAdcionarResponsavel.Text = "INSERIR CLIENTE";
            this.bntAdcionarResponsavel.UseVisualStyleBackColor = false;
            this.bntAdcionarResponsavel.Click += new System.EventHandler(this.bntAdcionarResponsavel_Click);
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
            this.panel1.Size = new System.Drawing.Size(977, 162);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Candara", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorFormAluno.SetIconAlignment(this.label27, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label27.Location = new System.Drawing.Point(18, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(730, 106);
            this.label27.TabIndex = 23;
            this.label27.Text = "Cadastro de Aluno";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(754, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(820, 197);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 25);
            this.label26.TabIndex = 22;
            this.label26.Text = "USUÁRIO:";
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOperador.Location = new System.Drawing.Point(822, 222);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(71, 18);
            this.lblOperador.TabIndex = 19;
            this.lblOperador.Text = "Operador";
            this.lblOperador.Click += new System.EventHandler(this.lblOperador_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.bluefilefolder_azul_archivo_12582;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(823, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "&RELATÓRIO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorFormAluno
            // 
            this.errorFormAluno.ContainerControl = this;
            // 
            // viewCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1000, 687);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewCadastroAluno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cadastro de aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewCadastroAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSexoAluno.ResumeLayout(false);
            this.gbSexoAluno.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFormAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntAdcionarResponsavel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MaskedTextBox mtbDataNascAluno;
        public System.Windows.Forms.MaskedTextBox mtbCpfResponsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtNomeResponsavelAluno;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbParentescoResponsavel;
        public System.Windows.Forms.ErrorProvider errorFormAluno;
        public System.Windows.Forms.RadioButton rbSexoMasculino;
        public System.Windows.Forms.RadioButton rbSexoFeminino;
        public System.Windows.Forms.GroupBox gbSexoAluno;
        public System.Windows.Forms.TextBox txtNomeAluno;
        public System.Windows.Forms.TextBox txtRgAluno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label31;
    }
}