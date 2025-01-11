namespace OrdenesdeServicio
{
    partial class Anular_venta
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
            this.grdEliminarOrdenes = new System.Windows.Forms.DataGridView();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtobservaciones = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdEliminarOrdenes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEliminarOrdenes
            // 
            this.grdEliminarOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEliminarOrdenes.Location = new System.Drawing.Point(11, 226);
            this.grdEliminarOrdenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdEliminarOrdenes.Name = "grdEliminarOrdenes";
            this.grdEliminarOrdenes.RowHeadersWidth = 51;
            this.grdEliminarOrdenes.Size = new System.Drawing.Size(675, 330);
            this.grdEliminarOrdenes.TabIndex = 9;
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(489, 15);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(135, 28);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(332, 15);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarOrden
            // 
            this.txtEliminarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarOrden.Location = new System.Drawing.Point(216, 15);
            this.txtEliminarOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEliminarOrden.Name = "txtEliminarOrden";
            this.txtEliminarOrden.Size = new System.Drawing.Size(107, 26);
            this.txtEliminarOrden.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consecutivo Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtobservaciones);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(608, 154);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // rtxtobservaciones
            // 
            this.rtxtobservaciones.Location = new System.Drawing.Point(37, 31);
            this.rtxtobservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtobservaciones.Name = "rtxtobservaciones";
            this.rtxtobservaciones.Size = new System.Drawing.Size(563, 102);
            this.rtxtobservaciones.TabIndex = 67;
            this.rtxtobservaciones.Text = "";
            // 
            // Anular_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdEliminarOrdenes);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminarOrden);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Anular_venta";
            this.Text = "Anular_venta";
            this.Load += new System.EventHandler(this.Anular_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEliminarOrdenes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEliminarOrdenes;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminarOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtobservaciones;
    }
}