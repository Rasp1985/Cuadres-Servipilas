namespace OrdenesdeServicio
{
    partial class Abonos
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
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.lblSu = new System.Windows.Forms.Label();
            this.grdConsultarAbono = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuscarorden = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BTNrEGRESAR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarAbono)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abono";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(141, 19);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(136, 30);
            this.txtConsecutivo.TabIndex = 2;
            this.txtConsecutivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsecutivo_KeyPress);
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(141, 116);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(136, 30);
            this.txtAbono.TabIndex = 3;
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(323, 104);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 32);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guadar Abono";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(137, 67);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 25);
            this.lblCliente.TabIndex = 0;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Image = global::OrdenesdeServicio.Properties.Resources.r9;
            this.btnConsultarCliente.Location = new System.Drawing.Point(309, 9);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(51, 48);
            this.btnConsultarCliente.TabIndex = 44;
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSu.Location = new System.Drawing.Point(136, -34);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(0, 36);
            this.lblSu.TabIndex = 0;
            // 
            // grdConsultarAbono
            // 
            this.grdConsultarAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultarAbono.Location = new System.Drawing.Point(8, 40);
            this.grdConsultarAbono.Name = "grdConsultarAbono";
            this.grdConsultarAbono.RowHeadersWidth = 51;
            this.grdConsultarAbono.Size = new System.Drawing.Size(814, 269);
            this.grdConsultarAbono.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar";
            // 
            // txtbuscarorden
            // 
            this.txtbuscarorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarorden.Location = new System.Drawing.Point(93, 9);
            this.txtbuscarorden.Name = "txtbuscarorden";
            this.txtbuscarorden.Size = new System.Drawing.Size(136, 30);
            this.txtbuscarorden.TabIndex = 113;
            this.txtbuscarorden.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarorden_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.BTNrEGRESAR);
            this.groupBox1.Controls.Add(this.txtConsecutivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConsultarCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblSu);
            this.groupBox1.Controls.Add(this.txtAbono);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 186);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Image = global::OrdenesdeServicio.Properties.Resources.printer_blue256_24942;
            this.button4.Location = new System.Drawing.Point(474, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 46);
            this.button4.TabIndex = 153;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(323, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 28);
            this.btnEliminar.TabIndex = 117;
            this.btnEliminar.Text = "Anular Abono";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BTNrEGRESAR
            // 
            this.BTNrEGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNrEGRESAR.Image = global::OrdenesdeServicio.Properties.Resources._3;
            this.BTNrEGRESAR.Location = new System.Drawing.Point(393, 10);
            this.BTNrEGRESAR.Name = "BTNrEGRESAR";
            this.BTNrEGRESAR.Size = new System.Drawing.Size(52, 53);
            this.BTNrEGRESAR.TabIndex = 116;
            this.BTNrEGRESAR.UseVisualStyleBackColor = true;
            this.BTNrEGRESAR.Click += new System.EventHandler(this.BTNrEGRESAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbuscarorden);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.grdConsultarAbono);
            this.groupBox2.Location = new System.Drawing.Point(14, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 333);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Abonos";
            this.Text = "Abonos";
            this.Load += new System.EventHandler(this.Abonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarAbono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.DataGridView grdConsultarAbono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbuscarorden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNrEGRESAR;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button4;
    }
}