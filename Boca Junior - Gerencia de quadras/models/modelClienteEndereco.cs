using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelClienteEndereco
    {
        private int idClienteEndereco;
        private string Cep;
        private string rua;
        private string numero;
        private string bairro;
        private string estado;
        private string complemento;
        private string cidade;


        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public int IdClienteEndereco
        {
            get { return idClienteEndereco; }
            set { idClienteEndereco = value; }
        }
        public string CEP
        {
            get { return Cep; }
            set { Cep = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

    }
}
