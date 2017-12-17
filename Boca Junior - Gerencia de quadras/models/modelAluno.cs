using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras.models
{
    class modelAluno
    {
        int codAluno;
        string categoria;
        string RG;
        string nome;
        string data_nascimento;
        int sexo;

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Data_nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string RG1
        {
            get { return RG; }
            set { RG = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int CodAluno
        {
            get { return codAluno; }
            set { codAluno = value; }
        }
    }
}


