using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Boca_Junior___Gerencia_de_quadras
{
    class controlerReserva
    {
        daoReserva daoReserva = new daoReserva();
        public MySqlDataReader carregaCliente(string cpf)
        {
            daoCliente daocliente = new daoCliente();
            MySqlDataReader cliente = daocliente.buscaClienteCPF(cpf);
            return cliente;
        }
        public void reservaQuadra(modelReserva reserva)
        {

                daoReserva.reservarQuadra(reserva);
        }
        public MySqlDataReader buscarReservaCPF(modelCliente cliente)
        {
            MySqlDataReader reservaCliente = daoReserva.BuscaReservaCPF(cliente);
            return reservaCliente;
        }
        public MySqlDataReader listaReserva()
        {
            MySqlDataReader reservaCliente = daoReserva.BuscaReserva();
            return reservaCliente;
        }
        public void deletarHorario(string codReserva)
        {
            daoReserva.deletaReserva(codReserva);
        }
        public bool verificaDataHoraReserva(modelReserva reserva)
        {
            if (Convert.ToDateTime(reserva.HorarioEntrada) < Convert.ToDateTime(reserva.HorarioSaida) && DateTime.Now >= Convert.ToDateTime(reserva.Data + " " + reserva.HorarioEntrada))
            {
                MessageBox.Show("Data Invalida!");
                return false;
            }
            else
            {
                if (Convert.ToInt32(reserva.Quadra) == 0 )
                {
                    MessageBox.Show("Selecione a Quadra");
                    return false;
                }
                MySqlDataReader reservas = daoReserva.horariosData(reserva.Data, reserva.HorarioEntrada, reserva.HorarioSaida, reserva.Quadra);
                while (reservas.Read())
                {
                    MessageBox.Show("Horario Indisponivel");
                    return false;
                }                
            }
            return true;
         
        }
        public void gridReservasData(modelReserva reserva)
        {
            ReservasData view = new ReservasData(daoReserva.horariosData(reserva.Data, true));
            view.Show();
        }
        public MySqlDataReader listaReservas()
        {
            try{
                   return daoReserva.listaReserva();
            }catch(Exception ex){
                MessageBox.Show("Nenhuma Lista Encontrada!!");
                return null;
            }
            
        }
        public MySqlDataReader listaReservas(string campo)
        {
            try
            {
                return daoReserva.listaReserva(campo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Lista Encontrada!!");
                return null;
            }

        }
        public void alteraReserva(modelReserva reserva)
        {           
            daoReserva.alteraReserva(reserva);
        }

        public void atualizaStatus()
        {
            daoReserva.atualizaReserva();
        }
       
    }
}
