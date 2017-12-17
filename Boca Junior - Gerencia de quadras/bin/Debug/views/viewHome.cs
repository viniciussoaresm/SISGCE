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

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewHome : Form
    {
        public viewHome()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastrarCliente_Click(object sender, EventArgs e)
        {
            viewTelaCadastroCliente viewCadastroCliente = new viewTelaCadastroCliente();
            viewCadastroCliente.Show();
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
            viewRelatorioCliente view = new viewRelatorioCliente();
            view.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void viewHome_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtRelogioHome.Text = DateTime.Now.ToShortTimeString(); 

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
