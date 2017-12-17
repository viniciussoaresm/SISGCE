using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class daoClienteResponsavel
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;
        public bool cadastraClienteResponsavel(modelClienteResponsavel responsavel)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO `sisgce`.`cliente_responsavel` (`codCliente`, `parentesco`, `codAluno`) VALUES ('"+responsavel.Cliente.Cliente+"', '"+responsavel.Parentesto+"', '"+responsavel.Aluno.CodAluno+"')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool alteraClienteResponsavel(modelClienteResponsavel responsavel)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`cliente_responsavel` SET `codCliente`='" + responsavel.Cliente.Cliente +"', `parentesco`='"+responsavel.Parentesto+"' WHERE `codClienteResponsavel`='"+responsavel.Aluno.CodAluno+"'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
