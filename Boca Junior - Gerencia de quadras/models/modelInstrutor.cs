using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boca_Junior___Gerencia_de_quadras.models;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelInstrutor
    {
        private int codInstrutor;
        private string nome;
        private string RG;
        private string telefone;
        private string celular;
        private string CPF;
        private modelEnderecoInstrutor endereco;
        private int sexo;
        private string data_nasc;
        private string data_cadastro;

        public string Data_cadastro
        {
            get { return data_cadastro; }
            set { data_cadastro = value; }
        }

        public string Data_nasc
        {
            get { return data_nasc; }
            set { data_nasc = value; }
        }
        

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        internal modelEnderecoInstrutor Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string CPF1
        {
            get { return CPF; }
            set { CPF = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string RG1
        {
            get { return RG; }
            set { RG = value; }
        }       

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int CodInstrutor
        {
            get { return codInstrutor; }
            set { codInstrutor = value; }
        }




    }
}
