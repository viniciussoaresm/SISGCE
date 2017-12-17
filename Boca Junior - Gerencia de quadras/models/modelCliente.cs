using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelCliente
    {
        private int idCliente;
        private string nome;
        private string CPF;
        private string RG;
        private string telefone;
        private string telefone_op;
        private int sexo;
        private string data_nascimento;
        private string data_cadastro;
        private modelClienteEndereco endereco;

        internal modelClienteEndereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        public int Cliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return CPF; }
            set { CPF = value; }
        }
        public string Rg
        {
            get { return RG; }
            set { RG = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string TelefoneOp
        {
            get { return telefone_op; }
            set { telefone_op = value; }
        }
        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string DataNascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }
        public string DataCadastro
        {
            get { return data_cadastro; }
            set { data_cadastro = value; }
        }        
    }
}
