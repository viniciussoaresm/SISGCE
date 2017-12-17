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
    public partial class viewTelaRelatorioAluno : Form
    {
        tools tools = new tools();
        controlerAluno controler = new controlerAluno();
        public viewTelaRelatorioAluno()
        {
            InitializeComponent();
            carregaGrid();           
            controler.carregaComboBoxTurma(cbTurma);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cbTurma.SelectedIndex = 0;
                txtNome.Text = "";
                txtRg.Text = "";
                carregaGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao limpar "+ex.Message);
            }
           
        }

        private void bntClientePesquisa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRelatorioAluno.Rows.Clear();
                carregaGrid();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao pesquisar aluno!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void carregaGrid()
        {
           MySqlDataReader alunos = controler.listaAlunos(txtNome.Text,txtRg.Text,Convert.ToInt32(cbTurma.SelectedValue));
           if (alunos != null)
            {

                dgvRelatorioAluno.Rows.Clear();
                while (alunos.Read())
                {
                    object[] values = new object[alunos.FieldCount];
                    for (int i = 0; i < alunos.FieldCount; i++)
                    {
                        if (i == 4)
                        {
                            values[i] = (DateTime.ParseExact(alunos.GetValue(i).ToString(), "dd/MM/yyyy HH:mm:ss", null)).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            values[i] = alunos.GetValue(i);
                        }

                    }
                    dgvRelatorioAluno.Rows.Add(values);

                }

            }
           
            
        }
        private void carregaData()
        {
            
        }

        private void viewTelaRelatorioAluno_Load(object sender, EventArgs e)
        {

            
        }

        private void dgvAlunos_Enter(object sender, EventArgs e)
        {

        }
        private void dgvRelatorioAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controler.chamaFormaEdicao(Convert.ToInt32(this.dgvRelatorioAluno.CurrentRow.Cells[0].Value),"Vinicius");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirm = tools.formConfirmacao("Deseja Continuar?", "Excluir Aluno");

                if (confirm == true)
                {
                    controler.excluirAluno(Convert.ToInt32(this.dgvRelatorioAluno.CurrentRow.Cells[0].Value));
                    dgvRelatorioAluno.Rows.Clear();
                    this.carregaGrid();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao excluir aluno!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvar = new SaveFileDialog();
                Excel.Application App; // Aplicação Excel
                Excel.Workbook WorkBook; // Pasta
                Excel.Worksheet WorkSheet; // Planilha
                object misValue = System.Reflection.Missing.Value;
                App = new Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
               
                int i = 0;
                int j = 0;
                // passa as celulas do DataGridView para a Pasta do Excel
                for (i = 2; i <= dgvRelatorioAluno.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvRelatorioAluno.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvRelatorioAluno[j, i];
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRelatorioAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

       
    }
}
