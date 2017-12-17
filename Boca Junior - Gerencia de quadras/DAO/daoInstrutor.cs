using Boca_Junior___Gerencia_de_quadras.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class daoInstrutor
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;
        public bool cadastroEnderecoInstrutor(modelEnderecoInstrutor endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO `sisgce`.`instrutor_endereco` (`rua`, `bairro`, `cidade`, `estado`, `cep`,numero,complemento) VALUES ('"+endereco.Rua+"', '"+endereco.Bairro+"', '"+endereco.Cidade+"', '"+endereco.Estado+"', '"+endereco.CEP1+"','"+endereco.Numero+"','"+endereco.Complemento+"')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public string cadastroInstrutor(modelInstrutor instrutor)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO `sisgce`.`instrutor` (`nome`, `RG`, `telefone`, `telefoneOp`, `CPF`, `codEnderecoInstrutor`,sexo,data_nascimento,data_cadastro) VALUES ('" + instrutor.Nome + "', '" + instrutor.RG1 + "', '" + instrutor.Telefone + "', '" + instrutor.Celular + "', '" + instrutor.CPF1 + "', '" + instrutor.Endereco.CodInstrutorEndereco + "','" + instrutor.Sexo + "','"+instrutor.Data_nasc+"','"+instrutor.Data_cadastro+"')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Cadastrado com Sucesso!";
        }

        public MySqlDataReader buscaEnderecoInstrutor(modelEnderecoInstrutor endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codInstrutorEndereco FROM sisgce.instrutor_endereco WHERE rua = '" + endereco.Rua + "' and numero = '" + endereco.Numero + "' and cidade = '" + endereco.Cidade + "'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader enderecoInstrutor = comando.ExecuteReader();
                return enderecoInstrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public MySqlDataReader buscaInstrutor(string CPF)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT * FROM sisgce.instrutor where CPF = " + CPF;
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader Instrutor = comando.ExecuteReader();
                return Instrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public MySqlDataReader buscaInstrutor(string CPF,string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codInstrutor,nome,RG,telefone,CPF,data_nascimento,codEnderecoInstrutor FROM sisgce.instrutor where CPF = " + CPF + " and nome = '" + nome + "'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader Instrutor = comando.ExecuteReader();
                return Instrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       public MySqlDataReader buscaInstrutorLista()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codInstrutor,nome FROM sisgce.instrutor";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader Instrutor = comando.ExecuteReader();
                return Instrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public MySqlDataReader buscaInstrutorListaGrid()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codInstrutor,nome,RG,telefone,CPF,data_nascimento,codEnderecoInstrutor FROM sisgce.instrutor where codInstrutor > 1";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader Instrutor = comando.ExecuteReader();
                return Instrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public MySqlDataReader buscaInstrutorListaGrid(string NOME)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codInstrutor,nome,RG,telefone,CPF,data_nascimento,codEnderecoInstrutor FROM sisgce.instrutor where codInstrutor > 1 AND nome like '"+NOME+"%'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader Instrutor = comando.ExecuteReader();
                return Instrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public MySqlDataReader buscaInstrutor(int codInstrutor)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT * FROM sisgce.instrutor inst LEFT JOIN instrutor_endereco as end on end.codInstrutorEndereco = inst.codEnderecoInstrutor where codInstrutor = '" + codInstrutor + "'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader Instrutor = comando.ExecuteReader();
                return Instrutor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AlterarInstrutor(modelInstrutor instrutor)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`instrutor` SET `nome`='"+instrutor.Nome+"', `RG`='"+instrutor.RG1+"', `telefone`='"+instrutor.Telefone+"', `telefoneOp`='"+instrutor.Celular+"', `CPF`='"+instrutor.CPF1+"' WHERE `codInstrutor`='"+instrutor.CodInstrutor+"'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AlterarEnderecoInstrutor(modelEnderecoInstrutor endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`instrutor_endereco` SET `rua`='"+endereco.Rua+"', `bairro`='"+endereco.Bairro+"', `cidade`='"+endereco.Cidade+"', `estado`='"+endereco.Estado+"', `cep`='"+endereco.CEP1+"', `numero`='"+endereco.Numero+"', `complemento`='"+endereco.Complemento+"' WHERE `codInstrutorEndereco`='"+endereco.CodInstrutorEndereco+"'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeletarEnderecoInstrutor(modelEnderecoInstrutor endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "delete from instrutor_endereco where codInstrutorEndereco = '"+endereco.CodInstrutorEndereco+"'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeletarInstrutor(modelInstrutor instrutor)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "delete from instrutor where codInstrutor = '" + instrutor.CodInstrutor + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public int buscaCodEnderecoInstrutor(int codEndereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "SELECT codEnderecoInstrutor from instrutor where codInstrutor = '" + codEndereco + "'";
                comando = new MySqlCommand(query, conexaoDb);
                MySqlDataReader cod = comando.ExecuteReader();
                while (cod.Read())
                {
                    return Convert.ToInt32(cod["codEnderecoInstrutor"]);
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        
       // INSERT INTO `sisgce`.`instrutor` (`nome`, `periodo`, `RG`, `telefone`, `telefoneOp`, `CPF`, `codEnderecoInstrutor`) VALUES ('Matheus', '1', '321321312', '2321321312', '2131231232', '2132132131', '1');
        //INSERT INTO `sisgce`.`instrutor_endereco` (`rua`, `bairro`, `cidade`, `estado`, `cep`) VALUES ('Rua A', 'Bairro 1', 'Paulinia', 'SP', '2332432432423');

    }
}
