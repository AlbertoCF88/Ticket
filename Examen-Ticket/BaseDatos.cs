using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Ticket
{
    public class BaseDatos

    {
        private MySqlConnection conectar;

        /*cosntructor para la bd*/
        public BaseDatos()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "FACTURA";
            builder.Port = 3306;

            conectar = new MySqlConnection(builder.ToString());
        }

        //esta funcion no la utilizo
        /* public long insertarDesdeObjeto(Ticket t)
         {

             conectar.Open();
             string query = "insert into factura ( fecha, concepto, importe)" +
                 "values ( @fecha, @concepto, @importe)";
             MySqlCommand mySqlCommand  = new MySqlCommand(query, conectar);
             //mySqlCommand.Parameters.AddWithValue("@id", t.Id_Factura);
             mySqlCommand.Parameters.AddWithValue("@fecha", t.Fecha);
             mySqlCommand.Parameters.AddWithValue("@concepto", t.Concepto);
             mySqlCommand.Parameters.AddWithValue("@importe", t.Importe);
             mySqlCommand.Prepare();

             long id = mySqlCommand.LastInsertedId;
             conectar.Close();
             return id;
         }*/

        public void insertarDesdeDatos(DateTime fecha, string concepto, float importe)
        {
            conectar.Open();
            string query = "insert into ticket ( fecha, concepto, importe)" +
                "values ( @fecha, @concepto, @importe)";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conectar);
            mySqlCommand.Parameters.AddWithValue("@fecha", fecha);
            mySqlCommand.Parameters.AddWithValue("@concepto", concepto);
            mySqlCommand.Parameters.AddWithValue("@importe", importe);
            mySqlCommand.Prepare();
            int resultado = mySqlCommand.ExecuteNonQuery();

            conectar.Close();


        }

        public bool updateTicket(Ticket t)
        {
            conectar.Open();
            string query = "update ticket set fecha = @fecha, concepto = @concepto, importe = @importe where id= @id";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conectar);
            mySqlCommand.Parameters.AddWithValue("@id", t.Id_Factura);
            mySqlCommand.Parameters.AddWithValue("@fecha", t.Fecha);
            mySqlCommand.Parameters.AddWithValue("@concepto", t.Concepto);
            mySqlCommand.Parameters.AddWithValue("@importe", t.Importe);
            mySqlCommand.Prepare();
            int affterdRows = mySqlCommand.ExecuteNonQuery();
            conectar.Close();

            return affterdRows == 1;//no lo uso

        }

        public bool deleteTicket(Ticket t)
        {
            conectar.Open();
            string query = "delete from ticket where id= @id";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conectar);
            mySqlCommand.Parameters.AddWithValue("@id", t.Id_Factura);
            mySqlCommand.Prepare();
            int affterdRows = mySqlCommand.ExecuteNonQuery();
            conectar.Close();

            return affterdRows == 1; //no lo uso

        }

        public List<Ticket> obtenerTodosLosTicket()
        {
            List<Ticket> list = new List<Ticket>();

            try
            {
                conectar.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible conectar a base de datos");
                Environment.Exit(1);
            }
            //conectar.Open();
            string query = "select * from ticket";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conectar);
            MySqlDataReader datos = mySqlCommand.ExecuteReader();

            while (datos.Read())
            {
                list.Add(new Ticket(
                                datos.GetInt32("id"),
                                datos.GetDateTime("fecha"),
                                datos.GetString("concepto"),
                                datos.GetFloat("importe")));
            }
            conectar.Close();
            return list;
        }

    }
}
