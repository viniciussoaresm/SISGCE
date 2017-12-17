using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    ///teste

    
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login login = new login();
            login.validacao(new viewHome(null));
            // Application.Run(new viewHome());

        }
    }
}
