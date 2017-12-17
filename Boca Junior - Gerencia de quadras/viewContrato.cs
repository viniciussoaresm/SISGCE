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
    public partial class viewContrato : Form
    {
        public viewContrato(String cliente, String reserva,String CPF)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CPF", CPF));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Cliente", cliente));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Reserva", reserva));
            this.reportViewer1.RefreshReport();
        }

        private void viewContrato_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
