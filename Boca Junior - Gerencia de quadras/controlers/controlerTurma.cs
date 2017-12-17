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
    class controlerTurma
    {
        daoAluno daoAluno = new daoAluno();
        tools tools = new tools();
        daoTurma daoTurma = new daoTurma();
        public void cadastrarTurma(modelTurma turma)
        {


            Boolean retorno = daoTurma.cadastrarTurma(turma);

            if (retorno == true)
            {
                MessageBox.Show("Turma cadastrada!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }

        }
        public void carregaComboBoxInstrutor(ComboBox comboInstrutor)
        {
            daoInstrutor DAO = new daoInstrutor();
            MySqlDataReader instrutores = DAO.buscaInstrutorLista();


            List<modelInstrutor> list = new List<modelInstrutor>();
            while (instrutores.Read())
            {
                list.Add(new modelInstrutor { CodInstrutor = Convert.ToInt32(instrutores["codInstrutor"]), Nome = instrutores["nome"].ToString() });
            }

            comboInstrutor.DataSource = list;
            comboInstrutor.DisplayMember = "nome";
            comboInstrutor.ValueMember = "codInstrutor";

        }
        public bool validaNomeTurma(string nome)
        {
            MySqlDataReader turma = daoTurma.buscaTurma(nome);
            while (turma.Read())
            {
                return true;
            }
            return false;
        }
        public bool ValidaForm(viewCadastrarTurma form, bool edicao)
        {
            bool retorno = true;
            if (validaNomeTurma(form.txtNomeTurma.Text) == true && edicao == false)
            {
                form.errorTurma.SetError(form.txtNomeTurma, "Nome de turma já Usado!");
                retorno = false;
            }
            if (form.cbInstrutorTurma.SelectedValue == null)
            {
                form.errorTurma.SetError(form.cbInstrutorTurma, "Selecione um Instrutor");
                retorno = false;
            }
            if (form.cbCategoriaTurma.SelectedItem == null)
            {
                form.errorTurma.SetError(form.cbCategoriaTurma, "Selecione um Instrutor");
                retorno = false;
            }
            if (form.cbPeriodoTurma.SelectedItem == null)
            {
                form.errorTurma.SetError(form.cbPeriodoTurma, "Selecione um Instrutor");
                retorno = false;
            }
            if (tools.validaTextBox(form.txtNomeTurma) == false)
            {
                form.errorTurma.SetError(form.txtNomeTurma, "Digite um nome para a turma");
                retorno = false;
            }
            return retorno;
        }

        public modelTurma buscaIdTurma(modelTurma Turma)
        {
            MySqlDataReader turmaB = daoTurma.buscaTurma(Turma);

            while (turmaB.Read())
            {
                Turma.CodTurma = Convert.ToInt32(turmaB["codTurma"]);
            }
            return Turma;
        }

        public modelAluno BuscaAlunoRg(string Rg, int codTurma)
        {
            modelAluno Aluno = new modelAluno();
            daoAluno DAO = new daoAluno();
            MySqlDataReader aluno = DAO.buscaAlunoTurma(Rg, codTurma);
            while (aluno.Read())
            {
                Aluno.Nome = aluno["nome"].ToString();
                Aluno.CodAluno = Convert.ToInt32(aluno["codAluno"]);
                Aluno.RG1 = aluno["RG"].ToString();
            }
            return Aluno;
        }

        public modelTurma buscaTurma(int codTurma)
        {
            modelInstrutor instrutor = new modelInstrutor();
            modelTurma turma = new modelTurma();
            MySqlDataReader turmaB = daoTurma.buscaTurma(codTurma);
            while (turmaB.Read())
            {
                turma.CodTurma = Convert.ToInt32(turmaB["codTurma"]);
                instrutor.CodInstrutor = Convert.ToInt32(turmaB["codInstrutor"]);
                turma.Periodo = Convert.ToInt32(turmaB["periodo"]);
                turma.Categoria = Convert.ToInt32(turmaB["categoria"]);
                turma.Nome = turmaB["nome"].ToString();
                turma.Instrutoor = instrutor;
            }
            return turma;
        }

        public bool listaALunos(int codTurma, viewInserirAluno view)
        {
            modelTurma turma = this.buscaTurma(codTurma);
            if (turma.CodTurma > 0)
            {
                view.dgvAdcionarAluno.Rows.Clear();
                MySqlDataReader alunos = daoAluno.buscaAlunoTurma(codTurma);
                while (alunos.Read())
                {
                    object[] values = new object[alunos.FieldCount];
                    for (int i = 0; i < alunos.FieldCount; i++)
                    {
                        values[i] = alunos.GetValue(i);
                    }
                    view.dgvAdcionarAluno.Rows.Add(values);
                }
                view.lblCodTurma.Text = turma.CodTurma.ToString();
                view.lblNomeTurma.Text = turma.Nome;
                view.lblPeriodoTurma.Text = turma.PeriodoString();
                view.lblCategoriaTurma.Text = turma.CategoriaString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void alteraTurmaAluno(int codAluno, int codTurma)
        {
            bool retorno = daoAluno.AlteraTurma(codAluno, codTurma);
            if (retorno == false)
            {
                MessageBox.Show("Erro ao Adiocionar/Retirar Aluno!");
            }
        }

        public MySqlDataReader listaTurma()
        {
            return daoTurma.listaTurma(true);
        }

        public void deleteTurma(int codTurma)
        {
            MySqlDataReader alunos = daoAluno.buscaAlunoTurma(codTurma);
            controlerAluno contAluno = new controlerAluno();
            while (alunos.Read())
            {
                this.alteraTurmaAluno(Convert.ToInt32(alunos["codAluno"]), 1);
            }

            bool retorno = daoTurma.deleteTurma(codTurma);
            if (retorno == true)
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            if (retorno == false)
            {
                MessageBox.Show("Falha ao excluir!");
            }
        }

        public void carregaEdicao(int codTurma){
            MySqlDataReader turma = daoTurma.buscaTurma(codTurma);
            modelInstrutor modelInst = new modelInstrutor();
            modelTurma modelTurma = new modelTurma();
            while (turma.Read())
            {
                modelTurma.CodTurma = Convert.ToInt32(turma["codTurma"]);
                modelTurma.Nome = turma["nome"].ToString();
                modelTurma.Periodo = Convert.ToInt32(turma["periodo"]);
                modelTurma.Categoria = Convert.ToInt32(turma["categoria"]);
                modelInst.CodInstrutor = Convert.ToInt32(turma["codInstrutor"]);
                modelInst.Nome = turma["instrutor"].ToString();
                modelTurma.Instrutoor = modelInst;
            }
            carregaFormEdicao(modelTurma);
        }

        public void carregaFormEdicao(modelTurma turma)
        {
            viewCadastrarTurma view = new viewCadastrarTurma(true);
            view.txtCodTurma.Text = turma.CodTurma.ToString();
            view.txtNomeTurma.Text = turma.Nome;
            view.cbCategoriaTurma.SelectedIndex = turma.Categoria;
            view.cbPeriodoTurma.SelectedIndex = turma.Periodo;
            view.carregaInstrutores();
            view.cbInstrutorTurma.Text = turma.Instrutoor.Nome;
            view.Show();
        }
        public void alteraTurma(modelTurma turma)
        {   
            bool retorno = daoTurma.alteraTurma(turma);
            if (retorno == true)
            {
                MessageBox.Show("Alterado com sucesso!");
            }
            if (retorno == false)
            {
                MessageBox.Show("Falha ao Alterar!");
            }    
        }

    }
}

