namespace OrdenesdeServicio
{
    partial class EliminarOrden
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEliminarOrden = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.grdEliminarOrdenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdEliminarOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo";
            // 
            // txtEliminarOrden
            // 
            this.txtEliminarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminarOrden.Location = new System.Drawing.Point(171, 35);
            this.txtEliminarOrden.Name = "txtEliminarOrden";
            this.txtEliminarOrden.Size = new System.Drawing.Size(184, 22);
            this.txtEliminarOrden.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(103, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(258, 105);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(83, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // grdEliminarOrdenes
            // 
            this.grdEliminarOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEliminarOrdenes.Location = new System.Drawing.Point(12, 176);
            this.grdEliminarOrdenes.Name = "grdEliminarOrdenes";
            this.grdEliminarOrdenes.Size = new System.Drawing.Size(470, 251);
            this.grdEliminarOrdenes.TabIndex = 4;
            // 
            // EliminarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 433);
            this.Controls.Add(this.grdEliminarOrdenes);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminarOrden);
            this.Controls.Add(this.label1);
            this.Name = "EliminarOrden";
            this.Text = "Eliminar Orden";
            this.Load += new System.EventHandler(this.EliminarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEliminarOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEliminarOrden;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView grdEliminarOrdenes;
    }
}