using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Ticket
{
    public class Ticket
    {
        static int cantidadFacturas;

        static Ticket()
        {
            cantidadFacturas = 0;
        }

        private long id_Factura;
        private DateTime fecha;
        private string concepto;
        private float importe;
        private float importeTotal;
        private const float IVA = 1.21f;

        /*get y set*/
        public long Id_Factura { get => id_Factura; set => id_Factura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public float Importe { get => importe; set => importe = value; }
        public float ImporteTotal { get => importeTotal; set => importeTotal = value; }
        public int CantidadFacturas { get => cantidadFacturas; set => cantidadFacturas = value; }

        /*constructores*/
        public Ticket()
        {

        }
        public Ticket(DateTime fecha, string concepto, float importe)
        {
            totalFacturas();
            Id_Factura = CantidadFacturas;
            Fecha = fecha;
            Concepto = concepto;
            Importe = importe;
            ImporteTotal = CalcularImporteTotal();

        }

        /*constructor  para el fichero*/
        public Ticket(string escribirTicketFichero)
        {
            try
            {
                string[] atributos = escribirTicketFichero.Split(';');
                totalFacturas();
                Id_Factura = CantidadFacturas;
                Fecha = DateTime.Parse(atributos[1]);
                Concepto = atributos[2];
                Importe = float.Parse(atributos[3]);
                ImporteTotal = float.Parse(atributos[4]);
            }
            catch (Exception )
            {

                MessageBox.Show("Fichero corrupto");
            }
        }

        /*constructor BD*/
        public Ticket(int id, DateTime fecha, string concepto, float importe)
        {
            totalFacturas();
            Id_Factura = id;
            Fecha = fecha;
            Concepto = concepto;
            Importe = importe;
            ImporteTotal = CalcularImporteTotal();

        }

        /*funciones*/
        private void totalFacturas()
        {
            //regsitro de facturas
            cantidadFacturas++;
        }

        public float CalcularImporteTotal()
        {

            return ImporteTotal = Importe * IVA;
        }

        public override string ToString()
        {
            return "▶ " + " 〈Nº - Factura: " + Id_Factura + "〉 〈Fecha: " + Fecha + "〉 〈Concepto: " + Concepto +
                "〉 〈Importe: " + Importe + "〉 〈Total: " + ImporteTotal + "〉";
        }

        /***--filtros-****/
        public Ticket buscarConcepto(List<Ticket> listaTickets, string _concepto)
        {

            foreach (Ticket item in listaTickets)
            {
                if (item.Concepto == _concepto)
                {
                    return item;
                }

            }
            return null;

        }

        public Ticket buscarId(List<Ticket> listaTickets, long _id)
        {

            foreach (Ticket item in listaTickets)
            {
                if (item.Id_Factura == _id)
                {
                    return item;
                }

            }
            return null;

        }

        public List<Ticket> buscarFechas(List<Ticket> listaTickets, DateTime fecha1, DateTime fecha2)
        {
            List<Ticket> listaFechas = new List<Ticket>();

            if (fecha1 > fecha2)
            {
                MessageBox.Show("Ingreso de fechas sin sentido");
            }
            foreach (Ticket item in listaTickets)
            {
                if (item.Fecha >= fecha1 && item.Fecha <= fecha2.AddDays(+1))
                {
                    listaFechas.Add(item);
                }
            }
            return listaFechas;
        }

        /*funciones para el fichero*/
        public string escribirTicketFichero(Ticket t)
        {
            return t.Id_Factura + ";" + t.Fecha + ";" + t.Concepto + ";" + t.Importe + ";" + t.ImporteTotal + ";";
        }

        public string guardarTicketFichero()
        {
            return Id_Factura + ";" + Fecha + ";" + Concepto + ";" + Importe + ";" + ImporteTotal + ";";
        }


    }
}
