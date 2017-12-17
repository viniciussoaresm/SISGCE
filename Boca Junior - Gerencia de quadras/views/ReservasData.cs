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
    public partial class ReservasData : Form
    {
        public ReservasData(MySqlDataReader reservas)
        {
            InitializeComponent();
            while (reservas.Read())
            {
                this.carregaGrid(reservas);
            }
            
        }

        private void ReservasData_Load(object sender, EventArgs e)
        {

        }

        private void carregaGrid(MySqlDataReader reservas)
        {
            dgvReservasData.Rows.Clear();
            while (reservas.Read())
            {
                object[] values = new object[reservas.FieldCount];
                if (dgvReservasData.Rows.Count == 0)
                    for (int i = 0; i < reservas.FieldCount; i++)
                        dgvReservasData.Columns.Add(reservas.GetName(i), reservas.GetName(i));
                for (int i = 0; i < reservas.FieldCount; i++)
                    values[i] = reservas.GetValue(i);
                dgvReservasData.Rows.Add(values);
            }
        }
    }
}
