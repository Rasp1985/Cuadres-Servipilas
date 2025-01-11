namespace OrdenesdeServicio
{
    partial class Consultarabonos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AbonoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdOrdenesDataSet2 = new OrdenesdeServicio.bdOrdenesDataSet2();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSucrsalt = new System.Windows.Forms.ComboBox();
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AbonoTableAdapter = new OrdenesdeServicio.bdOrdenesDataSet2TableAdapters.AbonoTableAdapter();
            this.VentaTableAdapter = new OrdenesdeServicio.bdOrdenesDataSet2TableAdapters.VentaTableAdapter();
            this.rdbayer = new System.Windows.Forms.RadioButton();
            this.rdbhoy = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AbonoBindingSource
            // 
            this.AbonoBindingSource.DataMember = "Abono";
            this.AbonoBindingSource.DataSource = this.bdOrdenesDataSet2;
            // 
            // bdOrdenesDataSet2
            // 
            this.bdOrdenesDataSet2.DataSetName = "bdOrdenesDataSet2";
            this.bdOrdenesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataMember = "Venta";
            this.VentaBindingSource.DataSource = this.bdOrdenesDataSet2;
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
            this.txtSucrsalt.Location = new System.Drawing.Point(122, 13);
            this.txtSucrsalt.Name = "txtSucrsalt";
            this.txtSucrsalt.Size = new System.Drawing.Size(199, 21);
            this.txtSucrsalt.TabIndex = 152;
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Location = new System.Drawing.Point(506, 40);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 151;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(121, 40);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 148;
            this.label2.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 149;
            this.label3.Text = "Fecha Inicial";
            // 
            // button1
            // 
            this.button1.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button1.Location = new System.Drawing.Point(744, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 46);
            this.button1.TabIndex = 147;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 146;
            this.label1.Text = "Usuario:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AbonoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.VentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OrdenesdeServicio.ventasyabonos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1176, 588);
            this.reportViewer1.TabIndex = 145;
            // 
            // AbonoTableAdapter
            // 
            this.AbonoTableAdapter.ClearBeforeFill = true;
            // 
            // VentaTableAdapter
            // 
            this.VentaTableAdapter.ClearBeforeFill = true;
            // 
            // rdbayer
            // 
            this.rdbayer.AutoSize = true;
            this.rdbayer.Location = new System.Drawing.Point(506, 12);
            this.rdbayer.Name = "rdbayer";
            this.rdbayer.Size = new System.Drawing.Size(46, 17);
            this.rdbayer.TabIndex = 178;
            this.rdbayer.TabStop = true;
            this.rdbayer.Text = "Ayer";
            this.rdbayer.UseVisualStyleBackColor = true;
            // 
            // rdbhoy
            // 
            this.rdbhoy.AutoSize = true;
            this.rdbhoy.Location = new System.Drawing.Point(416, 11);
            this.rdbhoy.Name = "rdbhoy";
            this.rdbhoy.Size = new System.Drawing.Size(44, 17);
            this.rdbhoy.TabIndex = 179;
            this.rdbhoy.TabStop = true;
            this.rdbhoy.Text = "Hoy";
            this.rdbhoy.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(586, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 180;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rango Fechas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Consultarabonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 683);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbayer);
            this.Controls.Add(this.rdbhoy);
            this.Controls.Add(this.txtSucrsalt);
            this.Controls.Add(this.dtFechafinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Consultarabonos";
            this.Text = "Consultarabonos";
            this.Load += new System.EventHandler(this.Consultarabonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbonoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdOrdenesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource AbonoBindingSource;
        private bdOrdenesDataSet2 bdOrdenesDataSet2;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private bdOrdenesDataSet2TableAdapters.AbonoTableAdapter AbonoTableAdapter;
        private bdOrdenesDataSet2TableAdapters.VentaTableAdapter VentaTableAdapter;
        private System.Windows.Forms.RadioButton rdbayer;
        private System.Windows.Forms.RadioButton rdbhoy;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}