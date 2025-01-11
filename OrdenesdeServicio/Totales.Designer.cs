namespace OrdenesdeServicio
{
    partial class Totales
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
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.GRDCONSULTAORDEN = new System.Windows.Forms.DataGridView();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSumarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRDCONSULTAORDEN)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Location = new System.Drawing.Point(513, 12);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 140;
            this.dtFechafinal.ValueChanged += new System.EventHandler(this.dtFechafinal_ValueChanged);
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(128, 12);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 137;
            this.label2.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Fecha Inicial";
            // 
            // grdCliente
            // 
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(12, 84);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.Size = new System.Drawing.Size(732, 302);
            this.grdCliente.TabIndex = 141;
            // 
            // GRDCONSULTAORDEN
            // 
            this.GRDCONSULTAORDEN.AllowUserToAddRows = false;
            this.GRDCONSULTAORDEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRDCONSULTAORDEN.Location = new System.Drawing.Point(12, 411);
            this.GRDCONSULTAORDEN.Name = "GRDCONSULTAORDEN";
            this.GRDCONSULTAORDEN.Size = new System.Drawing.Size(732, 283);
            this.GRDCONSULTAORDEN.TabIndex = 152;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(128, 53);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(156, 20);
            this.txtDocumento.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 153;
            this.label1.Text = "Salida OK";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(303, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 31);
            this.btnAgregar.TabIndex = 155;
            this.btnAgregar.Text = "Salida Mercancia";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSumarVentas
            // 
            this.btnSumarVentas.Location = new System.Drawing.Point(513, 48);
            this.btnSumarVentas.Name = "btnSumarVentas";
            this.btnSumarVentas.Size = new System.Drawing.Size(200, 23);
            this.btnSumarVentas.TabIndex = 156;
            this.btnSumarVentas.Text = "Sumar ventas por fecha";
            this.btnSumarVentas.UseVisualStyleBackColor = true;
            this.btnSumarVentas.Click += new System.EventHandler(this.btnSumarVentas_Click);
            // 
            // Totales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 706);
            this.Controls.Add(this.btnSumarVentas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRDCONSULTAORDEN);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.dtFechafinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Totales";
            this.Text = "Totales";
            this.Load += new System.EventHandler(this.Totales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRDCONSULTAORDEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechafinal;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.DataGridView GRDCONSULTAORDEN;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSumarVentas;
    }
}