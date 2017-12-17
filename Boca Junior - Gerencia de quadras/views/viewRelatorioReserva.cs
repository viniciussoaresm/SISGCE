using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewRelatorioReserva : Form
    {
        daoReserva reserva = new daoReserva();
        controlerReserva controler = new controlerReserva();
        public viewRelatorioReserva()
        {
            InitializeComponent();
            carregaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRelatorioAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void carregaGrid()
        {
           MySqlDataReader reservas = controler.listaReservas();
           if (reservas != null)
            {

                dgvReserva.Rows.Clear();
                while (reservas.Read())
                {
                    object[] values = new object[reservas.FieldCount];
                    for (int i = 0; i < reservas.FieldCount; i++)
                    {
                        if (i == 2)
                        {
                            values[i] = (DateTime.ParseExact(reservas.GetValue(i).ToString(), "dd/MM/yyyy HH:mm:ss", null)).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            values[i] = reservas.GetValue(i);
                        }

                    }
                    dgvReserva.Rows.Add(values);

                }

            }
        }

        private void bntExcluirInstrutor_Click(object sender, EventArgs e)
        {
            reserva.deletaReserva(this.dgvReserva.CurrentRow.Cells[0].Value.ToString());
            carregaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReserva.Rows.Clear();
                MySqlDataReader reservas = controler.listaReservas(txtBusca.Text);
                if (reservas != null)
                {

                    dgvReserva.Rows.Clear();
                    while (reservas.Read())
                    {
                        object[] values = new object[reservas.FieldCount];
                        for (int i = 0; i < reservas.FieldCount; i++)
                        {
                            if (i == 2)
                            {
                                values[i] = (DateTime.ParseExact(reservas.GetValue(i).ToString(), "dd/MM/yyyy HH:mm:ss", null)).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                values[i] = reservas.GetValue(i);
                            }

                        }
                        dgvReserva.Rows.Add(values);

                    }

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao pesquisar campos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReserva.Rows.Clear();
                carregaGrid();
                txtBusca.Text = "";
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao limpar campos!");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvar = new SaveFileDialog();
                Excel.Application App;
                Excel.Workbook WorkBook;
                Excel.Worksheet WorkSheet;
                object misValue = System.Reflection.Missing.Value;
                App = new Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dgvReserva.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvReserva.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvReserva[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }
                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo *.xls | *.xls";
                salvar.ShowDialog();
                WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit();
                MessageBox.Show("Exportado com sucesso!");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erro ao gerar o excel ! " + exp.Message);
            }
        }
    }
}
