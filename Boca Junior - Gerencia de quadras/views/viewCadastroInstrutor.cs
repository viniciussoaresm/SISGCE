using Boca_Junior___Gerencia_de_quadras.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewCadastroFunionario : Form
    {
        tools tools = new tools();
        controlerInstrutor controler = new controlerInstrutor();
        bool altera;
        int codInstrutorEdicao;
        public viewCadastroFunionario(string operadorLogado,bool alteracao,int codInstrutor)
        {
            InitializeComponent();
            altera = alteracao;
            this.lblOperador.Text = operadorLogado;
            tools.AutoCompleteComboBox(cbUfInstrutor, "UF", null);
            if(alteracao == true){
                lblBannerInstrutor.Text = "Alterar Cadastro de Instrutor";
                codInstrutorEdicao = codInstrutor;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                erroFrmInstrutor.Clear();
                bool validacao = controler.validaForm(this, altera);
                if (validacao == true)
                {
                    modelInstrutor instrutor = new modelInstrutor();
                    modelEnderecoInstrutor endereco = new modelEnderecoInstrutor();
                    instrutor.Nome = txtNomeInstrutor.Text;
                    instrutor.RG1 = txtRgInstrutor.Text;
                    instrutor.Telefone = mtbTelefoneInstrutorOp.Text;
                    instrutor.Celular = mtbTelefoneInstrutor.Text;
                    instrutor.CPF1 = mtbCpfInstrutor.Text.Replace(".", "").Replace("-", "");
                    instrutor.Data_nasc = Convert.ToDateTime(mtbDataNascInstrutor.Text).ToString("yyyy-MM-dd");
                    instrutor.Data_cadastro = DateTime.Now.ToString("yyyy-MM-dd");
                    endereco.Rua = txtRuaInstrutor.Text;
                    endereco.Bairro = cbBairroInstrutor.Text;
                    endereco.Complemento = txtCompleInstrutor.Text;
                    endereco.Cidade = cbCidadeEnderecoInstrutor.Text;
                    endereco.Estado = cbUfInstrutor.Text;
                    endereco.CEP1 = mtbCepInstrutor.Text;
                    endereco.Numero = txtNumeroInstrutor.Text;
                    instrutor.Endereco = endereco;
                    if (altera == false)
                    {
                        controler.cadastraInstrutor(instrutor);
                        bool confirmacao = tools.formConfirmacao("Deseja Continuar Cadastrando?", "Cadastro de Instrutor");
                        if (confirmacao == false)
                        {
                            this.Close();
                        }
                        else
                        {
                            viewCadastroFunionario view = new viewCadastroFunionario(lblOperador.Text, false, 0);
                            this.Close();
                            view.Show();
                        }
                    }
                    else
                    {
                        instrutor.CodInstrutor = codInstrutorEdicao;
                        controler.alteraInstrutor(instrutor);
                        this.Close();
                        viewRelatorioFuncionariocs view = new viewRelatorioFuncionariocs();
                        view.Show();
                    }

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Salvar Instrutor!");
            }

        }
        private void cbUfCliente_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void teste(object sender, System.EventArgs e)
        {
            try
            {
                tools.AutoCompleteComboBox(cbCidadeEnderecoInstrutor, "CIDADE", cbUfInstrutor.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Selecione um Estado!");
            }
        }

        private void teste2(object sender, System.EventArgs e)
        {
            try
            {
                tools.AutoCompleteComboBox(cbBairroInstrutor, "BAIRRO", cbCidadeEnderecoInstrutor.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Selecione uma Cidade!");
            }
        }

        private void viewCadastroFunionario_Load(object sender, EventArgs e)
        {

        }

        private void bntLoadEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                controler.carregaComboBoxEndereco(this);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Carregar CEP!");
            }
        }

        private void cbUfInstrutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tools.AutoCompleteComboBox(cbCidadeEnderecoInstrutor, "CIDADE", cbUfInstrutor.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Selecione um Estado!");
            }
        }

        private void cbCidadeEnderecoInstrutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tools.AutoCompleteComboBox(cbBairroInstrutor, "BAIRRO", cbCidadeEnderecoInstrutor.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Selecione uma Cidade!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                viewRelatorioFuncionariocs view = new viewRelatorioFuncionariocs();
                view.Show();
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao entrar no relatorio!");
            }
        }
        
    }
}
