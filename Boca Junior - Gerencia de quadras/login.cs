using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    class login
    {
        daoLogin daoLogin = new daoLogin();
        private modelOperador operadorOn = new modelOperador();

        internal modelOperador OperadorOn
        {
            get { return operadorOn; }
            set { operadorOn = value; }
        }
        public void loginValidacao(string login, string senha,Form formLogin)
        {
            MySqlDataReader operador = daoLogin.buscaLogin(login);

            int validadorLogin = 1;
            while (operador.Read())
            {
               this.OperadorOn.Login = operador["login"].ToString();
               this.OperadorOn.Nome = operador["nome"].ToString();
               this.OperadorOn.CodOperador = Convert.ToInt32(operador["codOperador"]);
               this.OperadorOn.Senha = operador["senha"].ToString();
               this.OperadorOn.Adm = Convert.ToInt16(operador["adm"]);
               this.OperadorOn.Ativo = Convert.ToInt16(operador["ativo"]);
               validadorLogin = 2;
            }

            if (validadorLogin == 1)
            {
                MessageBox.Show("Login ou senha Incorreto!");
            }
            else
            {
                if (senha == OperadorOn.Senha)
                {
                    formLogin.Hide();
                    viewHome view = new viewHome(this.OperadorOn.Nome);
                    view.Show();
                }
                else
                {
               MessageBox.Show("Login ou senha Incorreto!");
                }
            }
        }
        public void validacao(Form form)
        {
            viewLogin telaLogin = new viewLogin();
            telaLogin.FormValidacao = form;
            Application.Run(telaLogin);
        }

    }

}
