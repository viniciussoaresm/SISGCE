using Boca_Junior___Gerencia_de_quadras.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class daoAluno
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;
        public bool cadastraAluno(modelAluno aluno)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO `sisgce`.`aluno` (`RG`, `nome`, `data_nascimento`,codTurma,sexo) VALUES ('" + aluno.RG1 + "','" + aluno.Nome + "','" + aluno.Data_nascimento + "','1','"+aluno.Sexo+"')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool AlteraTurma(int codAluno, int codTurma)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`aluno` SET `codTurma`='" + codTurma + "' WHERE `codAluno`='" + codAluno + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool excluirAluno(int codAluno)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "DELETE FROM `sisgce`.`aluno` WHERE `codAluno` = '" + codAluno + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public MySqlDataReader buscaAlunoRg(string RG)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codAluno FROM sisgce.aluno where RG = '" + RG + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader alunos = comando.ExecuteReader();
            return alunos;
        }

        public MySqlDataReader buscaAlunosLista(string nome, string rg, int turma)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "select codAluno,aluno.nome,RG,TIMESTAMPDIFF(YEAR,data_nascimento, NOW()) AS idade,data_nascimento,aluno.codTurma,turma.nome from aluno join turma on turma.codTurma = aluno.codTurma  where aluno.nome like '" + nome + "%' and rg like '" + rg + "%' and turma.codTurma > 0";
            if (turma > 0)
            {
                query += " AND aluno.codTurma = " + turma;
            }
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader alunos = comando.ExecuteReader();
            return alunos;
        }
        public MySqlDataReader buscaAlunosLista()
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "select codAluno,aluno.nome,RG,TIMESTAMPDIFF(YEAR,data_nascimento, NOW()) AS idade,data_nascimento,aluno.codTurma,turma.nome from aluno join turma on turma.codTurma = aluno.codTurma";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader alunos = comando.ExecuteReader();
            return alunos;
        }

        public MySqlDataReader buscaAlunoTurma(int codTurma)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codAluno,nome,RG,TIMESTAMPDIFF(YEAR,data_nascimento, NOW()) AS idade,data_nascimento,codTurma FROM sisgce.aluno where codTurma = '" + codTurma + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader alunos = comando.ExecuteReader();
            return alunos;
        }

        public MySqlDataReader buscaAlunoTurma(string RG, int codTurma)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codAluno,nome,RG,data_nascimento,codTurma FROM sisgce.aluno where RG = '" + RG + "' and codTurma <> '" + codTurma + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader alunos = comando.ExecuteReader();
            return alunos;
        }

        public MySqlDataReader buscaAluno(int codAluno)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT aluno.codAluno alunoCod, aluno.nome alunoNome,aluno.sexo as sexo, aluno.RG alunoRg,aluno.data_nascimento, cliente_responsavel.parentesco, cliente.nome as responsavelNome, cliente.CPF responsavelCPF FROM  sisgce.aluno join cliente_responsavel on cliente_responsavel.codAluno = aluno.codAluno join cliente on cliente_responsavel.codCliente  = cliente.idCliente where aluno.codAluno = '" + codAluno + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader alunos = comando.ExecuteReader();
            return alunos;
        }

        public bool AlteraAluno(modelAluno aluno)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`aluno` SET `nome`='"+aluno.Nome+"', `data_nascimento`='"+aluno.Data_nascimento+"', sexo = '"+aluno.Sexo+"' WHERE `codAluno`='"+aluno.CodAluno+"'";
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
