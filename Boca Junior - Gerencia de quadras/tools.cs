using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    class tools
    {
        public controlerEndereco contEndereco = new controlerEndereco();

        public bool validaDataString(string data)
        {
            try
            {
                Convert.ToDateTime(data).ToString("yyyy-MM-dd");
                DateTime resultado;
                if (DateTime.TryParse(data, out resultado))
                {
                    DateTime date = Convert.ToDateTime(data);
                    if (DateTime.Compare(date, DateTime.Now) >= 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        public Boolean validaTextBox(TextBox campo)
        {
            if (campo.TextLength > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool validaMaskText(MaskedTextBox maskText)
        {
            if (!maskText.MaskCompleted)
            {
                return false;
            }
            return true;
        }
        public int CalculaIdade(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Now;
            return (DateTime.Now.Year - dataNasc.Year);
        }

        public int rbSexo(RadioButton radioM, RadioButton radioF)
        {
            if (radioM.Checked == true && radioF.Checked == false)
            {
                return 1;
            }
            if (radioF.Checked == true && radioM.Checked == false)
            {
                return 0;
            }
            return 2;
        }
        public bool validaRbSexo(int sexo, ErrorProvider error, GroupBox grupo)
        {
            if (sexo > 1 || sexo < 0)
            {
                error.SetError(grupo, "Sexo Invalido!");
                return false;
            }
            return true;
        }

        public bool validaComboBox(ComboBox box)
        {
            if (box.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool formConfirmacao(string msg, string acao)
        {
            DialogResult confirm = MessageBox.Show(msg, acao, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void carregaComboBoxEndereco(ComboBox bairro,ComboBox cidade,ComboBox uf, TextBox rua,MaskedTextBox CEP)
        {
            modelEndereco modelEnd = new modelEndereco();
            modelEnd = contEndereco.carregaEndereco(CEP.Text.Replace(".", "").Replace("-", ""));
            try
            {
                bairro.Text = modelEnd.Bairro.Nome;
                cidade.Text = modelEnd.Bairro.Cidade.Nome;
                uf.Text = modelEnd.Bairro.Cidade.Uf.Sigla;
                rua.Text = modelEnd.Endereco;
            }
            catch (Exception e)
            {
                MessageBox.Show("Endereco não encontrado");
            }
        }
        public void AutoCompleteComboBox(ComboBox combo, string campo, string Parametro)
        {

            combo.Items.Clear();
            string index = "";
            MySqlDataReader itensCombo = null;
            if (String.IsNullOrEmpty(Parametro))
            {
                if (campo == "UF")
                {

                    itensCombo = contEndereco.buscaUF();
                    index = "uf_sigla";
                }
            }
            else
            {
                if (campo == "CIDADE")
                {
                    string cod = contEndereco.buscaCodUF(Parametro);
                    if (cod != null)
                    {
                        itensCombo = contEndereco.buscaCidade(cod);
                        index = "cidade_descricao";
                    }
                    else
                    {
                        MessageBox.Show("Selecione um Estado!");
                    }

                }
                if (campo == "BAIRRO")
                {
                    string cod = contEndereco.buscaCodCidade(Parametro);
                    if (cod != null)
                    {
                        itensCombo = contEndereco.buscaBairro(cod);
                        index = "bairro_descricao";
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma cidade!");
                    }
                }

            }
            while (itensCombo.Read())
            {
                combo.Items.Add(itensCombo[index]);
            }
        }      

    }
}
