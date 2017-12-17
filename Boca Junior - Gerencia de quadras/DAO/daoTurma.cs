using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras 
{
    class daoTurma
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;
        public bool cadastrarTurma(modelTurma turma)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO `sisgce`.`turma` (`codInstrutor`, `periodo`, `categoria`, `nome`) VALUES ('" + turma.Instrutoor.CodInstrutor + "', '" + turma.Periodo + "', '" + turma.Categoria +"', '"+turma.Nome+"')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AlterarInstrutorTurma(int codInstrutor)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`turma` SET `codInstrutor`='1' WHERE codInstrutor = '" + codInstrutor + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public MySqlDataReader buscaTurma(modelTurma modelTurma)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT * FROM sisgce.turma where codInstrutor = '"+modelTurma.Instrutoor.CodInstrutor+"' and nome = '"+modelTurma.Nome+"'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader turma = comando.ExecuteReader();
                return turma;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public MySqlDataReader buscaTurma(int codTurma)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT turma.*,instrutor.nome as instrutor from turma join instrutor on instrutor.codInstrutor = turma.codInstrutor where codTurma ='"+codTurma+"'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader turma = comando.ExecuteReader();
                return turma;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public MySqlDataReader buscaTurma(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT * FROM sisgce.turma where nome ='" + nome + "'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader turma = comando.ExecuteReader();
                return turma;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public MySqlDataReader listaTurma()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codTurma,nome FROM sisgce.turma";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader turma = comando.ExecuteReader();
                return turma;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public MySqlDataReader listaTurma(bool grid)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT turma.codTurma as codigo,turma.nome as nomeTurma,turma.periodo as periodo,turma.categoria as categoria,instrutor.codInstrutor codigoInstrutor ,instrutor.nome nomeInstrutor FROM sisgce.turma left join instrutor on instrutor.codInstrutor = turma.codInstrutor where turma.codTurma > 1";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader turma = comando.ExecuteReader();
                return turma;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool deleteTurma(int codTurma)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "delete from turma where turma.codTurma =  '" + codTurma + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool alteraTurma(modelTurma turma)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`turma` SET `codInstrutor`='"+turma.Instrutoor.CodInstrutor+"', `periodo`='"+turma.Periodo+"', `categoria`='"+turma.Categoria+"', `nome`='"+turma.Nome+"' where turma.codTurma =  '" + turma.CodTurma + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
      

    }
}
