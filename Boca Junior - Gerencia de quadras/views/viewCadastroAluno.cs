using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Boca_Junior___Gerencia_de_quadras.models;
namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewCadastroAluno : Form
    {
        controlerAluno controler = new controlerAluno();
        private modelCliente clienteResponsavel;
        private bool edicaoOp;
        private int codAlunoForm;
        tools tools = new tools();
        public viewCadastroAluno(string operador,bool edicao,int codAlunoEdicao)
        {
            InitializeComponent();
            edicaoOp = edicao;
            codAlunoForm = codAlunoEdicao;
            lblOperador.Text = operador;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mtbDataNascCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bntAdcionarResponsavel_Click(object sender, EventArgs e)
        {
            try
            {
                this.carregaResponsavel();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Inserir Cliente!");
            }
            
        }

        public void carregaResponsavel()
        {
            controlerReserva controlerReserva = new controlerReserva();
            MySqlDataReader ClienteBusca = controlerReserva.carregaCliente(mtbCpfResponsavel.Text.Replace(".", "").Replace("-", ""));
            if (ClienteBusca.HasRows == false)
            {
                MessageBox.Show("CPF não cadastrado!");
            }
            else
            {
                while (ClienteBusca.Read())
                {
                    modelCliente cliente = new modelCliente();
                    cliente.Cliente = Convert.ToInt32(ClienteBusca["idCliente"]);
                    cliente.Nome = ClienteBusca["nome"].ToString();
                    cliente.Cpf = ClienteBusca["CPF"].ToString();
                    cliente.Rg = ClienteBusca["RG"].ToString();
                    cliente.Telefone = ClienteBusca["telefone"].ToString();
                    cliente.TelefoneOp = ClienteBusca["telefone_op"].ToString();
                    cliente.Sexo = Convert.ToInt32(ClienteBusca["sexo"]);
                    cliente.DataNascimento = ClienteBusca["data_nascimento"].ToString();
                    cliente.DataCadastro = ClienteBusca["data_cadastro"].ToString();
                    txtNomeResponsavelAluno.Text = ClienteBusca["nome"].ToString();
                    cbParentescoResponsavel.Enabled = true;
                    clienteResponsavel = cliente;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
            viewTelaCadastroCliente view = new viewTelaCadastroCliente(lblOperador.Text, false);
            view.Show();
        }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Entrar no cadastro do cliente!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                errorFormAluno.Clear();
                bool validacao = this.validaForm(edicaoOp);
                if (clienteResponsavel != null || edicaoOp == true)
                {
                    if (validacao == true)
                    {
                        modelAluno aluno = new modelAluno();
                        modelClienteResponsavel responsalvel = new modelClienteResponsavel();
                        aluno.Data_nascimento = Convert.ToDateTime(mtbDataNascAluno.Text).ToString("yyyy-MM-dd");
                        aluno.Nome = txtNomeAluno.Text;
                        aluno.RG1 = txtRgAluno.Text;
                        aluno.Sexo = tools.rbSexo(rbSexoMasculino, rbSexoFeminino);
                        responsalvel.Cliente = clienteResponsavel;
                        responsalvel.Parentesto = cbParentescoResponsavel.Text;
                        if (edicaoOp == false)
                        {
                            controler.cadastrarAluno(aluno, responsalvel);
                            bool confitm = tools.formConfirmacao("Deseja Continuar?", "Cadastrar Aluno");
                            if (confitm == false)
                            {
                                this.Close();
                            }
                            else
                            {
                                viewCadastroAluno newView = new viewCadastroAluno(lblOperador.Text, false, 0);
                                this.Close();
                                newView.Show();
                            }
                        }
                        if (edicaoOp == true)
                        {
                            aluno.CodAluno = codAlunoForm;
                            responsalvel.Aluno = aluno;
                            controler.editaAluno(responsalvel, aluno);
                        }
                    }
                }
                else
                {
                    errorFormAluno.SetError(txtNomeResponsavelAluno, "Adicione um responsavel!");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Salvar Aluno!");
            }
        }
        private bool validaForm(bool edicao)
        {
            return controler.validaForm(this, edicao);
        }

        private void viewCadastroAluno_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOperador_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                viewTelaRelatorioAluno view = new viewTelaRelatorioAluno();
                view.Show();
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao entrar no relatorio!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
