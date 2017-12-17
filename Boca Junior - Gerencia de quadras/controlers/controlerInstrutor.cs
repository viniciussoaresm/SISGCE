using Boca_Junior___Gerencia_de_quadras.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boca_Junior___Gerencia_de_quadras
{
    class controlerInstrutor
    {
        daoInstrutor DAO = new daoInstrutor();
        tools tools = new tools();
        public void cadastraInstrutor(modelInstrutor instrutor)
        {
            bool result = DAO.cadastroEnderecoInstrutor(instrutor.Endereco);
            if (result == true)
            {
                MySqlDataReader buscaEndereco = DAO.buscaEnderecoInstrutor(instrutor.Endereco);

                while (buscaEndereco.Read())
                {
                    instrutor.Endereco.CodInstrutorEndereco = Convert.ToInt32(buscaEndereco["codInstrutorEndereco"]);
                }
            }
            DAO.cadastroInstrutor(instrutor);

        }
        public bool validaForm(viewCadastroFunionario form, bool alterar)
        {
            bool campoValidacao = true;
            bool retorno = true;

            MaskedTextBox[] maskedText = new MaskedTextBox[] { form.mtbCepInstrutor, form.mtbDataNascInstrutor, form.mtbTelefoneInstrutor };
            foreach (MaskedTextBox masked in maskedText)
            {
                campoValidacao = tools.validaMaskText(masked);
                if (campoValidacao == false)
                {
                    form.erroFrmInstrutor.SetError(masked, "Campo Vazio!");
                    retorno = false;
                }
            }
            if (campoValidacao == false)
            {
                retorno = false;
            }

            if (!form.mtbDataNascInstrutor.MaskCompleted)
            {
                retorno = false;
                form.erroFrmInstrutor.SetError(form.mtbDataNascInstrutor, "Data invalida!");
            }
            else
            {
                if (tools.validaDataString(form.mtbDataNascInstrutor.Text) == false)
                {
                    form.erroFrmInstrutor.SetError(form.mtbDataNascInstrutor, "Data invalida!");
                    retorno = false;
                }
                else
                {
                    if (tools.CalculaIdade(Convert.ToDateTime(form.mtbDataNascInstrutor.Text)) < 18)
                    {
                        form.erroFrmInstrutor.SetError(form.mtbDataNascInstrutor, "Instrutor menor de 18 anos!");
                        retorno = false;
                    }
                }
            }
            if (!form.mtbCpfInstrutor.MaskFull)
            {
                retorno = false;
                form.erroFrmInstrutor.SetError(form.mtbCpfInstrutor, "CPF invalido!");
            }
            else
            {
                if (tools.IsCpf(form.mtbCpfInstrutor.Text) == false)
                {
                    retorno = false;
                    form.erroFrmInstrutor.SetError(form.mtbCpfInstrutor, "CPF invalido!");
                }
                if (alterar == false)
                {
                    if (this.validaCpfCadastrado(form.mtbCpfInstrutor.Text.Replace(".", "").Replace("-", "")) == true)
                    {
                        retorno = false;
                        form.erroFrmInstrutor.SetError(form.mtbCpfInstrutor, "CPF já cadastrado!");
                    }
                }

                if (form.cbBairroInstrutor.Text == "")
                {
                    form.erroFrmInstrutor.SetError(form.cbBairroInstrutor, "Digite ou selecione um bairro!");
                }
                if (form.cbCidadeEnderecoInstrutor.Text == "")
                {
                    form.erroFrmInstrutor.SetError(form.cbCidadeEnderecoInstrutor, "Digite ou selecione uma cidade!");
                }
                if (form.cbUfInstrutor.Text == "")
                {
                    form.erroFrmInstrutor.SetError(form.cbUfInstrutor, "Digite ou selecione uma UF!");
                }
            }

            if (form.rbSexoInstrutorF.Checked == false && form.rbSexoInstrutorM.Checked == false)
            {
                retorno = false;
                form.erroFrmInstrutor.SetError(form.gbSexo, "Campo vazio!");
            }
            if (form.cbBairroInstrutor.Text == "")
            {
                retorno = false;
                form.erroFrmInstrutor.SetError(form.cbBairroInstrutor, "Campo vazio!");
            }
            if (form.cbCidadeEnderecoInstrutor.Text == "")
            {
                retorno = false;
                form.erroFrmInstrutor.SetError(form.cbCidadeEnderecoInstrutor, "Campo vazio!");
            }
            if (form.cbUfInstrutor.Text == "")
            {
                retorno = false;
                form.erroFrmInstrutor.SetError(form.cbUfInstrutor, "Campo vazio!");
            }

            TextBox[] formsText = new TextBox[] { form.txtRgInstrutor, form.txtRuaInstrutor, form.txtNomeInstrutor, form.txtNumeroInstrutor };
            foreach (TextBox text in formsText)
            {
                campoValidacao = tools.validaTextBox(text);
                if (campoValidacao == false)
                {
                    form.erroFrmInstrutor.SetError(text, "Campo Vazio!");
                    retorno = false;
                }
            }
            if (campoValidacao == false)
            {
                retorno = false;
            }
            return retorno;
        }
        public void carregaComboBoxEndereco(viewCadastroFunionario view)
        {
            tools.carregaComboBoxEndereco(view.cbBairroInstrutor, view.cbCidadeEnderecoInstrutor, view.cbUfInstrutor, view.txtRuaInstrutor, view.mtbCepInstrutor);
        }

        public bool validaCpfCadastrado(string cpf)
        {

            MySqlDataReader instrutor = DAO.buscaInstrutor(cpf);
            while (instrutor.Read())
            {
                return true;
            }
            return false;
        }

        public MySqlDataReader listaInstrutores()
        {
            return DAO.buscaInstrutorListaGrid();           
        }

        public MySqlDataReader listaInstrutores(string cpf,string nome)
        {
            return DAO.buscaInstrutor(cpf,nome);
        }

        public modelInstrutor carregarInstrutor(int codInstrutor)
        {
          MySqlDataReader instrutorBusca = DAO.buscaInstrutor(codInstrutor);
          modelInstrutor instrutor = new modelInstrutor();
          modelEnderecoInstrutor enderecoInstrutor = new modelEnderecoInstrutor();
            while(instrutorBusca.Read()){
                instrutor.CodInstrutor = Convert.ToInt32(instrutorBusca["codInstrutor"]);
                instrutor.Nome = instrutorBusca["nome"].ToString();
                instrutor.RG1 = instrutorBusca["RG"].ToString();
                instrutor.Telefone = instrutorBusca["telefone"].ToString();
                instrutor.Celular = instrutorBusca["telefoneOp"].ToString();
                instrutor.CPF1 = instrutorBusca["CPF"].ToString();
                instrutor.Sexo = Convert.ToInt32(instrutorBusca["sexo"]);
                instrutor.Data_cadastro = instrutorBusca["data_cadastro"].ToString();
                instrutor.Data_nasc = instrutorBusca["data_nascimento"].ToString();
                enderecoInstrutor.Bairro = instrutorBusca["bairro"].ToString();
                enderecoInstrutor.CEP1 = instrutorBusca["cep"].ToString();
                enderecoInstrutor.Numero = instrutorBusca["numero"].ToString();
                enderecoInstrutor.Cidade = instrutorBusca["cidade"].ToString();
                enderecoInstrutor.Rua = instrutorBusca["rua"].ToString();
                enderecoInstrutor.Estado = instrutorBusca["estado"].ToString();
                enderecoInstrutor.CodInstrutorEndereco = Convert.ToInt32(instrutorBusca["codinstrutorEndereco"]);
                instrutor.Endereco = enderecoInstrutor;
            }
            return instrutor;
        }
        public bool alteraInstrutor(modelInstrutor instrutor)
        {
           instrutor.Endereco.CodInstrutorEndereco = DAO.buscaCodEnderecoInstrutor(instrutor.CodInstrutor);            
           bool retorno = DAO.AlterarInstrutor(instrutor);

           if (retorno == true)
           {
            retorno = DAO.AlterarEnderecoInstrutor(instrutor.Endereco);
               if(retorno == true){
                   MessageBox.Show("Alterado com sucesso!");
               }
               return retorno;
           }
           return false;
        }

        public bool excluirInstrutor(modelInstrutor instrutor)
        {
            bool retorno = DAO.DeletarInstrutor(instrutor);
            if (retorno == true)
            {
                if (DAO.DeletarEnderecoInstrutor(instrutor.Endereco))
                {
                    daoTurma DAOt = new daoTurma();
                    DAOt.AlterarInstrutorTurma(instrutor.CodInstrutor);
                    return true;
                }               

            }
            return false;
        }
        public void buscaInstrutores(string nome,viewRelatorioFuncionariocs view)
        {
           MySqlDataReader instrutores = DAO.buscaInstrutorListaGrid(nome);
           view.carregaGridInstrutor(instrutores);
        }

    }
}
