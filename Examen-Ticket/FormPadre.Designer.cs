namespace Examen_Ticket
{
    partial class FormPadre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltro_Concepto = new System.Windows.Forms.TextBox();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.numFiltro_Id = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarConcepto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalirFecha = new System.Windows.Forms.Button();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.factura_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.factura_importe = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.factura_concepto = new System.Windows.Forms.TextBox();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.factura_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listado_Facturas = new System.Windows.Forms.ListBox();
            this.control_seleccion = new System.Windows.Forms.GroupBox();
            this.btnModSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalFacturas = new System.Windows.Forms.Label();
            this.toolTipBtn = new System.Windows.Forms.ToolTip(this.components);
            this.lbTotalFacReal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFacturasEliminadas = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupOrdenar = new System.Windows.Forms.GroupBox();
            this.cheDes = new System.Windows.Forms.RadioButton();
            this.cheAs = new System.Windows.Forms.RadioButton();
            this.btnBD = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltro_Id)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_importe)).BeginInit();
            this.control_seleccion.SuspendLayout();
            this.groupOrdenar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(128, 34);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(233, 21);
            this.fechaInicio.TabIndex = 6;
            // 
            // fechaFinal
            // 
            this.fechaFinal.Location = new System.Drawing.Point(478, 34);
            this.fechaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(233, 21);
            this.fechaFinal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha final:";
            // 
            // txtFiltro_Concepto
            // 
            this.txtFiltro_Concepto.Location = new System.Drawing.Point(6, 32);
            this.txtFiltro_Concepto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltro_Concepto.Name = "txtFiltro_Concepto";
            this.txtFiltro_Concepto.Size = new System.Drawing.Size(245, 21);
            this.txtFiltro_Concepto.TabIndex = 2;
            // 
            // filtros
            // 
            this.filtros.BackColor = System.Drawing.Color.Transparent;
            this.filtros.Controls.Add(this.btnBuscarId);
            this.filtros.Controls.Add(this.numFiltro_Id);
            this.filtros.Location = new System.Drawing.Point(12, 51);
            this.filtros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtros.Name = "filtros";
            this.filtros.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtros.Size = new System.Drawing.Size(210, 79);
            this.filtros.TabIndex = 1;
            this.filtros.TabStop = false;
            this.filtros.Text = "Buscar por Nº Factura:";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBuscarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarId.Location = new System.Drawing.Point(129, 30);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarId.TabIndex = 4;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.UseVisualStyleBackColor = false;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // numFiltro_Id
            // 
            this.numFiltro_Id.Cursor = System.Windows.Forms.Cursors.Help;
            this.numFiltro_Id.Location = new System.Drawing.Point(6, 30);
            this.numFiltro_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFiltro_Id.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numFiltro_Id.Name = "numFiltro_Id";
            this.numFiltro_Id.Size = new System.Drawing.Size(117, 21);
            this.numFiltro_Id.TabIndex = 0;
            this.numFiltro_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscarConcepto);
            this.groupBox1.Controls.Add(this.txtFiltro_Concepto);
            this.groupBox1.Location = new System.Drawing.Point(229, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(338, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Concepto:";
            // 
            // btnBuscarConcepto
            // 
            this.btnBuscarConcepto.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBuscarConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarConcepto.Location = new System.Drawing.Point(257, 31);
            this.btnBuscarConcepto.Name = "btnBuscarConcepto";
            this.btnBuscarConcepto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarConcepto.TabIndex = 3;
            this.btnBuscarConcepto.Text = "Buscar";
            this.btnBuscarConcepto.UseVisualStyleBackColor = false;
            this.btnBuscarConcepto.Click += new System.EventHandler(this.btnBuscarConcepto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSalirFecha);
            this.groupBox2.Controls.Add(this.btnBuscarFecha);
            this.groupBox2.Controls.Add(this.fechaInicio);
            this.groupBox2.Controls.Add(this.fechaFinal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(574, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(759, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por fecha:";
            // 
            // btnSalirFecha
            // 
            this.btnSalirFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirFecha.Enabled = false;
            this.btnSalirFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirFecha.Location = new System.Drawing.Point(669, 76);
            this.btnSalirFecha.Name = "btnSalirFecha";
            this.btnSalirFecha.Size = new System.Drawing.Size(42, 23);
            this.btnSalirFecha.TabIndex = 4;
            this.btnSalirFecha.Text = "X";
            this.btnSalirFecha.UseVisualStyleBackColor = false;
            this.btnSalirFecha.Click += new System.EventHandler(this.btnSalirFecha_Click);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBuscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFecha.Location = new System.Drawing.Point(43, 76);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(620, 23);
            this.btnBuscarFecha.TabIndex = 4;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.factura_total);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.factura_importe);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.factura_concepto);
            this.groupBox3.Controls.Add(this.btnCrearFactura);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.factura_fecha);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(549, 304);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear Factura:";
            // 
            // factura_total
            // 
            this.factura_total.AutoSize = true;
            this.factura_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura_total.ForeColor = System.Drawing.Color.Red;
            this.factura_total.Location = new System.Drawing.Point(228, 200);
            this.factura_total.Name = "factura_total";
            this.factura_total.Size = new System.Drawing.Size(17, 17);
            this.factura_total.TabIndex = 20;
            this.factura_total.Text = "0";
            this.factura_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 19;
            // 
            // factura_importe
            // 
            this.factura_importe.DecimalPlaces = 2;
            this.factura_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura_importe.Location = new System.Drawing.Point(231, 136);
            this.factura_importe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.factura_importe.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.factura_importe.Name = "factura_importe";
            this.factura_importe.Size = new System.Drawing.Size(300, 20);
            this.factura_importe.TabIndex = 18;
            this.factura_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Importe:";
            // 
            // factura_concepto
            // 
            this.factura_concepto.Location = new System.Drawing.Point(230, 92);
            this.factura_concepto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.factura_concepto.Name = "factura_concepto";
            this.factura_concepto.Size = new System.Drawing.Size(300, 21);
            this.factura_concepto.TabIndex = 3;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.Blue;
            this.btnCrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFactura.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearFactura.Location = new System.Drawing.Point(6, 247);
            this.btnCrearFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(543, 36);
            this.btnCrearFactura.TabIndex = 13;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Concepto:";
            // 
            // factura_fecha
            // 
            this.factura_fecha.Location = new System.Drawing.Point(231, 47);
            this.factura_fecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.factura_fecha.Name = "factura_fecha";
            this.factura_fecha.Size = new System.Drawing.Size(300, 21);
            this.factura_fecha.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Importe Total con IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(6, 26);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(543, 38);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listado_Facturas
            // 
            this.listado_Facturas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listado_Facturas.FormattingEnabled = true;
            this.listado_Facturas.ItemHeight = 15;
            this.listado_Facturas.Location = new System.Drawing.Point(568, 183);
            this.listado_Facturas.Name = "listado_Facturas";
            this.listado_Facturas.Size = new System.Drawing.Size(759, 514);
            this.listado_Facturas.TabIndex = 16;
            this.listado_Facturas.SelectedIndexChanged += new System.EventHandler(this.SeleccionFactura);
            // 
            // control_seleccion
            // 
            this.control_seleccion.BackColor = System.Drawing.Color.Transparent;
            this.control_seleccion.Controls.Add(this.btnEliminar);
            this.control_seleccion.Location = new System.Drawing.Point(6, 647);
            this.control_seleccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.control_seleccion.Name = "control_seleccion";
            this.control_seleccion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.control_seleccion.Size = new System.Drawing.Size(555, 80);
            this.control_seleccion.TabIndex = 10;
            this.control_seleccion.TabStop = false;
            this.control_seleccion.Text = "Controles seleccion item";
            // 
            // btnModSalir
            // 
            this.btnModSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModSalir.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModSalir.ForeColor = System.Drawing.Color.Black;
            this.btnModSalir.Location = new System.Drawing.Point(568, 696);
            this.btnModSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModSalir.Name = "btnModSalir";
            this.btnModSalir.Size = new System.Drawing.Size(759, 31);
            this.btnModSalir.TabIndex = 16;
            this.btnModSalir.Text = "Deseleccionar Factura";
            this.btnModSalir.UseVisualStyleBackColor = false;
            this.btnModSalir.Click += new System.EventHandler(this.btnModSalir_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1348, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alberto Carrasco Fernández";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moverVentana);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrarVentana.BackgroundImage = global::Examen_Ticket.Properties.Resources.X;
            this.btnCerrarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrarVentana.Location = new System.Drawing.Point(1298, 0);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(37, 35);
            this.btnCerrarVentana.TabIndex = 22;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimizar.BackgroundImage = global::Examen_Ticket.Properties.Resources.min1;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMinimizar.Location = new System.Drawing.Point(1255, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 35);
            this.btnMinimizar.TabIndex = 21;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1132, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Facturas Realizadas:";
            // 
            // lbTotalFacturas
            // 
            this.lbTotalFacturas.AutoSize = true;
            this.lbTotalFacturas.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFacturas.Location = new System.Drawing.Point(1275, 161);
            this.lbTotalFacturas.Name = "lbTotalFacturas";
            this.lbTotalFacturas.Size = new System.Drawing.Size(15, 15);
            this.lbTotalFacturas.TabIndex = 24;
            this.lbTotalFacturas.Text = "0";
            // 
            // toolTipBtn
            // 
            this.toolTipBtn.IsBalloon = true;
            // 
            // lbTotalFacReal
            // 
            this.lbTotalFacReal.AutoSize = true;
            this.lbTotalFacReal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalFacReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFacReal.Location = new System.Drawing.Point(673, 161);
            this.lbTotalFacReal.Name = "lbTotalFacReal";
            this.lbTotalFacReal.Size = new System.Drawing.Size(15, 15);
            this.lbTotalFacReal.TabIndex = 26;
            this.lbTotalFacReal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(565, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total Facturas:";
            // 
            // lblFacturasEliminadas
            // 
            this.lblFacturasEliminadas.AutoSize = true;
            this.lblFacturasEliminadas.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturasEliminadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturasEliminadas.Location = new System.Drawing.Point(997, 161);
            this.lblFacturasEliminadas.Name = "lblFacturasEliminadas";
            this.lblFacturasEliminadas.Size = new System.Drawing.Size(15, 15);
            this.lblFacturasEliminadas.TabIndex = 28;
            this.lblFacturasEliminadas.Text = "0";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Transparent;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(849, 161);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(142, 15);
            this.lbl12.TabIndex = 27;
            this.lbl12.Text = "Facturas Eliminadas:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(404, 4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(135, 26);
            this.btnAbrir.TabIndex = 29;
            this.btnAbrir.Text = "Abrir Fichero";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(263, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 26);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar Fichero";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupOrdenar
            // 
            this.groupOrdenar.BackColor = System.Drawing.Color.Transparent;
            this.groupOrdenar.Controls.Add(this.cheDes);
            this.groupOrdenar.Controls.Add(this.cheAs);
            this.groupOrdenar.Location = new System.Drawing.Point(12, 138);
            this.groupOrdenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupOrdenar.Name = "groupOrdenar";
            this.groupOrdenar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupOrdenar.Size = new System.Drawing.Size(549, 47);
            this.groupOrdenar.TabIndex = 4;
            this.groupOrdenar.TabStop = false;
            this.groupOrdenar.Text = "Ordenar";
            // 
            // cheDes
            // 
            this.cheDes.AutoSize = true;
            this.cheDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheDes.Location = new System.Drawing.Point(205, 18);
            this.cheDes.Name = "cheDes";
            this.cheDes.Size = new System.Drawing.Size(101, 19);
            this.cheDes.TabIndex = 32;
            this.cheDes.TabStop = true;
            this.cheDes.Tag = "descendente";
            this.cheDes.Text = "Descendente ";
            this.cheDes.UseVisualStyleBackColor = true;
            this.cheDes.CheckedChanged += new System.EventHandler(this.cambioOrden);
            // 
            // cheAs
            // 
            this.cheAs.AutoSize = true;
            this.cheAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheAs.Location = new System.Drawing.Point(70, 18);
            this.cheAs.Name = "cheAs";
            this.cheAs.Size = new System.Drawing.Size(89, 19);
            this.cheAs.TabIndex = 31;
            this.cheAs.TabStop = true;
            this.cheAs.Tag = "ascendente";
            this.cheAs.Text = "Ascendente";
            this.cheAs.UseVisualStyleBackColor = true;
            this.cheAs.CheckedChanged += new System.EventHandler(this.cambioOrden);
            // 
            // btnBD
            // 
            this.btnBD.BackColor = System.Drawing.Color.Black;
            this.btnBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.ForeColor = System.Drawing.Color.White;
            this.btnBD.Location = new System.Drawing.Point(917, 3);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(135, 26);
            this.btnBD.TabIndex = 31;
            this.btnBD.Text = "Conectar BBDD";
            this.btnBD.UseVisualStyleBackColor = false;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(2057, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(759, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por fecha:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(669, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSalirFecha_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(43, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(620, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 21);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(478, 34);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(233, 21);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha inicial:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Fecha final:";
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Examen_Ticket.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.groupOrdenar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblFacturasEliminadas);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbTotalFacReal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTotalFacturas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModSalir);
            this.Controls.Add(this.control_seleccion);
            this.Controls.Add(this.listado_Facturas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filtros);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormPadre";
            this.Text = "Ticket-Save";
            this.filtros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFiltro_Id)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_importe)).EndInit();
            this.control_seleccion.ResumeLayout(false);
            this.groupOrdenar.ResumeLayout(false);
            this.groupOrdenar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltro_Concepto;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.NumericUpDown numFiltro_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox factura_concepto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker factura_fecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown factura_importe;
        private System.Windows.Forms.Label factura_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listado_Facturas;
        private System.Windows.Forms.GroupBox control_seleccion;
        private System.Windows.Forms.Button btnModSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalFacturas;
        private System.Windows.Forms.ToolTip toolTipBtn;
        private System.Windows.Forms.Label lbTotalFacReal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFacturasEliminadas;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarConcepto;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Button btnSalirFecha;
        private System.Windows.Forms.GroupBox groupOrdenar;
        private System.Windows.Forms.RadioButton cheAs;
        private System.Windows.Forms.RadioButton cheDes;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
    }
}

