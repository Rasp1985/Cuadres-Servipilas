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
          
            //Buscar("mayorca", "Sucursal", grdConsultarordenes);

        }






        public void sumargrid()
        {

            sumatoria = 0;
            foreach (DataGridViewRow row in grdConsultarordenes.Rows)
            {


                sumatoria += Convert.ToDouble(row.Cells[5].Value);

            }



        }







        public void ConsultarOrdenp(string sucursal)
        {




            try
            {
                
                string q = "SELECT tblOrden.Fecha, tblOrden.Consecutivo, tblOrden.Usuario as Sucursal, tblOrden.Documento, tblCliente.Nombrecompleto, tblOrden.Total FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario where tblOrden.usuario=@Sucursal";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();

                comando.Parameters.AddWithValue("@Sucursal", Sucursal);
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






        public void ConsultarOrdenpt(string sucursal)
        {

             
            string fecha1 = dtFechaInicial.Value.Date.ToShortDateString();
            string fecha2 = dtFechafinal.Value.Date.ToShortDateString();

         
            try
            {
                DataSet pr = new DataSet();
                pr.Clear();
                string q = "SELECT tblOrden.Fecha, tblOrden.Consecutivo, tblOrden.Usuario as Sucursal, tblOrden.Documento, tblCliente.Nombrecompleto, tblOrden.Total FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario where (((tblOrden.Fecha)>=@fecha1 And (tblOrden.Fecha)<=@fecha2) AND ((tblOrden.Usuario)=@Sucursal))";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@fecha1", fecha1);
                comando.Parameters.AddWithValue("@fecha2", fecha2);
                comando.Parameters.AddWithValue("@Sucursal", Sucursal);
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                
                ad.Fill(pr);
                grdConsultarordenes.DataSource = pr.Tables[0];
                grdConsultarordenes.Columns[4].Width = 170;
                comando.Connection.Close();
            





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

        bool Buscar(string TextoABuscar, string Columna, DataGridView grid)
        {
            bool encontrado = false;
            if (TextoABuscar == string.Empty) return false;
            if (grid.RowCount == 0) return false;
            grid.ClearSelection();
            if (Columna == string.Empty)
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        if (cell.Value == TextoABuscar)
                        {
                            row.Selected = true;
                            return true;
                        }
                }
            }
            else
            {
                foreach (DataGridViewRow row in grid.Rows)
                {

                    if (row.Cells[Columna].Value == TextoABuscar)
                    {
                        row.Selected = true;
                        return true;
                    }
                }
            }
            return encontrado;
        }

      

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
           {
               double rma = 0, rs = 0, rm = 0, rd = 0, rt = 0;
               if (chkMayorca.Checked)
               {
                   Sucursal = chkMayorca.Text;
                   ConsultarOrdenpt(Sucursal);

                   sumargrid();
                   txtMayorca.Text = sumatoria.ToString();
                   rma = sumatoria;
               }

               if (chkSanDiego.Checked)
               {
                   Sucursal = chkSanDiego.Text;
                   ConsultarOrdenpt(Sucursal);
                   sumargrid();
                   txtSandiego.Text = sumatoria.ToString();
                   rs = sumatoria;
               }

               if (chkMolinos.Checked)
               {
                   Sucursal = chkMolinos.Text;
                   ConsultarOrdenpt(Sucursal);
                   sumargrid();
                   txtMolinos.Text = sumatoria.ToString();
                   rm = sumatoria;
               }
               if (chkDiamante.Checked)
               {
                   Sucursal = chkDiamante.Text;
                   ConsultarOrdenpt(Sucursal);
                   sumargrid();
                   txtDiamante.Text = sumatoria.ToString();
                   rd = sumatoria;
                   sumatoria = 0;
               }
               rt = rma + rs + rm + rd;
               txtSandiego.Text = rs.ToString();
               txtMolinos.Text = rm.ToString();
               txtDiamante.Text = rd.ToString();
               txtMayorca.Text = rma.ToString();
               txtTotalpuntos.Text = rt.ToString();
               
           }

        private void chkSanDiego_CheckedChanged(object sender, EventArgs e)
        {
            double rma = 0, rs = 0, rm = 0, rd = 0, rt = 0;
            if (chkMayorca.Checked)
            {
                Sucursal = chkMayorca.Text;
                ConsultarOrdenpt(Sucursal);

                sumargrid();
                txtMayorca.Text = sumatoria.ToString();
                rma = sumatoria;
            }

            if (chkSanDiego.Checked)
            {
                Sucursal = chkSanDiego.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtSandiego.Text = sumatoria.ToString();
                rs = sumatoria;
            }

            if (chkMolinos.Checked)
            {
                Sucursal = chkMolinos.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtMolinos.Text = sumatoria.ToString();
                rm = sumatoria;
            }
            if (chkDiamante.Checked)
            {
                Sucursal = chkDiamante.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtDiamante.Text = sumatoria.ToString();
                rd = sumatoria;
                sumatoria = 0;
            }
            rt = rma + rs + rm + rd;
            txtSandiego.Text = rs.ToString();
            txtMolinos.Text = rm.ToString();
            txtDiamante.Text = rd.ToString();
            txtMayorca.Text = rma.ToString();
            txtTotalpuntos.Text = rt.ToString();
        }

        private void chkMayorca_CheckedChanged(object sender, EventArgs e)
        {
            double rma = 0, rs = 0, rm = 0, rd = 0, rt = 0;
            if (chkMayorca.Checked)
            {
                Sucursal = chkMayorca.Text;
                ConsultarOrdenpt(Sucursal);

                sumargrid();
                txtMayorca.Text = sumatoria.ToString();
                rma = sumatoria;
            }

            if (chkSanDiego.Checked)
            {
                Sucursal = chkSanDiego.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtSandiego.Text = sumatoria.ToString();
                rs = sumatoria;
            }

            if (chkMolinos.Checked)
            {
                Sucursal = chkMolinos.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtMolinos.Text = sumatoria.ToString();
                rm = sumatoria;
            }
            if (chkDiamante.Checked)
            {
                Sucursal = chkDiamante.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtDiamante.Text = sumatoria.ToString();
                rd = sumatoria;
                sumatoria = 0;
            }
            rt = rma + rs + rm + rd;
            txtSandiego.Text = rs.ToString();
            txtMolinos.Text = rm.ToString();
            txtDiamante.Text = rd.ToString();
            txtMayorca.Text = rma.ToString();
            txtTotalpuntos.Text = rt.ToString();
        }

        private void chkMolinos_CheckedChanged(object sender, EventArgs e)
        {
            double rma = 0, rs = 0, rm = 0, rd = 0, rt = 0;
            if (chkMayorca.Checked)
            {
                Sucursal = chkMayorca.Text;
                ConsultarOrdenpt(Sucursal);

                sumargrid();
                txtMayorca.Text = sumatoria.ToString();
                rma = sumatoria;
            }

            if (chkSanDiego.Checked)
            {
                Sucursal = chkSanDiego.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtSandiego.Text = sumatoria.ToString();
                rs = sumatoria;
            }

            if (chkMolinos.Checked)
            {
                Sucursal = chkMolinos.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtMolinos.Text = sumatoria.ToString();
                rm = sumatoria;
            }
            if (chkDiamante.Checked)
            {
                Sucursal = chkDiamante.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtDiamante.Text = sumatoria.ToString();
                rd = sumatoria;
                sumatoria = 0;
            }
            rt = rma + rs + rm + rd;
            txtSandiego.Text = rs.ToString();
            txtMolinos.Text = rm.ToString();
            txtDiamante.Text = rd.ToString();
            txtMayorca.Text = rma.ToString();
            txtTotalpuntos.Text = rt.ToString();
        }

        private void chkDiamante_CheckedChanged(object sender, EventArgs e)
        {
            double rma = 0, rs = 0, rm = 0, rd = 0, rt = 0;
            if (chkMayorca.Checked)
            {
                Sucursal = chkMayorca.Text;
                ConsultarOrdenpt(Sucursal);

                sumargrid();
                txtMayorca.Text = sumatoria.ToString();
                rma = sumatoria;
            }

            if (chkSanDiego.Checked)
            {
                Sucursal = chkSanDiego.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtSandiego.Text = sumatoria.ToString();
                rs = sumatoria;
            }

            if (chkMolinos.Checked)
            {
                Sucursal = chkMolinos.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtMolinos.Text = sumatoria.ToString();
                rm = sumatoria;
            }
            if (chkDiamante.Checked)
            {
                Sucursal = chkDiamante.Text;
                ConsultarOrdenpt(Sucursal);
                sumargrid();
                txtDiamante.Text = sumatoria.ToString();
                rd = sumatoria;
                sumatoria = 0;
            }
            rt = rma + rs + rm + rd;

            txtSandiego.Text = rs.ToString();
            txtMolinos.Text = rm.ToString();
            txtDiamante.Text = rd.ToString();
            txtMayorca.Text = rma.ToString();
            txtTotalpuntos.Text = rt.ToString();
            
        }


    }
}