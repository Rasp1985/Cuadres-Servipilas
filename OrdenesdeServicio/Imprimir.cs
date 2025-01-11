using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;
namespace OrdenesdeServicio
{
    public partial class Imprimir : Form
    {
        OleDbConnection conexion;
        private string user;
        private string consecutivo;
        public Imprimir(string userd,string consecutivod)
        {
            user = userd;
            consecutivo = consecutivod;
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void Imprimir_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet2.Detalle_venta' Puede moverla o quitarla según sea necesario.
            this.Detalle_ventaTableAdapter.Fill(this.bdOrdenesDataSet2.Detalle_venta);

            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblOrden' Puede moverla o quitarla según sea necesario.
            this.tblOrdenTableAdapter.Fill(this.bdOrdenesDataSet.tblOrden);
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.Abono' Puede moverla o quitarla según sea necesario.
            this.AbonoTableAdapter.Fill(this.bdOrdenesDataSet.Abono);
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblCliente' Puede moverla o quitarla según sea necesario.
            this.tblClienteTableAdapter.Fill(this.bdOrdenesDataSet.tblCliente);
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblDetalleOrden' Puede moverla o quitarla según sea necesario.
            this.tblDetalleOrdenTableAdapter.Fill(this.bdOrdenesDataSet.tblDetalleOrden);
            // TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet1.tblRepuestos' Puede moverla o quitarla según sea necesario.
            this.tblRepuestosTableAdapter.Fill(this.bdOrdenesDataSet1.tblRepuestos);
            //// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblOrden' Puede moverla o quitarla según sea necesario.
            //this.tblOrdenTableAdapter.Fill(this.bdOrdenesDataSet.tblOrden);
            //// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.Abono' Puede moverla o quitarla según sea necesario.
            //this.AbonoTableAdapter.Fill(this.bdOrdenesDataSet.Abono);
            //// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblCliente' Puede moverla o quitarla según sea necesario.
            //this.tblClienteTableAdapter.Fill(this.bdOrdenesDataSet.tblCliente);
            //// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblDetalleOrden' Puede moverla o quitarla según sea necesario.
            //this.tblDetalleOrdenTableAdapter.Fill(this.bdOrdenesDataSet.tblDetalleOrden);
            ////// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet1.tblCliente' Puede moverla o quitarla según sea necesario.
            ////this.tblClienteTableAdapter.Fill(this.bdOrdenesDataSet1.tblCliente);
            ////// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.Abono' Puede moverla o quitarla según sea necesario.
            ////this.AbonoTableAdapter.Fill(this.bdOrdenesDataSet.Abono);
            ////// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblDetalleOrden' Puede moverla o quitarla según sea necesario.
            ////this.tblDetalleOrdenTableAdapter.Fill(this.bdOrdenesDataSet.tblDetalleOrden);
            ////// TODO: esta línea de código carga datos en la tabla 'bdOrdenesDataSet.tblOrden' Puede moverla o quitarla según sea necesario.
            ////this.tblOrdenTableAdapter.Fill(this.bdOrdenesDataSet.tblOrden);

            //this.reportViewer1.RefreshReport();
        }


        private void consultar()
        {
            
            try
            {
                //    consecutivo = "";
                //    //string q = "SELECT tblCliente.Documento,tblCliente.Nombrecompleto, tblOrden.Consecutivo, tblOrden.Usuario FROM tblCliente INNER JOIN tblOrden ON tblCliente.[Documento] = tblOrden.[Documento] WHERE(((tblOrden.Consecutivo) = @Documento) AND((tblOrden.Usuario) = @Document))";

                //    string q = "SELECT Consecutivo,Documento,Usuario FROM tblOrden WHERE(((tblOrden.Consecutivo) = @Documento) AND((tblOrden.Usuario) = @Document))";

                //    OleDbCommand comando = new OleDbCommand(q, conexion);
                //    comando.Connection.Open();
                //    comando.Parameters.AddWithValue("@Documento", consecutivo);
                //    comando.Parameters.AddWithValue("@Document", user);


                //    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                //    ///comando.Parameters["@fechafactura"].Value = fecha1;
                //    OleDbDataReader dr = comando.ExecuteReader();

                //    if (dr.Read())
                //    {

                //      string caracteristicas = "";

                //        caracteristicas= dr["Documento"].ToString();


                //    this.tblOrdenTableAdapter.imprimiro(this.bdOrdenesDataSet.tblOrden, consecutivo, user);
                //    this.tblDetalleOrdenTableAdapter.imprimiro(this.bdOrdenesDataSet.tblDetalleOrden, consecutivo, user);
                //    this.AbonoTableAdapter.imprimiro(this.bdOrdenesDataSet.Abono, consecutivo, user);
                //    this.tblClienteTableAdapter.imprimiro(this.bdOrdenesDataSet.tblCliente, caracteristicas);
                //    this.reportViewer1.RefreshReport();
                //    }
                //    conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = "";
            user = txtSucrsalt.Text;
            DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
         
            string entrega = "Entrega";
            this.tblRepuestosTableAdapter.consultarrepuestos(this.bdOrdenesDataSet1.tblRepuestos, fecha1, fecha2, user,entrega);
            //this.tblRepuestosTableAdapter.Sumatotal(this.bdOrdenesDataSet1.tblRepuestos, user, fecha1, fecha2);
            this.reportViewer1.RefreshReport();
            //consultar();
        }

        private void dtFechafinal_ValueChanged(object sender, EventArgs e)
        {
            user = "";
            user = txtSucrsalt.Text;
            DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
        
            string entrega = "Entrega";
            this.tblRepuestosTableAdapter.consultarrepuestos(this.bdOrdenesDataSet1.tblRepuestos,fecha1,fecha2,user,entrega);
            //this.tblRepuestosTableAdapter.Sumatotal(this.bdOrdenesDataSet1.tblRepuestos, user,fecha1,fecha2);
            this.reportViewer1.RefreshReport();

        }

        private void txtSucrsalt_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = "";
            user = txtSucrsalt.Text;
            DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
           
            string entrega = "Entrega";
            this.tblRepuestosTableAdapter.consultarrepuestos(this.bdOrdenesDataSet1.tblRepuestos, fecha1, fecha2, user, entrega);
            //this.tblRepuestosTableAdapter.Sumatotal(this.bdOrdenesDataSet1.tblRepuestos, user,fecha1,fecha2);
            this.reportViewer1.RefreshReport();

        }

        private void dtFechaInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSucrsalt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
