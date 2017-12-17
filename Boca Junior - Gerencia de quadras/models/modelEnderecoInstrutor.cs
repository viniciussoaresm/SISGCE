using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boca_Junior___Gerencia_de_quadras.models
{
    class modelEnderecoInstrutor
    {
        private int codInstrutorEndereco;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string CEP;
        private string numero;
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string CEP1
        {
            get { return CEP; }
            set { CEP = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int CodInstrutorEndereco
        {
            get { return codInstrutorEndereco; }
            set { codInstrutorEndereco = value; }
        } 
    }
}
