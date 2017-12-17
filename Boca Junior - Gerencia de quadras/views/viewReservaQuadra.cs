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
using System.IO;
using System.Drawing.Printing;
using System.Drawing;


namespace Boca_Junior___Gerencia_de_quadras
{
    public partial class viewReservaQuadra : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        private modelCliente clienteReserva;
        public viewReservaQuadra()
        {
            
            InitializeComponent();
            dgvReservas.Enabled = false;
            gbAdicionar.Enabled = false;
            bntAdcionarHorario.Enabled = false;
            bntExcluirReserva.Enabled = false;
            bntContrato.Enabled = false;
            bntAlterar.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewReservaQuadra_Load(object sender, EventArgs e)
        {

            //dtpHorarioEntrada.MaxDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controlerReserva controler = new controlerReserva();
                MySqlDataReader ClienteBusca = controler.carregaCliente(txtReservaCPF.Text);
                if (ClienteBusca.HasRows == false)
                {
                    MessageBox.Show("CPF não cadastrado!");
                    txtReservaNome.Text = "";
                    dgvReservas.Enabled = false;
                    bntAdcionarHorario.Enabled = false;
                    bntExcluirReserva.Enabled = false;
                    bntContrato.Enabled = false;
                    dgvReservas.Rows.Clear();
                }
                else
                {
                    while (ClienteBusca.Read())
                    {
                        modelCliente cliente = new modelCliente();
                        cliente.Cliente = Convert.ToInt32(ClienteBusca["idCliente"]);
                        cliente.Nome = ClienteBusca["nome"].ToString();
                        cliente.Cpf = ClienteBusca["CPF"].ToString();
                        cliente.Rg = ClienteBusca["RG"].ToString();
                        cliente.Telefone = ClienteBusca["telefone"].ToString();
                        cliente.TelefoneOp = ClienteBusca["telefone_op"].ToString();
                        cliente.Sexo = Convert.ToInt32(ClienteBusca["sexo"]);
                        cliente.DataNascimento = ClienteBusca["data_nascimento"].ToString();
                        cliente.DataCadastro = ClienteBusca["data_cadastro"].ToString();
                        txtReservaNome.Text = cliente.Nome;
                        clienteReserva = cliente;

                    }
                    dgvReservas.Enabled = true;                   
                    carregaGrid(clienteReserva);
                    gbAdicionar.Enabled = true;
                    bntAdcionarHorario.Enabled = true;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao pesquisar cliente!");
            }
            

        }

        private void rbReservaAvulso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbReservaMensal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbQuadraReserva.Enabled = true;
            //     carregaComboBox(getComboQuadra(),getDtpReserva());
        }
        private string getComboQuadra()
        {
            if (cbQuadraReserva.Text.ToString() == "QUADRA 1")
            {
                return "1";
            }
            if (cbQuadraReserva.Text.ToString() == "QUADRA 2")
            {
                return "2";
            }
            if (cbQuadraReserva.Text.ToString() == "QUADRA ARREIA")
            {
                return "3";
            }
            return "0";
        }
        private string getDtpReserva()
        {
            return Convert.ToDateTime(dtpDataReserva.Text).ToString("yyyy-MM-dd");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                controlerReserva controler = new controlerReserva();
                controler.deletarHorario(this.dgvReservas.CurrentRow.Cells[0].Value.ToString());
                dgvReservas.Rows.Clear();
                this.carregaGrid(clienteReserva);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao excluir reserva!");
            }
            bntExcluirReserva.Enabled = false;
            bntAlterar.Enabled = false;
            bntContrato.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           


        }
        private void carregaGrid(modelCliente cliente)
        {
            controlerReserva controler = new controlerReserva();
            MySqlDataReader reservas = controler.buscarReservaCPF(cliente);
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                string reserva = "Reserva " + this.dgvReservas.CurrentRow.Cells[3].Value.ToString() + "    Horario " + this.dgvReservas.CurrentRow.Cells[4].Value.ToString() + " ás " + this.dgvReservas.CurrentRow.Cells[5].Value.ToString() + ".";
                viewContrato contrato = new viewContrato(txtReservaNome.Text, reserva, txtReservaCPF.Text);
                contrato.Show();
                bntExcluirReserva.Enabled = false;
                bntContrato.Enabled = false;
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao gerar contrato!");
            }
            bntExcluirReserva.Enabled = false;
            bntContrato.Enabled = false;
            bntAlterar.Enabled = false;
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbQuadraReserva.SelectedIndex = Convert.ToInt32(this.dgvReservas.CurrentRow.Cells[2].Value);
                dtpDataReserva.Text = this.dgvReservas.CurrentRow.Cells[3].Value.ToString();
                dtpHorarioEntrada.Text = this.dgvReservas.CurrentRow.Cells[4].Value.ToString();
                dtpHorarioSaida.Text = this.dgvReservas.CurrentRow.Cells[5].Value.ToString();
                bntAdcionarHorario.Enabled = true;
                bntExcluirReserva.Enabled = true;
                bntAlterar.Enabled = true;
                bntContrato.Enabled = true;
            }
            catch(Exception ex){

            }
        }

        private void bntAdcionarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(dtpHorarioEntrada.Text) < Convert.ToDateTime(dtpHorarioSaida.Text))
                {
                    controlerReserva controler = new controlerReserva();
                    modelReserva reserva = new modelReserva();
                    reserva.HorarioEntrada = dtpHorarioEntrada.Text;
                    reserva.HorarioSaida = dtpHorarioSaida.Text;
                    reserva.Data = Convert.ToDateTime(dtpDataReserva.Text).ToString("yyyy-MM-dd");
                    reserva.Cliente = clienteReserva;
                    reserva.Quadra = getComboQuadra();
                    bool result = controler.verificaDataHoraReserva(reserva);
                    if (result == true)
                    {

                        controler.reservaQuadra(reserva);
                        carregaGrid(clienteReserva);
                        cbQuadraReserva.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data de entrada é maior que data de saida!");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao adicionar horario!");
            }
        
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                controlerReserva controler = new controlerReserva();
                modelReserva reserva = new modelReserva();
                reserva.HorarioEntrada = dtpHorarioEntrada.Text;
                reserva.HorarioSaida = dtpHorarioSaida.Text;
                reserva.Data = Convert.ToDateTime(dtpDataReserva.Text).ToString("yyyy-MM-dd");
                reserva.Cliente = clienteReserva;
                reserva.Quadra = getComboQuadra();
                bool result = controler.verificaDataHoraReserva(reserva);
                if (result == true)
                {
                    reserva.CodReserva = Convert.ToInt32(this.dgvReservas.CurrentRow.Cells[0].Value);
                    controler.alteraReserva(reserva);
                    carregaGrid(clienteReserva);
                    cbQuadraReserva.SelectedIndex = 0;
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao alterar hora!");
            }
            bntExcluirReserva.Enabled = false;
            bntAlterar.Enabled = false;
            bntContrato.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
