namespace OrdenesdeServicio
{
    partial class Imprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprimir));
            this.tblRepuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdOrdenesDataSet1 = new OrdenesdeServicio.bdOrdenesDataSet1();
            this.Detalle_ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdOrdenesDataSet2 = new OrdenesdeServicio.bdOrdenesDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.txtSucrsalt = new System.Windows.Forms.ComboBox();
            this.tblOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdOrdenesDataSet = new OrdenesdeServicio.bdOrdenesDataSet();
            this.AbonoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClienteTableAdapter = new OrdenesdeServicio.bdOrdenesDataSetTableAdapters.tblClienteTableAdapter();
            this.tblOrdenTableAdapter = new OrdenesdeServicio.bdOrdenesDataSetTableAdapters.tblOrdenTableAdapter();
            this.tblRepuestosTableAdapter = new OrdenesdeServicio.bdOrdenesDataSet1TableAdapters.tblRepuestosTableAdapter();
            this.AbonoTableAdapter = new OrdenesdeServicio.bdOrdenesDataSetTableAdapters.AbonoTableAdapter();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDetalleOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDetalleOrdenTableAdapter = new OrdenesdeServicio.bdOrdenesDataSetTableAdapters.tblDetalleOrdenTableAdapter();
            this.Detalle_ventaTableAdapter = new OrdenesdeServicio.bdOrdenesDataSet2TableAdapters.Detalle_ventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDetalleOrdenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRepuestosBindingSource
            // 
            this.tblRepuestosBindingSource.DataMember = "tblRepuestos";
            this.tblRepuestosBindingSource.DataSource = this.bdOrdenesDataSet1;
            // 
            // bdOrdenesDataSet1
            // 
            this.bdOrdenesDataSet1.DataSetName = "bdOrdenesDataSet1";
            this.bdOrdenesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblRepuestosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OrdenesdeServicio.impresiontaller.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1236, 588);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button1.Location = new System.Drawing.Point(745, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 46);
            this.button1.TabIndex = 131;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Location = new System.Drawing.Point(507, 35);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 135;
            this.dtFechafinal.ValueChanged += new System.EventHandler(this.dtFechafinal_ValueChanged);
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(122, 35);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 134;
            this.dtFechaInicial.ValueChanged += new System.EventHandler(this.dtFechaInicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "Fecha Final";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "Fecha Inicial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            this.txtSucrsalt.Location = new System.Drawing.Point(123, 8);
            this.txtSucrsalt.Name = "txtSucrsalt";
            this.txtSucrsalt.Size = new System.Drawing.Size(199, 21);
            this.txtSucrsalt.TabIndex = 136;
            this.txtSucrsalt.SelectedIndexChanged += new System.EventHandler(this.txtSucrsalt_SelectedIndexChanged_1);
            // 
            // tblOrdenBindingSource
            // 
            this.tblOrdenBindingSource.DataMember = "tblOrden";
            this.tblOrdenBindingSource.DataSource = this.bdOrdenesDataSet;
            // 
            // bdOrdenesDataSet
            // 
            this.bdOrdenesDataSet.DataSetName = "bdOrdenesDataSet";
            this.bdOrdenesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AbonoBindingSource
            // 
            this.AbonoBindingSource.DataMember = "Abono";
            this.AbonoBindingSource.DataSource = this.bdOrdenesDataSet;
            // 
            // tblClienteTableAdapter
            // 
            this.tblClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrdenTableAdapter
            // 
            this.tblOrdenTableAdapter.ClearBeforeFill = true;
            // 
            // tblRepuestosTableAdapter
            // 
            this.tblRepuestosTableAdapter.ClearBeforeFill = true;
            // 
            // AbonoTableAdapter
            // 
            this.AbonoTableAdapter.ClearBeforeFill = true;
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "tblCliente";
            this.tblClienteBindingSource.DataSource = this.bdOrdenesDataSet;
            // 
            // tblDetalleOrdenBindingSource
            // 
            this.tblDetalleOrdenBindingSource.DataMember = "tblDetalleOrden";
            this.tblDetalleOrdenBindingSource.DataSource = this.bdOrdenesDataSet;
            // 
            // tblDetalleOrdenTableAdapter
            // 
            this.tblDetalleOrdenTableAdapter.ClearBeforeFill = true;
            // 
            // Detalle_ventaTableAdapter
            // 
            this.Detalle_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 733);
            this.Controls.Add(this.txtSucrsalt);
            this.Controls.Add(this.dtFechafinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Imprimir";
            this.Text = "Imprimir";
            this.Load += new System.EventHandler(this.Imprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRepuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDetalleOrdenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private bdOrdenesDataSetTableAdapters.tblClienteTableAdapter tblClienteTableAdapter;
        private System.Windows.Forms.BindingSource tblOrdenBindingSource;
        private bdOrdenesDataSet bdOrdenesDataSet;
        private System.Windows.Forms.BindingSource AbonoBindingSource;
        private bdOrdenesDataSetTableAdapters.tblOrdenTableAdapter tblOrdenTableAdapter;
        private System.Windows.Forms.DateTimePicker dtFechafinal;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private bdOrdenesDataSet1 bdOrdenesDataSet1;
        private System.Windows.Forms.BindingSource tblRepuestosBindingSource;
        private bdOrdenesDataSet1TableAdapters.tblRepuestosTableAdapter tblRepuestosTableAdapter;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private System.Windows.Forms.BindingSource tblDetalleOrdenBindingSource;
        private bdOrdenesDataSetTableAdapters.AbonoTableAdapter AbonoTableAdapter;
        private bdOrdenesDataSetTableAdapters.tblDetalleOrdenTableAdapter tblDetalleOrdenTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ComboBox txtSucrsalt;
        private System.Windows.Forms.BindingSource Detalle_ventaBindingSource;
        private bdOrdenesDataSet2 bdOrdenesDataSet2;
        private bdOrdenesDataSet2TableAdapters.Detalle_ventaTableAdapter Detalle_ventaTableAdapter;
    }
}