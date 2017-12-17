using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelCidade
    {
        private int codCidade;
        private modelUf uf;

        internal modelUf Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cidadeCep;

        public string CidadeCep
        {
            get { return cidadeCep; }
            set { cidadeCep = value; }
        }
        public int CodCidade
        {
            get { return codCidade; }
            set { codCidade = value; }
        }
    }
}
