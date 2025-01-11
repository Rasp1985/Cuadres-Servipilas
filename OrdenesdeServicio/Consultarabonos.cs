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
    public partial class Consultarabonos : Form
    {
        public Consultarabonos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "";
            user = txtSucrsalt.Text;
            DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
            DateTime fecha3 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
            if(rdbhoy.Checked==true)
            {
                fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            fecha2=Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            }
            if (rdbayer.Checked == true)
            {
                fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.AddDays(-1).ToShortDateString());
                fecha2 = Convert.ToDateTime(dtFechaInicial.Value.Date.AddDays(-1).ToShortDateString());
            }
            this.AbonoTableAdapter.fechasAbonos(this.bdOrdenesDataSet2.Abono,fecha1,fecha2, user);
     
            this.VentaTableAdapter.fechaventas(this.bdOrdenesDataSet2.Venta, fecha1, user, fecha2);
            this.reportViewer1.RefreshReport();

        }

        private void Consultarabonos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet2.Abono' Puede moverla o quitarla según sea necesario.


        }
    }
}
