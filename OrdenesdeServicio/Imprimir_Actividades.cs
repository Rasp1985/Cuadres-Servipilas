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
    public partial class Imprimir_Actividades : Form
    {
        OleDbConnection conexion;
        public Imprimir_Actividades()
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void Imprimir_Actividades_Load(object sender, EventArgs e)
        {


            llenarcombo();
            

        }




        public void llenaractividades()
        {
            string user = txtSucrsalt.Text;
            //DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            //DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());

          string fecha1 = dtFechaInicial.Text;
         string fecha2 = dtFechafinal.Text;

            try
            {
                string q = "SELECT Nombre, Fecha, Horainicio as Hora_Inicio, horafinal as Hora_Final, Actividades, Observaciones FROM tblActividades where (tblActividades.Fecha)>=@Fecha And (tblActividades.Fecha)<=@Fecha1 AND (tblActividades.Nombre=@Nombre)";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();

                comando.Parameters.AddWithValue("@Fecha", fecha1);
                comando.Parameters.AddWithValue("@Fecha1", fecha2);
                comando.Parameters.AddWithValue("@Nombre", user);
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
               grdConsultarCliente.DataSource = pr.Tables[0];

                grdConsultarCliente.Columns[0].Width = 150;
                grdConsultarCliente.Columns[1].Width = 70;
                grdConsultarCliente.Columns[2].Width = 70;
                grdConsultarCliente.Columns[3].Width = 70;


                grdConsultarCliente.Columns[4].Width = 400;
                grdConsultarCliente.Columns[5].Width = 300;
                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

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
                txtSucrsalt.DataSource = pr;
                txtSucrsalt.DisplayMember = "tblvendedor";
                txtSucrsalt.ValueMember = "Vendedor";

                comando.Connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            llenaractividades();
        }
    }
}
