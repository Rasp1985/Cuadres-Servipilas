namespace OrdenesdeServicio
{
    partial class Imprimir_Cuadre
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.ComboBox();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.grdConsultarCliente = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblsobrante = new System.Windows.Forms.Label();
            this.txtsobrante = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TXTCAJA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtventasmegared = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtcompras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtgastos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdmegared = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtconsignacionesmegared = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarCliente)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdmegared)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.dtFechaInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFechafinal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 83);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.FormattingEnabled = true;
            this.lblUsuario.Items.AddRange(new object[] {
            "La Central",
            "Mayorca",
            "Molinos",
            "San Diego",
            "Puerta del Norte"});
            this.lblUsuario.Location = new System.Drawing.Point(19, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(199, 21);
            this.lblUsuario.TabIndex = 145;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(18, 49);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 139;
            this.label3.Text = "Fecha Final";
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechafinal.Location = new System.Drawing.Point(396, 49);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 141;
            // 
            // button1
            // 
            this.button1.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button1.Location = new System.Drawing.Point(646, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 46);
            this.button1.TabIndex = 137;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdConsultarCliente
            // 
            this.grdConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultarCliente.Location = new System.Drawing.Point(12, 92);
            this.grdConsultarCliente.Name = "grdConsultarCliente";
            this.grdConsultarCliente.Size = new System.Drawing.Size(788, 505);
            this.grdConsultarCliente.TabIndex = 145;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 161;
            this.label10.Text = "INGRESOS";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(110, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 26);
            this.txtTotal.TabIndex = 160;
            // 
            // lblsobrante
            // 
            this.lblsobrante.AutoSize = true;
            this.lblsobrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblsobrante.ForeColor = System.Drawing.Color.Red;
            this.lblsobrante.Location = new System.Drawing.Point(9, 22);
            this.lblsobrante.Name = "lblsobrante";
            this.lblsobrante.Size = new System.Drawing.Size(82, 24);
            this.lblsobrante.TabIndex = 32;
            this.lblsobrante.Text = "Correcto";
            // 
            // txtsobrante
            // 
            this.txtsobrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsobrante.ForeColor = System.Drawing.Color.Red;
            this.txtsobrante.Location = new System.Drawing.Point(97, 20);
            this.txtsobrante.Name = "txtsobrante";
            this.txtsobrante.Size = new System.Drawing.Size(134, 26);
            this.txtsobrante.TabIndex = 31;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblsobrante);
            this.groupBox6.Controls.Add(this.txtsobrante);
            this.groupBox6.Location = new System.Drawing.Point(261, 608);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 56);
            this.groupBox6.TabIndex = 168;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sobrantes ó Faltantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(524, 608);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 56);
            this.groupBox2.TabIndex = 169;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Ingresos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TXTCAJA);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 608);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 56);
            this.groupBox3.TabIndex = 170;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Cajas";
            // 
            // TXTCAJA
            // 
            this.TXTCAJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCAJA.Location = new System.Drawing.Point(79, 19);
            this.TXTCAJA.Name = "TXTCAJA";
            this.TXTCAJA.Size = new System.Drawing.Size(139, 26);
            this.TXTCAJA.TabIndex = 160;
            this.TXTCAJA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 161;
            this.label1.Text = "CAJAS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtventasmegared);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 670);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 56);
            this.groupBox4.TabIndex = 173;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Ventas Megared";
            // 
            // txtventasmegared
            // 
            this.txtventasmegared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtventasmegared.Location = new System.Drawing.Point(104, 19);
            this.txtventasmegared.Name = "txtventasmegared";
            this.txtventasmegared.Size = new System.Drawing.Size(114, 26);
            this.txtventasmegared.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 161;
            this.label2.Text = "MEGARED";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtcompras);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(524, 670);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 56);
            this.groupBox5.TabIndex = 172;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Compras";
            // 
            // txtcompras
            // 
            this.txtcompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompras.Location = new System.Drawing.Point(112, 19);
            this.txtcompras.Name = "txtcompras";
            this.txtcompras.Size = new System.Drawing.Size(148, 26);
            this.txtcompras.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 161;
            this.label4.Text = "COMPRAS";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtgastos);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(261, 670);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 56);
            this.groupBox7.TabIndex = 171;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Total Gastos";
            // 
            // txtgastos
            // 
            this.txtgastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtgastos.ForeColor = System.Drawing.Color.Red;
            this.txtgastos.Location = new System.Drawing.Point(98, 22);
            this.txtgastos.Name = "txtgastos";
            this.txtgastos.Size = new System.Drawing.Size(133, 26);
            this.txtgastos.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 161;
            this.label5.Text = "GASTOS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grdmegared
            // 
            this.grdmegared.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdmegared.Location = new System.Drawing.Point(806, 92);
            this.grdmegared.Name = "grdmegared";
            this.grdmegared.Size = new System.Drawing.Size(170, 505);
            this.grdmegared.TabIndex = 174;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtconsignacionesmegared);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(807, 608);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(169, 118);
            this.groupBox8.TabIndex = 170;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Total Consignaciones Megared";
            // 
            // txtconsignacionesmegared
            // 
            this.txtconsignacionesmegared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsignacionesmegared.Location = new System.Drawing.Point(18, 64);
            this.txtconsignacionesmegared.Name = "txtconsignacionesmegared";
            this.txtconsignacionesmegared.Size = new System.Drawing.Size(134, 26);
            this.txtconsignacionesmegared.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 161;
            this.label6.Text = "MEGARED";
            // 
            // Imprimir_Cuadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 732);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.grdmegared);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdConsultarCliente);
            this.Name = "Imprimir_Cuadre";
            this.Text = "Imprimir_Cuadre";
            this.Load += new System.EventHandler(this.Imprimir_Cuadre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarCliente)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdmegared)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechafinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdConsultarCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblsobrante;
        private System.Windows.Forms.TextBox txtsobrante;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TXTCAJA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lblUsuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtventasmegared;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtcompras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtgastos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdmegared;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtconsignacionesmegared;
        private System.Windows.Forms.Label label6;
    }
}