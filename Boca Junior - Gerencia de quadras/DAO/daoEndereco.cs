using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Boca_Junior___Gerencia_de_quadras
{
    class daoEndereco
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;
        public MySqlDataReader BuscaEndereco(string cep)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT brr.bairro_descricao, uf_sigla ,cdd.cidade_descricao, ende.endereco_logradouro FROM sisgce.endereco ende join bairro brr on ende.bairro_codigo = brr.bairro_codigo join cidade cdd on cdd.cidade_codigo = brr.cidade_codigo join uf on uf.uf_codigo = cdd.uf_codigo where ende.endereco_cep = '" + cep + "' or cdd.cidade_cep = '" + cep + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader endereco = comando.ExecuteReader();
            return endereco;
        }
        public MySqlDataReader buscaUF()
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT uf_sigla from uf order by uf.uf_sigla ASC";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader uf = comando.ExecuteReader();
            return uf;
        }
        public MySqlDataReader buscaUF(string uf_sigla)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT uf_codigo from uf WHERE uf_sigla = '" + uf_sigla + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader uf = comando.ExecuteReader();
            return uf;
        }
        public MySqlDataReader buscaCidadeCod(string cidade_nome)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT cidade_codigo FROM sisgce.cidade where cidade_descricao = '" + cidade_nome + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader cidade = comando.ExecuteReader();
            return cidade;
        }

        public MySqlDataReader buscaCidade(string uf_cod)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT cidade_descricao FROM sisgce.cidade WHERE uf_codigo = '" + uf_cod + "' ORDER BY cidade_descricao ASC ;";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader cidade = comando.ExecuteReader();
            return cidade;
        }

        public MySqlDataReader buscaBairro(string cidade_cod)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT bairro_descricao FROM sisgce.bairro where cidade_codigo = '" + cidade_cod + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader bairro = comando.ExecuteReader();
            return bairro;
        }

    }
}
