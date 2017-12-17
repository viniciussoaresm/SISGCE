using Boca_Junior___Gerencia_de_quadras.models;
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
    public partial class viewInserirAluno : Form
    {
        controlerTurma controler = new controlerTurma();
        modelAluno alunoOP = new modelAluno();
        public viewInserirAluno()
        {
            InitializeComponent();
        }

        private void lblCodTurma_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            bntRetirar.Enabled = false;
            if (txtRgAluno.TextLength > 0)
            {
                for (int i = 0; i < dgvAdcionarAluno.RowCount - 1; i++)
                {
                    if (dgvAdcionarAluno.Rows[i].Cells["rg"].Value.ToString() == txtRgAluno.Text)
                    {
                        txtNomeAluno.Text = dgvAdcionarAluno.Rows[i].Cells["nome"].Value.ToString();
                        alunoOP.CodAluno = Convert.ToInt32(dgvAdcionarAluno.Rows[i].Cells["codAluno"].Value);
                        bntRetirar.Enabled = true;
                        bntIncluirAluno.Enabled = false;
                        break;
                    }
                }
                if (bntRetirar.Enabled == false)
                {
                    modelAluno aluno = controler.BuscaAlunoRg(txtRgAluno.Text, Convert.ToInt32(lblCodTurma.Text));
                    if (aluno.CodAluno > 0)
                    {
                        txtNomeAluno.Text = aluno.Nome;
                        alunoOP = aluno;
                        bntIncluirAluno.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado!!");
                    }
                }

            }
        }

        private void bntIncluirAluno_Click(object sender, EventArgs e)
        {
            controler.alteraTurmaAluno(alunoOP.CodAluno, Convert.ToInt32(lblCodTurma.Text));
            controler.listaALunos(Convert.ToInt32(lblCodTurma.Text), this);
            bntIncluirAluno.Enabled = false;
            txtNomeAluno.Clear();
            txtRgAluno.Clear();
        }

        private void bntRetirar_Click(object sender, EventArgs e)
        {
            controler.alteraTurmaAluno(alunoOP.CodAluno, 1);
            controler.listaALunos(Convert.ToInt32(lblCodTurma.Text), this);
            bntRetirar.Enabled = false;
            txtNomeAluno.Clear();
            txtRgAluno.Clear();
        }


        private void dgvAdcionarAluno_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            alunoOP.CodAluno = Convert.ToInt32(this.dgvAdcionarAluno.CurrentRow.Cells[0].Value);
            txtRgAluno.Text = alunoOP.RG1 = this.dgvAdcionarAluno.CurrentRow.Cells[2].Value.ToString();
            txtNomeAluno.Text = alunoOP.Nome = this.dgvAdcionarAluno.CurrentRow.Cells[1].Value.ToString();
            bntRetirar.Enabled = true;
        }

        private void viewInserirAluno_Load(object sender, EventArgs e)
        {

        }

        private void dgvAdcionarAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
