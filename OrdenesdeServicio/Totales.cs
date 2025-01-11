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
    public partial class Totales : Form
    {
        string usu;
        DataSet resultados1 = new DataSet();

        OleDbConnection conexion;
        public Totales(string total)
        {
            usu = total;
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
        }

        private void Totales_Load(object sender, EventArgs e)
        {
            consultarobservaciones();
        }

        public void consultarticket()
        {
            {
                try
                {

                    DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
                    DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());

                    string qf = "SELECT Codigo_plug,Plug,sum(Cantidad) as Cantidad FROM Detalle_venta  WHERE Detalle_venta.Fecha>= @f1 AND Detalle_venta.Fecha<=@f2 AND Detalle_venta.Usuario =@us GROUP BY Codigo_plug,Plug";
                    OleDbCommand comandod = new OleDbCommand(qf, conexion);
                    comandod.Connection.Open();
                   
                    comandod.Parameters.AddWithValue("@f1", fecha1);
                    comandod.Parameters.AddWithValue("@f2", fecha2);
                    comandod.Parameters.AddWithValue("@us", usu);



                    OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                    DataSet pr = new DataSet();
                    ad.Fill(pr);
                 grdCliente.DataSource = pr.Tables[0];

                     grdCliente.Columns[0].Width = 180;
                    grdCliente.Columns[1].Width = 360;
                    grdCliente.Columns[2].Width = 140;





                    comandod.Connection.Close();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }

            }
        }



        public void consultarobservaciones()
        {
            {
                try
                {

                    DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
                    DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
                    string obser = "Salida OK:"+txtDocumento.Text + " Fecha inicial:" + fecha1 + " Fecha final:" + fecha2;
                    string qf = "SELECT Observaciones from Observaciones where Observaciones.usuario=@f2 order by Fecha desc ";
                    OleDbCommand comandod = new OleDbCommand(qf, conexion);
                    comandod.Connection.Open();

                   
                    comandod.Parameters.AddWithValue("@f2", usu);
          



                    OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                    DataSet pr = new DataSet();
                    ad.Fill(pr);
                    GRDCONSULTAORDEN.DataSource = pr.Tables[0];

                    GRDCONSULTAORDEN.Columns[0].Width = 750;
             





                    comandod.Connection.Close();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }

            }
        }
        private void dtFechafinal_ValueChanged(object sender, EventArgs e)
        {
            //consultarticket();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea grabar esta salida de mercancía", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
           
            try
            {




                DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
                DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());
                string obser = "Salida OK:" + txtDocumento.Text + "Fecha inicial:" + fecha1 + "Fecha final:" + fecha2;
                string observaciones = obser;

              




                string q = "insert into Observaciones(Observaciones,usuario,Fecha) values(@observaciones,@usuario,@Fecha)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();




                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@observaciones", observaciones);
               
                cmd.Parameters.AddWithValue("@usuario", usu);

                cmd.Parameters.AddWithValue("@Fecha", fecha2);



                    cmd.ExecuteNonQuery();



              


                cmd.Connection.Close();
                consultarobservaciones();

            }

            catch (Exception ex)
            {
                conexion.Close();
                //return false;
                MessageBox.Show(ex.Message);
                return;


            }
            }

        }

        private void btnSumarVentas_Click(object sender, EventArgs e)
        {
            consultarticket();
        }
    }
}
