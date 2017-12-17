namespace Boca_Junior___Gerencia_de_quadras
{
    partial class viewHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.menuAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlunoCad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlunoAbr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInstrutor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInstrutorCad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInstrutorAbr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteCad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteAbr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoginAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservaCriar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservaAbr = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntCadastrarCliente = new System.Windows.Forms.Button();
            this.bntReservarQuadra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RESERVAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtRelogioHome = new System.Windows.Forms.TextBox();
            this.menuHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAluno,
            this.menuInstrutor,
            this.menuCliente,
            this.menuLogin,
            this.menuReserva,
            this.sAIRToolStripMenuItem});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(905, 29);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "menuStrip1";
            this.menuHome.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuAluno
            // 
            this.menuAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlunoCad,
            this.menuAlunoAbr});
            this.menuAluno.Name = "menuAluno";
            this.menuAluno.Size = new System.Drawing.Size(81, 25);
            this.menuAluno.Text = "ALUNOS";
            // 
            // menuAlunoCad
            // 
            this.menuAlunoCad.Name = "menuAlunoCad";
            this.menuAlunoCad.Size = new System.Drawing.Size(166, 26);
            this.menuAlunoCad.Text = "CADASTRAR";
            this.menuAlunoCad.Click += new System.EventHandler(this.cADASTRARToolStripMenuItem_Click);
            // 
            // menuAlunoAbr
            // 
            this.menuAlunoAbr.Name = "menuAlunoAbr";
            this.menuAlunoAbr.Size = new System.Drawing.Size(166, 26);
            this.menuAlunoAbr.Text = "ABRIR";
            // 
            // menuInstrutor
            // 
            this.menuInstrutor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInstrutorCad,
            this.menuInstrutorAbr});
            this.menuInstrutor.Name = "menuInstrutor";
            this.menuInstrutor.Size = new System.Drawing.Size(119, 25);
            this.menuInstrutor.Text = "INSTRUTORES";
            // 
            // menuInstrutorCad
            // 
            this.menuInstrutorCad.Name = "menuInstrutorCad";
            this.menuInstrutorCad.Size = new System.Drawing.Size(166, 26);
            this.menuInstrutorCad.Text = "CADASTRAR";
            // 
            // menuInstrutorAbr
            // 
            this.menuInstrutorAbr.Name = "menuInstrutorAbr";
            this.menuInstrutorAbr.Size = new System.Drawing.Size(166, 26);
            this.menuInstrutorAbr.Text = "ABRIR";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClienteCad,
            this.menuClienteAbr});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(88, 25);
            this.menuCliente.Text = "CLIENTES";
            // 
            // menuClienteCad
            // 
            this.menuClienteCad.Name = "menuClienteCad";
            this.menuClienteCad.Size = new System.Drawing.Size(166, 26);
            this.menuClienteCad.Text = "CADASTRAR";
            // 
            // menuClienteAbr
            // 
            this.menuClienteAbr.Name = "menuClienteAbr";
            this.menuClienteAbr.Size = new System.Drawing.Size(166, 26);
            this.menuClienteAbr.Text = "ABRIR";
            this.menuClienteAbr.Click += new System.EventHandler(this.menuClienteAbr_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Checked = true;
            this.menuLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoginAdm});
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(75, 25);
            this.menuLogin.Text = "LOGINS";
            // 
            // menuLoginAdm
            // 
            this.menuLoginAdm.Name = "menuLoginAdm";
            this.menuLoginAdm.Size = new System.Drawing.Size(177, 26);
            this.menuLoginAdm.Text = "ADMINISTRAR";
            // 
            // menuReserva
            // 
            this.menuReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReservaCriar,
            this.menuReservaAbr});
            this.menuReserva.Name = "menuReserva";
            this.menuReserva.Size = new System.Drawing.Size(89, 25);
            this.menuReserva.Text = "RESERVAS";
            // 
            // menuReservaCriar
            // 
            this.menuReservaCriar.Name = "menuReservaCriar";
            this.menuReservaCriar.Size = new System.Drawing.Size(123, 26);
            this.menuReservaCriar.Text = "CRIAR";
            // 
            // menuReservaAbr
            // 
            this.menuReservaAbr.Name = "menuReservaAbr";
            this.menuReservaAbr.Size = new System.Drawing.Size(123, 26);
            this.menuReservaAbr.Text = "ABRIR";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // bntCadastrarCliente
            // 
            this.bntCadastrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.bntCadastrarCliente.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.football1;
            this.bntCadastrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.bntCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntCadastrarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.bntCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntCadastrarCliente.Location = new System.Drawing.Point(94, 46);
            this.bntCadastrarCliente.Name = "bntCadastrarCliente";
            this.bntCadastrarCliente.Size = new System.Drawing.Size(181, 134);
            this.bntCadastrarCliente.TabIndex = 1;
            this.bntCadastrarCliente.UseVisualStyleBackColor = false;
            this.bntCadastrarCliente.Click += new System.EventHandler(this.bntCadastrarCliente_Click);
            // 
            // bntReservarQuadra
            // 
            this.bntReservarQuadra.BackColor = System.Drawing.Color.Transparent;
            this.bntReservarQuadra.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.playground;
            this.bntReservarQuadra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntReservarQuadra.Location = new System.Drawing.Point(293, 46);
            this.bntReservarQuadra.Name = "bntReservarQuadra";
            this.bntReservarQuadra.Size = new System.Drawing.Size(181, 134);
            this.bntReservarQuadra.TabIndex = 2;
            this.bntReservarQuadra.UseVisualStyleBackColor = false;
            this.bntReservarQuadra.Click += new System.EventHandler(this.bntReservarQuadra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RESERVAR,
            this.CLIENTE,
            this.HORARIO});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(122, 352);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(642, 194);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RESERVAR
            // 
            this.RESERVAR.HeaderText = "RESERVA";
            this.RESERVAR.Name = "RESERVAR";
            this.RESERVAR.Width = 200;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 200;
            // 
            // HORARIO
            // 
            this.HORARIO.HeaderText = "HORARIO";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.Width = 200;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtRelogioHome
            // 
            this.txtRelogioHome.Location = new System.Drawing.Point(393, 326);
            this.txtRelogioHome.Name = "txtRelogioHome";
            this.txtRelogioHome.Size = new System.Drawing.Size(100, 20);
            this.txtRelogioHome.TabIndex = 4;
            // 
            // viewHome
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boca_Junior___Gerencia_de_quadras.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(905, 558);
            this.Controls.Add(this.txtRelogioHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntReservarQuadra);
            this.Controls.Add(this.bntCadastrarCliente);
            this.Controls.Add(this.menuHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuHome;
            this.Name = "viewHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISGCE - GERENCIAMENTO DE QUADRAS ESPORTIVAS";
            this.Load += new System.EventHandler(this.viewHome_Load);
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuAluno;
        private System.Windows.Forms.ToolStripMenuItem menuAlunoCad;
        private System.Windows.Forms.ToolStripMenuItem menuAlunoAbr;
        private System.Windows.Forms.ToolStripMenuItem menuInstrutor;
        private System.Windows.Forms.ToolStripMenuItem menuInstrutorCad;
        private System.Windows.Forms.ToolStripMenuItem menuInstrutorAbr;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuClienteCad;
        private System.Windows.Forms.ToolStripMenuItem menuClienteAbr;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuLoginAdm;
        private System.Windows.Forms.ToolStripMenuItem menuReserva;
        private System.Windows.Forms.ToolStripMenuItem menuReservaCriar;
        private System.Windows.Forms.ToolStripMenuItem menuReservaAbr;
        private System.Windows.Forms.Button bntCadastrarCliente;
        private System.Windows.Forms.Button bntReservarQuadra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtRelogioHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}