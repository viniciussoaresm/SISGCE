using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boca_Junior___Gerencia_de_quadras
{

    class controlerOperador
    {
        daoLogin dao = new daoLogin();


        public modelOperador listaOperadores()
        {
            modelOperador modelOperador = new modelOperador();
            MySqlDataReader logins = dao.listaLogin();
            while (logins.Read())
            {
                modelOperador.Ativo = Convert.ToInt32(logins["ativo"]);
                modelOperador.Adm = Convert.ToInt32(logins["adm"]);
                modelOperador.CodOperador = Convert.ToInt32(logins["codOperador"]);
                modelOperador.Login = logins["login"].ToString();
            }
            return modelOperador;
        }
        public MySqlDataReader listaOperadores(bool grid)
        {
            return dao.listaLogin();
        }
        public void gerenciaLogin(int codLogin, bool operacao)
        {
            if (operacao == true)
            {
                dao.bloqueandoLogin(codLogin);
            }
            if (operacao == false)
            {
                dao.desbloqueandoLogin(codLogin);
            }
        }
        public void cadastrarOperado(modelOperador operador)
        {
            bool retorno = dao.criaLogin(operador);

            if(retorno == true){
                MessageBox.Show("Cadastrador com sucesso!");
            }
            if (retorno == false)
            {
                MessageBox.Show("Login não cadastrado!");
            }

        }

    }



}
