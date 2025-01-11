namespace OrdenesdeServicio
{
    partial class imprimirventas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Detalle_ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdOrdenesDataSet2 = new OrdenesdeServicio.bdOrdenesDataSet2();
            this.txtSucrsalt = new System.Windows.Forms.ComboBox();
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detalle_ventaTableAdapter = new OrdenesdeServicio.bdOrdenesDataSet2TableAdapters.Detalle_ventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalle_ventaBindingSource
            // 
            this.Detalle_ventaBindingSource.DataMember = "Detalle_venta";
            this.Detalle_ventaBindingSource.DataSource = this.bdOrdenesDataSet2;
            // 
            // bdOrdenesDataSet2
            // 
            this.bdOrdenesDataSet2.DataSetName = "bdOrdenesDataSet2";
            this.bdOrdenesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSucrsalt
            // 
            this.txtSucrsalt.FormattingEnabled = true;
            this.txtSucrsalt.Items.AddRange(new object[] {
            "La Central",
            "Mayorca",
            "Molinos",
            "San Diego",
            "Puerta del Norte"});
            this.txtSucrsalt.Location = new System.Drawing.Point(125, 23);
            this.txtSucrsalt.Name = "txtSucrsalt";
            this.txtSucrsalt.Size = new System.Drawing.Size(199, 21);
            this.txtSucrsalt.TabIndex = 144;
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Location = new System.Drawing.Point(509, 50);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 143;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(124, 50);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 140;
            this.label2.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 141;
            this.label3.Text = "Fecha Inicial";
            // 
            // button1
            // 
            this.button1.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button1.Location = new System.Drawing.Point(747, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 46);
            this.button1.TabIndex = 139;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 138;
            this.label1.Text = "Usuario:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Detalle_ventaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OrdenesdeServicio.ventasproducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1145, 640);
            this.reportViewer1.TabIndex = 137;
            // 
            // Detalle_ventaTableAdapter
            // 
            this.Detalle_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // imprimirventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 738);
            this.Controls.Add(this.txtSucrsalt);
            this.Controls.Add(this.dtFechafinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "imprimirventas";
            this.Text = "imprimirventas";
            this.Load += new System.EventHandler(this.imprimirventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Detalle_ventaBindingSource;
        private bdOrdenesDataSet2 bdOrdenesDataSet2;
        private bdOrdenesDataSet2TableAdapters.Detalle_ventaTableAdapter Detalle_ventaTableAdapter;
    }
}