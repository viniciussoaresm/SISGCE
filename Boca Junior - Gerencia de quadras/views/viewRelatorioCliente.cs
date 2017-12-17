using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewRelatorioCliente : Form
    {
        tools tools = new tools();
        public viewRelatorioCliente(string operador)
        {

            InitializeComponent();
            this.inicializaGriCliente();
        }

        private void bntCliente_Click(object sender, EventArgs e)
        {
            try
            {
                dgvClienteRelatorio.Rows.Clear();
                controlerCliente cont = new controlerCliente();
                MySqlDataReader cliente = cont.buscaFormulario(txtClienteNome.Text, txtClienteCPF.Text);
                while (cliente.Read())
                {
                    object[] values = new object[cliente.FieldCount];
                    for (int i = 0; i < cliente.FieldCount; i++)
                        if (i == 5)
                        {
                            values[i] = cliente.GetValue(i).ToString().Substring(0, 10);
                        }
                        else
                        {
                            values[i] = cliente.GetValue(i);
                        }
                    dgvClienteRelatorio.Rows.Add(values);
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao pesquisar cliente!");
            }
        }
        public void inicializaGriCliente()
        {
            dgvClienteRelatorio.Rows.Clear();
            controlerCliente cont = new controlerCliente();
            MySqlDataReader cliente = cont.listaCliente();
            while (cliente.Read())
            {
                object[] values = new object[cliente.FieldCount];
                for (int i = 0; i < cliente.FieldCount; i++)

                    if (i == 5)
                    {
                        values[i] = cliente.GetValue(i).ToString().Substring(0, 10);
                    }
                    else
                    {
                        values[i] = cliente.GetValue(i);
                    }
                dgvClienteRelatorio.Rows.Add(values);
            }


        }

        private void dgvClienteRelatorio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controlerCliente cont = new controlerCliente();
            modelCliente Cliente = new modelCliente();
            cont.chamaFormEdicao(Convert.ToInt32(this.dgvClienteRelatorio.CurrentRow.Cells[0].Value));
        }



        private void bntClienteExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirm = tools.formConfirmacao("Deseja Continuar?", "Excluir Cliente");

                if (confirm == true)
                {
                    controlerCliente cont = new controlerCliente();
                    cont.excluiClienteGrid(this.dgvClienteRelatorio.CurrentRow.Cells[0].Value.ToString());
                    dgvClienteRelatorio.Rows.Clear();
                    this.inicializaGriCliente();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao excluir aluno!");
            }
            
            
        }

        private void viewRelatorioCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvClienteRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
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
                
                for (i = 0; i <= dgvClienteRelatorio.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvClienteRelatorio.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvClienteRelatorio[j, i];
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



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtClienteCPF.Clear();
                txtClienteNome.Clear();
                inicializaGriCliente();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Limpar Campos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

