using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Boca_Junior___Gerencia_de_quadras
{
    class controlerCliente
    {
        tools tools = new tools();
        public string CadastraCliente(modelCliente cliente, modelClienteEndereco endereco)
        {
            try
            {
                daoCliente daoCliente = new daoCliente();
                daoCliente.cadastrarEnderecoCliente(endereco);
                endereco = BuscaEndereco(endereco);
                cliente.Endereco = endereco;
                daoCliente.cadastroCliente(cliente);
                return "Cadastrado com Sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public MySqlDataReader listaCliente()
        {
            daoCliente daoCliente = new daoCliente();
            return daoCliente.buscarCliente();
        }
        public MySqlDataReader buscaFormulario(string whereNome, string whereCPF)
        {
            daoCliente daoCliente = new daoCliente();
            return daoCliente.buscarClienteRelatorio(whereNome, whereCPF);
        }
        public modelCliente BuscaEndereco(modelCliente cliente)
        {
            modelClienteEndereco modelEndereco = new modelClienteEndereco();
            daoCliente daoCliente = new daoCliente();
            MySqlDataReader enderecoCliente = daoCliente.buscaEnderecoCliente(cliente);
            while (enderecoCliente.Read())
            {
                modelEndereco.IdClienteEndereco = Convert.ToInt32(enderecoCliente["idCliente_endereco"]);
                modelEndereco.CEP = enderecoCliente["CEP"].ToString();
                modelEndereco.Rua = enderecoCliente["rua"].ToString();
                modelEndereco.Numero = enderecoCliente["numero"].ToString();
                modelEndereco.Bairro = enderecoCliente["bairro"].ToString();
                modelEndereco.Complemento = enderecoCliente["complemento"].ToString();
                modelEndereco.Cidade = enderecoCliente["cidade"].ToString();
                modelEndereco.Estado = enderecoCliente["estado"].ToString();
            }
            cliente.Endereco = modelEndereco;
            return cliente;

        }
        public modelCliente carregaCliente(int codCliente)
        {
            modelCliente Cliente = new modelCliente();
            modelClienteEndereco Endereco = new modelClienteEndereco();
            daoCliente daoCliente = new daoCliente();
            MySqlDataReader result = daoCliente.carregaCliente(codCliente);
            while (result.Read())
            {
                Cliente.Nome = result["nome"].ToString();
                Cliente.Cliente = Convert.ToInt32(result["idCliente"]);
                Cliente.Cpf = result["CPF"].ToString();
                Cliente.Rg = result["RG"].ToString();
                Cliente.Telefone = result["telefone"].ToString();
                Cliente.TelefoneOp = result["telefone_op"].ToString();
                Cliente.Sexo = Convert.ToInt32(result["sexo"]);
                Cliente.DataNascimento = result["data_nascimento"].ToString();
                Cliente.DataCadastro = result["data_cadastro"].ToString();
                Endereco.IdClienteEndereco = Convert.ToInt32(result["codClienteEndereco"]);
                Endereco.Bairro = result["bairro"].ToString();
                Endereco.CEP = result["cep"].ToString();
                Endereco.Rua = result["rua"].ToString();
                Endereco.Complemento = result["complemento"].ToString();
                Endereco.Estado = result["estado"].ToString();
                Endereco.Cidade = result["cidade"].ToString();
                Endereco.Numero = result["numero"].ToString();
                Cliente.Endereco = Endereco;
            }
            return Cliente;
        }

        public modelClienteEndereco BuscaEndereco(modelClienteEndereco modelEndereco)
        {
            daoCliente daoCliente = new daoCliente();
            modelEndereco.IdClienteEndereco = daoCliente.buscaEnderecoCliente(modelEndereco.CEP, modelEndereco.Numero);
            return modelEndereco;
        }
        public void chamaFormEdicao(int codCliente)
        {
            modelCliente cliente = new modelCliente();
            cliente = this.carregaCliente(codCliente);
            viewTelaCadastroCliente form = new viewTelaCadastroCliente("", true);

            form.txtClienteNome.Text = cliente.Nome;
            form.mtbCpfCliente.Text = cliente.Cpf;
            form.txtRgCliente.Text = cliente.Rg;
            form.mtbTelefoneCliente.Text = cliente.Telefone;
            form.mtbTelefoneClienteOp.Text = cliente.TelefoneOp;
            form.mtbDataNascCliente.Text = (DateTime.ParseExact(cliente.DataNascimento, "dd/MM/yyyy HH:mm:ss", null)).ToString();
            if (cliente.Sexo == 1)
            {
                form.rbSexoClienteM.Checked = true;
            }
            else
            {
                form.rbSexoClienteF.Checked = true;
            }
            form.mtbCepCliente.Text = cliente.Endereco.CEP;            
            form.txtClienteComple.Text = cliente.Endereco.Complemento;
            form.cbUfCliente.Text = cliente.Endereco.Estado;
            form.cbCidadeEnderecoCliente.Text = cliente.Endereco.Cidade;
            form.txtClienteNumero.Text = cliente.Endereco.Numero.ToString();
            form.txtClienteRua.Text = cliente.Endereco.Rua;
            form.cbBairro.Text = cliente.Endereco.Bairro;
            form.ClienteOp = cliente;
            form.Show();
        }
        public void excluiClienteGrid(string idCliente)
        {
            daoCliente daoCliente = new daoCliente();
            string idClienteEndereco = daoCliente.buscaIdEndereco(idCliente);
            daoCliente.excluirCliente(idCliente);
            daoCliente.excluirEnderecoCliente(idClienteEndereco);
        }
        public bool alteraEnderecoCliente(modelCliente cliente)
        {
            daoCliente daoCliente = new daoCliente();
            return daoCliente.alterandoEnderecoCliente(cliente.Endereco);
        }
        private long ToInt64(string p)
        {
            throw new NotImplementedException();
        }

        private DateTime ConvertToDateTime(string p)
        {
            throw new NotImplementedException();
        }
        public void alteraCliente(modelCliente cliente)
        {
            daoCliente daoCliente = new daoCliente();
            bool modif = alteraEnderecoCliente(cliente);
            if (modif == true)
            {
                string retorno = daoCliente.alterandoCliente(cliente);
                MessageBox.Show(retorno);
            }

        }
        public int verificaCliente(modelCliente cliente)
        {
            daoCliente daoCliente = new daoCliente();
            MySqlDataReader clientes = daoCliente.buscaClienteCPF(cliente.Cpf);
            while (clientes.Read())
            {
                return Convert.ToInt32(clientes["idCliente"]);
            }
            return 0;
        }
        public bool validaForm(viewTelaCadastroCliente form, bool alterar)
        {
            bool campoValidacao = true;
            bool retorno = true;
            tools tools = new tools();
            MaskedTextBox[] maskedText = new MaskedTextBox[] { form.mtbCepCliente, form.mtbDataNascCliente, form.mtbTelefoneCliente };
            foreach (MaskedTextBox masked in maskedText)
            {
                campoValidacao = tools.validaMaskText(masked);
                if (campoValidacao == false)
                {
                    form.erroFrmCliente.SetError(masked, "Campo Vazio!");
                    retorno = false;
                }
            }
            if (campoValidacao == false)
            {
                retorno = false;
            }

            if (!form.mtbDataNascCliente.MaskCompleted)
            {
                retorno = false;
                form.erroFrmCliente.SetError(form.mtbDataNascCliente, "Data invalida!");
            }
            else
            {
                if (tools.validaDataString(form.mtbDataNascCliente.Text) == false)
                {
                    form.erroFrmCliente.SetError(form.mtbDataNascCliente, "Data invalida!");
                    retorno = false;
                }
                else
                {
                    if (tools.CalculaIdade(Convert.ToDateTime(form.mtbDataNascCliente.Text)) < 18)
                    {
                        form.erroFrmCliente.SetError(form.mtbDataNascCliente, "Cliente menor de idade!");
                        retorno = false;
                    }
                }
            }

            if (!form.mtbCpfCliente.MaskCompleted)
            {
                retorno = false;
                form.erroFrmCliente.SetError(form.mtbDataNascCliente, "CPF invalido!");
            }
            else
            {
                if (tools.IsCpf(form.mtbCpfCliente.Text) == false)
                {
                    retorno = false;
                    form.erroFrmCliente.SetError(form.mtbCpfCliente, "CPF invalido!");
                }
                if (alterar == false)
                {
                    if (this.validaCpfCadastrado(form.mtbCpfCliente.Text.Replace(".", "").Replace("-", "")) == true)
                    {
                        retorno = false;
                        form.erroFrmCliente.SetError(form.mtbCpfCliente, "CPF já cadastrado!");
                    }
                }

            }

            if (form.cbCidadeEnderecoCliente.Text == "")
            {
                retorno = false;
                form.erroFrmCliente.SetError(form.cbCidadeEnderecoCliente, "Campo vazio!");
            }
            if (form.cbUfCliente.Text == "")
            {
                retorno = false;
                form.erroFrmCliente.SetError(form.cbUfCliente, "Campo vazio!");
            }
            if (form.cbBairro.Text == "")
            {
                retorno = false;
                form.erroFrmCliente.SetError(form.cbBairro, "Campo vazio!");
            }

            if (form.rbSexoClienteF.Checked == false && form.rbSexoClienteM.Checked == false)
            {
                retorno = false;
                form.erroFrmCliente.SetError(form.gbSexo, "Nenhuma opção selecionada!");
            }


            TextBox[] formsText = new TextBox[] { form.txtRgCliente, form.txtClienteRua, form.txtClienteNumero, form.txtClienteNome };
            foreach (TextBox text in formsText)
            {
                campoValidacao = tools.validaTextBox(text);
                if (campoValidacao == false)
                {
                    form.erroFrmCliente.SetError(text, "Campo Vazio!");
                    retorno = false;
                }
            }
            if (campoValidacao == false)
            {
                retorno = false;
            }
            return retorno;
        }
        public bool validaCpfCadastrado(string cpf)
        {
            daoCliente daoCliente = new daoCliente();
            return daoCliente.boolValidaCPF(cpf);
        }
        public void carregaComboBoxEndereco(viewTelaCadastroCliente view)
        {
            tools.carregaComboBoxEndereco(view.cbBairro, view.cbCidadeEnderecoCliente, view.cbUfCliente, view.txtClienteRua,view.mtbCepCliente); 
        }
    }
}
