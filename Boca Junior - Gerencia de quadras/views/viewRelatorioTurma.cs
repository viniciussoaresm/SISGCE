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
    public partial class viewRelatorioTurma : Form
    {
        tools tools = new tools();
        controlerTurma controler = new controlerTurma();
        public viewRelatorioTurma()
        {
            InitializeComponent();
            carregaGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewRelatorioTurma_Load(object sender, EventArgs e)
        {

        }

        private void carregaGrid()
        {
          MySqlDataReader turmas =  controler.listaTurma();
            while(turmas.Read()){
                object[] values = new object[turmas.FieldCount];
                for (int i = 0; i < turmas.FieldCount; i++)
                {
                    values[i] = turmas.GetValue(i);
                    if (i == 3)
                    {
                        if (Convert.ToInt32(turmas.GetValue(i)) == 0)
                        {
                            values[i] = "Mirim";
                        }
                        if (Convert.ToInt32(turmas.GetValue(i)) == 1)
                        {
                            values[i] = "Junior";
                        }
                    }
                    if (i == 2)
                    {
                        if (Convert.ToInt32(turmas.GetValue(i)) == 0)
                        {
                            values[i] = "Manhã";
                        }
                        if (Convert.ToInt32(turmas.GetValue(i)) == 1)
                        {
                            values[i] = "Tarde";
                        }
                    }
                }
                dgvTurmas.Rows.Add(values);
            }

        }

        private void bntExcluirInstrutor_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirm = tools.formConfirmacao("Deseja Continuar?", "Excluir Aluno");

                if (confirm == true)
                {
                    controler.deleteTurma(Convert.ToInt32(this.dgvTurmas.CurrentRow.Cells[0].Value));
                    dgvTurmas.Rows.Clear();
                    this.carregaGrid();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao excluir turma!");
            }
        }

        private void dgvTurmas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            controler.carregaEdicao(Convert.ToInt32(this.dgvTurmas.CurrentRow.Cells[0].Value));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

                for (i = 0; i <= dgvTurmas.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvTurmas.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvTurmas[j, i];
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
