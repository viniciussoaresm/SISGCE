using Boca_Junior___Gerencia_de_quadras.models;
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
    public partial class viewRelatorioFuncionariocs : Form
    {
        controlerInstrutor controler = new controlerInstrutor();
        modelInstrutor instrutorOp = new modelInstrutor();
        public viewRelatorioFuncionariocs()
        {
            InitializeComponent();
            carregaGridInstrutor(controler.listaInstrutores());
        }
        private void dgvInstrutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chamaFormEdicao(Convert.ToInt32(this.dgvInstrutores.CurrentRow.Cells[0].Value));
        }
        public void carregaGridInstrutor(MySqlDataReader instrutores)
        {
            if (instrutores != null)
            {

                dgvInstrutores.Rows.Clear();
                while (instrutores.Read())
                {
                    object[] values = new object[instrutores.FieldCount];
                    for (int i = 0; i < instrutores.FieldCount; i++)
                    {
                        if (i == 5)
                        {
                            values[i] = (DateTime.ParseExact(instrutores.GetValue(i).ToString(), "dd/MM/yyyy HH:mm:ss", null)).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            values[i] = instrutores.GetValue(i);
                        }

                    }
                    dgvInstrutores.Rows.Add(values);

                }

            }
                
        }

        private void chamaFormEdicao(int codInstrutor)
        {
            viewCadastroFunionario form = new viewCadastroFunionario("", true,codInstrutor);
            instrutorOp = controler.carregarInstrutor(codInstrutor);
            form.txtNomeInstrutor.Text = instrutorOp.Nome;
            form.txtRgInstrutor.Text = instrutorOp.RG1;
            form.mtbDataNascInstrutor.Text = (DateTime.ParseExact(instrutorOp.Data_nasc, "dd/MM/yyyy HH:mm:ss", null)).ToString();
            form.mtbCpfInstrutor.Text = instrutorOp.CPF1;
            if(instrutorOp.Sexo == 0){
                form.rbSexoInstrutorM.Checked = true;
            }
            else
            {
                form.rbSexoInstrutorF.Checked = true;
            }
            form.mtbTelefoneInstrutor.Text = instrutorOp.Telefone;
            form.mtbTelefoneInstrutorOp.Text = instrutorOp.Celular;
            form.mtbCpfInstrutor.Text = instrutorOp.CPF1;
            form.mtbCepInstrutor.Text = instrutorOp.Endereco.CEP1;
            form.cbUfInstrutor.Text = instrutorOp.Endereco.Estado;
            form.cbCidadeEnderecoInstrutor.Text = instrutorOp.Endereco.Cidade;
            form.cbBairroInstrutor.Text = instrutorOp.Endereco.Bairro;
            form.txtRuaInstrutor.Text = instrutorOp.Endereco.Rua;
            form.txtNumeroInstrutor.Text = instrutorOp.Endereco.Numero;
            form.txtCompleInstrutor.Text = instrutorOp.Endereco.Complemento;
            form.mtbCpfInstrutor.Enabled = false;
            form.Show();
            this.Close();
        }



        private void viewRelatorioFuncionariocs_Load(object sender, EventArgs e)
        {

        }

        private void dgvInstrutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                modelEnderecoInstrutor endereco = new modelEnderecoInstrutor();
                instrutorOp.CodInstrutor = Convert.ToInt32(this.dgvInstrutores.CurrentRow.Cells[0].Value);
                endereco.CodInstrutorEndereco = Convert.ToInt32(this.dgvInstrutores.CurrentRow.Cells[6].Value);
                instrutorOp.Endereco = endereco;
                if (controler.excluirInstrutor(instrutorOp))
                {
                    MessageBox.Show("Excluido com sucesso!!");
                    carregaGridInstrutor(controler.listaInstrutores());
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao excluir instrutor!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = "";
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao limpar campos!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controler.buscaInstrutores(txtNome.Text, this);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao pesquisar Instrutor!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

                for (i = 0; i <= dgvInstrutores.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvInstrutores.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvInstrutores[j, i];
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
