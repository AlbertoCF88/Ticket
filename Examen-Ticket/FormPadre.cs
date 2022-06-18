using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Ticket
{
    public partial class FormPadre : Form
    {
        private List<Ticket> listaTickets;

        private int totalfacturasReales;
        private string rutaFile;
        private bool cambioArray;

        private bool btnOnline;
        public FormPadre()
        {
            InitializeComponent();
            listaTickets = new List<Ticket>();
            totalfacturasReales = 0;
            //tooltip
            toolTipBtnMod();

            //ruta fichero
            rutaFile = "";

            //filtro fechas
            cambioArray = false;

            //para concetarse a la base de datos
            btnOnline = false;
        }

        /*crear factura*/
        private void crearTicket(DateTime fecha, String concepto, float importe)
        {
            totalfacturasReales++;
            cantidadFacturasReales();
            Ticket t = new Ticket(fecha, concepto, importe);
            listaTickets.Add(t);
            MessageBox.Show("Nueva factura añadida ", t.Concepto.ToString());

            /*agregar en fichero el nuevo ticket*/
            agregarFichero(t);

            //*BBDD*/
            if (btnOnline == true)
            {
                BaseDatos bd = new BaseDatos();
                bd.insertarDesdeDatos(fecha, concepto, importe);
                MessageBox.Show("Guardo en BBDD");
            }


            //total facturas
            lbTotalFacturas.Text = t.CantidadFacturas.ToString();
            //lista vista
            listado_Facturas.Items.Add(t);
            //limpiar campos
            limpiarCamposFactura();
        }
        /* hibrido crear y modificar*/
        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            //el mismo boton de crear cambia a modifificar
            if (btnCrearFactura.Text == "Crear Factura")
            {
                if (factura_fecha.Text != "" && factura_concepto.Text != "" && factura_importe.Value != 0)
                {
                    crearTicket(factura_fecha.Value, factura_concepto.Text, (float)factura_importe.Value);

                }
                else
                {
                    MessageBox.Show("Para generar una factura debe de introducir: \n FECHA, CONCEPTO e IMPORTE");
                }
            }
            else
            {
                MessageBox.Show("Factura modificada correctamente");
                modificarFactura();

                limpiarCamposFactura();
                //habilitar btn crear factura
                enableBtnCrear();
                //quitar btneliminar
                disableBtnEliminar();

            }

        }
        /*seleccion para modiifcar o eliminar */
        private void SeleccionFactura(object sender, EventArgs e)
        {
            //para modificar factura primero tienes que seleccionar un item
            if (listado_Facturas.SelectedIndex != -1)//si tiene alguno seleccionado
            {
                try
                {
                    Ticket t = (Ticket)listado_Facturas.SelectedItem;
                    factura_fecha.Value = t.Fecha;
                    factura_concepto.Text = t.Concepto;
                    factura_importe.Value = (decimal)t.Importe;
                    factura_total.Text = decimal.Round((decimal)t.ImporteTotal, 2).ToString() + " €";
                    //cambair a modo modificar
                    enableBtnMod();
                    //habiliar eliminar
                    enableBtnEliminar();
                }
                catch (Exception)
                {
                    listado_Facturas.SelectedIndex = -1;
                    MessageBox.Show("Imposible modificar, fichero corrupto");
                }


            }
        }
        private void modificarFactura()
        {
            if (factura_fecha.Text != "" && factura_concepto.Text != "" && factura_importe.Value != 0)
            {
                Ticket t = listado_Facturas.Items[listado_Facturas.SelectedIndex] as Ticket;
                t.Fecha = factura_fecha.Value;
                t.Concepto = factura_concepto.Text;
                t.Importe = (float)factura_importe.Value;
                t.CalcularImporteTotal();
                rellenaListaVista();
                //fichero
                guardadoAutomatico_MOD_Eliminar();
                //salir busqueda fechas
                enableBtnSalirFecha();

                //*BBDD*/
                if (btnOnline == true)
                {
                    BaseDatos bd = new BaseDatos();
                    bd.updateTicket(t);
                    MessageBox.Show("Modificado en BBDD");
                }
            }
            else
            {
                MessageBox.Show("Para modificar una factura los campos: \n FECHA, CONCEPTO e IMPORTE , deben estar rellenados");
            }
        }

        /*eliminar un item*/

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //preguntar antes de eliminar item
            Ticket t = (Ticket)listado_Facturas.SelectedItem;
            string id = t.Id_Factura.ToString();
            string concepto = t.Concepto.ToString();
            DialogResult pregunta = MessageBox.Show("¿Eliminar factura: " + concepto + "?", "ID: " + id, MessageBoxButtons.YesNo);

            if (pregunta == DialogResult.Yes)
            {
                listaTickets.RemoveAt(listado_Facturas.SelectedIndex);
                limpiarCamposFactura();
                rellenaListaVista();

                //inconcluencia de ID con base de datos
                if (btnOnline == false)
                {
                    totalfacturasReales--;
                }

                facturasElimindas();
                cantidadFacturasReales();

                enableBtnCrear();
                disableBtnEliminar();
                //fichero
                guardadoAutomatico_MOD_Eliminar();

                //salir busqueda fechas
                enableBtnSalirFecha();

                //*BBDD*/
                if (btnOnline == true)
                {
                    BaseDatos bd = new BaseDatos();
                    bd.deleteTicket(t);
                    MessageBox.Show("Eliminado en BBDD");
                }
            }
        }

        /************************ funciones aux *******************************/
        private void cantidadFacturasReales()
        {
            lbTotalFacReal.Text = totalfacturasReales.ToString();
        }
        private void facturasElimindas()
        {
            Ticket t = new Ticket();
            int facEliminadas = t.CantidadFacturas - totalfacturasReales;
            lblFacturasEliminadas.Text = facEliminadas.ToString();
        }
        private void toolTipBtnMod()
        {
            //tooltip
            if (btnCrearFactura.Text == "Modificar factura")
            {
                this.toolTipBtn.SetToolTip(this.btnCrearFactura, "Para salir del modo modificar apretar botón 'Deseleccionar Factura'");
            }

        }
        private void rellenaListaVista()
        {
            listado_Facturas.Items.Clear();
            foreach (var t in listaTickets)
            {
                listado_Facturas.Items.Add(t);
            }
        }
        private void limpiarCamposFactura()
        {
            factura_fecha.Value = DateTime.Now;
            factura_concepto.Text = "";
            factura_importe.Value = 0;
            factura_total.Text = "0";
        }

        private void enableBtnCrear()
        {
            //habilitar btn crear factura
            btnCrearFactura.BackColor = Color.Blue;
            btnCrearFactura.Text = "Crear Factura";
        }

        private void enableBtnMod()
        {
            //habilitar btn modificar
            btnCrearFactura.BackColor = Color.Green;
            btnCrearFactura.Text = "Modificar factura";
            toolTipBtnMod();
        }
        private void enableBtnEliminar()
        {
            //habilitar btn eliminar
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Enabled = true;
        }

        private void disableBtnEliminar()
        {
            //habilitar btn eliminar
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.Enabled = false;
        }
        private void btnModSalir_Click(object sender, EventArgs e)
        {
            //deseleccionar un item
            listado_Facturas.SelectedIndex = -1;
            enableBtnCrear();
            limpiarCamposFactura();
            disableBtnEliminar();
            //label buscadores filtro
            txtFiltro_Concepto.Text = "";
            numFiltro_Id.Value = 0;
        }

        /****************-filtros-*********************************************/
        private void btnBuscarConcepto_Click(object sender, EventArgs e)
        {

            Ticket t = new Ticket();
            t = t.buscarConcepto(listaTickets, txtFiltro_Concepto.Text);
            if (t != null)
            {
                factura_fecha.Value = t.Fecha;
                factura_concepto.Text = t.Concepto;
                factura_importe.Value = (decimal)t.Importe;
                factura_total.Text = decimal.Round((decimal)t.ImporteTotal, 2).ToString() + " €";

                listado_Facturas.SelectedItem = t;
            }
            else
            {
                MessageBox.Show("Ticket no encontrado");
                listado_Facturas.SelectedIndex = -1;
            }
        }
        private void btnBuscarId_Click(object sender, EventArgs e)
        {

            Ticket t = new Ticket();
            t = t.buscarId(listaTickets, (long)numFiltro_Id.Value);
            if (t != null)
            {
                factura_fecha.Value = t.Fecha;
                factura_concepto.Text = t.Concepto;
                factura_importe.Value = (decimal)t.Importe;
                factura_total.Text = decimal.Round((decimal)t.ImporteTotal, 2).ToString() + " €";
                //seleccion lista vista
                listado_Facturas.SelectedItem = t;

            }
            else
            {
                MessageBox.Show("Ticket no encontrado");
                listado_Facturas.SelectedIndex = -1;
            }
        }
        private void btnFecha_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            List<Ticket> listaFechas = new List<Ticket>();
            listaFechas = t.buscarFechas(listaTickets, fechaInicio.Value.Date, fechaFinal.Value.Date);
            if (t != null && listaFechas != null)
            {
                listado_Facturas.Items.Clear();
                foreach (Ticket item in listaFechas)
                {
                    listado_Facturas.Items.Add(item);
                }
                //seleccion lista vista         
                cambioArray = true;
                btnSalirFecha.Enabled = true;
                btnSalirFecha.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Ticket no encontrado");
                listado_Facturas.SelectedIndex = -1;

            }
        }

        private void btnSalirFecha_Click(object sender, EventArgs e)
        {
            //si estamos en filtro fechas
            if (cambioArray)
            {
                rellenaListaVista();
                cambioArray = false;
                btnSalirFecha.Enabled = false;
                btnSalirFecha.BackColor = Color.Transparent;
            }
        }
        private void enableBtnSalirFecha()
        {
            cambioArray = false;
            btnSalirFecha.Enabled = false;
            btnSalirFecha.BackColor = Color.Transparent;
        }

        private void cambioOrden(object sender, EventArgs e)
        {
            RadioButton check = (RadioButton)sender;

            switch (check.Tag.ToString())
            {
                case "ascendente":

                    listaTickets.Sort(delegate (Ticket x, Ticket y)
                    {
                        return x.Id_Factura.CompareTo(y.Id_Factura);
                    });
                    rellenaListaVista();
                    break;
                case "descendente":
                    listaTickets.Sort(delegate (Ticket x, Ticket y)
                    {
                        return y.Id_Factura.CompareTo(x.Id_Factura);
                    });
                    rellenaListaVista();
                    break;
                default:

                    break;
            }


        }

        /*************************************** botones de ventena *************************************************************/
        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*mover ventana sin bordes*/
        bool mover = false;
        private void moverVentana(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        /*************************************-FICHERO-************************************************************/
        private void crearFichero()
        {
            // Crear SaveDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Copia de Seguridad";
            saveFileDialog.Filter = "BackUp (*.bck)|*.bck|Todos (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"\ficheros";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Con la ruta creo el Fichero
                string ruta = saveFileDialog.FileName;
                // Creo El StreamWriter
                StreamWriter escritor = File.CreateText(ruta);
                // Escribo linea a linea
                foreach (Ticket ticket in listaTickets)
                {
                    escritor.WriteLine(ticket.guardarTicketFichero());
                }
                // Cierro el Stream
                escritor.Close();
            }
        }

        private void abrirFichero()
        {
            Ticket ticket = new Ticket();
            ticket.CantidadFacturas = 0;
            // El OpenFileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona el Fichero de BackUp";
            ofd.Filter = "BackUp Files (*.bck)|*.bck|Todos (*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = @"\ficheros";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listaTickets.Clear();
                // Crear el fichero -> Objeto File a partir de la ruta
                string ruta = ofd.FileName;
                rutaFile = ruta;
                // Del Objeto File creo su StreamRead
                StreamReader lector = File.OpenText(ruta);

                if (lector != null)
                {
                    // Bucle para la lectura del fichero
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        // Hago las tareas necesarias para la info del fichero
                        // En el String linea, tengo un Ticket codificado
                        listaTickets.Add(new Ticket(linea));
                    }
                    lector.Close();
                    rellenaListaVista();
                    MessageBox.Show("Carga de datos Terminada, Tenemos " + listaTickets.Count + " tickets");
                    lbTotalFacReal.Text = listaTickets.Count.ToString();
                    totalfacturasReales = listaTickets.Count;
                }

            }

        }

        private void agregarFichero(Ticket t)
        {
            if (rutaFile != "")
            {
                StreamWriter streamWriter = File.AppendText(rutaFile);
                Ticket ticket = new Ticket();
                streamWriter.WriteLine(ticket.escribirTicketFichero(t));
                streamWriter.Close();

                MessageBox.Show("Guardado automaticamente en el fichero: " + rutaFile);
            }
        }

        private void guardadoAutomatico_MOD_Eliminar()
        {
            if (rutaFile != "")
            {
                StreamWriter escritor = File.CreateText(rutaFile);
                foreach (Ticket ticket in listaTickets)
                {
                    escritor.WriteLine(ticket.guardarTicketFichero());
                }
                // Cierro el Stream
                escritor.Close();
                MessageBox.Show("Guardado automaticamente en el fichero: " + rutaFile);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            crearFichero();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrirFichero();
        }



        /****************************************************************-BASE DATOS-*******************************************************************/
        private void btnBD_Click(object sender, EventArgs e)
        {
            btnOnline = !btnOnline;
            //primer click este en el else
            if (btnOnline == false)
            {
                listaTickets.Clear();
                btnBD.Text = "Conectar BBDD";
                btnBD.BackColor = Color.Black;
                Ticket t = new Ticket();
                t.CantidadFacturas = 0;
                lbTotalFacReal.Text = t.CantidadFacturas.ToString();
                rellenaListaVista();

            }
            else
            {
                listaTickets.Clear();
                btnBD.Text = "Desconectar BBDD";
                btnBD.BackColor = Color.Red;


                BaseDatos bd = new BaseDatos();
                listaTickets = bd.obtenerTodosLosTicket();
                Ticket t = new Ticket();
                lbTotalFacReal.Text = t.CantidadFacturas.ToString();
                rellenaListaVista();

            }

        }




    }
}
