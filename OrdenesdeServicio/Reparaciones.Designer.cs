namespace OrdenesdeServicio
{
    partial class Reparaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPlug = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtobservaciones = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtCabonos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grdOrdenes = new System.Windows.Forms.DataGridView();
            this.Codigop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenesDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallerDeRelojeriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasYAbonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaMercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadreCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldopendiente = new System.Windows.Forms.TextBox();
            this.txtmodificaro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdOrdenes1 = new System.Windows.Forms.DataGridView();
            this.codigop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plug1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevaorden = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Documento Cliente";
            // 
            // grdCliente
            // 
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(12, 76);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.Size = new System.Drawing.Size(1131, 75);
            this.grdCliente.TabIndex = 80;
            this.grdCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCliente_CellClick);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(1036, 189);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(107, 26);
            this.txtValor.TabIndex = 118;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(82, 191);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 26);
            this.txtCodigo.TabIndex = 114;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtPlug
            // 
            this.txtPlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlug.Location = new System.Drawing.Point(334, 190);
            this.txtPlug.Name = "txtPlug";
            this.txtPlug.Size = new System.Drawing.Size(243, 26);
            this.txtPlug.TabIndex = 115;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(667, 189);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(89, 26);
            this.txtCantidad.TabIndex = 116;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(980, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 111;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(786, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Descuento %";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(288, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 113;
            this.label16.Text = "Plug";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 119;
            this.label15.Text = "Código";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescuento.Location = new System.Drawing.Point(907, 189);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(47, 26);
            this.txtdescuento.TabIndex = 153;
            this.txtdescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescuento_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtobservaciones);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 82);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // rtxtobservaciones
            // 
            this.rtxtobservaciones.Location = new System.Drawing.Point(17, 25);
            this.rtxtobservaciones.Name = "rtxtobservaciones";
            this.rtxtobservaciones.Size = new System.Drawing.Size(840, 47);
            this.rtxtobservaciones.TabIndex = 67;
            this.rtxtobservaciones.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(861, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 159;
            this.label10.Text = "Total a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(984, 419);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(159, 26);
            this.txtTotal.TabIndex = 158;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(441, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 37);
            this.lblUsuario.TabIndex = 109;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 30);
            this.button1.TabIndex = 166;
            this.button1.Text = "Añadir Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(12, 418);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(86, 26);
            this.txtConsecutivo.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 167;
            this.label1.Text = "Número de Orden";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(572, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 26);
            this.button5.TabIndex = 171;
            this.button5.Text = "Aplicar anticipo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtCabonos
            // 
            this.txtCabonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabonos.Location = new System.Drawing.Point(435, 418);
            this.txtCabonos.Name = "txtCabonos";
            this.txtCabonos.Size = new System.Drawing.Size(117, 26);
            this.txtCabonos.TabIndex = 170;
            this.txtCabonos.TextChanged += new System.EventHandler(this.txtCabonos_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(324, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 169;
            this.label12.Text = "Saldo a favor";
            // 
            // grdOrdenes
            // 
            this.grdOrdenes.AllowUserToAddRows = false;
            this.grdOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigop,
            this.Plug,
            this.Cantidad,
            this.Descuento,
            this.Valor,
            this.Subtotal});
            this.grdOrdenes.Location = new System.Drawing.Point(12, 248);
            this.grdOrdenes.Name = "grdOrdenes";
            this.grdOrdenes.Size = new System.Drawing.Size(1134, 139);
            this.grdOrdenes.TabIndex = 172;
            this.grdOrdenes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrdenes_CellEndEdit);
            // 
            // Codigop
            // 
            this.Codigop.DataPropertyName = "codigo_p";
            this.Codigop.HeaderText = "Codigo_Plug";
            this.Codigop.Name = "Codigop";
            this.Codigop.Width = 150;
            // 
            // Plug
            // 
            this.Plug.DataPropertyName = "plug";
            this.Plug.HeaderText = "Plug";
            this.Plug.Name = "Plug";
            this.Plug.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "precio";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 200;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "valor";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 250;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(723, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 31);
            this.btnAgregar.TabIndex = 174;
            this.btnAgregar.Text = "Grabar orden";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeServicioToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem,
            this.tallerDeRelojeriaToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.ventasYAbonosToolStripMenuItem,
            this.salidaMercanciaToolStripMenuItem,
            this.actividadesRealizadasToolStripMenuItem,
            this.cuadreCajaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 175;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordenesDeServicioToolStripMenuItem
            // 
            this.ordenesDeServicioToolStripMenuItem.Name = "ordenesDeServicioToolStripMenuItem";
            this.ordenesDeServicioToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.ordenesDeServicioToolStripMenuItem.Text = "Ordenes de Servicio";
            this.ordenesDeServicioToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeServicioToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // tallerDeRelojeriaToolStripMenuItem
            // 
            this.tallerDeRelojeriaToolStripMenuItem.Name = "tallerDeRelojeriaToolStripMenuItem";
            this.tallerDeRelojeriaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.tallerDeRelojeriaToolStripMenuItem.Text = "Taller de Relojeria";
            this.tallerDeRelojeriaToolStripMenuItem.Click += new System.EventHandler(this.tallerDeRelojeriaToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // ventasYAbonosToolStripMenuItem
            // 
            this.ventasYAbonosToolStripMenuItem.Name = "ventasYAbonosToolStripMenuItem";
            this.ventasYAbonosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.ventasYAbonosToolStripMenuItem.Text = "Ventas y Abonos";
            this.ventasYAbonosToolStripMenuItem.Click += new System.EventHandler(this.ventasYAbonosToolStripMenuItem_Click);
            // 
            // salidaMercanciaToolStripMenuItem
            // 
            this.salidaMercanciaToolStripMenuItem.Name = "salidaMercanciaToolStripMenuItem";
            this.salidaMercanciaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.salidaMercanciaToolStripMenuItem.Text = "Salida Mercancia";
            this.salidaMercanciaToolStripMenuItem.Click += new System.EventHandler(this.salidaMercanciaToolStripMenuItem_Click);
            // 
            // actividadesRealizadasToolStripMenuItem
            // 
            this.actividadesRealizadasToolStripMenuItem.Name = "actividadesRealizadasToolStripMenuItem";
            this.actividadesRealizadasToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.actividadesRealizadasToolStripMenuItem.Text = "Actividades Realizadas";
            this.actividadesRealizadasToolStripMenuItem.Click += new System.EventHandler(this.actividadesRealizadasToolStripMenuItem_Click);
            // 
            // cuadreCajaToolStripMenuItem
            // 
            this.cuadreCajaToolStripMenuItem.Name = "cuadreCajaToolStripMenuItem";
            this.cuadreCajaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.cuadreCajaToolStripMenuItem.Text = "Cuadre Caja";
            this.cuadreCajaToolStripMenuItem.Click += new System.EventHandler(this.cuadreCajaToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(906, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 159;
            this.label5.Text = "Debe";
            // 
            // txtSaldopendiente
            // 
            this.txtSaldopendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldopendiente.Location = new System.Drawing.Point(984, 458);
            this.txtSaldopendiente.Name = "txtSaldopendiente";
            this.txtSaldopendiente.Size = new System.Drawing.Size(159, 26);
            this.txtSaldopendiente.TabIndex = 176;
            // 
            // txtmodificaro
            // 
            this.txtmodificaro.Location = new System.Drawing.Point(721, 53);
            this.txtmodificaro.Name = "txtmodificaro";
            this.txtmodificaro.Size = new System.Drawing.Size(94, 20);
            this.txtmodificaro.TabIndex = 178;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(719, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 20);
            this.label17.TabIndex = 177;
            this.label17.Text = "Consecutivo ";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(159, 44);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(195, 26);
            this.txtDocumento.TabIndex = 180;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(360, 47);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 23);
            this.btnConsultar.TabIndex = 181;
            this.btnConsultar.Text = "?";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grdOrdenes1
            // 
            this.grdOrdenes1.AllowUserToAddRows = false;
            this.grdOrdenes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdenes1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigop1,
            this.plug1,
            this.cantidad1,
            this.descuento1,
            this.valor1,
            this.subtotal1});
            this.grdOrdenes1.Location = new System.Drawing.Point(9, 248);
            this.grdOrdenes1.Name = "grdOrdenes1";
            this.grdOrdenes1.Size = new System.Drawing.Size(1134, 139);
            this.grdOrdenes1.TabIndex = 183;
            this.grdOrdenes1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrdenes1_CellEndEdit);
            // 
            // codigop1
            // 
            this.codigop1.HeaderText = "Codigo_Plug";
            this.codigop1.Name = "codigop1";
            this.codigop1.Width = 150;
            // 
            // plug1
            // 
            this.plug1.HeaderText = "Plug";
            this.plug1.Name = "plug1";
            this.plug1.Width = 300;
            // 
            // cantidad1
            // 
            this.cantidad1.HeaderText = "Cantidad";
            this.cantidad1.Name = "cantidad1";
            // 
            // descuento1
            // 
            this.descuento1.HeaderText = "Descuento";
            this.descuento1.Name = "descuento1";
            // 
            // valor1
            // 
            this.valor1.DataPropertyName = "precio";
            this.valor1.HeaderText = "Valor";
            this.valor1.Name = "valor1";
            this.valor1.Width = 200;
            // 
            // subtotal1
            // 
            this.subtotal1.HeaderText = "Subtotal";
            this.subtotal1.Name = "subtotal1";
            this.subtotal1.Width = 250;
            // 
            // button4
            // 
            this.button4.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button4.Location = new System.Drawing.Point(831, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 46);
            this.button4.TabIndex = 179;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::OrdenesdeServicio.Properties.Resources.descarga;
            this.btnBorrar.Location = new System.Drawing.Point(1009, 33);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(39, 34);
            this.btnBorrar.TabIndex = 163;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::OrdenesdeServicio.Properties.Resources.delete_256;
            this.btnCerrar.Location = new System.Drawing.Point(1078, 33);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 33);
            this.btnCerrar.TabIndex = 164;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevaorden
            // 
            this.btnNuevaorden.Image = global::OrdenesdeServicio.Properties.Resources._1481064749;
            this.btnNuevaorden.Location = new System.Drawing.Point(951, 33);
            this.btnNuevaorden.Name = "btnNuevaorden";
            this.btnNuevaorden.Size = new System.Drawing.Size(34, 31);
            this.btnNuevaorden.TabIndex = 160;
            this.btnNuevaorden.Click += new System.EventHandler(this.btnNuevaorden_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::OrdenesdeServicio.Properties.Resources.disquete_icono_4115_128;
            this.btnIngresar.Location = new System.Drawing.Point(897, 33);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(33, 33);
            this.btnIngresar.TabIndex = 162;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button3
            // 
            this.button3.Image = global::OrdenesdeServicio.Properties.Resources.r9;
            this.button3.Location = new System.Drawing.Point(195, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 48);
            this.button3.TabIndex = 120;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 580);
            this.Controls.Add(this.grdOrdenes1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtmodificaro);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSaldopendiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdOrdenes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtCabonos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevaorden);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPlug);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reparaciones";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.Reparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPlug;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtobservaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnNuevaorden;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtCabonos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView grdOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallerDeRelojeriaToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldopendiente;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtmodificaro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem ventasYAbonosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ToolStripMenuItem salidaMercanciaToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdOrdenes1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plug1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal1;
        private System.Windows.Forms.ToolStripMenuItem actividadesRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadreCajaToolStripMenuItem;
    }
}