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
    public partial class ConsultaRepuestos : Form
    {
        DataSet resultados = new DataSet();
      
        OleDbConnection conexion;
        private string user;
        
        public ConsultaRepuestos(string usuario)
        {

            //user =  usuario;
            //user = usuario;
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void ConsultaRepuestos_Load(object sender, EventArgs e)
        {
            user = txtSucrsalt.Text;
            lblSucursal.Text = user;
            txtSucrsalt.SelectedIndex = 0;

        }



        public void sumargrid()
        {

            double sumatoria = 0;
            double sump = 0;
            double sumro = 0;
            double sumrr = 0;
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {


                sumatoria += Convert.ToDouble(row.Cells[4].Value);


            }

            txtSumatoria.Text = sumatoria.ToString();


            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {


                sumrr += Convert.ToDouble(row.Cells[8].Value);


            }

            txttrepuestos.Text = sumrr.ToString();




            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {


                sumro += Convert.ToDouble(row.Cells[10].Value);


            }

            txttrosvaldo.Text = sumro.ToString();

            int cont = 0;
            foreach (DataGridViewRow row in grdConsultarCliente.Rows)
            {

                cont = cont + 1;
                sump += Convert.ToDouble(row.Cells[9].Value);


            }
            cont = cont - 1;
            txtCantidadreloj.Text = cont.ToString();
           



        }
        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarOrdenpt(user);
        }
        public void ConsultarOrdenpt(string sucursal)
        {

            sucursal = txtSucrsalt.Text;
            if (sucursal == "")
            {
                MessageBox.Show("Ingrese el Usuario");
                return;
            }

            string fecha1 = dtFechaInicial.Value.Date.ToShortDateString();

            string fecha2 = dtFechafinal.Value.Date.AddDays(+1).ToShortDateString();

            //string fecha2 = dtFechafinal.Value.Date.ToShortDateString();



            try
            {
                DataSet pr = new DataSet();
                pr.Clear();
                string estado = "";
                string q = "SELECT tblRepuestos.Documento as Orden,tblRepuestos.CodR as Codigo_Reloj,tblRepuestos.Primernombre as Fecha,tblRepuestos.Segundonombre as Marca_reloj,tblRepuestos.Primerapellido as Precio_reparacion,tblRepuestos.Segundoapellido as Persona_que_recibe, tblRepuestos.Nombrecompleto as Tipo_Reparacion, tblRepuestos.Telefono as Plug_Servipilas, tblRepuestos.Telofc as Precio_Repuestos, tblRepuestos.Ext as Pila, tblRepuestos.Direccion as Repuesto_Osvaldo, tblRepuestos.Contacto as Persona_que_Reclama, tblRepuestos.Email as Entrega_Devolucion,tblRepuestos.Repuestorreloj as Repuestos_Reloj,Usuario  FROM tblRepuestos where (tblRepuestos.Fecha_entrega)>=@fecha1 And (tblRepuestos.Fecha_entrega)<=@fecha2 and (tblRepuestos.Usuario)=@Sucursal and Email=@Entrega";
                // AND (tblOrden.Estado)='" + estado + "'"
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@fecha1", fecha1);
                comando.Parameters.AddWithValue("@fecha2", fecha2);
                comando.Parameters.AddWithValue("@Sucursal", sucursal);
                string entrega = "Entrega";
                comando.Parameters.AddWithValue("@Entrega", entrega);

                OleDbDataAdapter ad = new OleDbDataAdapter(comando);

                ad.Fill(pr);
                grdConsultarCliente.DataSource = pr.Tables[0];
                //grdConsultarCliente.Columns[4].Width = 170;
                comando.Connection.Close();


                sumargrid();

               
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSucursal.Text = txtSucrsalt.Text;
            ConsultarOrdenpt(user);
            sumargrid();
           

        }
    }
}



