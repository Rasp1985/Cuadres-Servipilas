namespace OrdenesdeServicio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.tabOrdenes = new System.Windows.Forms.TabControl();
            this.Ordenes = new System.Windows.Forms.TabPage();
            this.CboVendedor = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtSaldopendiente = new System.Windows.Forms.TextBox();
            this.Lblestadofactura = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.txttotalcancelado = new System.Windows.Forms.TextBox();
            this.btnBorrarregistro = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grdOrdenes = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Características = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rtxtObservacionesgenerales = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevaorden = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.dtfechaentrega = new System.Windows.Forms.DateTimePicker();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nuevaorden = new System.Windows.Forms.TabPage();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chkchapetaenbuenestado = new System.Windows.Forms.CheckBox();
            this.chkchapetaoriginal = new System.Windows.Forms.CheckBox();
            this.chkchapetarayada = new System.Windows.Forms.CheckBox();
            this.chkchapetasinpin = new System.Windows.Forms.CheckBox();
            this.Eslabones = new System.Windows.Forms.GroupBox();
            this.chksineslabones = new System.Windows.Forms.CheckBox();
            this.txtEslabones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Tapa = new System.Windows.Forms.GroupBox();
            this.chkTapabuenestado = new System.Windows.Forms.CheckBox();
            this.chkTaparayada = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbdnogarantiaimpermeabilidad = new System.Windows.Forms.RadioButton();
            this.rdbgarantiaimpermeabilidad = new System.Windows.Forms.RadioButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chkcoronabuesestado = new System.Windows.Forms.CheckBox();
            this.chkcoronaoxidada = new System.Windows.Forms.CheckBox();
            this.chkcoronasuelta = new System.Windows.Forms.CheckBox();
            this.chkcoronaoriginal = new System.Windows.Forms.CheckBox();
            this.chkcoronafloja = new System.Windows.Forms.CheckBox();
            this.chkcoronadesgastada = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbdoriginal = new System.Windows.Forms.RadioButton();
            this.rbdimitacion = new System.Windows.Forms.RadioButton();
            this.Cristal = new System.Windows.Forms.GroupBox();
            this.chkcristalbuenestado = new System.Windows.Forms.CheckBox();
            this.chkcristalhumedad = new System.Windows.Forms.CheckBox();
            this.chkCristalmanchado = new System.Windows.Forms.CheckBox();
            this.chkcristaldespicado = new System.Windows.Forms.CheckBox();
            this.chkcristalquebrado = new System.Windows.Forms.CheckBox();
            this.chkcristalrayado = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chktablerobuenestado = new System.Windows.Forms.CheckBox();
            this.chktablerosinsegundero = new System.Windows.Forms.CheckBox();
            this.chktableroquebrado = new System.Windows.Forms.CheckBox();
            this.chkTablerorayado = new System.Windows.Forms.CheckBox();
            this.chktableronumero = new System.Windows.Forms.CheckBox();
            this.chktableromanchado = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkpulsoenbuenestado = new System.Windows.Forms.CheckBox();
            this.chkpulsosinhebilla = new System.Windows.Forms.CheckBox();
            this.chkpulsorayado = new System.Windows.Forms.CheckBox();
            this.chkpulsodespintado = new System.Windows.Forms.CheckBox();
            this.chkpulsopartido = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkescafandrabuenestado = new System.Windows.Forms.CheckBox();
            this.chksinescafandra = new System.Windows.Forms.CheckBox();
            this.chkescafandrapintada = new System.Windows.Forms.CheckBox();
            this.chkescafandranumeracion = new System.Windows.Forms.CheckBox();
            this.chkEscafandrarayada = new System.Windows.Forms.CheckBox();
            this.chkEscafandrasuelta = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkcajasintornillo = new System.Windows.Forms.CheckBox();
            this.chkcajabuenestado = new System.Windows.Forms.CheckBox();
            this.chkcajaporosa = new System.Windows.Forms.CheckBox();
            this.chkcajamanchada = new System.Windows.Forms.CheckBox();
            this.chkCajaquebrada = new System.Windows.Forms.CheckBox();
            this.chkcajarayada = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtObservaciones = new System.Windows.Forms.RichTextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chknofuncionadigital = new System.Windows.Forms.CheckBox();
            this.chknofuncionananalogo = new System.Windows.Forms.CheckBox();
            this.chkfuncionadigital = new System.Windows.Forms.CheckBox();
            this.chkfuncionaanalogo = new System.Windows.Forms.CheckBox();
            this.Abonos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabOrdenes.SuspendLayout();
            this.Ordenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.Nuevaorden.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.Eslabones.SuspendLayout();
            this.Tapa.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.Cristal.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.ordenToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.Abonos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Anticipo";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ingresarClienteToolStripMenuItem.Text = "Ingresar Cliente";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarClienteToolStripMenuItem_Click);
            // 
            // ordenToolStripMenuItem
            // 
            this.ordenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarOrdenToolStripMenuItem});
            this.ordenToolStripMenuItem.Name = "ordenToolStripMenuItem";
            this.ordenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ordenToolStripMenuItem.Text = "Orden";
            // 
            // eliminarOrdenToolStripMenuItem
            // 
            this.eliminarOrdenToolStripMenuItem.Name = "eliminarOrdenToolStripMenuItem";
            this.eliminarOrdenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eliminarOrdenToolStripMenuItem.Text = "Eliminar Orden";
            this.eliminarOrdenToolStripMenuItem.Click += new System.EventHandler(this.eliminarOrdenToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarOrdenesToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // consultarOrdenesToolStripMenuItem
            // 
            this.consultarOrdenesToolStripMenuItem.Name = "consultarOrdenesToolStripMenuItem";
            this.consultarOrdenesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarOrdenesToolStripMenuItem.Text = "consultar Ordenes";
            this.consultarOrdenesToolStripMenuItem.Click += new System.EventHandler(this.consultarOrdenesToolStripMenuItem_Click);
            // 
            // tabOrdenes
            // 
            this.tabOrdenes.Controls.Add(this.Ordenes);
            this.tabOrdenes.Controls.Add(this.Nuevaorden);
            this.tabOrdenes.Location = new System.Drawing.Point(0, 27);
            this.tabOrdenes.Name = "tabOrdenes";
            this.tabOrdenes.SelectedIndex = 0;
            this.tabOrdenes.Size = new System.Drawing.Size(1203, 676);
            this.tabOrdenes.TabIndex = 67;
            // 
            // Ordenes
            // 
            this.Ordenes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ordenes.Controls.Add(this.CboVendedor);
            this.Ordenes.Controls.Add(this.lblUsuario);
            this.Ordenes.Controls.Add(this.lblVendedor);
            this.Ordenes.Controls.Add(this.txtSaldopendiente);
            this.Ordenes.Controls.Add(this.Lblestadofactura);
            this.Ordenes.Controls.Add(this.txtAnticipo);
            this.Ordenes.Controls.Add(this.txttotalcancelado);
            this.Ordenes.Controls.Add(this.btnBorrarregistro);
            this.Ordenes.Controls.Add(this.label11);
            this.Ordenes.Controls.Add(this.label12);
            this.Ordenes.Controls.Add(this.label9);
            this.Ordenes.Controls.Add(this.label10);
            this.Ordenes.Controls.Add(this.txtTotal);
            this.Ordenes.Controls.Add(this.grdOrdenes);
            this.Ordenes.Controls.Add(this.groupBox9);
            this.Ordenes.Controls.Add(this.btnAgregar);
            this.Ordenes.Controls.Add(this.groupBox2);
            this.Ordenes.Controls.Add(this.grdCliente);
            this.Ordenes.Controls.Add(this.dtfechaentrega);
            this.Ordenes.Controls.Add(this.dtFecha);
            this.Ordenes.Controls.Add(this.txtConsecutivo);
            this.Ordenes.Controls.Add(this.txtDocumento);
            this.Ordenes.Controls.Add(this.label4);
            this.Ordenes.Controls.Add(this.label3);
            this.Ordenes.Controls.Add(this.label1);
            this.Ordenes.Controls.Add(this.label14);
            this.Ordenes.Controls.Add(this.label2);
            this.Ordenes.Location = new System.Drawing.Point(4, 22);
            this.Ordenes.Name = "Ordenes";
            this.Ordenes.Padding = new System.Windows.Forms.Padding(3);
            this.Ordenes.Size = new System.Drawing.Size(1195, 650);
            this.Ordenes.TabIndex = 0;
            this.Ordenes.Text = "Orden";
            this.Ordenes.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CboVendedor
            // 
            this.CboVendedor.FormattingEnabled = true;
            this.CboVendedor.Location = new System.Drawing.Point(92, 139);
            this.CboVendedor.Name = "CboVendedor";
            this.CboVendedor.Size = new System.Drawing.Size(259, 21);
            this.CboVendedor.TabIndex = 109;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(87, 113);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 25);
            this.lblUsuario.TabIndex = 108;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(271, 139);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblVendedor.TabIndex = 107;
            // 
            // txtSaldopendiente
            // 
            this.txtSaldopendiente.Location = new System.Drawing.Point(572, 430);
            this.txtSaldopendiente.Name = "txtSaldopendiente";
            this.txtSaldopendiente.Size = new System.Drawing.Size(117, 20);
            this.txtSaldopendiente.TabIndex = 106;
            // 
            // Lblestadofactura
            // 
            this.Lblestadofactura.AutoSize = true;
            this.Lblestadofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblestadofactura.Location = new System.Drawing.Point(700, 516);
            this.Lblestadofactura.Name = "Lblestadofactura";
            this.Lblestadofactura.Size = new System.Drawing.Size(0, 24);
            this.Lblestadofactura.TabIndex = 105;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(315, 428);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(100, 20);
            this.txtAnticipo.TabIndex = 104;
            this.txtAnticipo.TextChanged += new System.EventHandler(this.txtAnticipo_TextChanged);
            // 
            // txttotalcancelado
            // 
            this.txttotalcancelado.Location = new System.Drawing.Point(835, 426);
            this.txttotalcancelado.Name = "txttotalcancelado";
            this.txttotalcancelado.Size = new System.Drawing.Size(113, 20);
            this.txttotalcancelado.TabIndex = 103;
            this.txttotalcancelado.TextChanged += new System.EventHandler(this.txttotalcancelado_TextChanged);
            // 
            // btnBorrarregistro
            // 
            this.btnBorrarregistro.Location = new System.Drawing.Point(11, 285);
            this.btnBorrarregistro.Name = "btnBorrarregistro";
            this.btnBorrarregistro.Size = new System.Drawing.Size(118, 33);
            this.btnBorrarregistro.TabIndex = 102;
            this.btnBorrarregistro.Text = "Quitar registro";
            this.btnBorrarregistro.UseVisualStyleBackColor = true;
            this.btnBorrarregistro.Click += new System.EventHandler(this.btnBorrarregistro_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(700, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 101;
            this.label11.Text = "Total Cancelado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 101;
            this.label12.Text = "Anticipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Saldo Pendiente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Total a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(126, 430);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 100;
            // 
            // grdOrdenes
            // 
            this.grdOrdenes.AllowUserToAddRows = false;
            this.grdOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Cantidad,
            this.Descuento,
            this.Valor,
            this.Observaciones,
            this.Características,
            this.Consecutivo});
            this.grdOrdenes.Location = new System.Drawing.Point(12, 322);
            this.grdOrdenes.Name = "grdOrdenes";
            this.grdOrdenes.Size = new System.Drawing.Size(1063, 82);
            this.grdOrdenes.TabIndex = 84;
            this.grdOrdenes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrdenes_CellValueChanged);
            this.grdOrdenes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grdOrdenes_RowsRemoved);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 70;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 300;
            // 
            // Características
            // 
            this.Características.HeaderText = "Características";
            this.Características.Name = "Características";
            this.Características.Width = 250;
            // 
            // Consecutivo
            // 
            this.Consecutivo.HeaderText = "Consecutivo";
            this.Consecutivo.Name = "Consecutivo";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.rtxtObservacionesgenerales);
            this.groupBox9.Location = new System.Drawing.Point(22, 480);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(640, 92);
            this.groupBox9.TabIndex = 83;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Observaciones";
            // 
            // rtxtObservacionesgenerales
            // 
            this.rtxtObservacionesgenerales.Location = new System.Drawing.Point(24, 19);
            this.rtxtObservacionesgenerales.Name = "rtxtObservacionesgenerales";
            this.rtxtObservacionesgenerales.Size = new System.Drawing.Size(603, 59);
            this.rtxtObservacionesgenerales.TabIndex = 67;
            this.rtxtObservacionesgenerales.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(217, 285);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 31);
            this.btnAgregar.TabIndex = 81;
            this.btnAgregar.Text = "Nueva Orden";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.btnNuevaorden);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 47);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::OrdenesdeServicio.Properties.Resources.descarga;
            this.btnBorrar.Location = new System.Drawing.Point(344, 10);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 37);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::OrdenesdeServicio.Properties.Resources.delete_256;
            this.btnCerrar.Location = new System.Drawing.Point(412, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 34);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnNuevaorden
            // 
            this.btnNuevaorden.Image = global::OrdenesdeServicio.Properties.Resources._1481064749;
            this.btnNuevaorden.Location = new System.Drawing.Point(279, 10);
            this.btnNuevaorden.Name = "btnNuevaorden";
            this.btnNuevaorden.Size = new System.Drawing.Size(45, 37);
            this.btnNuevaorden.TabIndex = 2;
            this.btnNuevaorden.UseVisualStyleBackColor = true;
            this.btnNuevaorden.Click += new System.EventHandler(this.btnNuevaorden_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::OrdenesdeServicio.Properties.Resources.edit_256;
            this.btnModificar.Location = new System.Drawing.Point(205, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(54, 37);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::OrdenesdeServicio.Properties.Resources.disquete_icono_4115_128;
            this.btnIngresar.Location = new System.Drawing.Point(141, 10);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(48, 37);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // grdCliente
            // 
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(12, 170);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.Size = new System.Drawing.Size(1063, 89);
            this.grdCliente.TabIndex = 79;
            this.grdCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCliente_CellClick);
            // 
            // dtfechaentrega
            // 
            this.dtfechaentrega.Location = new System.Drawing.Point(561, 132);
            this.dtfechaentrega.Name = "dtfechaentrega";
            this.dtfechaentrega.Size = new System.Drawing.Size(200, 20);
            this.dtfechaentrega.TabIndex = 78;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(561, 88);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(197, 20);
            this.dtFecha.TabIndex = 77;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(375, 88);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(86, 20);
            this.txtConsecutivo.TabIndex = 76;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(101, 86);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(128, 20);
            this.txtDocumento.TabIndex = 75;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged_1);
            this.txtDocumento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Fecha Entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Consecutivo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 73;
            this.label14.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Documento";
            // 
            // Nuevaorden
            // 
            this.Nuevaorden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nuevaorden.Controls.Add(this.txtValor);
            this.Nuevaorden.Controls.Add(this.txtdescuento);
            this.Nuevaorden.Controls.Add(this.txtCantidad);
            this.Nuevaorden.Controls.Add(this.txtReferencia);
            this.Nuevaorden.Controls.Add(this.label8);
            this.Nuevaorden.Controls.Add(this.label7);
            this.Nuevaorden.Controls.Add(this.label5);
            this.Nuevaorden.Controls.Add(this.label6);
            this.Nuevaorden.Controls.Add(this.groupBox3);
            this.Nuevaorden.Location = new System.Drawing.Point(4, 22);
            this.Nuevaorden.Name = "Nuevaorden";
            this.Nuevaorden.Padding = new System.Windows.Forms.Padding(3);
            this.Nuevaorden.Size = new System.Drawing.Size(1195, 650);
            this.Nuevaorden.TabIndex = 1;
            this.Nuevaorden.Text = "Nueva Orden";
            this.Nuevaorden.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(901, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 98;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(761, 16);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(44, 20);
            this.txtdescuento.TabIndex = 97;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(552, 16);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(86, 20);
            this.txtCantidad.TabIndex = 96;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(97, 20);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(350, 20);
            this.txtReferencia.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(843, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 92;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(667, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 91;
            this.label7.Text = "Descuento %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Referencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 93;
            this.label6.Text = "Cantidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox13);
            this.groupBox3.Controls.Add(this.Eslabones);
            this.groupBox3.Controls.Add(this.Tapa);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.Cristal);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Location = new System.Drawing.Point(8, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1072, 576);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Características del Artículo";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chkchapetaenbuenestado);
            this.groupBox13.Controls.Add(this.chkchapetaoriginal);
            this.groupBox13.Controls.Add(this.chkchapetarayada);
            this.groupBox13.Controls.Add(this.chkchapetasinpin);
            this.groupBox13.Location = new System.Drawing.Point(7, 135);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(701, 48);
            this.groupBox13.TabIndex = 86;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Chapeta";
            // 
            // chkchapetaenbuenestado
            // 
            this.chkchapetaenbuenestado.AutoSize = true;
            this.chkchapetaenbuenestado.Location = new System.Drawing.Point(520, 16);
            this.chkchapetaenbuenestado.Name = "chkchapetaenbuenestado";
            this.chkchapetaenbuenestado.Size = new System.Drawing.Size(143, 17);
            this.chkchapetaenbuenestado.TabIndex = 3;
            this.chkchapetaenbuenestado.Text = "Chapeta en buen estado";
            this.chkchapetaenbuenestado.UseVisualStyleBackColor = true;
            // 
            // chkchapetaoriginal
            // 
            this.chkchapetaoriginal.AutoSize = true;
            this.chkchapetaoriginal.Location = new System.Drawing.Point(332, 16);
            this.chkchapetaoriginal.Name = "chkchapetaoriginal";
            this.chkchapetaoriginal.Size = new System.Drawing.Size(102, 17);
            this.chkchapetaoriginal.TabIndex = 2;
            this.chkchapetaoriginal.Text = "Chapeta original";
            this.chkchapetaoriginal.UseVisualStyleBackColor = true;
            // 
            // chkchapetarayada
            // 
            this.chkchapetarayada.AutoSize = true;
            this.chkchapetarayada.Location = new System.Drawing.Point(165, 18);
            this.chkchapetarayada.Name = "chkchapetarayada";
            this.chkchapetarayada.Size = new System.Drawing.Size(101, 17);
            this.chkchapetarayada.TabIndex = 1;
            this.chkchapetarayada.Text = "Chapeta rayada";
            this.chkchapetarayada.UseVisualStyleBackColor = true;
            // 
            // chkchapetasinpin
            // 
            this.chkchapetasinpin.AutoSize = true;
            this.chkchapetasinpin.Location = new System.Drawing.Point(21, 19);
            this.chkchapetasinpin.Name = "chkchapetasinpin";
            this.chkchapetasinpin.Size = new System.Drawing.Size(99, 17);
            this.chkchapetasinpin.TabIndex = 0;
            this.chkchapetasinpin.Text = "Chapeta sin pin";
            this.chkchapetasinpin.UseVisualStyleBackColor = true;
            // 
            // Eslabones
            // 
            this.Eslabones.Controls.Add(this.chksineslabones);
            this.Eslabones.Controls.Add(this.txtEslabones);
            this.Eslabones.Controls.Add(this.label13);
            this.Eslabones.Location = new System.Drawing.Point(740, 135);
            this.Eslabones.Name = "Eslabones";
            this.Eslabones.Size = new System.Drawing.Size(320, 46);
            this.Eslabones.TabIndex = 90;
            this.Eslabones.TabStop = false;
            this.Eslabones.Text = "Eslabones";
            // 
            // chksineslabones
            // 
            this.chksineslabones.AutoSize = true;
            this.chksineslabones.Location = new System.Drawing.Point(221, 19);
            this.chksineslabones.Name = "chksineslabones";
            this.chksineslabones.Size = new System.Drawing.Size(92, 17);
            this.chksineslabones.TabIndex = 2;
            this.chksineslabones.Text = "Sin eslabones";
            this.chksineslabones.UseVisualStyleBackColor = true;
            // 
            // txtEslabones
            // 
            this.txtEslabones.Location = new System.Drawing.Point(141, 16);
            this.txtEslabones.Name = "txtEslabones";
            this.txtEslabones.Size = new System.Drawing.Size(45, 20);
            this.txtEslabones.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Número de eslabones";
            // 
            // Tapa
            // 
            this.Tapa.Controls.Add(this.chkTapabuenestado);
            this.Tapa.Controls.Add(this.chkTaparayada);
            this.Tapa.Location = new System.Drawing.Point(6, 451);
            this.Tapa.Name = "Tapa";
            this.Tapa.Size = new System.Drawing.Size(318, 46);
            this.Tapa.TabIndex = 89;
            this.Tapa.TabStop = false;
            this.Tapa.Text = "Tapa";
            // 
            // chkTapabuenestado
            // 
            this.chkTapabuenestado.AutoSize = true;
            this.chkTapabuenestado.Location = new System.Drawing.Point(164, 18);
            this.chkTapabuenestado.Name = "chkTapabuenestado";
            this.chkTapabuenestado.Size = new System.Drawing.Size(128, 17);
            this.chkTapabuenestado.TabIndex = 1;
            this.chkTapabuenestado.Text = "Tapa en buen estado";
            this.chkTapabuenestado.UseVisualStyleBackColor = true;
            // 
            // chkTaparayada
            // 
            this.chkTaparayada.AutoSize = true;
            this.chkTaparayada.Location = new System.Drawing.Point(21, 20);
            this.chkTaparayada.Name = "chkTaparayada";
            this.chkTaparayada.Size = new System.Drawing.Size(86, 17);
            this.chkTaparayada.TabIndex = 0;
            this.chkTaparayada.Text = "Tapa rayada";
            this.chkTaparayada.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbdnogarantiaimpermeabilidad);
            this.groupBox8.Controls.Add(this.rdbgarantiaimpermeabilidad);
            this.groupBox8.Location = new System.Drawing.Point(686, 297);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(374, 43);
            this.groupBox8.TabIndex = 88;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Garantia";
            // 
            // rbdnogarantiaimpermeabilidad
            // 
            this.rbdnogarantiaimpermeabilidad.AutoSize = true;
            this.rbdnogarantiaimpermeabilidad.Location = new System.Drawing.Point(210, 20);
            this.rbdnogarantiaimpermeabilidad.Name = "rbdnogarantiaimpermeabilidad";
            this.rbdnogarantiaimpermeabilidad.Size = new System.Drawing.Size(158, 17);
            this.rbdnogarantiaimpermeabilidad.TabIndex = 1;
            this.rbdnogarantiaimpermeabilidad.TabStop = true;
            this.rbdnogarantiaimpermeabilidad.Text = "No garantia impermeabilidad";
            this.rbdnogarantiaimpermeabilidad.UseVisualStyleBackColor = true;
            // 
            // rdbgarantiaimpermeabilidad
            // 
            this.rdbgarantiaimpermeabilidad.AutoSize = true;
            this.rdbgarantiaimpermeabilidad.Location = new System.Drawing.Point(22, 19);
            this.rdbgarantiaimpermeabilidad.Name = "rdbgarantiaimpermeabilidad";
            this.rdbgarantiaimpermeabilidad.Size = new System.Drawing.Size(158, 17);
            this.rdbgarantiaimpermeabilidad.TabIndex = 0;
            this.rdbgarantiaimpermeabilidad.TabStop = true;
            this.rdbgarantiaimpermeabilidad.Text = "Garantia de impermeabilidad";
            this.rdbgarantiaimpermeabilidad.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chkcoronabuesestado);
            this.groupBox12.Controls.Add(this.chkcoronaoxidada);
            this.groupBox12.Controls.Add(this.chkcoronasuelta);
            this.groupBox12.Controls.Add(this.chkcoronaoriginal);
            this.groupBox12.Controls.Add(this.chkcoronafloja);
            this.groupBox12.Controls.Add(this.chkcoronadesgastada);
            this.groupBox12.Location = new System.Drawing.Point(6, 189);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1054, 48);
            this.groupBox12.TabIndex = 86;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Corona";
            // 
            // chkcoronabuesestado
            // 
            this.chkcoronabuesestado.AutoSize = true;
            this.chkcoronabuesestado.Location = new System.Drawing.Point(890, 20);
            this.chkcoronabuesestado.Name = "chkcoronabuesestado";
            this.chkcoronabuesestado.Size = new System.Drawing.Size(137, 17);
            this.chkcoronabuesestado.TabIndex = 5;
            this.chkcoronabuesestado.Text = "Corona en buen estado";
            this.chkcoronabuesestado.UseVisualStyleBackColor = true;
            // 
            // chkcoronaoxidada
            // 
            this.chkcoronaoxidada.AutoSize = true;
            this.chkcoronaoxidada.Location = new System.Drawing.Point(696, 20);
            this.chkcoronaoxidada.Name = "chkcoronaoxidada";
            this.chkcoronaoxidada.Size = new System.Drawing.Size(100, 17);
            this.chkcoronaoxidada.TabIndex = 4;
            this.chkcoronaoxidada.Text = "Corona oxidada";
            this.chkcoronaoxidada.UseVisualStyleBackColor = true;
            // 
            // chkcoronasuelta
            // 
            this.chkcoronasuelta.AutoSize = true;
            this.chkcoronasuelta.Location = new System.Drawing.Point(521, 20);
            this.chkcoronasuelta.Name = "chkcoronasuelta";
            this.chkcoronasuelta.Size = new System.Drawing.Size(91, 17);
            this.chkcoronasuelta.TabIndex = 3;
            this.chkcoronasuelta.Text = "Corona suelta";
            this.chkcoronasuelta.UseVisualStyleBackColor = true;
            // 
            // chkcoronaoriginal
            // 
            this.chkcoronaoriginal.AutoSize = true;
            this.chkcoronaoriginal.Location = new System.Drawing.Point(333, 19);
            this.chkcoronaoriginal.Name = "chkcoronaoriginal";
            this.chkcoronaoriginal.Size = new System.Drawing.Size(96, 17);
            this.chkcoronaoriginal.TabIndex = 2;
            this.chkcoronaoriginal.Text = "Corona original";
            this.chkcoronaoriginal.UseVisualStyleBackColor = true;
            // 
            // chkcoronafloja
            // 
            this.chkcoronafloja.AutoSize = true;
            this.chkcoronafloja.Location = new System.Drawing.Point(166, 19);
            this.chkcoronafloja.Name = "chkcoronafloja";
            this.chkcoronafloja.Size = new System.Drawing.Size(82, 17);
            this.chkcoronafloja.TabIndex = 1;
            this.chkcoronafloja.Text = "Corona floja";
            this.chkcoronafloja.UseVisualStyleBackColor = true;
            // 
            // chkcoronadesgastada
            // 
            this.chkcoronadesgastada.AutoSize = true;
            this.chkcoronadesgastada.Location = new System.Drawing.Point(21, 19);
            this.chkcoronadesgastada.Name = "chkcoronadesgastada";
            this.chkcoronadesgastada.Size = new System.Drawing.Size(118, 17);
            this.chkcoronadesgastada.TabIndex = 0;
            this.chkcoronadesgastada.Text = "Corona desgastada";
            this.chkcoronadesgastada.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbdoriginal);
            this.groupBox7.Controls.Add(this.rbdimitacion);
            this.groupBox7.Location = new System.Drawing.Point(856, 348);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(205, 43);
            this.groupBox7.TabIndex = 87;
            this.groupBox7.TabStop = false;
            // 
            // rbdoriginal
            // 
            this.rbdoriginal.AutoSize = true;
            this.rbdoriginal.Location = new System.Drawing.Point(141, 20);
            this.rbdoriginal.Name = "rbdoriginal";
            this.rbdoriginal.Size = new System.Drawing.Size(60, 17);
            this.rbdoriginal.TabIndex = 1;
            this.rbdoriginal.TabStop = true;
            this.rbdoriginal.Text = "Original";
            this.rbdoriginal.UseVisualStyleBackColor = true;
            // 
            // rbdimitacion
            // 
            this.rbdimitacion.AutoSize = true;
            this.rbdimitacion.Location = new System.Drawing.Point(21, 20);
            this.rbdimitacion.Name = "rbdimitacion";
            this.rbdimitacion.Size = new System.Drawing.Size(67, 17);
            this.rbdimitacion.TabIndex = 0;
            this.rbdimitacion.TabStop = true;
            this.rbdimitacion.Text = "Imitación";
            this.rbdimitacion.UseVisualStyleBackColor = true;
            // 
            // Cristal
            // 
            this.Cristal.Controls.Add(this.chkcristalbuenestado);
            this.Cristal.Controls.Add(this.chkcristalhumedad);
            this.Cristal.Controls.Add(this.chkCristalmanchado);
            this.Cristal.Controls.Add(this.chkcristaldespicado);
            this.Cristal.Controls.Add(this.chkcristalquebrado);
            this.Cristal.Controls.Add(this.chkcristalrayado);
            this.Cristal.Location = new System.Drawing.Point(7, 78);
            this.Cristal.Name = "Cristal";
            this.Cristal.Size = new System.Drawing.Size(1054, 51);
            this.Cristal.TabIndex = 81;
            this.Cristal.TabStop = false;
            this.Cristal.Text = "Cristal";
            // 
            // chkcristalbuenestado
            // 
            this.chkcristalbuenestado.AutoSize = true;
            this.chkcristalbuenestado.Location = new System.Drawing.Point(889, 19);
            this.chkcristalbuenestado.Name = "chkcristalbuenestado";
            this.chkcristalbuenestado.Size = new System.Drawing.Size(131, 17);
            this.chkcristalbuenestado.TabIndex = 5;
            this.chkcristalbuenestado.Text = "Cristal en buen estado";
            this.chkcristalbuenestado.UseVisualStyleBackColor = true;
            // 
            // chkcristalhumedad
            // 
            this.chkcristalhumedad.AutoSize = true;
            this.chkcristalhumedad.Location = new System.Drawing.Point(695, 19);
            this.chkcristalhumedad.Name = "chkcristalhumedad";
            this.chkcristalhumedad.Size = new System.Drawing.Size(122, 17);
            this.chkcristalhumedad.TabIndex = 4;
            this.chkcristalhumedad.Text = "Cristal con humedad";
            this.chkcristalhumedad.UseVisualStyleBackColor = true;
            // 
            // chkCristalmanchado
            // 
            this.chkCristalmanchado.AutoSize = true;
            this.chkCristalmanchado.Location = new System.Drawing.Point(520, 19);
            this.chkCristalmanchado.Name = "chkCristalmanchado";
            this.chkCristalmanchado.Size = new System.Drawing.Size(107, 17);
            this.chkCristalmanchado.TabIndex = 3;
            this.chkCristalmanchado.Text = "Cristal manchado";
            this.chkCristalmanchado.UseVisualStyleBackColor = true;
            // 
            // chkcristaldespicado
            // 
            this.chkcristaldespicado.AutoSize = true;
            this.chkcristaldespicado.Location = new System.Drawing.Point(332, 19);
            this.chkcristaldespicado.Name = "chkcristaldespicado";
            this.chkcristaldespicado.Size = new System.Drawing.Size(106, 17);
            this.chkcristaldespicado.TabIndex = 2;
            this.chkcristaldespicado.Text = "Cristal despicado";
            this.chkcristaldespicado.UseVisualStyleBackColor = true;
            // 
            // chkcristalquebrado
            // 
            this.chkcristalquebrado.AutoSize = true;
            this.chkcristalquebrado.Location = new System.Drawing.Point(164, 19);
            this.chkcristalquebrado.Name = "chkcristalquebrado";
            this.chkcristalquebrado.Size = new System.Drawing.Size(102, 17);
            this.chkcristalquebrado.TabIndex = 1;
            this.chkcristalquebrado.Text = "Cristal quebrado";
            this.chkcristalquebrado.UseVisualStyleBackColor = true;
            // 
            // chkcristalrayado
            // 
            this.chkcristalrayado.AutoSize = true;
            this.chkcristalrayado.Location = new System.Drawing.Point(21, 20);
            this.chkcristalrayado.Name = "chkcristalrayado";
            this.chkcristalrayado.Size = new System.Drawing.Size(89, 17);
            this.chkcristalrayado.TabIndex = 0;
            this.chkcristalrayado.Text = "Cristal rayado";
            this.chkcristalrayado.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chktablerobuenestado);
            this.groupBox6.Controls.Add(this.chktablerosinsegundero);
            this.groupBox6.Controls.Add(this.chktableroquebrado);
            this.groupBox6.Controls.Add(this.chkTablerorayado);
            this.groupBox6.Controls.Add(this.chktableronumero);
            this.groupBox6.Controls.Add(this.chktableromanchado);
            this.groupBox6.Location = new System.Drawing.Point(7, 397);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1054, 48);
            this.groupBox6.TabIndex = 86;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tablero";
            // 
            // chktablerobuenestado
            // 
            this.chktablerobuenestado.AutoSize = true;
            this.chktablerobuenestado.Location = new System.Drawing.Point(886, 20);
            this.chktablerobuenestado.Name = "chktablerobuenestado";
            this.chktablerobuenestado.Size = new System.Drawing.Size(139, 17);
            this.chktablerobuenestado.TabIndex = 5;
            this.chktablerobuenestado.Text = "Tablero en buen estado";
            this.chktablerobuenestado.UseVisualStyleBackColor = true;
            // 
            // chktablerosinsegundero
            // 
            this.chktablerosinsegundero.AutoSize = true;
            this.chktablerosinsegundero.Location = new System.Drawing.Point(695, 20);
            this.chktablerosinsegundero.Name = "chktablerosinsegundero";
            this.chktablerosinsegundero.Size = new System.Drawing.Size(131, 17);
            this.chktablerosinsegundero.TabIndex = 4;
            this.chktablerosinsegundero.Text = "Tablero sin segundero";
            this.chktablerosinsegundero.UseVisualStyleBackColor = true;
            // 
            // chktableroquebrado
            // 
            this.chktableroquebrado.AutoSize = true;
            this.chktableroquebrado.Location = new System.Drawing.Point(520, 19);
            this.chktableroquebrado.Name = "chktableroquebrado";
            this.chktableroquebrado.Size = new System.Drawing.Size(110, 17);
            this.chktableroquebrado.TabIndex = 3;
            this.chktableroquebrado.Text = "Tablero quebrado";
            this.chktableroquebrado.UseVisualStyleBackColor = true;
            // 
            // chkTablerorayado
            // 
            this.chkTablerorayado.AutoSize = true;
            this.chkTablerorayado.Location = new System.Drawing.Point(332, 20);
            this.chkTablerorayado.Name = "chkTablerorayado";
            this.chkTablerorayado.Size = new System.Drawing.Size(97, 17);
            this.chkTablerorayado.TabIndex = 2;
            this.chkTablerorayado.Text = "Tablero rayado";
            this.chkTablerorayado.UseVisualStyleBackColor = true;
            // 
            // chktableronumero
            // 
            this.chktableronumero.AutoSize = true;
            this.chktableronumero.Location = new System.Drawing.Point(168, 19);
            this.chktableronumero.Name = "chktableronumero";
            this.chktableronumero.Size = new System.Drawing.Size(123, 17);
            this.chktableronumero.TabIndex = 1;
            this.chktableronumero.Text = "Tablero falta número";
            this.chktableronumero.UseVisualStyleBackColor = true;
            // 
            // chktableromanchado
            // 
            this.chktableromanchado.AutoSize = true;
            this.chktableromanchado.Location = new System.Drawing.Point(21, 19);
            this.chktableromanchado.Name = "chktableromanchado";
            this.chktableromanchado.Size = new System.Drawing.Size(115, 17);
            this.chktableromanchado.TabIndex = 0;
            this.chktableromanchado.Text = "Tablero manchado";
            this.chktableromanchado.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkpulsoenbuenestado);
            this.groupBox5.Controls.Add(this.chkpulsosinhebilla);
            this.groupBox5.Controls.Add(this.chkpulsorayado);
            this.groupBox5.Controls.Add(this.chkpulsodespintado);
            this.groupBox5.Controls.Add(this.chkpulsopartido);
            this.groupBox5.Location = new System.Drawing.Point(7, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(843, 45);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pulso";
            // 
            // chkpulsoenbuenestado
            // 
            this.chkpulsoenbuenestado.AutoSize = true;
            this.chkpulsoenbuenestado.Location = new System.Drawing.Point(694, 20);
            this.chkpulsoenbuenestado.Name = "chkpulsoenbuenestado";
            this.chkpulsoenbuenestado.Size = new System.Drawing.Size(129, 17);
            this.chkpulsoenbuenestado.TabIndex = 4;
            this.chkpulsoenbuenestado.Text = "Pulso en buen estado";
            this.chkpulsoenbuenestado.UseVisualStyleBackColor = true;
            // 
            // chkpulsosinhebilla
            // 
            this.chkpulsosinhebilla.AutoSize = true;
            this.chkpulsosinhebilla.Location = new System.Drawing.Point(520, 19);
            this.chkpulsosinhebilla.Name = "chkpulsosinhebilla";
            this.chkpulsosinhebilla.Size = new System.Drawing.Size(137, 17);
            this.chkpulsosinhebilla.TabIndex = 3;
            this.chkpulsosinhebilla.Text = "Pulso sin hebilla original";
            this.chkpulsosinhebilla.UseVisualStyleBackColor = true;
            // 
            // chkpulsorayado
            // 
            this.chkpulsorayado.AutoSize = true;
            this.chkpulsorayado.Location = new System.Drawing.Point(332, 19);
            this.chkpulsorayado.Name = "chkpulsorayado";
            this.chkpulsorayado.Size = new System.Drawing.Size(87, 17);
            this.chkpulsorayado.TabIndex = 2;
            this.chkpulsorayado.Text = "Pulso rayado";
            this.chkpulsorayado.UseVisualStyleBackColor = true;
            // 
            // chkpulsodespintado
            // 
            this.chkpulsodespintado.AutoSize = true;
            this.chkpulsodespintado.Location = new System.Drawing.Point(164, 19);
            this.chkpulsodespintado.Name = "chkpulsodespintado";
            this.chkpulsodespintado.Size = new System.Drawing.Size(107, 17);
            this.chkpulsodespintado.TabIndex = 1;
            this.chkpulsodespintado.Text = "Pulso despintado";
            this.chkpulsodespintado.UseVisualStyleBackColor = true;
            // 
            // chkpulsopartido
            // 
            this.chkpulsopartido.AutoSize = true;
            this.chkpulsopartido.Location = new System.Drawing.Point(21, 20);
            this.chkpulsopartido.Name = "chkpulsopartido";
            this.chkpulsopartido.Size = new System.Drawing.Size(87, 17);
            this.chkpulsopartido.TabIndex = 0;
            this.chkpulsopartido.Text = "Pulso partido";
            this.chkpulsopartido.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(947, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 90;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkescafandrabuenestado);
            this.groupBox4.Controls.Add(this.chksinescafandra);
            this.groupBox4.Controls.Add(this.chkescafandrapintada);
            this.groupBox4.Controls.Add(this.chkescafandranumeracion);
            this.groupBox4.Controls.Add(this.chkEscafandrarayada);
            this.groupBox4.Controls.Add(this.chkEscafandrasuelta);
            this.groupBox4.Location = new System.Drawing.Point(7, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1054, 46);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Escafandra";
            // 
            // chkescafandrabuenestado
            // 
            this.chkescafandrabuenestado.AutoSize = true;
            this.chkescafandrabuenestado.Location = new System.Drawing.Point(886, 19);
            this.chkescafandrabuenestado.Name = "chkescafandrabuenestado";
            this.chkescafandrabuenestado.Size = new System.Drawing.Size(157, 17);
            this.chkescafandrabuenestado.TabIndex = 5;
            this.chkescafandrabuenestado.Text = "Escafandra en buen estado";
            this.chkescafandrabuenestado.UseVisualStyleBackColor = true;
            // 
            // chksinescafandra
            // 
            this.chksinescafandra.AutoSize = true;
            this.chksinescafandra.Location = new System.Drawing.Point(695, 19);
            this.chksinescafandra.Name = "chksinescafandra";
            this.chksinescafandra.Size = new System.Drawing.Size(97, 17);
            this.chksinescafandra.TabIndex = 4;
            this.chksinescafandra.Text = "Sin escafandra";
            this.chksinescafandra.UseVisualStyleBackColor = true;
            // 
            // chkescafandrapintada
            // 
            this.chkescafandrapintada.AutoSize = true;
            this.chkescafandrapintada.Location = new System.Drawing.Point(520, 19);
            this.chkescafandrapintada.Name = "chkescafandrapintada";
            this.chkescafandrapintada.Size = new System.Drawing.Size(135, 17);
            this.chkescafandrapintada.TabIndex = 3;
            this.chkescafandrapintada.Text = "Escafandra despintada";
            this.chkescafandrapintada.UseVisualStyleBackColor = true;
            // 
            // chkescafandranumeracion
            // 
            this.chkescafandranumeracion.AutoSize = true;
            this.chkescafandranumeracion.Location = new System.Drawing.Point(332, 19);
            this.chkescafandranumeracion.Name = "chkescafandranumeracion";
            this.chkescafandranumeracion.Size = new System.Drawing.Size(154, 17);
            this.chkescafandranumeracion.TabIndex = 2;
            this.chkescafandranumeracion.Text = "Escafandra sin numeración";
            this.chkescafandranumeracion.UseVisualStyleBackColor = true;
            // 
            // chkEscafandrarayada
            // 
            this.chkEscafandrarayada.AutoSize = true;
            this.chkEscafandrarayada.Location = new System.Drawing.Point(165, 19);
            this.chkEscafandrarayada.Name = "chkEscafandrarayada";
            this.chkEscafandrarayada.Size = new System.Drawing.Size(115, 17);
            this.chkEscafandrarayada.TabIndex = 1;
            this.chkEscafandrarayada.Text = "Escafandra rayada";
            this.chkEscafandrarayada.UseVisualStyleBackColor = true;
            // 
            // chkEscafandrasuelta
            // 
            this.chkEscafandrasuelta.AutoSize = true;
            this.chkEscafandrasuelta.Location = new System.Drawing.Point(21, 19);
            this.chkEscafandrasuelta.Name = "chkEscafandrasuelta";
            this.chkEscafandrasuelta.Size = new System.Drawing.Size(111, 17);
            this.chkEscafandrasuelta.TabIndex = 0;
            this.chkEscafandrasuelta.Text = "Escafandra suelta";
            this.chkEscafandrasuelta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(947, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "Añadir Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chkcajasintornillo);
            this.groupBox10.Controls.Add(this.chkcajabuenestado);
            this.groupBox10.Controls.Add(this.chkcajaporosa);
            this.groupBox10.Controls.Add(this.chkcajamanchada);
            this.groupBox10.Controls.Add(this.chkCajaquebrada);
            this.groupBox10.Controls.Add(this.chkcajarayada);
            this.groupBox10.Location = new System.Drawing.Point(6, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1054, 46);
            this.groupBox10.TabIndex = 83;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Caja";
            // 
            // chkcajasintornillo
            // 
            this.chkcajasintornillo.AutoSize = true;
            this.chkcajasintornillo.Location = new System.Drawing.Point(695, 20);
            this.chkcajasintornillo.Name = "chkcajasintornillo";
            this.chkcajasintornillo.Size = new System.Drawing.Size(96, 17);
            this.chkcajasintornillo.TabIndex = 5;
            this.chkcajasintornillo.Text = "Caja sin tornillo";
            this.chkcajasintornillo.UseVisualStyleBackColor = true;
            // 
            // chkcajabuenestado
            // 
            this.chkcajabuenestado.AutoSize = true;
            this.chkcajabuenestado.Location = new System.Drawing.Point(890, 19);
            this.chkcajabuenestado.Name = "chkcajabuenestado";
            this.chkcajabuenestado.Size = new System.Drawing.Size(124, 17);
            this.chkcajabuenestado.TabIndex = 4;
            this.chkcajabuenestado.Text = "Caja en buen estado";
            this.chkcajabuenestado.UseVisualStyleBackColor = true;
            // 
            // chkcajaporosa
            // 
            this.chkcajaporosa.AutoSize = true;
            this.chkcajaporosa.Location = new System.Drawing.Point(521, 20);
            this.chkcajaporosa.Name = "chkcajaporosa";
            this.chkcajaporosa.Size = new System.Drawing.Size(82, 17);
            this.chkcajaporosa.TabIndex = 3;
            this.chkcajaporosa.Text = "Caja porosa";
            this.chkcajaporosa.UseVisualStyleBackColor = true;
            // 
            // chkcajamanchada
            // 
            this.chkcajamanchada.AutoSize = true;
            this.chkcajamanchada.Location = new System.Drawing.Point(333, 19);
            this.chkcajamanchada.Name = "chkcajamanchada";
            this.chkcajamanchada.Size = new System.Drawing.Size(100, 17);
            this.chkcajamanchada.TabIndex = 2;
            this.chkcajamanchada.Text = "Caja manchada";
            this.chkcajamanchada.UseVisualStyleBackColor = true;
            // 
            // chkCajaquebrada
            // 
            this.chkCajaquebrada.AutoSize = true;
            this.chkCajaquebrada.Location = new System.Drawing.Point(165, 19);
            this.chkCajaquebrada.Name = "chkCajaquebrada";
            this.chkCajaquebrada.Size = new System.Drawing.Size(95, 17);
            this.chkCajaquebrada.TabIndex = 1;
            this.chkCajaquebrada.Text = "Caja quebrada";
            this.chkCajaquebrada.UseVisualStyleBackColor = true;
            // 
            // chkcajarayada
            // 
            this.chkcajarayada.AutoSize = true;
            this.chkcajarayada.Location = new System.Drawing.Point(21, 20);
            this.chkcajarayada.Name = "chkcajarayada";
            this.chkcajarayada.Size = new System.Drawing.Size(82, 17);
            this.chkcajarayada.TabIndex = 0;
            this.chkcajarayada.Text = "Caja rayada";
            this.chkcajarayada.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtObservaciones);
            this.groupBox1.Location = new System.Drawing.Point(349, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 87);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // rtxtObservaciones
            // 
            this.rtxtObservaciones.Location = new System.Drawing.Point(20, 19);
            this.rtxtObservaciones.Name = "rtxtObservaciones";
            this.rtxtObservaciones.Size = new System.Drawing.Size(553, 53);
            this.rtxtObservaciones.TabIndex = 83;
            this.rtxtObservaciones.Text = "";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chknofuncionadigital);
            this.groupBox11.Controls.Add(this.chknofuncionananalogo);
            this.groupBox11.Controls.Add(this.chkfuncionadigital);
            this.groupBox11.Controls.Add(this.chkfuncionaanalogo);
            this.groupBox11.Location = new System.Drawing.Point(7, 294);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(663, 46);
            this.groupBox11.TabIndex = 82;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Funcionamiento";
            // 
            // chknofuncionadigital
            // 
            this.chknofuncionadigital.AutoSize = true;
            this.chknofuncionadigital.Location = new System.Drawing.Point(520, 20);
            this.chknofuncionadigital.Name = "chknofuncionadigital";
            this.chknofuncionadigital.Size = new System.Drawing.Size(114, 17);
            this.chknofuncionadigital.TabIndex = 3;
            this.chknofuncionadigital.Text = "No funciona digital";
            this.chknofuncionadigital.UseVisualStyleBackColor = true;
            // 
            // chknofuncionananalogo
            // 
            this.chknofuncionananalogo.AutoSize = true;
            this.chknofuncionananalogo.Location = new System.Drawing.Point(332, 19);
            this.chknofuncionananalogo.Name = "chknofuncionananalogo";
            this.chknofuncionananalogo.Size = new System.Drawing.Size(126, 17);
            this.chknofuncionananalogo.TabIndex = 2;
            this.chknofuncionananalogo.Text = "No funciona Análogo";
            this.chknofuncionananalogo.UseVisualStyleBackColor = true;
            // 
            // chkfuncionadigital
            // 
            this.chkfuncionadigital.AutoSize = true;
            this.chkfuncionadigital.Location = new System.Drawing.Point(164, 19);
            this.chkfuncionadigital.Name = "chkfuncionadigital";
            this.chkfuncionadigital.Size = new System.Drawing.Size(100, 17);
            this.chkfuncionadigital.TabIndex = 1;
            this.chkfuncionadigital.Text = "Funciona digital";
            this.chkfuncionadigital.UseVisualStyleBackColor = true;
            // 
            // chkfuncionaanalogo
            // 
            this.chkfuncionaanalogo.AutoSize = true;
            this.chkfuncionaanalogo.Location = new System.Drawing.Point(21, 20);
            this.chkfuncionaanalogo.Name = "chkfuncionaanalogo";
            this.chkfuncionaanalogo.Size = new System.Drawing.Size(111, 17);
            this.chkfuncionaanalogo.TabIndex = 0;
            this.chkfuncionaanalogo.Text = "Funciona análogo";
            this.chkfuncionaanalogo.UseVisualStyleBackColor = true;
            // 
            // Abonos
            // 
            this.Abonos.Name = "Abonos";
            this.Abonos.Size = new System.Drawing.Size(60, 20);
            this.Abonos.Text = "Abonos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 687);
            this.Controls.Add(this.tabOrdenes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ordenes de Servicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabOrdenes.ResumeLayout(false);
            this.Ordenes.ResumeLayout(false);
            this.Ordenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.Nuevaorden.ResumeLayout(false);
            this.Nuevaorden.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.Eslabones.ResumeLayout(false);
            this.Eslabones.PerformLayout();
            this.Tapa.ResumeLayout(false);
            this.Tapa.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.Cristal.ResumeLayout(false);
            this.Cristal.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.TabControl tabOrdenes;
        private System.Windows.Forms.TabPage Ordenes;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox rtxtObservacionesgenerales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevaorden;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.DateTimePicker dtfechaentrega;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Nuevaorden;
        private System.Windows.Forms.DataGridView grdOrdenes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtObservaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbdnogarantiaimpermeabilidad;
        private System.Windows.Forms.RadioButton rdbgarantiaimpermeabilidad;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbdoriginal;
        private System.Windows.Forms.RadioButton rbdimitacion;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chktablerobuenestado;
        private System.Windows.Forms.CheckBox chktablerosinsegundero;
        private System.Windows.Forms.CheckBox chktableroquebrado;
        private System.Windows.Forms.CheckBox chkTablerorayado;
        private System.Windows.Forms.CheckBox chktableronumero;
        private System.Windows.Forms.CheckBox chktableromanchado;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkpulsoenbuenestado;
        private System.Windows.Forms.CheckBox chkpulsosinhebilla;
        private System.Windows.Forms.CheckBox chkpulsorayado;
        private System.Windows.Forms.CheckBox chkpulsodespintado;
        private System.Windows.Forms.CheckBox chkpulsopartido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkescafandrabuenestado;
        private System.Windows.Forms.CheckBox chksinescafandra;
        private System.Windows.Forms.CheckBox chkescafandrapintada;
        private System.Windows.Forms.CheckBox chkescafandranumeracion;
        private System.Windows.Forms.CheckBox chkEscafandrarayada;
        private System.Windows.Forms.CheckBox chkEscafandrasuelta;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox chkcajasintornillo;
        private System.Windows.Forms.CheckBox chkcajabuenestado;
        private System.Windows.Forms.CheckBox chkcajaporosa;
        private System.Windows.Forms.CheckBox chkcajamanchada;
        private System.Windows.Forms.CheckBox chkCajaquebrada;
        private System.Windows.Forms.CheckBox chkcajarayada;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox chknofuncionadigital;
        private System.Windows.Forms.CheckBox chknofuncionananalogo;
        private System.Windows.Forms.CheckBox chkfuncionadigital;
        private System.Windows.Forms.CheckBox chkfuncionaanalogo;
        private System.Windows.Forms.GroupBox Cristal;
        private System.Windows.Forms.CheckBox chkcristalbuenestado;
        private System.Windows.Forms.CheckBox chkcristalhumedad;
        private System.Windows.Forms.CheckBox chkCristalmanchado;
        private System.Windows.Forms.CheckBox chkcristaldespicado;
        private System.Windows.Forms.CheckBox chkcristalquebrado;
        private System.Windows.Forms.CheckBox chkcristalrayado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBorrarregistro;
        private System.Windows.Forms.TextBox txttotalcancelado;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Lblestadofactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSaldopendiente;
        private System.Windows.Forms.ToolStripMenuItem ordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdenesToolStripMenuItem;
        private System.Windows.Forms.GroupBox Eslabones;
        private System.Windows.Forms.TextBox txtEslabones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox Tapa;
        private System.Windows.Forms.CheckBox chkTapabuenestado;
        private System.Windows.Forms.CheckBox chkTaparayada;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox chkchapetaenbuenestado;
        private System.Windows.Forms.CheckBox chkchapetaoriginal;
        private System.Windows.Forms.CheckBox chkchapetarayada;
        private System.Windows.Forms.CheckBox chkchapetasinpin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chkcoronabuesestado;
        private System.Windows.Forms.CheckBox chkcoronaoxidada;
        private System.Windows.Forms.CheckBox chkcoronasuelta;
        private System.Windows.Forms.CheckBox chkcoronaoriginal;
        private System.Windows.Forms.CheckBox chkcoronafloja;
        private System.Windows.Forms.CheckBox chkcoronadesgastada;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox CboVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Características;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutivo;
        private System.Windows.Forms.CheckBox chksineslabones;
        private System.Windows.Forms.ToolStripMenuItem Abonos;

    }
}

