using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewCadastrarTurma : Form
    {
        bool edicaoOp;
        controlerTurma controler = new controlerTurma();
        public viewCadastrarTurma(bool edicao)
        {
            edicaoOp = edicao;
            InitializeComponent();
            carregaInstrutores();
        }
        public void carregaInstrutores()
        {
            controler.carregaComboBoxInstrutor(this.cbInstrutorTurma);

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                errorTurma.Clear();
                bool validacao = controler.ValidaForm(this, edicaoOp);

                if (validacao == true)
                {
                    modelInstrutor instrutor = new modelInstrutor();
                    modelTurma turma = new modelTurma();
                    instrutor.CodInstrutor = Convert.ToInt32(cbInstrutorTurma.SelectedValue);
                    instrutor.Nome = cbInstrutorTurma.SelectedText;
                    turma.Instrutoor = instrutor;
                    turma.Nome = txtNomeTurma.Text;
                    turma.Periodo = cbPeriodoTurma.SelectedIndex;
                    turma.Categoria = cbCategoriaTurma.SelectedIndex;
                    if (edicaoOp == false)
                    {
                        controler.cadastrarTurma(turma);
                        turma = controler.buscaIdTurma(turma);
                        txtCodTurma.Text = turma.CodTurma.ToString();
                    }
                    else
                    {
                        turma.CodTurma = Convert.ToInt32(txtCodTurma.Text);
                        controler.alteraTurma(turma);
                    }
                    gbOpcao.Enabled = true;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Salvar Turma!");
            }
            }
        
    
        
        private void bntAddAluno_Click(object sender, EventArgs e)
        {
            try
            {
                viewInserirAluno view = new viewInserirAluno();
                controler.listaALunos(Convert.ToInt32(txtCodTurma.Text), view);
                view.Show();
            }
            catch (Exception exe) {
                MessageBox.Show("Erro ao adicionar aluno!");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try{
                viewCadastrarTurma view = new viewCadastrarTurma(false);
                view.Show();
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao adicionar nova Turma!");
            }

            
        }

        private void cbInstrutorTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewCadastrarTurma_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
