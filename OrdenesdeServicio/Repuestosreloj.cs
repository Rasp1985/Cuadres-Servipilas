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
    public partial class Repuestosreloj : Form
    {
        private string user1;
        private string iusuario;
        private string icontraseña;
        private double sumatoria;
        private double PILAST;
        private double PRECIOR;
        private double REPUESTOO;
        private string REPUESTORRELOJ;
        private string fechaentrega;
        public double Sumatoria
        {
            get { return sumatoria; }
            set { sumatoria = value; }
        }
        DataSet resultados = new DataSet();
        DataView mifiltro;
        OleDbConnection conexion;
        private string user;
        public Repuestosreloj(string usuario)
        {
            user = usuario;
            user1 = usuario;
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }



        public void sumargrid()
        {

            sumatoria = 0;
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


        private void Repuestosreloj_Load(object sender, EventArgs e)
        {
            txtfechaentrega.Enabled = false;
            txtfechavendedor.Enabled = false;
            txtvENDEDOR.Enabled = false;
            if (user == "Administrativo")
            {
                user = txtSucrsalt.Text;
                Usuario.Text = user1;
                txtSucrsalt.SelectedIndex = 0;
            }
            else
            {
                Usuario.Text = user;
                btnBorrar.Enabled = false;
                btnIngresar.Enabled = false;
                btnModificar.Enabled = false;
                //btnNuevaorden.Enabled = false;
                txtSucrsalt.Enabled = false;
                lblSucursal.Enabled = false;
                BTNrEGRESAR.Enabled = false;
                button1.Enabled = false;
                btnConsultarRO.Enabled = false;
                imprimirtaller.Enabled = false;
            }




            CodigoReloj.SelectedIndex = 0;
         
            txtTelOfc.Text = "0";
            txtDireccion.Text = "0";
            txtPrimerApellido.Text = "0";
            tolactualizar.SetToolTip(BTNrEGRESAR, "Actualizar");
            toolTip2.SetToolTip(btnModificar, "Modificar Registro");

            toolTip3.SetToolTip(btnNuevaorden, "Nuevo registro");

            toolTip4.SetToolTip(btnBorrar, "Eliminar registro");

            toolTip5.SetToolTip(btnCerrar, "Cerrar");
            toolTip1.SetToolTip(btnIngresar, "Guardar Registro");
            //txtNombreCompleto.Enabled = false;
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;
            //txtNombreCompleto.Text =PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido;
            resultados.Clear();
            this.Consultarcliente("SELECT tblRepuestos.Documento as Orden,tblRepuestos.CodR as Codigo_Reloj,tblRepuestos.Primernombre as Fecha,tblRepuestos.Segundonombre as Marca_reloj,tblRepuestos.Primerapellido as Precio_reparacion,tblRepuestos.Segundoapellido as Persona_que_recibe, tblRepuestos.Nombrecompleto as Tipo_Reparacion, tblRepuestos.Telefono as Plug_Servipilas, tblRepuestos.Telofc as Precio_Repuestos, tblRepuestos.Ext as Pila, tblRepuestos.Direccion as Repuesto_Osvaldo, tblRepuestos.Contacto as Persona_que_Reclama, tblRepuestos.Email as Entrega_Devolucion,Repuestorreloj as Repuestos_Reloj,Fecha_entrega,Usuario  FROM tblRepuestos where Usuario='" + user + "'", ref resultados, "tblRepuestos");
            this.mifiltro = ((DataTable)resultados.Tables["tblRepuestos"]).DefaultView;
            this.grdConsultarCliente.DataSource = mifiltro;
            grdConsultarCliente.Columns[1].Width = 170;

            sumargrid();
        }



        public void Mostrarcliente()
        {

            string Documento = txtNit.Text;

            try
            {
                string q = "SELECT  tblRepuestos.Documento, tblRepuestos.Nombrecompleto as Nombre_Completo, tblRepuestos.Telefono as Teléfono, tblRepuestos.Telofc as Teléfono_Oficina, tblRepuestos.Ext as Extensión, tblRepuestos.Direccion as Dirección, tblRepuestos.Contacto, tblRepuestos.Email,Repuestorreloj as Repuestos_Reloj,Observaciones,Fecha_entrega  FROM tblRepuestos";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdConsultarCliente.DataSource = pr.Tables[0];

                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }




        public void limpiar()
        {
            CodigoReloj.SelectedIndex = 0;
            txtfechaentrega.Text = "";
            txtTelOfc.Text = "0";
            txtDireccion.Text = "0";
            richcaracteristicas.Text = "";
            txtNit.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtSegundoApellido.Text = "";
            txtPrimerApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtContacto.Text = "";
            txtTelOfc.Text = "";
            
            txtNit.Focus();
            txtNombreCompleto.Text = "";
            CodigoReloj.SelectedIndex = 0;
            txtRepuestosreparacion.Text = "";
            txtobservaciones.Text = "";
          

        }

        public bool InsertarCliente()
        {

            try
            {
                if (user1 == "Administrativo")
                {

                    user = txtSucrsalt.Text;
                }

                if (user == "")
                {

                    MessageBox.Show("Ingese el usuario");
                }
                DateTime fechad = DateTime.Now;
                String FECHALARGAj = fechad.ToString("hh:mm tt");
                string fechavendedor = txtfechavendedor.Text;
                string caracteristicas = richcaracteristicas.Text;
                string observaciones = txtobservaciones.Text;
                string Documento = txtNit.Text;
                string PrimerNombre = txtPrimerNombre.Value.Date.ToShortDateString();
                string segundonombre = txtSegundoNombre.Text;
                string segundoapellido = txtSegundoApellido.Text;
                decimal primerapellido = Convert.ToDecimal(txtPrimerApellido.Text);
                string Telefono = txtTelefono.Text;

                DateTime localDate = DateTime.Now;
                string fechae1 = localDate.ToString();
                DateTime fecha = localDate.Date;
           
                string Contacto = txtContacto.Text;
                string Email = txtEmail.Text;
                string VENDEDOR = txtvENDEDOR.Text;
                PILAST = 0;
                PRECIOR = Convert.ToDouble(txtTelOfc.Text);
                REPUESTOO = Convert.ToDouble(txtDireccion.Text);
                REPUESTORRELOJ = txtRepuestosreparacion.Text;
            
                //txtNombreCompleto.Text = "" + PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido + "";
                string nombrecompleto = txtNombreCompleto.Text;
                string codreloj = CodigoReloj.Text;
                


                string q = "insert into tblRepuestos(CodR,Usuario,Documento,Primernombre,Segundonombre,Primerapellido,Segundoapellido,Telefono,Telofc,Ext,Direccion,Contacto,Email,Nombrecompleto,Repuestorreloj,Observaciones,Fecha_entrega,Fecha,Caracteristicas,vendedor,fechavendedor,Fecha_e1) values('" + codreloj + "','" + user + "','" + Documento + "','" + PrimerNombre + "','" + segundonombre + "','" + primerapellido + "','" + segundoapellido + "','" + Telefono + "','" + PRECIOR + "','" + PILAST + "','" + REPUESTOO + "','" + Contacto + "','" + Email + "','" + nombrecompleto + "','" + REPUESTORRELOJ + "','" + observaciones + "','" + fecha + "','" + PrimerNombre + "','" + caracteristicas + "','" + VENDEDOR + "','" + fechavendedor + "','" + fechae1 + "')";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;

            }

            catch (Exception ex)
            {
                conexion.Close();
              
                MessageBox.Show(ex.Message);

                return false;

            }



        }

        private void grdConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char[] delimitador = { '/' };
            txtNit.Text = Convert.ToString(this.grdConsultarCliente.CurrentRow.Cells[0].Value);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        public void reiniciar()
        {
            if (user1 == "Administrativo")
            {

                user = txtSucrsalt.Text;

            }
            else
            {

                user = Usuario.Text;
            }
            if (user == "")
            {

                MessageBox.Show("Ingese el usuario");
            }
            
            resultados.Clear();
            this.Consultarcliente("SELECT tblRepuestos.Documento as Orden,tblRepuestos.CodR as Codigo_Reloj,tblRepuestos.Primernombre as Fecha,tblRepuestos.Segundonombre as Marca_reloj,tblRepuestos.Primerapellido as Precio_reparacion,tblRepuestos.Segundoapellido as Persona_que_recibe, tblRepuestos.Nombrecompleto as Tipo_Reparacion, tblRepuestos.Telefono as Plug_Servipilas, tblRepuestos.Telofc as Precio_Repuestos, tblRepuestos.Ext as Pila, tblRepuestos.Direccion as Repuesto_Osvaldo, tblRepuestos.Contacto as Persona_que_Reclama, tblRepuestos.Email as Entrega_Devolucion,Repuestorreloj as Repuestos_Reloj,Observaciones,Fecha_entrega,Usuario  FROM tblRepuestos where Usuario='" + user + "'", ref resultados, "tblRepuestos");
            this.mifiltro = ((DataTable)resultados.Tables["tblRepuestos"]).DefaultView;
            this.grdConsultarCliente.DataSource = mifiltro;

        }






        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el número de orden");
                return;
            }
            if (txtSegundoNombre.Text == "")
            {
                MessageBox.Show("Ingrese la marca y la referencia del reloj");
                return;
            }
            if (user1 == "Administrativo")
            {

                user = txtSucrsalt.Text;
            }

            if (user == "")
            {

                MessageBox.Show("Ingese el usuario");
            }




            if (OrdenexisteModificar() == true)
            {
                MessageBox.Show("El Número de orden y el Código del reloj ya estan registrados");
                return;
              
            }
     
            




                if (InsertarCliente())
                {
                    MessageBox.Show("Repuesto ingresado con éxito");

                    //limpiar();
                    reiniciar();
                    sumargrid();



                }
                else
                {
                    MessageBox.Show("Valida los datos de una orden que exista");
                    return;

                }

            limpiar();
            txtPrimerApellido.Text = "0";
            txtTelOfc.Text = "0";
            txtDireccion.Text = "0";



        }

        private void btnNuevaorden_Click(object sender, EventArgs e)
        {
            limpiar();
            txtPrimerApellido.Text="0";
            txtTelOfc.Text = "0";
            txtDireccion.Text = "0";
            //txtSucrsalt.SelectedIndex = 0;
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {

            if (user1 == "Administrativo")
            {

                user = txtSucrsalt.Text;
            }

            if (user == "")
            {

                MessageBox.Show("Ingese el usuario");
            }
            string Documento = txtNit.Text;
            string codoreloj = CodigoReloj.Text;

            try
            {
                string q = "delete  tblRepuestos.* from tblRepuestos WHERE tblRepuestos.Documento=@Documento and tblRepuestos.CodR=@codreloj and tblRepuestos.Usuario=@Usuario";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Documento", Documento);
                comando.Parameters.AddWithValue("@codreloj", codoreloj);
                comando.Parameters.AddWithValue("@Usuario", user);



                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                MessageBox.Show("Repuesto eliminado con éxito");

                comando.Connection.Close();


                reiniciar();

                sumargrid();


                limpiar();
                txtPrimerApellido.Text = "0";
                txtTelOfc.Text = "0";
                txtDireccion.Text = "0";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el número de orden");
                return;
            }

            if (InsertarCliente())
            {
                MessageBox.Show("Repuesto ingresado con éxito");

                reiniciar();
                sumargrid();

            }
            else
            {
                MessageBox.Show("El repuesto ya existe");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtNit.Text == "")
                {

                    return;
                }
                if (user1 == "Administrativo")
                {

                    user = txtSucrsalt.Text;
                }

                if (user == "")
                {

                    MessageBox.Show("Ingese el usuario");
                }
                string caracteristicas = richcaracteristicas.Text;
                string observaciones = txtobservaciones.Text;
                string Documento = txtNit.Text;
                string PrimerNombre = txtPrimerNombre.Value.Date.ToShortDateString(); 
                string segundonombre = txtSegundoNombre.Text;
                string segundoapellido = txtSegundoApellido.Text;
                decimal primerapellido = Convert.ToDecimal(txtPrimerApellido.Text);
                string Telefono = txtTelefono.Text;
                DateTime fechad = DateTime.Now;
                String FECHALARGAj = fechad.ToString("hh:mm tt");
                PRECIOR = Convert.ToDouble(txtTelOfc.Text);
                REPUESTOO = Convert.ToDouble(txtDireccion.Text);
                REPUESTORRELOJ = txtRepuestosreparacion.Text;
                string Contacto = txtContacto.Text;
                string Email = txtEmail.Text;

                string fechaentgraga = txtfechaentrega.Text;
                DateTime localDate = DateTime.Now;
            string fechae1 = txtfechaentrega.Text;
                DateTime fecha = localDate.Date;
              
                if (txtEmail.Text == "Entrega" || txtEmail.Text == "Devolución")
                {
                    fechaentgraga = fecha.ToString();
                    fechae1 = localDate.ToString();

                }
             
                  


                
                string codireloj = CodigoReloj.Text;
                string nombrecompleto = txtNombreCompleto.Text;

                string q = "update tblRepuestos set Primernombre='" + PrimerNombre + "',Segundonombre='" + segundonombre + "',Primerapellido='" + primerapellido + "',Segundoapellido='" + segundoapellido + "',Telefono='" + Telefono + "',Telofc='" + PRECIOR + "',Ext='" + PILAST + "',Direccion='" + REPUESTOO + "',Contacto='" + Contacto + "',Email='" + Email + "',Nombrecompleto='" + nombrecompleto + "', Repuestorreloj='" + REPUESTORRELOJ + "',Observaciones ='" + observaciones + "',Fecha_entrega ='" + fechaentgraga + "',Fecha ='" + PrimerNombre + "',Caracteristicas ='" + caracteristicas + "',Fecha_e1 ='" + fechae1 + "' where Documento=@Documento and Usuario=@Usuario and CodR=@codreloj";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", Documento);
                comando.Parameters.AddWithValue("@Usuario", user);
                comando.Parameters.AddWithValue("@codreloj", codireloj);





                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Orden actualizada con éxito");




                reiniciar();
                sumargrid();
                limpiar();
                txtPrimerApellido.Text = "0";
                txtTelOfc.Text = "0";
                txtDireccion.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (user1 == "Administrativo")
            {

                user = txtSucrsalt.Text;
                if (user == "")
                {

                    MessageBox.Show("Ingese el usuario");
                }
            }
            else
            {

                user = Usuario.Text;
            }







            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el número de orden");
                return;
            }

            string codreloj = CodigoReloj.Text;


            string documento = txtNit.Text;
            try
            {
                string q = "SELECT * from tblRepuestos WHERE (tblRepuestos.Documento=@Documento and tblRepuestos.Usuario=@Usuario and tblRepuestos.CodR=@CodReloj)";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);
                comando.Parameters.AddWithValue("@Usuario", user);
                comando.Parameters.AddWithValue("@CodReloj", codreloj);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtPrimerNombre.Text = dr["Primernombre"].ToString();
                    txtSegundoNombre.Text = dr["Segundonombre"].ToString();
                    txtPrimerApellido.Text = dr["Primerapellido"].ToString();
                    txtSegundoApellido.Text = dr["Segundoapellido"].ToString();
                    txtTelefono.Text = dr["Telefono"].ToString();
                    txtTelOfc.Text = dr["Telofc"].ToString();
                  
                    txtDireccion.Text = dr["Direccion"].ToString();
                    txtContacto.Text = dr["Contacto"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtNombreCompleto.Text = dr["Nombrecompleto"].ToString();
                    CodigoReloj.Text = dr["CodR"].ToString();
                    txtRepuestosreparacion.Text = dr["Repuestorreloj"].ToString();
                    txtobservaciones.Text = dr["Observaciones"].ToString();
                  
                    richcaracteristicas.Text = dr["Caracteristicas"].ToString();
                    txtvENDEDOR.Text = dr["vendedor"].ToString();
                    txtfechavendedor.Text = dr["fechavendedor"].ToString();

                    txtfechaentrega.Text = dr["Fecha_e1"].ToString();


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

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtNit.Text == "")
                {
                    MessageBox.Show("Ingrese el número de orden");
                    return;
                }




                string documento = txtNit.Text;
                try
                {
                    string q = "SELECT * from tblRepuestos WHERE tblRepuestos.Documento=@Documento";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@Documento", documento);

                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        txtPrimerNombre.Text = dr["Primernombre"].ToString();
                        txtSegundoNombre.Text = dr["Segundonombre"].ToString();
                        txtPrimerApellido.Text = dr["Primerapellido"].ToString();
                        txtSegundoApellido.Text = dr["Segundoapellido"].ToString();
                        txtTelefono.Text = dr["Telefono"].ToString();
                        txtTelOfc.Text = dr["Telofc"].ToString();
                       
                        txtDireccion.Text = dr["Direccion"].ToString();
                        txtContacto.Text = dr["Contacto"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                        txtNombreCompleto.Text = dr["Nombrecompleto"].ToString();
                        txtRepuestosreparacion.Text = dr["Repuestorreloj"].ToString();
                        txtobservaciones.Text = dr["Observaciones"].ToString();
                        fechaentrega = dr["Fecha_entrega"].ToString();



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
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }



        public void Consultarcliente(string query, ref DataSet dsprincipal, string tabla)
        {

            string Documento = txtNit.Text;
            user = txtSucrsalt.Text;
            try
            {
                string q = "SELECT  tblRepuestos.Documento, tblRepuestos.Nombrecompleto as Nombre_Completo, tblRepuestos.Telefono as Teléfono, tblRepuestos.Telofc as Teléfono_Oficina, tblRepuestos.Ext as Extensión, tblRepuestos.Direccion as Dirección, tblRepuestos.Contacto, tblRepuestos.Email, tblRepuestos.Repuestorreloj,tblRepuestos.Observaciones,tblRepuestos.Fecha_entrega  FROM tblRepuestos";

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

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                string salida = "";
                string[] palabrasb = this.txtBuscar.Text.Split(' ');
                foreach (string palabra in palabrasb)
                {
                    if (salida.Length == 0)
                    {
                        salida = "(Orden LIKE '%" + palabra + "%' OR Fecha LIKE '%" + palabra + "%')";
                    }
                    else
                    {
                        salida += "(Orden LIKE '%" + palabra + "%' OR Fecha '%" + palabra + "%')";
                    }
                    this.mifiltro.RowFilter = salida;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtNit.Text == "")
                {
                    MessageBox.Show("Ingrese el número de orden");
                    return;
                }

                if (InsertarCliente())
                {
                    MessageBox.Show("Ingrese el número de orden");

                    Mostrarcliente();
                    reiniciar();


                }
                else
                {
                    MessageBox.Show("El cliente ya existe");

                }

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;

        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;

        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;

        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;

        }

        private void grdConsultarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            char[] delimitador = { '/' };
            txtNit.Text = Convert.ToString(this.grdConsultarCliente.CurrentRow.Cells[0].Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }





        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                string salida = "";
                string[] palabrasb = this.txtBuscar.Text.Split(' ');
                foreach (string palabra in palabrasb)
                {
                    if (salida.Length == 0)
                    {
                        salida = "(Orden LIKE '%" + palabra + "%' OR Fecha LIKE '%" + palabra + "%')";
                    }
                    else
                    {
                        salida += "(Orden LIKE '%" + palabra + "%' OR Fecha '%" + palabra + "%')";
                    }
                    this.mifiltro.RowFilter = salida;
                }

                sumargrid();

            }

            catch (Exception ex)
            {
                MessageBox.Show("No dejes espacios");
                conexion.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }









        private bool OrdenexisteModificar()

        {

            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese una orden que exista");

                return false;
            }
            string codreloj = CodigoReloj.Text;
            user = txtSucrsalt.Text;
            string id = txtNit.Text;
            string query = "SELECT COUNT(*) FROM tblRepuestos WHERE Documento=@Id and CodR=@Codr and Usuario=@Usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Codr", codreloj);
            cmd.Parameters.AddWithValue("@Usuario", user);
            cmd.Connection.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                
                cmd.Connection.Close();
                return false;

            }
            cmd.Connection.Close();
            return true;
        }













        private bool Ordenexiste()

        {

            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese una orden que exista");

                return false;
            }
            string codreloj = CodigoReloj.Text;
            user = txtSucrsalt.Text;
            string id = txtNit.Text;
            string query = "SELECT COUNT(*) FROM tblDetalleOrden WHERE Codigo=@Id and Codigo_r=@Codr and Usuario=@Usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Codr", codreloj);
            cmd.Parameters.AddWithValue("@Usuario", user);
            cmd.Connection.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("Ingrese una orden que exista");
                cmd.Connection.Close();
                return false;

            }
            cmd.Connection.Close();
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Ordenexiste() == false)
            {

                return;

            }
            else
            {

                if (txtNit.Text == "")
                {
                    MessageBox.Show("Ingrese el número de orden");
                    return;
                }

                string codreloj = CodigoReloj.Text;
                user = txtSucrsalt.Text;

                string documento = txtNit.Text;
                try
                {
                    string q = "SELECT * FROM tblOrden INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo WHERE (tblDetalleOrden.Codigo=@Documento and tblDetalleOrden.Usuario=@Usuario and tblDetalleOrden.Codigo_r=@CodReloj)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@Codigo", documento);
                    comando.Parameters.AddWithValue("@Usuario", user);
                    comando.Parameters.AddWithValue("@CodReloj", codreloj);

                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        txtNit.Text = dr["Codigo"].ToString();
                        CodigoReloj.Text = dr["Codigo_r"].ToString();
                        txtSegundoNombre.Text = dr["Referencia"].ToString();
                        txtPrimerApellido.Text = dr["Valor"].ToString();
                        txtTelefono.Text = dr["Codigo_p"].ToString();
                        richcaracteristicas.Text = dr["Caracteristicas"].ToString();
                        txtobservaciones.Text = dr["Observacionesr"].ToString();
                        txtfechavendedor.Text = dr["Fecha"].ToString();
                        txtvENDEDOR.Text = dr["Vendedor"].ToString();

                        //CodigoReloj.Text = dr["CodR"].ToString();






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
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            ConsultaRepuestos rep = new ConsultaRepuestos(user);
            rep.Show();
        }

        private void txtSucrsalt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSucursal.Text = txtSucrsalt.Text;
            reiniciar();
            sumargrid();
        }

        private void btnConsultarRO_Click(object sender, EventArgs e)
        {
            ConsultaRepuestos rep = new ConsultaRepuestos(user);
            rep.Show();
        }












        public void acceso(string usuario, string contraseña)
        {
            iusuario = usuario;
            icontraseña = contraseña;


        }

        private void BTNrEGRESAR_Click(object sender, EventArgs e)
        {
            this.Refresh();
            reiniciar();
            sumargrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtNit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (user1 == "Administrativo")
                {

                    user = txtSucrsalt.Text;
                    if (user == "")
                    {

                        MessageBox.Show("Ingese el usuario");
                    }
                }
                else
                {

                    user = Usuario.Text;
                }







                if (txtNit.Text == "")
                {
                    MessageBox.Show("Ingrese el número de orden");
                    return;
                }

                string codreloj = CodigoReloj.Text;


                string documento = txtNit.Text;
                try
                {
                    string q = "SELECT * from tblRepuestos WHERE (tblRepuestos.Documento=@Documento and tblRepuestos.Usuario=@Usuario and tblRepuestos.CodR=@CodReloj)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@Documento", documento);
                    comando.Parameters.AddWithValue("@Usuario", user);
                    comando.Parameters.AddWithValue("@CodReloj", codreloj);

                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        txtPrimerNombre.Text = dr["Primernombre"].ToString();
                        txtSegundoNombre.Text = dr["Segundonombre"].ToString();
                        txtPrimerApellido.Text = dr["Primerapellido"].ToString();
                        txtSegundoApellido.Text = dr["Segundoapellido"].ToString();
                        txtTelefono.Text = dr["Telefono"].ToString();
                        txtTelOfc.Text = dr["Telofc"].ToString();
                  
                        txtDireccion.Text = dr["Direccion"].ToString();
                        txtContacto.Text = dr["Contacto"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                        txtNombreCompleto.Text = dr["Nombrecompleto"].ToString();
                        CodigoReloj.Text = dr["CodR"].ToString();
                        txtRepuestosreparacion.Text = dr["Repuestorreloj"].ToString();
                        txtobservaciones.Text = dr["Observaciones"].ToString();
                    
                        richcaracteristicas.Text = dr["Caracteristicas"].ToString();
                        txtvENDEDOR.Text = dr["vendedor"].ToString();
                        txtfechavendedor.Text = dr["fechavendedor"].ToString();
                        txtfechaentrega.Text = dr["Fecha_e1"].ToString();


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

        }

        private void imprimirtaller_Click(object sender, EventArgs e)
        {
            string consecutivo = "";
            Imprimir imp = new Imprimir(txtSucrsalt.Text,consecutivo);
            imp.Show();

           

        }

        private void txtPrimerApellido_TextChanged_1(object sender, EventArgs e)
        {
            {
             
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            reiniciar();
        }

 
    }

}
