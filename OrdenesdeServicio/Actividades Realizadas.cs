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
    public partial class Actividades_Realizadas : Form
    {
        OleDbConnection conexion;
       
        public Actividades_Realizadas()
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void Actividades_Realizadas_Load(object sender, EventArgs e)
        {
            llenarcombo();
        }



        private void llenarcombo()
        {




            try
            {
                string q = "SELECT vendedor FROM tblvendedor";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataTable pr = new DataTable("tblvendedor");
                ad.Fill(pr);
                cboNombre.DataSource = pr;
                cboNombre.DisplayMember = "tblvendedor";
                cboNombre.ValueMember = "Vendedor";

                comando.Connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }


        }



        private void limpiar()
        {
           
          dtfecha.Text = "";
            dtmhorainicio.Text = "";
            dtmhorafina.Text = "";
            rthActividades.Text = "";
            rthObservaciones.Text = "";
            txtlugar.Text = "";



        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {



                string nombre = cboNombre.Text;
                string fecha = dtfecha.Text;
                string horainicio = dtmhorainicio.Text;
               string horafinal = dtmhorafina.Text;
                string Actividades = rthActividades.Text;
            string observaciones = rthObservaciones.Text;



       string q = "insert into tblActividades(Nombre,fecha,horainicio,horafinal,actividades,observaciones) values(@Nombre,@fecha,@horainicio,@horafinal,@actividades,@observaciones)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();




                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
               cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@horainicio", horainicio);
            cmd.Parameters.AddWithValue("@horafinal", horafinal);
            cmd.Parameters.AddWithValue("@actividades", Actividades);
            cmd.Parameters.AddWithValue("@observaciones", observaciones);






            cmd.ExecuteNonQuery();


                MessageBox.Show("Registro almacenado");

              
                cmd.Connection.Close();

                limpiar();
            }

            catch (Exception ex)
            {
                conexion.Close();

                MessageBox.Show(ex.Message);
                return;


            }

          

        }

        private void btnNuevaorden_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Imprimir_Actividades impact = new Imprimir_Actividades();
            impact.Show();

        }
    }
}
