using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Boca_Junior___Gerencia_de_quadras
{
    class daoReserva
    {
        private MySqlConnection conexaoDb;
        private MySqlCommand comando;

       
        public void atualizaReserva()
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "UPDATE `sisgce`.`reserva` SET `status` = 1 WHERE codReserva > 1 AND  data < DATE(NOW()) OR (horario_entrada < TIME(NOW()) AND data = DATE(NOW()))";
            comando = new MySqlCommand(query, conexaoDb);
            comando.ExecuteReader();
        }

        public MySqlDataReader horariosData(string data)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codHorario FROM sisgce.reserva where data = '" + data + "' and status = 2";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosdata = comando.ExecuteReader();
            return horariosdata;
        }
        public void reservarQuadra(modelReserva reserva)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "INSERT INTO `sisgce`.`reserva` (`codCliente`, `quadra`, `data`, `horario_entrada`, `horario_saida`,status)  VALUES ('" + reserva.Cliente.Cliente + "', '" + reserva.Quadra + "', '" + reserva.Data + "', '" + reserva.HorarioEntrada + "', '" + reserva.HorarioSaida + "','2')";
            comando = new MySqlCommand(query, conexaoDb);
            comando.ExecuteReader();
        }
        public MySqlDataReader BuscaReservaCPF(modelCliente cliente)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "select * from reserva where codCliente =" + cliente.Cliente.ToString()+" AND status = 2";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosReserva = comando.ExecuteReader();
            return horariosReserva;
        }
        public MySqlDataReader BuscaReserva()
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "select * from reserva where  status = 2";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosReserva = comando.ExecuteReader();
            return horariosReserva;
        }

        public MySqlDataReader listaReserva()
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codReserva,quadra,data,horario_entrada,horario_saida,idCliente,nome FROM reserva join cliente on cliente.idCliente = reserva.codCliente where status = 2";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosReserva = comando.ExecuteReader();
            return horariosReserva;
        }
        public MySqlDataReader listaReserva(string campo)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codReserva,quadra,data,horario_entrada,horario_saida,idCliente,nome FROM reserva join cliente on cliente.idCliente = reserva.codCliente where status = 2 and nome like '"+campo+"%' or cpf like '"+campo+"%'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosReserva = comando.ExecuteReader();
            return horariosReserva;
        }
        public void deletaReserva(string codReserva)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "DELETE FROM `sisgce`.`reserva` WHERE `codReserva`= " + codReserva+" AND status = 2";
            comando = new MySqlCommand(query, conexaoDb);
            comando.ExecuteReader();
        }
        public MySqlDataReader horarioQuadra(string codQuadra, string data)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT codHorario FROM sisgce.reserva where data = '" + data + "' and quadra = " + codQuadra;
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosdata = comando.ExecuteReader();
            return horariosdata;
        }

        public MySqlDataReader horariosData(string data, string horaEntrada, string horaSaida, string quadra)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT * FROM reserva WHERE ( (reserva.horario_entrada BETWEEN '" + horaEntrada + "' AND '" + horaSaida + "') OR (reserva.horario_saida BETWEEN '" + horaEntrada + "' AND '" + horaSaida + "' ))  AND reserva.data = '" + data + "' AND quadra = '"+quadra+"' ";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosdata = comando.ExecuteReader();
            return horariosdata;
        }

        public MySqlDataReader horariosData(string data,bool grid)
        {
            Conexao conexao = new Conexao();
            conexaoDb = conexao.conectar();
            string query = "SELECT data as DATA,horario_entrada as ENTRADA, horario_saida as SAIDA, quadra as QUADRA FROM reserva WHERE  reserva.data = '" + data + "'";
            comando = new MySqlCommand(query, conexaoDb);
            MySqlDataReader horariosdata = comando.ExecuteReader();
            return horariosdata;
        }
        public bool alteraReserva(modelReserva reserva)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexaoDb = conexao.conectar();
                string query = "UPDATE `sisgce`.`reserva` SET  `quadra`='" + reserva.Quadra + "', `data`='" + reserva.Data + "', `horario_entrada`= '" + reserva.HorarioEntrada + "', `horario_saida`= '" + reserva.HorarioSaida + "' WHERE `codReserva`='" + reserva.CodReserva + "'";
                comando = new MySqlCommand(query, conexaoDb);
                comando.ExecuteReader();
                return true;
            }
            catch(Exception ex){
                return false;
            }
           
        }
    }
}
