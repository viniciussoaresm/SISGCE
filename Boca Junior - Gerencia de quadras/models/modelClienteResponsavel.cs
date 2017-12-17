using Boca_Junior___Gerencia_de_quadras.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelClienteResponsavel
    {
        int codClienteResponsavel;
        modelCliente cliente;
        modelAluno aluno;
        string parentesto;

        public string Parentesto
        {
            get { return parentesto; }
            set { parentesto = value; }
        }

        internal modelAluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        internal modelCliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public int CodClienteResponsavel
        {
            get { return codClienteResponsavel; }
            set { codClienteResponsavel = value; }
        }
    }
}
