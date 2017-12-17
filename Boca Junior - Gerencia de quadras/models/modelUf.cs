using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelUf
    {
        private int codUf;
        private string sigla;

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int CodUf
        {
            get { return codUf; }
            set { codUf = value; }
        }
        
    }
}
