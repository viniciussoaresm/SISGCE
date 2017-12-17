using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelEndereco
    {
        //teste
        private int codEndereco;
        private modelBairro bairro;
        private string cep;
        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public modelBairro Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public int CodEndereco
        {
            get { return codEndereco; }
            set { codEndereco = value; }
        }
    }
}
