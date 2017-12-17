using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Boca_Junior___Gerencia_de_quadras
{
    class tools
    {
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

    }
}
