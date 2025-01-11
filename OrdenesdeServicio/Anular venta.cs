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
    public partial class Anular_venta : Form
    {
        OleDbConnection conexion;
        private string  Consecutiv;

        public Anular_venta(string usuario)
        {
            Consecutiv = usuario;
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
            
            if (rtxtobservaciones.Text == "")
            {
                MessageBox.Show("Ingrese observaciones");
                return;
            }
            DateTime fecha = DateTime.Now;

            string obs = rtxtobservaciones.Text;
            rtxtobservaciones.Text =obs+" "+fecha.ToString("dd/MM/yyyy HH:mm");
           
           Int32 consecutivo =Convert.ToInt32(txtEliminarOrden.Text);
            double totalVenta = 0;
            try
            {
                string q = "Select Total from venta WHERE Venta.consecutivo=@Numero and Venta.Usuario='" + Consecutiv + "' ";


            OleDbCommand comando = new OleDbCommand(q, conexion);
            comando.Connection.Open();


            comando.Parameters.AddWithValue("@Numero", consecutivo);

            /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
            ///comando.Parameters["@fechafactura"].Value = fecha1;
            OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    totalVenta = double.Parse(dr["Total"].ToString());
                }

            comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }
            try
            {
                string q = "delete  venta.* from venta WHERE Venta.consecutivo=@Numero and Venta.Usuario='" + Consecutiv + "' ";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Numero", consecutivo);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();



                comando.Connection.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }

            try
            {
                string q = "delete  Detalle_venta.* from Detalle_venta WHERE Detalle_venta.Consecutivo=@Numero and Detalle_venta.Usuario='" + Consecutiv + "' ";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Numero", consecutivo);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();



                comando.Connection.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

            try
            {




                string q = "insert into eliminar_ventas(Consecutivo_venta,Observaciones,Usuario,fecha) values(@consecutivo,@codigop,@codig,@fecha)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();




                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@consecutivo", txtEliminarOrden.Text);
                cmd.Parameters.AddWithValue("@codigop", rtxtobservaciones.Text+" "+totalVenta.ToString("C0"));
                cmd.Parameters.AddWithValue("@codig", Consecutiv);
                cmd.Parameters.AddWithValue("@fecha", fecha.ToShortDateString());

                cmd.ExecuteNonQuery();



                cmd.Connection.Close();
                Eliminarventa();
                grdEliminarOrdenes.Columns[0].Width = 120;
                grdEliminarOrdenes.Columns[1].Width = 400;
                rtxtobservaciones.Text = "";
            }



            catch (Exception ex)
            {
                conexion.Close();
                //return false;
                MessageBox.Show(ex.Message);
                return;


            }

        }


        public void Eliminarventa()
        {



            try
            {
                string q = "SELECT eliminar_ventas.Consecutivo_venta, eliminar_ventas.observaciones FROM eliminar_ventas where usuario=@codigop order by Fecha desc";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@codigop",Consecutiv);

                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdEliminarOrdenes.DataSource = pr.Tables[0];

                comando.Connection.Close();


                grdEliminarOrdenes.Columns[0].Width = 120;
                grdEliminarOrdenes.Columns[1].Width = 400;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Anular_venta_Load(object sender, EventArgs e)
        {
            Eliminarventa();
                
        }
    }
    }

