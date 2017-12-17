using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    class Conexao
    {
        public MySqlConnection ConexaoMySQL;

        public MySqlConnection conectar()
        {
                string dadosBanco = "SERVER=localhost;DATABASE=sisgce;UID=root;PASSWORD=root;";
                ConexaoMySQL = new MySqlConnection(dadosBanco);
                ConexaoMySQL.Open();
                return ConexaoMySQL;
           
        }

    }
}
