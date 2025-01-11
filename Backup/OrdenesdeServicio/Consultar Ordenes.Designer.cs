namespace OrdenesdeServicio
{
    partial class Consultar_Ordenes
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechafinal = new System.Windows.Forms.DateTimePicker();
            this.grdConsultarordenes = new System.Windows.Forms.DataGridView();
            this.txtSandiego = new System.Windows.Forms.TextBox();
            this.txtDiamante = new System.Windows.Forms.TextBox();
            this.txtMolinos = new System.Windows.Forms.TextBox();
            this.txtMayorca = new System.Windows.Forms.TextBox();
            this.chkSanDiego = new System.Windows.Forms.CheckBox();
            this.chkMayorca = new System.Windows.Forms.CheckBox();
            this.chkMolinos = new System.Windows.Forms.CheckBox();
            this.chkDiamante = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalpuntos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha Inicial";
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(135, 16);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha Final";
            // 
            // dtFechafinal
            // 
            this.dtFechafinal.Location = new System.Drawing.Point(522, 12);
            this.dtFechafinal.Name = "dtFechafinal";
            this.dtFechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechafinal.TabIndex = 34;
            this.dtFechafinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // grdConsultarordenes
            // 
            this.grdConsultarordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultarordenes.Location = new System.Drawing.Point(12, 81);
            this.grdConsultarordenes.Name = "grdConsultarordenes";
            this.grdConsultarordenes.Size = new System.Drawing.Size(783, 348);
            this.grdConsultarordenes.TabIndex = 35;
            // 
            // txtSandiego
            // 
            this.txtSandiego.Location = new System.Drawing.Point(12, 472);
            this.txtSandiego.Name = "txtSandiego";
            this.txtSandiego.Size = new System.Drawing.Size(174, 20);
            this.txtSandiego.TabIndex = 36;
            // 
            // txtDiamante
            // 
            this.txtDiamante.Location = new System.Drawing.Point(621, 472);
            this.txtDiamante.Name = "txtDiamante";
            this.txtDiamante.Size = new System.Drawing.Size(174, 20);
            this.txtDiamante.TabIndex = 37;
            // 
            // txtMolinos
            // 
            this.txtMolinos.Location = new System.Drawing.Point(407, 472);
            this.txtMolinos.Name = "txtMolinos";
            this.txtMolinos.Size = new System.Drawing.Size(174, 20);
            this.txtMolinos.TabIndex = 38;
            // 
            // txtMayorca
            // 
            this.txtMayorca.Location = new System.Drawing.Point(206, 472);
            this.txtMayorca.Name = "txtMayorca";
            this.txtMayorca.Size = new System.Drawing.Size(174, 20);
            this.txtMayorca.TabIndex = 39;
            // 
            // chkSanDiego
            // 
            this.chkSanDiego.AutoSize = true;
            this.chkSanDiego.Location = new System.Drawing.Point(12, 58);
            this.chkSanDiego.Name = "chkSanDiego";
            this.chkSanDiego.Size = new System.Drawing.Size(73, 17);
            this.chkSanDiego.TabIndex = 40;
            this.chkSanDiego.Text = "SanDiego";
            this.chkSanDiego.UseVisualStyleBackColor = true;
            this.chkSanDiego.CheckedChanged += new System.EventHandler(this.chkSanDiego_CheckedChanged);
            // 
            // chkMayorca
            // 
            this.chkMayorca.AutoSize = true;
            this.chkMayorca.Location = new System.Drawing.Point(119, 58);
            this.chkMayorca.Name = "chkMayorca";
            this.chkMayorca.Size = new System.Drawing.Size(67, 17);
            this.chkMayorca.TabIndex = 41;
            this.chkMayorca.Text = "Mayorca";
            this.chkMayorca.UseVisualStyleBackColor = true;
            this.chkMayorca.CheckedChanged += new System.EventHandler(this.chkMayorca_CheckedChanged);
            // 
            // chkMolinos
            // 
            this.chkMolinos.AutoSize = true;
            this.chkMolinos.Location = new System.Drawing.Point(222, 58);
            this.chkMolinos.Name = "chkMolinos";
            this.chkMolinos.Size = new System.Drawing.Size(62, 17);
            this.chkMolinos.TabIndex = 42;
            this.chkMolinos.Text = "Molinos";
            this.chkMolinos.UseVisualStyleBackColor = true;
            this.chkMolinos.CheckedChanged += new System.EventHandler(this.chkMolinos_CheckedChanged);
            // 
            // chkDiamante
            // 
            this.chkDiamante.AutoSize = true;
            this.chkDiamante.Location = new System.Drawing.Point(309, 58);
            this.chkDiamante.Name = "chkDiamante";
            this.chkDiamante.Size = new System.Drawing.Size(71, 17);
            this.chkDiamante.TabIndex = 43;
            this.chkDiamante.Text = "Diamante";
            this.chkDiamante.UseVisualStyleBackColor = true;
            this.chkDiamante.CheckedChanged += new System.EventHandler(this.chkDiamante_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Total Ordenes de Servicio de todos los puntos de venta";
            // 
            // txtTotalpuntos
            // 
            this.txtTotalpuntos.Location = new System.Drawing.Point(450, 509);
            this.txtTotalpuntos.Name = "txtTotalpuntos";
            this.txtTotalpuntos.Size = new System.Drawing.Size(328, 20);
            this.txtTotalpuntos.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "SanDiego";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mayorca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Molinos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Diamante";
            // 
            // Consultar_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 546);
            this.Controls.Add(this.txtTotalpuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkDiamante);
            this.Controls.Add(this.chkMolinos);
            this.Controls.Add(this.chkMayorca);
            this.Controls.Add(this.chkSanDiego);
            this.Controls.Add(this.txtMayorca);
            this.Controls.Add(this.txtMolinos);
            this.Controls.Add(this.txtDiamante);
            this.Controls.Add(this.txtSandiego);
            this.Controls.Add(this.grdConsultarordenes);
            this.Controls.Add(this.dtFechafinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Consultar_Ordenes";
            this.Text = "Consultar Ordenes";
            this.Load += new System.EventHandler(this.Consultar_Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechafinal;
        private System.Windows.Forms.DataGridView grdConsultarordenes;
        private System.Windows.Forms.TextBox txtSandiego;
        private System.Windows.Forms.TextBox txtDiamante;
        private System.Windows.Forms.TextBox txtMolinos;
        private System.Windows.Forms.TextBox txtMayorca;
        private System.Windows.Forms.CheckBox chkSanDiego;
        private System.Windows.Forms.CheckBox chkMayorca;
        private System.Windows.Forms.CheckBox chkMolinos;
        private System.Windows.Forms.CheckBox chkDiamante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalpuntos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}