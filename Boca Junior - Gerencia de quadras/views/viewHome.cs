using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewHome : Form
    {
        controlerReserva reservaControler = new controlerReserva();
        controlerTurma controler = new controlerTurma();
        public viewHome(string operador)
        {
            InitializeComponent();
            lblLogin.Text = operador;
            dgvReservas.Rows.Clear();
            carregarGrid();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCadastroAluno view = new viewCadastroAluno(lblLogin.Text,false,0);
            view.Show();
        }

        private void bntCadastrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void bntReservarQuadra_Click(object sender, EventArgs e)
        {
            viewReservaQuadra viewReservaQuadra = new viewReservaQuadra();
            viewReservaQuadra.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuClienteAbr_Click(object sender, EventArgs e)
        {
            viewRelatorioCliente view = new viewRelatorioCliente(lblLogin.Text);
            view.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void viewHome_Load(object sender, EventArgs e)
        {
        }
        public void carregarGrid()
        {
            controlerReserva controler = new controlerReserva();
            MySqlDataReader reservas = controler.listaReserva();
            dgvReservas.Rows.Clear();
            while (reservas.Read())
            {
                object[] values = new object[reservas.FieldCount];
                for (int i = 0; i < reservas.FieldCount; i++)
                {
                    if (i == 3)
                    {
                        values[i] = (DateTime.ParseExact(reservas.GetValue(i).ToString(), "dd/MM/yyyy HH:mm:ss", null)).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        values[i] = reservas.GetValue(i);
                    }

                }
                dgvReservas.Rows.Add(values);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();

        }

        private void menuClienteCad_Click(object sender, EventArgs e)
        {
            viewTelaCadastroCliente viewCadastroCliente = new viewTelaCadastroCliente(lblLogin.Text, false);
            viewCadastroCliente.Show();
        }

        private void menuReservaCriar_Click(object sender, EventArgs e)
        {
            viewReservaQuadra viewReservaQuadra = new viewReservaQuadra();
            viewReservaQuadra.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuInstrutorCad_Click(object sender, EventArgs e)
        {
            viewCadastroFunionario view = new viewCadastroFunionario(lblLogin.Text,false,0);
            view.Show();
        }

        private void cADASTRARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewCadastrarTurma view = new viewCadastrarTurma(false);
            view.Show();
        }


        private void aDIDIONARALUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Insira o codigo da Turma", "Adicionar Aluno", "Codigo da Turma"));
                viewInserirAluno view = new viewInserirAluno();
                if (controler.listaALunos(cod, view) == true)
                {
                    view.Show();

                }
                else
                {
                    MessageBox.Show("Turma não encontrada");

                }
            }
            catch (Exception ex)
            {
            }

        }

        private void menuInstrutorAbr_Click(object sender, EventArgs e)
        {
            viewRelatorioFuncionariocs view = new viewRelatorioFuncionariocs();
            view.Show();
        }

        private void menuAlunoAbr_Click(object sender, EventArgs e)
        {
            viewTelaRelatorioAluno view = new viewTelaRelatorioAluno();
            view.Show();
        }

        private void menuLoginAdm_Click(object sender, EventArgs e)
        {
            viewGerenciarLogin view = new viewGerenciarLogin();
            view.Show();
        }

        private void menuReservaAbr_Click(object sender, EventArgs e)
        {
            viewRelatorioReserva view = new viewRelatorioReserva();
            view.Show();
        }

        private void rELATORIODOTURMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewRelatorioTurma view = new viewRelatorioTurma();
            view.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtRelogioHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reservaControler.atualizaStatus();
            dgvReservas.Rows.Clear();
            carregarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewCadastroAluno view = new viewCadastroAluno(lblLogin.Text, false, 0);
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewTelaRelatorioAluno view = new viewTelaRelatorioAluno();
            view.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewCadastroFunionario view = new viewCadastroFunionario(lblLogin.Text, false, 0);
            view.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewRelatorioFuncionariocs view = new viewRelatorioFuncionariocs();
            view.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            viewTelaCadastroCliente viewCadastroCliente = new viewTelaCadastroCliente(lblLogin.Text, false);
            viewCadastroCliente.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewRelatorioCliente view = new viewRelatorioCliente(lblLogin.Text);
            view.Show();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            viewGerenciarLogin view = new viewGerenciarLogin();
            view.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            viewCadastrarTurma view = new viewCadastrarTurma(false);
            view.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Insira o codigo da Turma", "Adicionar Aluno", "Codigo da Turma"));
                viewInserirAluno view = new viewInserirAluno();
                if (controler.listaALunos(cod, view) == true)
                {
                    view.Show();

                }
                else
                {
                    MessageBox.Show("Turma não encontrada");

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            viewRelatorioTurma view = new viewRelatorioTurma();
            view.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            viewReservaQuadra viewReservaQuadra = new viewReservaQuadra();
            viewReservaQuadra.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            viewRelatorioReserva view = new viewRelatorioReserva();
            view.Show();
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
