namespace OrdenesdeServicio
{
    partial class Imprimir_Actividades
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
            this.txtSucrsalt = new System.Windows.Forms.ComboBox();
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grdConsultarCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSucrsalt
            // 
            this.txtSucrsalt.FormattingEnabled = true;
            this.txtSucrsalt.Location = new System.Drawing.Point(153, 18);
            this.txtSucrsalt.Name = "txtSucrsalt";
            this.txtSucrsalt.Size = new System.Drawing.Size(199, 21);
            this.txtSucrsalt.TabIndex = 142;
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechafinal.Location = new System.Drawing.Point(530, 41);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 141;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(152, 45);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 139;
            this.label3.Text = "Fecha Final";
            // 
            // button1
            // 
            this.button1.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button1.Location = new System.Drawing.Point(762, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 46);
            this.button1.TabIndex = 137;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdConsultarCliente
            // 
            this.grdConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultarCliente.Location = new System.Drawing.Point(12, 84);
            this.grdConsultarCliente.Name = "grdConsultarCliente";
            this.grdConsultarCliente.Size = new System.Drawing.Size(1090, 591);
            this.grdConsultarCliente.TabIndex = 143;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFechafinal);
            this.groupBox1.Controls.Add(this.txtSucrsalt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 74);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Nombre Empleado";
            // 
            // Imprimir_Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdConsultarCliente);
            this.Controls.Add(this.label2);
            this.Name = "Imprimir_Actividades";
            this.Text = "Imprimir_Actividades";
            this.Load += new System.EventHandler(this.Imprimir_Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSucrsalt;
        private System.Windows.Forms.DateTimePicker dtFechafinal;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdConsultarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}