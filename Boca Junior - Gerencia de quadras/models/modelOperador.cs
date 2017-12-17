using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boca_Junior___Gerencia_de_quadras
{
    class modelOperador
    {
        private int codOperador;
        private string nome;
        private string login;
        private string senha;
        private int adm;
        private int ativo;

        public int Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public int Adm
        {
            get { return adm; }
            set { adm = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int CodOperador
        {
            get { return codOperador; }
            set { codOperador = value; }
        }
    }
}
