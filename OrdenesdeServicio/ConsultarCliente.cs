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
    public partial class ConsultarCliente : Form
    {
        OleDbConnection conexion;

        private string user;

        public ConsultarCliente(string usuario)
        {
            user = usuario;
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            BuscarOrdenes();
        }

        public void BuscarOrdenes()
        {
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese el Documento");
                return;
            }
            string conse = user;
            string documento = txtDocumento.Text;
            try
            {
                string q = "SELECT tblCliente.Documento as Documento, tblCliente.Nombrecompleto as Nombre, tblOrden.Fecha as Fecha, tblOrden.Consecutivo as Número_Orden, tblOrden.Total as Total,tblOrden.Observaciones, tblOrden.Usuario as Usuario FROM tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento WHERE tblOrden.Estado='SinPagar' AND (((tblCliente.Documento) = '" + documento + "') AND (((tblOrden.Usuario) = '" + conse + "') or ('" + conse + "' = 'Administrativo')))";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdCliente.DataSource = pr.Tables[0];
                grdCliente.Columns[1].Width = 170;
                grdCliente.Columns[5].Width = 450;
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

       


        public void sumarorden()
        {
            double sumatoria = 0;
            foreach (DataGridViewRow row in grdOrdenes.Rows)
            {
                sumatoria += Convert.ToDouble(row.Cells[4].Value);
            }
            txtTotal.Text= string.Format("{0:c2}", sumatoria);
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
           
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BuscarOrdenes();
            }
        }

        private void grdCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Consecutivo = int.Parse(grdCliente.CurrentRow.Cells["Número_Orden"].Value.ToString());
            string conse = grdCliente.CurrentRow.Cells["Usuario"].Value.ToString();
            try
            {
                string r = "SELECT tblDetalleOrden.Codigo, tblDetalleOrden.referencia, tblDetalleOrden.Caracteristicas,tblDetalleOrden.Cantidad,tblDetalleOrden.Valor, tblOrden.Usuario, tblDetalleOrden.Observacionesr as Observaciones FROM tblSucursal INNER JOIN(tblOrden INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario WHERE(((tblDetalleOrden.Codigo) = @Documento)AND((tblOrden.Usuario) = '" + conse + "'))";
                OleDbCommand coman = new OleDbCommand(r, conexion);
                coman.Connection.Open();
                coman.Parameters.AddWithValue("@Documento", Consecutivo);


                OleDbDataAdapter af = new OleDbDataAdapter(coman);
                DataSet dtr = new DataSet();
                af.Fill(dtr);
                grdOrdenes.DataSource = dtr.Tables[0];
                grdOrdenes.Columns[0].Width = 50;
                grdOrdenes.Columns[2].Width = 260;
                grdOrdenes.Columns[3].Width = 60;
                grdOrdenes.Columns[1].Width = 200;
                grdOrdenes.Columns[6].Width = 400;
                coman.Connection.Close();
                sumarorden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
    }
}