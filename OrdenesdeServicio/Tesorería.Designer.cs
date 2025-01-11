namespace OrdenesdeServicio
{
    partial class Tesorería
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
            this.txtSucrsalt1 = new System.Windows.Forms.ComboBox();
            this.txtsucuarsal2 = new System.Windows.Forms.ComboBox();
            this.cbonombre = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Molinos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmolinos = new System.Windows.Forms.TextBox();
            this.txtmontotrasladar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcental = new System.Windows.Forms.TextBox();
            this.txttesoreria = new System.Windows.Forms.TextBox();
            this.txtsandiego = new System.Windows.Forms.TextBox();
            this.txtmayorca = new System.Windows.Forms.TextBox();
            this.grdtesoreria = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNactualizar = new System.Windows.Forms.Button();
            this.Btnenviardinero = new System.Windows.Forms.Button();
            this.grdusuarios = new System.Windows.Forms.DataGridView();
            this.grdAprobaciones = new System.Windows.Forms.DataGridView();
            this.btnAprobaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdtesoreria)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAprobaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSucrsalt1
            // 
            this.txtSucrsalt1.FormattingEnabled = true;
            this.txtSucrsalt1.Items.AddRange(new object[] {
            "La Central",
            "Mayorca",
            "Molinos",
            "San Diego",
            "Tesorería"});
            this.txtSucrsalt1.Location = new System.Drawing.Point(436, 19);
            this.txtSucrsalt1.Name = "txtSucrsalt1";
            this.txtSucrsalt1.Size = new System.Drawing.Size(263, 21);
            this.txtSucrsalt1.TabIndex = 143;
            this.txtSucrsalt1.Click += new System.EventHandler(this.txtSucrsalt1_Click);
            // 
            // txtsucuarsal2
            // 
            this.txtsucuarsal2.FormattingEnabled = true;
            this.txtsucuarsal2.Items.AddRange(new object[] {
            "La Central",
            "Mayorca",
            "Molinos",
            "San Diego",
            "Tesorería"});
            this.txtsucuarsal2.Location = new System.Drawing.Point(559, 56);
            this.txtsucuarsal2.Name = "txtsucuarsal2";
            this.txtsucuarsal2.Size = new System.Drawing.Size(422, 21);
            this.txtsucuarsal2.TabIndex = 143;
            // 
            // cbonombre
            // 
            this.cbonombre.FormattingEnabled = true;
            this.cbonombre.Location = new System.Drawing.Point(78, 19);
            this.cbonombre.Name = "cbonombre";
            this.cbonombre.Size = new System.Drawing.Size(215, 21);
            this.cbonombre.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(312, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 17);
            this.label11.TabIndex = 150;
            this.label11.Text = "Caja de Destino ó Descripción Salida";
            // 
            // Molinos
            // 
            this.Molinos.AutoSize = true;
            this.Molinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Molinos.Location = new System.Drawing.Point(9, 20);
            this.Molinos.Name = "Molinos";
            this.Molinos.Size = new System.Drawing.Size(56, 17);
            this.Molinos.TabIndex = 147;
            this.Molinos.Text = "Molinos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 148;
            this.label2.Text = "Caja de Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 149;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 147;
            this.label4.Text = "Monto a trasladar";
            // 
            // txtmolinos
            // 
            this.txtmolinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmolinos.Location = new System.Drawing.Point(10, 50);
            this.txtmolinos.Name = "txtmolinos";
            this.txtmolinos.Size = new System.Drawing.Size(133, 26);
            this.txtmolinos.TabIndex = 184;
            // 
            // txtmontotrasladar
            // 
            this.txtmontotrasladar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontotrasladar.Location = new System.Drawing.Point(148, 51);
            this.txtmontotrasladar.Name = "txtmontotrasladar";
            this.txtmontotrasladar.Size = new System.Drawing.Size(145, 26);
            this.txtmontotrasladar.TabIndex = 185;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 186;
            this.label5.Text = "Mayorca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(754, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 187;
            this.label6.Text = "Tesoreria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 188;
            this.label7.Text = "La Central";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 190;
            this.label9.Text = "San Diego";
            // 
            // txtcental
            // 
            this.txtcental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcental.Location = new System.Drawing.Point(563, 50);
            this.txtcental.Name = "txtcental";
            this.txtcental.Size = new System.Drawing.Size(134, 26);
            this.txtcental.TabIndex = 192;
            // 
            // txttesoreria
            // 
            this.txttesoreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttesoreria.Location = new System.Drawing.Point(757, 50);
            this.txttesoreria.Name = "txttesoreria";
            this.txttesoreria.Size = new System.Drawing.Size(130, 26);
            this.txttesoreria.TabIndex = 193;
            // 
            // txtsandiego
            // 
            this.txtsandiego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsandiego.Location = new System.Drawing.Point(377, 50);
            this.txtsandiego.Name = "txtsandiego";
            this.txtsandiego.Size = new System.Drawing.Size(128, 26);
            this.txtsandiego.TabIndex = 194;
            // 
            // txtmayorca
            // 
            this.txtmayorca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmayorca.Location = new System.Drawing.Point(199, 50);
            this.txtmayorca.Name = "txtmayorca";
            this.txtmayorca.Size = new System.Drawing.Size(132, 26);
            this.txtmayorca.TabIndex = 195;
            // 
            // grdtesoreria
            // 
            this.grdtesoreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtesoreria.Location = new System.Drawing.Point(15, 109);
            this.grdtesoreria.Name = "grdtesoreria";
            this.grdtesoreria.Size = new System.Drawing.Size(1079, 292);
            this.grdtesoreria.TabIndex = 196;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txttesoreria);
            this.groupBox5.Controls.Add(this.Molinos);
            this.groupBox5.Controls.Add(this.txtmayorca);
            this.groupBox5.Controls.Add(this.txtmolinos);
            this.groupBox5.Controls.Add(this.txtsandiego);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtcental);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(12, 567);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(954, 90);
            this.groupBox5.TabIndex = 197;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Efectivo por Caja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNactualizar);
            this.groupBox1.Controls.Add(this.Btnenviardinero);
            this.groupBox1.Controls.Add(this.txtSucrsalt1);
            this.groupBox1.Controls.Add(this.txtsucuarsal2);
            this.groupBox1.Controls.Add(this.cbonombre);
            this.groupBox1.Controls.Add(this.txtmontotrasladar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 90);
            this.groupBox1.TabIndex = 198;
            this.groupBox1.TabStop = false;
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNactualizar.Image = global::OrdenesdeServicio.Properties.Resources._3;
            this.BTNactualizar.Location = new System.Drawing.Point(1013, 19);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(60, 61);
            this.BTNactualizar.TabIndex = 200;
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // Btnenviardinero
            // 
            this.Btnenviardinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Btnenviardinero.Location = new System.Drawing.Point(742, 12);
            this.Btnenviardinero.Name = "Btnenviardinero";
            this.Btnenviardinero.Size = new System.Drawing.Size(239, 31);
            this.Btnenviardinero.TabIndex = 186;
            this.Btnenviardinero.Text = "Traslado Efectivo";
            this.Btnenviardinero.UseVisualStyleBackColor = true;
            this.Btnenviardinero.Click += new System.EventHandler(this.Btnenviardinero_Click);
            // 
            // grdusuarios
            // 
            this.grdusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdusuarios.Location = new System.Drawing.Point(15, 407);
            this.grdusuarios.Name = "grdusuarios";
            this.grdusuarios.Size = new System.Drawing.Size(335, 155);
            this.grdusuarios.TabIndex = 199;
            // 
            // grdAprobaciones
            // 
            this.grdAprobaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAprobaciones.Location = new System.Drawing.Point(356, 407);
            this.grdAprobaciones.Name = "grdAprobaciones";
            this.grdAprobaciones.Size = new System.Drawing.Size(738, 155);
            this.grdAprobaciones.TabIndex = 200;
            // 
            // btnAprobaciones
            // 
            this.btnAprobaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnAprobaciones.Location = new System.Drawing.Point(991, 573);
            this.btnAprobaciones.Name = "btnAprobaciones";
            this.btnAprobaciones.Size = new System.Drawing.Size(103, 84);
            this.btnAprobaciones.TabIndex = 201;
            this.btnAprobaciones.Text = "Aceptar Traslados";
            this.btnAprobaciones.UseVisualStyleBackColor = true;
            this.btnAprobaciones.Click += new System.EventHandler(this.btnAprobaciones_Click);
            // 
            // Tesorería
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 672);
            this.Controls.Add(this.btnAprobaciones);
            this.Controls.Add(this.grdAprobaciones);
            this.Controls.Add(this.grdusuarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grdtesoreria);
            this.Name = "Tesorería";
            this.Text = "Tesorería";
            this.Load += new System.EventHandler(this.Tesorería_Load);
            this.Click += new System.EventHandler(this.Tesorería_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grdtesoreria)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAprobaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSucrsalt1;
        private System.Windows.Forms.ComboBox txtsucuarsal2;
        private System.Windows.Forms.ComboBox cbonombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Molinos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmolinos;
        private System.Windows.Forms.TextBox txtmontotrasladar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcental;
        private System.Windows.Forms.TextBox txttesoreria;
        private System.Windows.Forms.TextBox txtsandiego;
        private System.Windows.Forms.TextBox txtmayorca;
        private System.Windows.Forms.DataGridView grdtesoreria;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btnenviardinero;
        private System.Windows.Forms.DataGridView grdusuarios;
        private System.Windows.Forms.Button BTNactualizar;
        private System.Windows.Forms.DataGridView grdAprobaciones;
        private System.Windows.Forms.Button btnAprobaciones;
    }
}