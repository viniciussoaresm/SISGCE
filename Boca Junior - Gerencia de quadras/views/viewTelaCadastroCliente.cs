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
namespace Boca_Junior___Gerencia_de_quadras
{

    public partial class viewTelaCadastroCliente : Form
    {
        controlerCliente controler = new controlerCliente();
        private modelCliente clienteOp;
        private bool alterar;
        tools tools = new tools();


        public bool Alterar
        {
            get { return alterar; }
            set { alterar = value; }
        }
        internal modelCliente ClienteOp
        {
            get { return clienteOp; }
            set { clienteOp = value; }
        }
        public viewTelaCadastroCliente(string operador, bool alterar)
        {
            InitializeComponent();
            Alterar = alterar;
            if (Alterar == true)
            {
                mtbCpfCliente.Enabled = false;
                lblBannerCadastroCliente.Text = "Editar Cliente";
            }
            else
            {
                lblBannerCadastroCliente.Text = "Cadastrar Cliente";

            }
            this.ClienteOp = null;
            lblOperador.Text = operador;
            tools.AutoCompleteComboBox(cbUfCliente, "UF", null);

            this.Height = Screen.PrimaryScreen.Bounds.Height;

            this.Width = Screen.PrimaryScreen.Bounds.Width;

            this.TopMost = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                erroFrmCliente.Clear();
                modelCliente cliente = new modelCliente();
                modelClienteEndereco endereco = new modelClienteEndereco();
                controlerCliente controlerCliente = new controlerCliente();
                int sexoOp = 3;
                Boolean validaCampo = controlerCliente.validaForm(this, Alterar);

                if (validaCampo == true)
                {
                    cliente.Nome = txtClienteNome.Text;
                    cliente.Cpf = mtbCpfCliente.Text.Replace(".", "").Replace("-", "");
                    cliente.Rg = txtRgCliente.Text;
                    cliente.Sexo = sexoOp;
                    cliente.Telefone = mtbTelefoneCliente.Text;
                    cliente.TelefoneOp = mtbTelefoneClienteOp.Text;
                    endereco.CEP = mtbCepCliente.Text;
                    endereco.Bairro = cbBairro.Text;
                    endereco.Cidade = cbCidadeEnderecoCliente.Text;
                    endereco.Complemento = txtClienteComple.Text;
                    endereco.Estado = cbUfCliente.Text;
                    endereco.Rua = txtClienteRua.Text;
                    endereco.Numero = txtClienteNumero.Text;
                    string dataCad = DateTime.Now.ToString("yyyy-MM-dd");
                    string dataNasc = Convert.ToDateTime(mtbDataNascCliente.Text).ToString("yyyy-MM-dd");
                    cliente.DataCadastro = dataCad;
                    cliente.DataNascimento = dataNasc;
                    cliente.Endereco = endereco;
                    // int clienteOperação = controlerCliente.ClienteSelecionado1.Cliente;
                    //int clienteOperação = controlerCliente.verificaCliente(cliente);
                    if (Alterar == true)
                    {
                        cliente.Cliente = ClienteOp.Cliente;
                        controlerCliente.alteraCliente(cliente);
                        controlerCliente.alteraEnderecoCliente(cliente);
                        this.Close();
                        viewRelatorioCliente relatorio = new viewRelatorioCliente(lblOperador.Text);
                        relatorio.Show();
                    }
                    else
                    {
                        string retorno = controlerCliente.CadastraCliente(cliente, endereco);
                        MessageBox.Show(retorno);
                        bool confirmacao = tools.formConfirmacao("Deseja Continuar Cadastrando?", "Cadastro de Cliente");
                        if (confirmacao == false)
                        {
                            this.Close();
                        }
                        else
                        {
                            viewTelaCadastroCliente view = new viewTelaCadastroCliente(lblOperador.Text, false);
                            this.Close();
                            view.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("preencha todos os campos corretamente");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao salvar cliente!");
            }
        }

        private void txtClienteNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewTelaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bntClienteCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtClienteNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClienteTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbTelefoneCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCpfCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
                MessageBox.Show("Erro ao carregar endereço!");
            }

        }

        private void cbUfCliente_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cbUfCliente_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                tools.AutoCompleteComboBox(cbCidadeEnderecoCliente, "CIDADE", cbUfCliente.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Selecione um Estado!");
            }
        }

        private void cbCidadeEnderecoCliente_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                tools.AutoCompleteComboBox(cbBairro, "BAIRRO", cbCidadeEnderecoCliente.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Selecione uma Cidade!");
            }
        }

        private void cbBairro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblOperador_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                viewRelatorioCliente view = new viewRelatorioCliente(lblOperador.Text);
                view.Show();
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao abrir relatorio!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
