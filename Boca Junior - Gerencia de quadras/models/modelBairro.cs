using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelBairro
    {
        private int codBairro;
        private modelCidade cidade;
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public modelCidade Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public int CodBairro
        {
            get { return codBairro; }
            set { codBairro = value; }
        }
    }
}
