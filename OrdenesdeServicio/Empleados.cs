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
    public partial class Empleados : Form
    {

        DataSet resultados = new DataSet();
        DataView mifiltro;
        OleDbConnection conexion;
        public Empleados()
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el documento del Empleado");
                return;
            }

            if (InsertarCliente())
            {
                MessageBox.Show(" Empleado ingresado con éxito");
                //limpiar();
                //Mostrarcliente();
                reiniciar();


                limpiar();


            }
            else
            {
                MessageBox.Show("El Empleado ya existe");

            }
        }

        public void limpiar()
        {
            txtNit.Text = "";
 
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
      
            txtTelOfc.Text = "";
      
            txtNit.Focus();
            txtNombreCompleto.Text = "";

        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            reiniciar();
        }
        public void Consultarcliente(string query, ref DataSet dsprincipal, string tabla)
        {

            string Documento = txtNit.Text;

            try
            {
                string q = "SELECT  tblVendedor.id as Documento, tblVendedor.Vendedor as Nombre_Completo, tblVendedor.Telefono as Teléfono, tblVendedor.Celular,tblVendedor.Direccion as Dirección,tblVendedor.Email  FROM tblVendedor";

                OleDbCommand comando = new OleDbCommand(query, conexion);
                comando.Connection.Open();


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(dsprincipal, tabla);
                ad.Dispose();
                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }


        public void reiniciar()
        {
            //this.Close();
            //Clientes cli = new Clientes();
            //cli.Show();
            resultados.Clear();
            this.Consultarcliente("SELECT  tblVendedor.Id as Documento, tblVendedor.Vendedor as Nombre_Completo, tblVendedor.Telefono as Teléfono, tblVendedor.Celular, tblVendedor.Direccion as Dirección, tblVendedor.Email  FROM tblVendedor", ref resultados, "tblVendedor");
            this.mifiltro = ((DataTable)resultados.Tables["tblVendedor"]).DefaultView;
            this.grdConsultarCliente.DataSource = mifiltro;
            //Form1 fr = new Form1();
            //fr.llenarordenes();
            //fr.Visible=true;
        }


        public bool InsertarCliente()
        {


            try
            {


                string Documento = txtNit.Text;
          
                string Telefono = txtTelefono.Text;
                string Direccion = txtDireccion.Text;
                
                string Email = txtEmail.Text;
                string telofc = txtTelOfc.Text;
               
                // txtNombreCompleto.Text = ""+PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido +"";
                string nombrecompleto = txtNombreCompleto.Text;



                string q = "insert into tblVendedor(Id,Vendedor,Telefono,Celular,Direccion,Email) values('" + Documento + "','" + nombrecompleto + "','" + Telefono + "','" + telofc + "','" + Direccion + "','" + Email + "')";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return false;
               



            }

        }
        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {

            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el Documento");
                return;
            }




            string documento = txtNit.Text;
            try
            {
                string q = "SELECT * from tblVendedor WHERE tblVendedor.Id=@Documento";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

    
                    txtTelefono.Text = dr["Telefono"].ToString();
                    txtTelOfc.Text = dr["Telofc"].ToString();

                    txtDireccion.Text = dr["Direccion"].ToString();

                    txtEmail.Text = dr["Email"].ToString();
                    txtNombreCompleto.Text = dr["Vendedor"].ToString();





                }
                dr.Close();

                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNit.Text == "")
                {
                    MessageBox.Show("Ingrese El documento del vendedor");
                    return;
                }

                string Documento = txtNit.Text;
     
                string Telefono = txtTelefono.Text;
                string Direccion = txtDireccion.Text;

                string Email = txtEmail.Text;
                string telofc = txtTelOfc.Text;
      
                string nombrecompleto = txtNombreCompleto.Text;

                string q = "update tblvendedor set Vendedor='" + nombrecompleto+ "',Telefono='" + Telefono + "',Celular='" + telofc + "',Direccion='" + Direccion + "',Email='" + Email + "'  where tblVendedor.Id=@Documento";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", Documento);


                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Vendedor actualizado con éxito");

                reiniciar();
                limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string Documento = txtNit.Text;

            try
            {
                string q = "delete  tblVendedor.* from tblVendedor WHERE tblVendedor.Id=@Documento";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Documento", Documento);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                MessageBox.Show("Vendedor eliminado con éxito");

                comando.Connection.Close();
      
                limpiar();
                reiniciar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void btnNuevaorden_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
