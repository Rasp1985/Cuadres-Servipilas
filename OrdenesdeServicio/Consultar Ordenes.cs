using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OrdenesdeServicio
{


    public partial class Consultar_Ordenes : Form
    {
        private double sumatoria;

        public double Sumatoria
        {
            get { return sumatoria; }
            set { sumatoria = value; }
        }
        OleDbConnection conexion;
        private string Sucursal;

        public Consultar_Ordenes()
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void Consultar_Ordenes_Load(object sender, EventArgs e)
        {
            //ConsultarOrden();
            sumargrid();
            rdosp.Checked = true;

            //Buscar("mayorca", "Sucursal", grdConsultarordenes);

        }






        public void sumargrid()
        {

            sumatoria = 0;
            int cont = 0;
            foreach (DataGridViewRow row in grdConsultarordenes.Rows)
            {

                cont = cont + 1;
                sumatoria += Convert.ToDouble(row.Cells[7].Value);

            }

            cont = cont - 1;
            lblcr.Text = "";
            lblcr.Text = cont.ToString();


        }









        //public void ConsultarOrdenp(string sucursal)
        //{




        //    try
        //    {
        //        string stadofactura = "";
        //        string fecha1 = dtFechaInicial.Value.Date.ToShortDateString();
        //        string fecha2 = dtFechafinal.Value.Date.AddDays(+1).ToShortDateString();

        //        if (rdop.Checked == true)
        //        {
        //            stadofactura = "Pagada";


        //        }
        //        if (rdosp.Checked == true)
        //        {
        //            stadofactura = "SinPagar";

        //        }

        //        string estado = "";
        //        string q = "SELECT tblOrden.Fecha, tblOrden.Consecutivo, tblOrden.Usuario as Sucursal, tblOrden.Documento, tblCliente.Nombrecompleto, tblOrden.Total FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario where (tblOrden.Fecha)>=@fecha1 And (tblOrden.Fecha)<=@fecha2  AND (tblOrden.Usuario)=@Sucursal and (tblOrden.Estado)=@Estado";
        //        AND(tblOrden.Estado) = '" + estado + "'"
        //        OleDbCommand comando = new OleDbCommand(q, conexion);
        //        comando.Connection.Open();

        //        comando.Connection.Open();
        //        comando.Parameters.AddWithValue("@fecha1", fecha1);
        //        comando.Parameters.AddWithValue("@fecha2", fecha2);
        //        comando.Parameters.AddWithValue("@Sucursal", Sucursal);

        //        comando.Parameters.AddWithValue("@Estado", stadofactura);
        //        OleDbDataAdapter ad = new OleDbDataAdapter(comando);
        //        DataSet pr = new DataSet();
        //        pr.Clear();
        //        ad.Fill(pr);
        //        grdConsultarordenes.DataSource = pr.Tables[0];

        //        comando.Connection.Close();






        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        conexion.Close();
        //    }

        //}






        public void ConsultarOrdenpt(string sucursal)
        {


            string fecha1 = dtFechaInicial.Value.Date.ToShortDateString();
            string fecha2 = dtFechafinal.Value.Date.ToShortDateString();


            try
            {
                string stadofactura = "";


                if (rdop.Checked == true)
                {
                    stadofactura = "Pagada";

                }



                if (rdosp.Checked == false)
                {

                    if (rdop.Checked == false)
                    {

                        MessageBox.Show("Debe selecionar el estado de la orden");
                        return;
                    }
                }
                if (rdosp.Checked == true)
                {
                    stadofactura = "SinPagar";


                    DataSet pr = new DataSet();
                    pr.Clear();

                    string q = "SELECT tblOrden.Fecha as [Fecha Ingreso], tblOrden.Consecutivo,tblDetalleOrden.referencia as Referencia, tblOrden.Usuario as Sucursal, tblOrden.Documento,tblOrden.Estado, tblCliente.Nombrecompleto as [Nombre Cliente], tblOrden.Total FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario where (tblOrden.Fecha)>=@fecha1 And (tblOrden.Fecha)<=@fecha2  AND (tblOrden.Usuario)=@Sucursal and (tblOrden.Estado)=@Estado";
                    // AND (tblOrden.Estado)='" + estado + "'"
                    OleDbCommand comando = new OleDbCommand(q, conexion);





                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@fecha1", fecha1);
                    comando.Parameters.AddWithValue("@fecha2", fecha2);
                    comando.Parameters.AddWithValue("@Sucursal", Sucursal);
                    comando.Parameters.AddWithValue("@Estado", stadofactura);
                    OleDbDataAdapter ad = new OleDbDataAdapter(comando);

                    ad.Fill(pr);
                    grdConsultarordenes.DataSource = pr.Tables[0];
                    grdConsultarordenes.Columns[6].Width = 170;
                    grdConsultarordenes.Columns[2].Width = 190;
                    comando.Connection.Close();



                }


            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

            try
            {

                if (rdop.Checked == true)
                {
                    string stadofactura = "Pagada";


                    DataSet pr = new DataSet();
                    pr.Clear();

                    string q = "SELECT tblOrden.Fecha, tblOrden.Consecutivo,tblDetalleOrden.referencia as Referencia, tblOrden.Usuario as Sucursal, tblOrden.Documento,tblOrden.Estado, tblCliente.Nombrecompleto, tblOrden.Total FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario where (tblOrden.Fecha)>=@fecha1 And (tblOrden.Fecha)<=@fecha2  AND (tblOrden.Usuario)=@Sucursal and (tblOrden.Estado)=@Estado";
                    // AND (tblOrden.Estado)='" + estado + "'"
                    OleDbCommand comando = new OleDbCommand(q, conexion);





                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@fecha1", fecha1);
                    comando.Parameters.AddWithValue("@fecha2", fecha2);
                    comando.Parameters.AddWithValue("@Sucursal", Sucursal);
                    comando.Parameters.AddWithValue("@Estado", stadofactura);
                    OleDbDataAdapter ad = new OleDbDataAdapter(comando);

                    ad.Fill(pr);
                    grdConsultarordenes.DataSource = pr.Tables[0];
                    grdConsultarordenes.Columns[4].Width = 170;
                    comando.Connection.Close();



                }


            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }


        }











        public void ConsultarOrden()
        {




            try
            {
                string q = "SELECT tblOrden.Fecha, tblOrden.Consecutivo, tblOrden.Usuario as Sucursal, tblOrden.Documento, tblCliente.Nombrecompleto, tblOrden.Total FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario;";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdConsultarordenes.DataSource = pr.Tables[0];

                comando.Connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalcularSucursales();
        }

        private void rdosp_CheckedChanged(object sender, EventArgs e)
        {
            CalcularSucursales();
        }

        private void rdop_CheckedChanged(object sender, EventArgs e)
        {
            CalcularSucursales();
        }


        public void CalcularSucursales()
        {
            double rma = 0, rs = 0, rm = 0, rd = 0, rt = 0, rpn = 0;
            if (chkMayorca.Checked)
            {
                Sucursal = chkMayorca.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                rma = sumatoria;
            }

            if (chkSanDiego.Checked)
            {
                Sucursal = chkSanDiego.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                rs = sumatoria;
            }

            if (chkMolinos.Checked)
            {
                Sucursal = chkMolinos.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                rm = sumatoria;
            }
            if (chkCentral.Checked)
            {
                Sucursal = chkCentral.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                rd = sumatoria;
                sumatoria = 0;
            }
            if (chkPNorte.Checked)
            {
                Sucursal = chkPNorte.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                rpn = sumatoria;
                sumatoria = 0;
            }
            rt = rma + rs + rm + rd + rpn;

            txtSandiego.Text = string.Format("{0:c2}", rs);
            txtMolinos.Text = string.Format("{0:c2}", rm);
            txtDiamante.Text = string.Format("{0:c2}", rd);
            txtMayorca.Text = string.Format("{0:c2}", rma);
            txtTotalpuntos.Text = string.Format("{0:c2}", rt);
            txtPuertaNorte.Text = string.Format("{0:c2}", rpn);
        }

        private void chkSanDiego_CheckedChanged_1(object sender, EventArgs e)
        {
            CalcularSucursales();
        }

        private void chkMayorca_CheckedChanged_1(object sender, EventArgs e)
        {
            CalcularSucursales();
        }

        private void chkMolinos_CheckedChanged_1(object sender, EventArgs e)
        {
            CalcularSucursales();
        }

        private void chkCentral_CheckedChanged_1(object sender, EventArgs e)
        {
            CalcularSucursales();
        }

        private void chkPNorte_CheckedChanged_1(object sender, EventArgs e)
        {
            CalcularSucursales();
        }
    }
}