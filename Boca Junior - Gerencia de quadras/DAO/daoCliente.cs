using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Boca_Junior___Gerencia_de_quadras
{
    class daoCliente
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;
        public string cadastroCliente(modelCliente cliente)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO cliente (nome, CPF, RG, telefone,telefone_op,sexo,data_nascimento,data_cadastro,codClienteEndereco) VALUES ('" + cliente.Nome + "','" + cliente.Cpf + "','" + cliente.Rg + "','" + cliente.Telefone + "','" + cliente.TelefoneOp + "','" + cliente.Sexo + "','" + cliente.DataNascimento + "','" + cliente.DataCadastro + "','" + cliente.Endereco.IdClienteEndereco + "')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Cadastrado com Sucesso!";
        }
        public bool alteraEnderecoCliente(modelClienteEndereco endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`cliente_endereco` SET `cep` = '" + endereco.CEP + "', `rua` = '" + endereco.Rua + "', `numero` = '" + endereco.Numero + "', `bairro` = '" + endereco.Bairro + "', `estado` = '" + endereco.Estado + "', `complemento` = '" + endereco.Complemento + "', `cidade` = '" + endereco.Cidade + "'WHERE `codClienteEndereco` = " + endereco.IdClienteEndereco;
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public string cadastrarEnderecoCliente(modelClienteEndereco endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "INSERT INTO sisgce.cliente_endereco (cep, rua,numero, bairro, estado, complemento, cidade) VALUES ('" + endereco.CEP + "','" + endereco.Rua + "','" + endereco.Numero + "', '" + endereco.Bairro + "', '" + endereco.Estado + "', '" + endereco.Complemento + "','" + endereco.Cidade + "')";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Cadastrado com Sucesso!";
        }
        public MySqlDataReader buscarCliente()
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "select idCliente,nome,CPF,telefone,telefone_op,data_nascimento,data_cadastro,data_cadastro,cep,estado,cidade,bairro,rua,numero,complemento from cliente inner join cliente_endereco on cliente_endereco.codClienteEndereco = cliente.codClienteEndereco ORDER BY nome ASC";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
            return clientes;
        }

       

        public MySqlDataReader buscaClienteCPF(string CPF)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT * FROM cliente WHERE CPF LIKE '%" + CPF + "%'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
            return clientes;
        }
        public MySqlDataReader buscarClienteRelatorio(string nome, string CPF)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT idCliente,nome,CPF,telefone,telefone_op,data_nascimento,data_cadastro,data_cadastro,cep,estado,cidade,bairro,rua,numero,complemento from cliente inner join cliente_endereco on cliente_endereco.codClienteEndereco = cliente.codClienteEndereco WHERE nome LIKE '%" + nome + "%' AND CPF LIKE '%" + CPF + "%'  ORDER BY nome ASC";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
            return clientes;

        }

        public MySqlDataReader buscaEnderecoCliente(modelCliente cliente)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT * FROM sisgce.cliente_endereco WHERE codClienteEndereco = " + cliente.Endereco.IdClienteEndereco;
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
            return clientes;
        }
        public MySqlDataReader carregaCliente(int codCliente)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = " SELECT * FROM sisgce.cliente join cliente_endereco on cliente_endereco.codClienteEndereco = cliente.codClienteEndereco where idCliente = " + codCliente;
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
            return clientes;
        }
        public int buscaEnderecoCliente(string cep, string numero)
        {
            int codEndereco = 0;
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codClienteEndereco FROM sisgce.cliente_endereco WHERE cep = '" + cep + "' AND numero = '" + numero + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader endereco = comando.ExecuteReader();
            while (endereco.Read())
            {
                codEndereco = Convert.ToInt32(endereco["codClienteEndereco"]);
            }
            return codEndereco;
        }
        public void excluirCliente(string idCliente)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "DELETE FROM sisgce.cliente WHERE idCliente = " + idCliente;
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
        }
        public void excluirEnderecoCliente(string id)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "DELETE FROM sisgce.cliente_endereco where codClienteEndereco = " + id;
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader clientes = comando.ExecuteReader();
        }
        public string alterandoCliente(modelCliente Cliente)
        {

            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE sisgce.cliente SET nome = '" + Cliente.Nome + "',CPF = '" + Cliente.Cpf + "', RG = '" + Cliente.Rg + "',telefone ='" + Cliente.Telefone + "', telefone_op = '" + Cliente.TelefoneOp + "',sexo = '" + Cliente.Sexo + "',data_nascimento = '" + Cliente.DataNascimento + "' WHERE idCliente = " + Cliente.Cliente;
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Alterado com Sucesso!";

        }
        public bool alterandoEnderecoCliente(modelClienteEndereco endereco)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE sisgce.cliente_endereco SET `rua`='" + endereco.Rua + "',`numero`='" + endereco.Numero + "', `bairro`='" + endereco.Bairro + "', `complemento`='" + endereco.Complemento + "', `cidade`='" + endereco.Cidade + "', `estado`='" + endereco.Estado + "' WHERE `codClienteEndereco`='" + endereco.IdClienteEndereco + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
          

        }
        public string buscaIdEndereco(string idCliente)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codClienteEndereco FROM sisgce.cliente where idCliente = " + idCliente;
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader cliente = comando.ExecuteReader();
            while (cliente.Read())
            {
                return cliente["codClienteEndereco"].ToString();
            }
            return null;
        }

        public bool boolValidaCPF(string cpf)
        {
            MySqlDataReader cliente  = this.buscaClienteCPF(cpf);
            while (cliente.Read())
            {
                return true;
            }
            return false;
        }

    }


}
