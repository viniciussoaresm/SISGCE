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

namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewGerenciarLogin : Form
    {
        controlerOperador controler = new controlerOperador();
        public viewGerenciarLogin()
        {
            InitializeComponent();
            this.carregaGrid();
        }

        private void carregaGrid()
        {
            MySqlDataReader logins = controler.listaOperadores(true);
            while (logins.Read())
            {
                object[] values = new object[logins.FieldCount];
                for (int i = 0; i < logins.FieldCount; i++)
                {
                    if (i == 5)
                    {
                        if (Convert.ToInt32(values[i]) == 1)
                        {
                            values[i] = "Ativo";
                        }
                        else
                        {
                            values[i] = "Desativado";
                        }
                    }
                    values[i] = logins.GetValue(i);
                }
                dgvLogins.Rows.Add(values);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GerenciarLogin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                controler.gerenciaLogin(Convert.ToInt32(this.dgvLogins.CurrentRow.Cells[0].Value), true);
                dgvLogins.Rows.Clear();
                carregaGrid();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao bloquear Login!");
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRelatorioAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                controler.gerenciaLogin(Convert.ToInt32(this.dgvLogins.CurrentRow.Cells[0].Value), false);
                dgvLogins.Rows.Clear();
                carregaGrid();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Desbloquear Login!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                modelOperador modelOp = new modelOperador();
                try
                {
                    string login = Microsoft.VisualBasic.Interaction.InputBox("Digite o Login", "Cadastro de Operador", "Login");
                    if (login != "")
                    {
                        modelOp.Login = login;
                        string senha = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova senha", "Cadastro de Operador", "Senha");
                        modelOp.Senha = senha;
                    }
                    controler.cadastrarOperado(modelOp);
                    this.dgvLogins.Rows.Clear();
                    carregaGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cadastro cancelado!");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao Criar Login!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
    }
}
