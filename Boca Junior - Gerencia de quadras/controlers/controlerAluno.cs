using Boca_Junior___Gerencia_de_quadras.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boca_Junior___Gerencia_de_quadras
{
    class controlerAluno
    {
        controlerOperador controler = new controlerOperador();
        daoTurma daoTurma = new daoTurma();
        daoAluno dAluno = new daoAluno();
        daoClienteResponsavel dResponsavel = new daoClienteResponsavel();

        public MySqlDataReader listaAlunos(string nome, string rg, int codturma)
        {

            if (nome == "" && rg == "" && codturma == 0)
            {
                return dAluno.buscaAlunosLista();

            }
            else
            {
                return dAluno.buscaAlunosLista(nome, rg, codturma);

            }
        }

        public void excluirAluno(int codAluno)
        {
            bool retorno = dAluno.excluirAluno(codAluno);
            if (retorno == true)
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao ExcluirS!");
            }
        }

        public void cadastrarAluno(modelAluno aluno, modelClienteResponsavel responsavel)
        {
            try
            {

                bool retorno = dAluno.cadastraAluno(aluno);
                if (retorno == true)
                {
                    MySqlDataReader Alunos = dAluno.buscaAlunoRg(aluno.RG1);
                    while (Alunos.Read())
                    {
                        aluno.CodAluno = Convert.ToInt32(Alunos["codAluno"]);
                        responsavel.Aluno = aluno;
                        dResponsavel.cadastraClienteResponsavel(responsavel);
                        MessageBox.Show("Aluno Cadastrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool validaForm(viewCadastroAluno view, bool edicao)
        {
            bool retorno = true;
            bool aux;
            tools tools = new tools();

            aux = tools.validaMaskText(view.mtbDataNascAluno);
            if (aux == false)
            {
                view.errorFormAluno.SetError(view.mtbDataNascAluno, "Campo Vazio!");
                retorno = false;

            }
            else
            {
                aux = tools.validaDataString(view.mtbDataNascAluno.Text);
                if (aux == false)
                {
                    view.errorFormAluno.SetError(view.mtbDataNascAluno, "Data Invalida!");
                    retorno = false;
                }
            }
            if (edicao == false)
            {
                if (validaRgAluno(view.txtRgAluno.Text) == false)
                {
                    view.errorFormAluno.SetError(view.txtRgAluno, "Aluno Já cadastrado!");
                    retorno = false;
                }
            }

            int rbSexo = tools.rbSexo(view.rbSexoMasculino, view.rbSexoFeminino);

            if (tools.validaRbSexo(rbSexo, view.errorFormAluno, view.gbSexoAluno) == false)
            {
                retorno = false;
            }

            if (tools.validaComboBox(view.cbParentescoResponsavel) == false)
            {
                view.errorFormAluno.SetError(view.cbParentescoResponsavel, "Selecione um parentesco!");
                retorno = false;
            }

            TextBox[] formsText = new TextBox[] { view.txtNomeAluno, view.txtRgAluno };
            foreach (TextBox text in formsText)
            {
                aux = tools.validaTextBox(text);
                if (aux == false)
                {
                    view.errorFormAluno.SetError(text, "Campo Vazio!");
                    retorno = false;
                }
            }
            return retorno;
        }
        public bool validaRgAluno(string RG)
        {
            daoAluno DAO = new daoAluno();
            MySqlDataReader aluno = DAO.buscaAlunoRg(RG);
            while (aluno.Read())
            {
                return false;
            }
            return true;
        }
        public void carregaComboBoxTurma(ComboBox comboAluno)
        {
            MySqlDataReader turma = daoTurma.listaTurma();


            List<modelTurma> list = new List<modelTurma>();
            list.Add(new modelTurma { CodTurma = 0, Nome = "TODAS AS TURMAS" });
            while (turma.Read())
            {
                list.Add(new modelTurma { CodTurma = Convert.ToInt32(turma["codTurma"]), Nome = turma["nome"].ToString() });
            }

            comboAluno.DataSource = list;
            comboAluno.DisplayMember = "nome";
            comboAluno.ValueMember = "codTurma";

        }


        public void chamaFormaEdicao(int codAluno, string operador)
        {

            modelAluno modelAluno = new modelAluno();
            modelCliente modelResponsalvel = new modelCliente();
            modelClienteResponsavel modelClienteResponsavel = new modelClienteResponsavel();
            MySqlDataReader aluno = dAluno.buscaAluno(codAluno);

            while (aluno.Read())
            {
                modelAluno.CodAluno = Convert.ToInt32(aluno["alunoCod"]);
                modelAluno.Nome = aluno["alunoNome"].ToString();
                modelAluno.RG1 = aluno["alunoRg"].ToString();
                modelAluno.Data_nascimento = aluno["data_nascimento"].ToString();
                modelResponsalvel.Nome = aluno["responsavelNome"].ToString();
                modelResponsalvel.Cpf = aluno["responsavelCPF"].ToString();
                modelClienteResponsavel.Parentesto = aluno["parentesco"].ToString();
                modelAluno.Sexo = Convert.ToInt32(aluno["sexo"]);

            }
            viewCadastroAluno cadastroAluno = new viewCadastroAluno(operador, true, modelAluno.CodAluno);
            setAluno(modelAluno, modelClienteResponsavel, modelResponsalvel, cadastroAluno);
        }
        public void setAluno(modelAluno aluno, modelClienteResponsavel responsavel, modelCliente cliente, viewCadastroAluno view)
        {
            view.txtNomeAluno.Text = aluno.Nome;
            view.txtRgAluno.Text = aluno.RG1;
            view.mtbDataNascAluno.Text = (DateTime.ParseExact(aluno.Data_nascimento, "dd/MM/yyyy HH:mm:ss", null)).ToString();
            view.txtNomeResponsavelAluno.Text = cliente.Nome;
            view.mtbCpfResponsavel.Text = cliente.Cpf;
            view.cbParentescoResponsavel.Text = responsavel.Parentesto;
            view.cbParentescoResponsavel.Enabled = false;
            view.txtNomeResponsavelAluno.Enabled = false;
            view.txtRgAluno.Enabled = false;
            if (aluno.Sexo == 1)
            {
                view.rbSexoMasculino.Checked = true;
            }
            if (aluno.Sexo == 0)
            {
                view.rbSexoFeminino.Checked = true;
            }
            view.carregaResponsavel();
            view.Show();
        }
        public void editaAluno(modelClienteResponsavel responsavel, modelAluno aluno)
        {
            daoClienteResponsavel dResponsavel = new daoClienteResponsavel();
            bool retorno = dAluno.AlteraAluno(aluno);

            if (retorno == true)
            {
                retorno = dResponsavel.alteraClienteResponsavel(responsavel);
                if (retorno == true)
                {
                    MessageBox.Show("Alterado com Sucesso!");
                }
            }
            if (retorno == false)
            {
                MessageBox.Show("Cadastro não Alterado!");

            }
        }
    }

}