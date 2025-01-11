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
    public partial class Imprimir_Cuadre : Form
    {
        private string usuario;
        DataSet resultados1 = new DataSet();

        OleDbConnection conexion;
        public Imprimir_Cuadre(string user)
        {
            usuario = user;
    
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumarcuadres();
            sumartotal();
            sumarMEGARED();
        }
        public void sumarcuadres()
        {
            usuario = lblUsuario.Text;
            //DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            //DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());

            string fecha1 = dtFechaInicial.Text;
            string fecha2 = dtFechafinal.Text;

            try
            {
                string q = "SELECT tblCuadre.[Fecha], tblCuadre.[C1] as Caja1, tblCuadre.[C2] as Caja2, tblCuadre.[C3]as Caja3, tblCuadre.[C4]as Caja4, tblCuadre.[C5]as Caja5, tblCuadre.[EFECTIVO], tblCuadre.[DATAFONO], tblCuadre.[GASTOS], tblCuadre.[COMPRAS], tblCuadre.[TRANSFERENCIAS], tblCuadre.[VENTASSISTECREDITO], tblCuadre.[VENTASTIENDA], tblCuadre.[APLICACIONANTICIPOS], tblCuadre.[Observaciones] FROM tblCuadre where (tblCuadre.Fecha)>=@Fecha And (tblCuadre.Fecha)<=@Fecha1 AND (tblCuadre.USUARIO=@Nombre)";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();

                comando.Parameters.AddWithValue("@Fecha", fecha1);
                comando.Parameters.AddWithValue("@Fecha1", fecha2);
                comando.Parameters.AddWithValue("@Nombre", usuario);
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdConsultarCliente.DataSource = pr.Tables[0];

                //grdConsultarCliente.Columns[0].Width = 150;
                //grdConsultarCliente.Columns[1].Width = 70;
                //grdConsultarCliente.Columns[2].Width = 70;
                //grdConsultarCliente.Columns[3].Width = 70;


                //grdConsultarCliente.Columns[4].Width = 400;
                //grdConsultarCliente.Columns[5].Width = 300;
                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }



        public void sumarMEGARED()
        {
            usuario = lblUsuario.Text;
            //DateTime fecha1 = Convert.ToDateTime(dtFechaInicial.Value.Date.ToShortDateString());
            //DateTime fecha2 = Convert.ToDateTime(dtFechafinal.Value.Date.ToShortDateString());

            string fecha1 = dtFechaInicial.Text;
            string fecha2 = dtFechafinal.Text;

            try
            {
                string q = "SELECT COMPRA8 AS CONSIGNACIONES_MEGARED FROM TBLCOMPRAS WHERE(TBLCOMPRAS.Fecha)>=@Fecha And (TBLCOMPRAS.Fecha)<=@Fecha1 AND (TBLCOMPRAS.USUARIO=@Nombre)";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();

                comando.Parameters.AddWithValue("@Fecha", fecha1);
                comando.Parameters.AddWithValue("@Fecha1", fecha2);
                comando.Parameters.AddWithValue("@Nombre", usuario);
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdmegared.DataSource = pr.Tables[0];

                grdmegared.Columns[0].Width = 150;
                //grdConsultarCliente.Columns[1].Width = 70;
                //grdConsultarCliente.Columns[2].Width = 70;
                //grdConsultarCliente.Columns[3].Width = 70;


                //grdConsultarCliente.Columns[4].Width = 400;
                //grdConsultarCliente.Columns[5].Width = 300;
                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }
        public void sumartotal()
        {

            double efectivo=0, datafono = 0, compras = 0, gastos = 0, ventassistecredito = 0, ventastiendavirtual = 0, aplicacionanticipos = 0, transferencias = 0,tmegared = 0, totalingresos = 0;

            double caja1=0, caja2=0, caja3=0, caja4=0, caja5=0;
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                efectivo += Convert.ToDouble(row.Cells[6].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                datafono+= Convert.ToDouble(row.Cells[7].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

               compras += Convert.ToDouble(row.Cells[9].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

               gastos += Convert.ToDouble(row.Cells[8].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                ventassistecredito+= Convert.ToDouble(row.Cells[11].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

               ventastiendavirtual += Convert.ToDouble(row.Cells[12].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                aplicacionanticipos += Convert.ToDouble(row.Cells[13].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

               transferencias += Convert.ToDouble(row.Cells[10].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                caja1 += Convert.ToDouble(row.Cells[1].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                caja2 += Convert.ToDouble(row.Cells[2].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                caja3 += Convert.ToDouble(row.Cells[3].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                caja4 += Convert.ToDouble(row.Cells[4].Value);

            }
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                caja5 += Convert.ToDouble(row.Cells[5].Value);

            }
            txtgastos.Text = gastos.ToString("N2");
            txtcompras.Text = compras.ToString("N2");
            txtventasmegared.Text = caja3.ToString("N2");
         
            foreach (DataGridViewRow row in grdmegared.Rows)
            {

                tmegared += Convert.ToDouble(row.Cells[0].Value);

            }
            txtconsignacionesmegared.Text = tmegared.ToString("N2");

            double total1=0,total2=0,sobrante= 0;
            total1= efectivo+ datafono + compras+ gastos + ventassistecredito + ventastiendavirtual- aplicacionanticipos + transferencias;
            total2 = caja1 + caja2 + caja3 + caja4 + caja5;
            sobrante = total1 - total2;
            txtsobrante.Text = sobrante.ToString("N2");
            if (Convert.ToDouble(txtsobrante.Text) < 0)
            {
                lblsobrante.Text = "Faltan";
            }
            if (Convert.ToDouble(txtsobrante.Text) == 0)
            {
                lblsobrante.Text = "Correcto";
            }
            if (Convert.ToDouble(txtsobrante.Text) > 0)
            {
                lblsobrante.Text = "Sobran";
            }
            totalingresos = efectivo + datafono + compras + gastos + ventassistecredito + ventastiendavirtual - aplicacionanticipos + transferencias;
            txtTotal.Text=totalingresos.ToString("N2");
            TXTCAJA.Text = total2.ToString("N2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imprimir_Cuadre_Load(object sender, EventArgs e)
        {
            
            txtsobrante.Text = "0";
            TXTCAJA.Text = "0";
            txtTotal.Text = "0";
            txtventasmegared.Text = "0";
            txtgastos.Text = "0";
            txtcompras.Text = "0";
            txtconsignacionesmegared.Text = "0";
        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
