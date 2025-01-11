namespace OrdenesdeServicio
{
    partial class ConsultarCliente
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
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Lblestadofactura = new System.Windows.Forms.Label();
            this.btnBorrarregistro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grdOrdenes = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rtxtObservacionesgenerales = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(133, 50);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(216, 26);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::OrdenesdeServicio.Properties.Resources.r91;
            this.btnSalir.Location = new System.Drawing.Point(375, 34);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 59);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Lblestadofactura
            // 
            this.Lblestadofactura.AutoSize = true;
            this.Lblestadofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblestadofactura.Location = new System.Drawing.Point(937, 556);
            this.Lblestadofactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblestadofactura.Name = "Lblestadofactura";
            this.Lblestadofactura.Size = new System.Drawing.Size(0, 29);
            this.Lblestadofactura.TabIndex = 157;
            // 
            // btnBorrarregistro
            // 
            this.btnBorrarregistro.Location = new System.Drawing.Point(861, 23);
            this.btnBorrarregistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarregistro.Name = "btnBorrarregistro";
            this.btnBorrarregistro.Size = new System.Drawing.Size(157, 41);
            this.btnBorrarregistro.TabIndex = 155;
            this.btnBorrarregistro.Text = "Actualizar Orden";
            this.btnBorrarregistro.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 481);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 154;
            this.label10.Text = "Total a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(171, 481);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 151;
            // 
            // grdOrdenes
            // 
            this.grdOrdenes.AllowUserToAddRows = false;
            this.grdOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdenes.Location = new System.Drawing.Point(8, 19);
            this.grdOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.grdOrdenes.Name = "grdOrdenes";
            this.grdOrdenes.RowHeadersWidth = 51;
            this.grdOrdenes.Size = new System.Drawing.Size(1565, 123);
            this.grdOrdenes.TabIndex = 150;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.rtxtObservacionesgenerales);
            this.groupBox9.Controls.Add(this.btnBorrarregistro);
            this.groupBox9.Location = new System.Drawing.Point(13, 556);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(1057, 113);
            this.groupBox9.TabIndex = 149;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Actualizar Observaciones";
            // 
            // rtxtObservacionesgenerales
            // 
            this.rtxtObservacionesgenerales.Location = new System.Drawing.Point(32, 23);
            this.rtxtObservacionesgenerales.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtObservacionesgenerales.Name = "rtxtObservacionesgenerales";
            this.rtxtObservacionesgenerales.Size = new System.Drawing.Size(803, 72);
            this.rtxtObservacionesgenerales.TabIndex = 67;
            this.rtxtObservacionesgenerales.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(424, 473);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 38);
            this.btnAgregar.TabIndex = 148;
            this.btnAgregar.Text = "Salir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdCliente
            // 
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(8, 18);
            this.grdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.RowHeadersWidth = 51;
            this.grdCliente.Size = new System.Drawing.Size(1565, 126);
            this.grdCliente.TabIndex = 146;
            this.grdCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCliente_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 141;
            this.label2.Text = "Documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1580, 152);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdOrdenes);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1580, 152);
            this.groupBox2.TabIndex = 160;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lblestadofactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDocumento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarCliente";
            this.Text = "Consultar y Modificar Orden";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenes)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Lblestadofactura;
        private System.Windows.Forms.Button btnBorrarregistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView grdOrdenes;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox rtxtObservacionesgenerales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}