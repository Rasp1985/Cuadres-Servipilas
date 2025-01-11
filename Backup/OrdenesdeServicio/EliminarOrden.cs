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
    public partial class EliminarOrden : Form
    {
        OleDbConnection conexion;
        public EliminarOrden()
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminarOrden.Text == "")
            {
                MessageBox.Show("Ingrese el consecutivo");
                return;
            }




            string consecutivo = txtEliminarOrden.Text;
            try
            {
                string q = "delete  tblOrden.* from tblOrden WHERE tblOrden.consecutivo=@Numero";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Numero", consecutivo);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                

                comando.Connection.Close();




                string a = "delete  tblDetalleOrden.* from tblDetalleOrden WHERE tblDetalleOrden.Codigo=@Numero";


                OleDbCommand coman = new OleDbCommand(a, conexion);
                coman.Connection.Open();


                coman.Parameters.AddWithValue("@Numero", consecutivo);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader fr = coman.ExecuteReader();

                MessageBox.Show("Orden eliminada con éxito");

                coman.Connection.Close();

                EliminarOrdenes();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarOrden_Load(object sender, EventArgs e)
        {
            EliminarOrdenes();

        }
         public void EliminarOrdenes()
        {

  

            try
            {
                string q = "SELECT tblOrden.Consecutivo, tblOrden.Fecha, tblCliente.Documento, tblCliente.Nombrecompleto FROM tblSucursal INNER JOIN ((tblCliente INNER JOIN tblOrden ON tblCliente.Documento = tblOrden.Documento) INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();

               
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdEliminarOrdenes.DataSource = pr.Tables[0];

                comando.Connection.Close();


   



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }




        

    }
}
