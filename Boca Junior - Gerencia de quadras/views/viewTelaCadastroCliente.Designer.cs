using System.Windows.Forms;
namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewTelaCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewTelaCadastroCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtRgCliente = new System.Windows.Forms.TextBox();
            this.mtbDataNascCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneClienteOp = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbSexoClienteF = new System.Windows.Forms.RadioButton();
            this.rbSexoClienteM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.bntLoadEndereco = new System.Windows.Forms.Button();
            this.cbUfCliente = new System.Windows.Forms.ComboBox();
            this.cbCidadeEnderecoCliente = new System.Windows.Forms.ComboBox();
            this.mtbCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClienteComple = new System.Windows.Forms.TextBox();
            this.txtClienteNumero = new System.Windows.Forms.TextBox();
            this.txtClienteRua = new System.Windows.Forms.TextBox();
            this.bntSalvarCliente = new System.Windows.Forms.Button();
            this.bntClienteCancelar = new System.Windows.Forms.Button();
            this.erroFrmCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBannerCadastroCliente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroFrmCliente)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.txtRgCliente);
            this.groupBox1.Controls.Add(this.mtbDataNascCliente);
            this.groupBox1.Controls.Add(this.mtbCpfCliente);
            this.groupBox1.Controls.Add(this.mtbTelefoneClienteOp);
            this.groupBox1.Controls.Add(this.mtbTelefoneCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtClienteNome);
            this.groupBox1.Controls.Add(this.gbSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 257);
            this.groupBox1.TabIndex = 2;
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
            this.label31.Location = new System.Drawing.Point(644, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(153, 17);
            this.label31.TabIndex = 23;
            this.label31.Text = "* - Campos Obrigatorios";
            // 
            // txtRgCliente
            // 
            this.txtRgCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgCliente.Location = new System.Drawing.Point(17, 136);
            this.txtRgCliente.Name = "txtRgCliente";
            this.txtRgCliente.Size = new System.Drawing.Size(153, 32);
            this.txtRgCliente.TabIndex = 2;
            // 
            // mtbDataNascCliente
            // 
            this.mtbDataNascCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbDataNascCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataNascCliente.Location = new System.Drawing.Point(559, 136);
            this.mtbDataNascCliente.Mask = "00/00/0000";
            this.mtbDataNascCliente.Name = "mtbDataNascCliente";
            this.mtbDataNascCliente.Size = new System.Drawing.Size(181, 32);
            this.mtbDataNascCliente.TabIndex = 4;
            this.mtbDataNascCliente.ValidatingType = typeof(System.DateTime);
            // 
            // mtbCpfCliente
            // 
            this.mtbCpfCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbCpfCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfCliente.Location = new System.Drawing.Point(271, 136);
            this.mtbCpfCliente.Mask = "999,999,999-99";
            this.mtbCpfCliente.Name = "mtbCpfCliente";
            this.mtbCpfCliente.Size = new System.Drawing.Size(183, 32);
            this.mtbCpfCliente.TabIndex = 3;
            this.mtbCpfCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCpfCliente_MaskInputRejected);
            // 
            // mtbTelefoneClienteOp
            // 
            this.mtbTelefoneClienteOp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbTelefoneClienteOp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneClienteOp.Location = new System.Drawing.Point(250, 211);
            this.mtbTelefoneClienteOp.Mask = "(99) 0000-0000";
            this.mtbTelefoneClienteOp.Name = "mtbTelefoneClienteOp";
            this.mtbTelefoneClienteOp.Size = new System.Drawing.Size(140, 32);
            this.mtbTelefoneClienteOp.TabIndex = 6;
            // 
            // mtbTelefoneCliente
            // 
            this.mtbTelefoneCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneCliente.Location = new System.Drawing.Point(19, 211);
            this.mtbTelefoneCliente.Mask = "(99) 00000-0000";
            this.mtbTelefoneCliente.Name = "mtbTelefoneCliente";
            this.mtbTelefoneCliente.Size = new System.Drawing.Size(140, 32);
            this.mtbTelefoneCliente.TabIndex = 5;
            this.mtbTelefoneCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefoneCliente_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone 1*:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(245, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Telefone 2:";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNome.Location = new System.Drawing.Point(17, 64);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(723, 32);
            this.txtClienteNome.TabIndex = 1;
            this.txtClienteNome.TextChanged += new System.EventHandler(this.txtClienteNome_TextChanged);
            // 
            // gbSexo
            // 
            this.gbSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSexo.BackColor = System.Drawing.Color.Transparent;
            this.gbSexo.Controls.Add(this.rbSexoClienteF);
            this.gbSexo.Controls.Add(this.rbSexoClienteM);
            this.gbSexo.ForeColor = System.Drawing.Color.White;
            this.gbSexo.Location = new System.Drawing.Point(478, 191);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(262, 52);
            this.gbSexo.TabIndex = 7;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo*:";
            this.gbSexo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbSexoClienteF
            // 
            this.rbSexoClienteF.AutoSize = true;
            this.rbSexoClienteF.Location = new System.Drawing.Point(148, 19);
            this.rbSexoClienteF.Name = "rbSexoClienteF";
            this.rbSexoClienteF.Size = new System.Drawing.Size(108, 28);
            this.rbSexoClienteF.TabIndex = 1;
            this.rbSexoClienteF.TabStop = true;
            this.rbSexoClienteF.Text = "Feminino";
            this.rbSexoClienteF.UseVisualStyleBackColor = true;
            // 
            // rbSexoClienteM
            // 
            this.rbSexoClienteM.AutoSize = true;
            this.rbSexoClienteM.Location = new System.Drawing.Point(17, 19);
            this.rbSexoClienteM.Name = "rbSexoClienteM";
            this.rbSexoClienteM.Size = new System.Drawing.Size(114, 28);
            this.rbSexoClienteM.TabIndex = 2;
            this.rbSexoClienteM.TabStop = true;
            this.rbSexoClienteM.Text = "Masculino";
            this.rbSexoClienteM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(266, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF*:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(526, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de Nascimento*:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "RG*:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbBairro);
            this.groupBox3.Controls.Add(this.bntLoadEndereco);
            this.groupBox3.Controls.Add(this.cbUfCliente);
            this.groupBox3.Controls.Add(this.cbCidadeEnderecoCliente);
            this.groupBox3.Controls.Add(this.mtbCepCliente);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblBairro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtClienteComple);
            this.groupBox3.Controls.Add(this.txtClienteNumero);
            this.groupBox3.Controls.Add(this.txtClienteRua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 238);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ENDEREÇO:";
            // 
            // cbBairro
            // 
            this.cbBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBairro.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Location = new System.Drawing.Point(420, 90);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(320, 33);
            this.cbBairro.TabIndex = 10;
            this.cbBairro.SelectedIndexChanged += new System.EventHandler(this.cbBairro_SelectedIndexChanged);
            // 
            // bntLoadEndereco
            // 
            this.bntLoadEndereco.BackColor = System.Drawing.Color.White;
            this.bntLoadEndereco.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntLoadEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLoadEndereco.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLoadEndereco.ForeColor = System.Drawing.Color.Transparent;
            this.bntLoadEndereco.Location = new System.Drawing.Point(199, 28);
            this.bntLoadEndereco.Name = "bntLoadEndereco";
            this.bntLoadEndereco.Size = new System.Drawing.Size(203, 31);
            this.bntLoadEndereco.TabIndex = 32;
            this.bntLoadEndereco.Text = "CARREGAR ENDEREÇO";
            this.bntLoadEndereco.UseVisualStyleBackColor = false;
            this.bntLoadEndereco.Click += new System.EventHandler(this.bntLoadEndereco_Click);
            // 
            // cbUfCliente
            // 
            this.cbUfCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUfCliente.FormattingEnabled = true;
            this.cbUfCliente.Location = new System.Drawing.Point(14, 90);
            this.cbUfCliente.Name = "cbUfCliente";
            this.cbUfCliente.Size = new System.Drawing.Size(80, 33);
            this.cbUfCliente.TabIndex = 8;
            this.cbUfCliente.SelectedIndexChanged += new System.EventHandler(this.cbUfCliente_SelectedIndexChanged);
            // 
            // cbCidadeEnderecoCliente
            // 
            this.cbCidadeEnderecoCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCidadeEnderecoCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidadeEnderecoCliente.FormattingEnabled = true;
            this.cbCidadeEnderecoCliente.Location = new System.Drawing.Point(153, 90);
            this.cbCidadeEnderecoCliente.Name = "cbCidadeEnderecoCliente";
            this.cbCidadeEnderecoCliente.Size = new System.Drawing.Size(206, 33);
            this.cbCidadeEnderecoCliente.TabIndex = 9;
            this.cbCidadeEnderecoCliente.SelectedIndexChanged += new System.EventHandler(this.cbCidadeEnderecoCliente_SelectedIndexChanged);
            // 
            // mtbCepCliente
            // 
            this.mtbCepCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCepCliente.Location = new System.Drawing.Point(76, 28);
            this.mtbCepCliente.Mask = "00000-999";
            this.mtbCepCliente.Name = "mtbCepCliente";
            this.mtbCepCliente.Size = new System.Drawing.Size(106, 32);
            this.mtbCepCliente.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Estado*:";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(415, 62);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(80, 25);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro*:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(634, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nº*:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "CEP:*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complemento:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(148, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cidade*:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua*:";
            // 
            // txtClienteComple
            // 
            this.txtClienteComple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteComple.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteComple.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteComple.Location = new System.Drawing.Point(166, 197);
            this.txtClienteComple.Name = "txtClienteComple";
            this.txtClienteComple.Size = new System.Drawing.Size(574, 32);
            this.txtClienteComple.TabIndex = 11;
            // 
            // txtClienteNumero
            // 
            this.txtClienteNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNumero.Location = new System.Drawing.Point(639, 156);
            this.txtClienteNumero.Name = "txtClienteNumero";
            this.txtClienteNumero.Size = new System.Drawing.Size(101, 32);
            this.txtClienteNumero.TabIndex = 13;
            // 
            // txtClienteRua
            // 
            this.txtClienteRua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteRua.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteRua.Location = new System.Drawing.Point(16, 156);
            this.txtClienteRua.Name = "txtClienteRua";
            this.txtClienteRua.Size = new System.Drawing.Size(548, 32);
            this.txtClienteRua.TabIndex = 12;
            // 
            // bntSalvarCliente
            // 
            this.bntSalvarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntSalvarCliente.BackColor = System.Drawing.Color.White;
            this.bntSalvarCliente.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvarCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvarCliente.ForeColor = System.Drawing.Color.White;
            this.bntSalvarCliente.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_floppy_12557;
            this.bntSalvarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSalvarCliente.Location = new System.Drawing.Point(823, 633);
            this.bntSalvarCliente.Name = "bntSalvarCliente";
            this.bntSalvarCliente.Size = new System.Drawing.Size(184, 49);
            this.bntSalvarCliente.TabIndex = 14;
            this.bntSalvarCliente.Text = "&SALVAR";
            this.bntSalvarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSalvarCliente.UseVisualStyleBackColor = false;
            this.bntSalvarCliente.Click += new System.EventHandler(this.button5_Click);
            // 
            // bntClienteCancelar
            // 
            this.bntClienteCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClienteCancelar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.bntClienteCancelar.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.bntClienteCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClienteCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClienteCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.bntClienteCancelar.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.blue_exit_delete_delete_12417;
            this.bntClienteCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntClienteCancelar.Location = new System.Drawing.Point(821, 473);
            this.bntClienteCancelar.Name = "bntClienteCancelar";
            this.bntClienteCancelar.Size = new System.Drawing.Size(186, 51);
            this.bntClienteCancelar.TabIndex = 17;
            this.bntClienteCancelar.Text = "CA&NCELAR";
            this.bntClienteCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntClienteCancelar.UseVisualStyleBackColor = false;
            this.bntClienteCancelar.Click += new System.EventHandler(this.bntClienteCancelar_Click);
            // 
            // erroFrmCliente
            // 
            this.erroFrmCliente.ContainerControl = this;
            this.erroFrmCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("erroFrmCliente.Icon")));
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.bluefilefolder_azul_archivo_12582;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(823, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 51);
            this.button1.TabIndex = 21;
            this.button1.Text = "&RELATÓRIO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo_botao;
            this.panel2.Controls.Add(this.lblBannerCadastroCliente);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 151);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblBannerCadastroCliente
            // 
            this.lblBannerCadastroCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBannerCadastroCliente.AutoSize = true;
            this.lblBannerCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblBannerCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBannerCadastroCliente.Font = new System.Drawing.Font("Candara", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBannerCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBannerCadastroCliente.Location = new System.Drawing.Point(21, 24);
            this.lblBannerCadastroCliente.Name = "lblBannerCadastroCliente";
            this.lblBannerCadastroCliente.Size = new System.Drawing.Size(735, 101);
            this.lblBannerCadastroCliente.TabIndex = 23;
            this.lblBannerCadastroCliente.Text = "Cadastro de Cliente";
            this.lblBannerCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.OOF;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(791, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(821, 189);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 25);
            this.label26.TabIndex = 28;
            this.label26.Text = "USUÁRIO:";
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.Transparent;
            this.lblOperador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOperador.Location = new System.Drawing.Point(824, 214);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(61, 16);
            this.lblOperador.TabIndex = 27;
            this.lblOperador.Text = "Operador";
            // 
            // viewTelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1014, 709);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntSalvarCliente);
            this.Controls.Add(this.bntClienteCancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewTelaCadastroCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cadastro Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewTelaCadastroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroFrmCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSalvarCliente;
        private System.Windows.Forms.Button bntClienteCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtClienteNome;
        public System.Windows.Forms.RadioButton rbSexoClienteF;
        public System.Windows.Forms.RadioButton rbSexoClienteM;
        public System.Windows.Forms.MaskedTextBox mtbTelefoneCliente;
        public System.Windows.Forms.MaskedTextBox mtbTelefoneClienteOp;
        public System.Windows.Forms.MaskedTextBox mtbCpfCliente;
        public System.Windows.Forms.MaskedTextBox mtbDataNascCliente;
        public System.Windows.Forms.ErrorProvider erroFrmCliente;
        public System.Windows.Forms.TextBox txtRgCliente;
        public System.Windows.Forms.GroupBox gbSexo;
        private GroupBox groupBox3;
        public ComboBox cbBairro;
        public ComboBox cbUfCliente;
        public ComboBox cbCidadeEnderecoCliente;
        public MaskedTextBox mtbCepCliente;
        private Label label12;
        private Label lblBairro;
        private Label label6;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label5;
        public TextBox txtClienteComple;
        public TextBox txtClienteNumero;
        public TextBox txtClienteRua;
        private Button button1;
        private Panel panel2;
        private Label lblBannerCadastroCliente;
        private PictureBox pictureBox2;
        private Label label31;
        private Button bntLoadEndereco;
        private Label label26;
        public Label lblOperador;
    }
}