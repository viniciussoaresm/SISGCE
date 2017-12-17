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
    public partial class viewLogin : Form
    {
        private Form formValidacao;
        login login = new login();
        public Form FormValidacao
        {
            get { return formValidacao; }
            set { formValidacao = value; }
        }
        public viewLogin()
        {
            InitializeComponent();
        }

        private void bntAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                login.loginValidacao(txtLogin.Text, mtbSenha.Text, this);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Erro ao realizar login!");
            }
        }

        private void viewLogin_Load(object sender, EventArgs e)
        {
            mtbSenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.bntAcessar.PerformClick();
            }
        }
    }
}
