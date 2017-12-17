using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    class daoLogin
    {
        private MySqlCommand comando;
        private MySqlConnection conexaoDb;
        public MySqlDataReader buscaLogin(string login)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT * FROM sisgce.operador where login = '" + login + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader operador = comando.ExecuteReader();
            return operador;
        }
        public MySqlDataReader listaLogin()
        {
             Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT * FROM sisgce.operador";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader operador = comando.ExecuteReader();
            return operador;            
        }

        public bool bloqueandoLogin(int codLogin)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "update operador set ativo = 0 where codOperador = '"+codLogin+"'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool criaLogin(modelOperador operador)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "insert into operador (login,senha,adm,ativo) value ('"+operador.Login+"','"+operador.Senha+"',0,0)";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool desbloqueandoLogin(int codLogin)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "update operador set ativo = 1 where codOperador = '" + codLogin + "'";
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
