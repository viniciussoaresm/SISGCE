using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelTurma
    {
        private int periodo;
        private int categoria;
        private string nome;
        private modelInstrutor instrutoor;
        private int codTurma;

        public int CodTurma
        {
            get { return codTurma; }
            set { codTurma = value; }
        }

        internal modelInstrutor Instrutoor
        {
            get { return instrutoor; }
            set { instrutoor = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public String CategoriaString()
        {
            switch (categoria)
            {
                case 0:
                    return "Mirim";
                    break;
                case 1:
                    return "junior";
                    break;
            }
            return "Não definido";
        }
        public String PeriodoString()
        {
            switch (periodo)
            {
                case 0:
                    return "Manhã";
                    break;
                case 1:
                    return "Tarde";
                    break;
            }
            return "Não definido";
        }
        public int Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
    }
}
