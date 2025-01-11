using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrdenesdeServicio
{
    public partial class imprimirventas : Form
    {
        public imprimirventas()
        {
            InitializeComponent();
        }

        private void imprimirventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet2.Detalle_venta' Puede moverla o quitarla según sea necesario.
            this.Detalle_ventaTableAdapter.Fill(this.bdOrdenesDataSet2.Detalle_venta);
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet2.Detalle_venta' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet2.Venta' Puede moverla o quitarla según sea necesario.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "";
            user = txtSucrsalt.Text;
            DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
       
            this.Detalle_ventaTableAdapter.casa(this.bdOrdenesDataSet2.Detalle_venta, fecha1, user, fecha2);
            //this.tblRepuestosTableAdapter.Sumatotal(this.bdOrdenesDataSet1.tblRepuestos, user, fecha1, fecha2);
            this.reportViewer1.RefreshReport();
           
        }
    }
}
