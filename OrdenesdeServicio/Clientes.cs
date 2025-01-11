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
    public partial class Clientes : Form
    {
        
        DataSet resultados=new DataSet();
        DataView mifiltro;
        OleDbConnection conexion;
        string documento;
        private string iusuario;
        public Clientes(string usuarioi,string doc)
        {
            documento = doc;
            iusuario = usuarioi;
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
            txtNit.Text = documento;
        }





       
        private void Clientes_Load(object sender, EventArgs e)
        {
            txtExt.Visible = false;
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
            this.Consultarcliente("SELECT  tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo, tblCliente.Telefono as Teléfono, tblCliente.Telofc as Teléfono_Oficina, tblCliente.Ext as Extensión, tblCliente.Direccion as Dirección, tblCliente.Contacto, tblCliente.Email  FROM tblCliente", ref resultados, "tblCliente");
            this.mifiltro = ((DataTable)resultados.Tables["tblCliente"]).DefaultView;
            this.grdConsultarCliente.DataSource = mifiltro;
            grdConsultarCliente.Columns[1].Width = 170;
            
            
        }

        

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
           
        }
        public void Mostrarcliente()
        {

            string Documento = txtNit.Text;

            try
            {
                string q = "SELECT  tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo, tblCliente.Telefono as Teléfono, tblCliente.Telofc as Teléfono_Oficina, tblCliente.Ext as Extensión, tblCliente.Direccion as Dirección, tblCliente.Contacto, tblCliente.Email  FROM tblCliente";

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
            txtExt.Text = "";
            txtNit.Focus();
            txtNombreCompleto.Text = "";
            

        }

        public bool InsertarCliente()
        {


         try
            {

                
            string Documento = txtNit.Text;
            string PrimerNombre=txtPrimerNombre.Text;
            string segundonombre=txtSegundoNombre.Text;
            string segundoapellido=txtSegundoApellido.Text;
            string primerapellido=txtPrimerApellido.Text;
            string Telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;
            string Contacto = txtContacto.Text;
            string Email = txtEmail.Text;
            string telofc = txtTelOfc.Text;
            string ext = txtExt.Text;
           // txtNombreCompleto.Text = ""+PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido +"";
            string nombrecompleto = txtNombreCompleto.Text;



            string q = "insert into tblCliente(Documento,Primernombre,Segundonombre,Primerapellido,Segundoapellido,Telefono,Telofc,Ext,Direccion,Contacto,Email,Nombrecompleto) values('" + Documento + "','" + PrimerNombre + "','" + segundonombre + "','" + primerapellido + "','" + segundoapellido + "','" + Telefono + "','" + telofc + "','" + ext + "','" + Direccion + "','" + Contacto + "','" + Email + "','" + nombrecompleto + "')";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
             
                return true;

            }
               
            catch (Exception ex)
            {
                conexion.Close();
                return false;
                MessageBox.Show(ex.Message);
               
             

            }
            
            
        
        }

        private void grdConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char[] delimitador = { '/' };
            txtNit.Text = Convert.ToString(this.grdConsultarCliente.CurrentRow.Cells[0].Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }
        public void reiniciar()
        {
            //this.Close();
            //Clientes cli = new Clientes();
            //cli.Show();
            resultados.Clear();
            this.Consultarcliente("SELECT  tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo, tblCliente.Telefono as Teléfono, tblCliente.Telofc as Teléfono_Oficina, tblCliente.Ext as Extensión, tblCliente.Direccion as Dirección, tblCliente.Contacto, tblCliente.Email  FROM tblCliente", ref resultados, "tblCliente");
            this.mifiltro = ((DataTable)resultados.Tables["tblCliente"]).DefaultView;
            this.grdConsultarCliente.DataSource = mifiltro;
            //Form1 fr = new Form1();
            //fr.llenarordenes();
            //fr.Visible=true;
        }



       


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el documento del cliente");
                return;
            }

            if (InsertarCliente())
            {
                MessageBox.Show("Cliente ingresado con éxito");
                limpiar();
                Mostrarcliente();
                reiniciar();
             
                




            }
            else
            {
                MessageBox.Show("El cliente ya existe");

            }



            
        }

        private void btnNuevaorden_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string Documento = txtNit.Text;

            try
            {
                string q = "delete  tblCliente.* from tblCliente WHERE tblCliente.Documento=@Documento";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Documento", Documento);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                MessageBox.Show("Cliente eliminado con éxito");

                comando.Connection.Close();
                Mostrarcliente();
                limpiar();
                reiniciar();
                limpiar();






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
                MessageBox.Show("Ingrese el documento del cliente");
                return;
            }

            if (InsertarCliente())
            {
                MessageBox.Show("Cliente ingresado con éxito");
                limpiar();
                Mostrarcliente();

            }
            else
            {
                MessageBox.Show("El cliente ya existe");

            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
            if(txtNit.Text=="")
             {
                 MessageBox.Show("Ingrese El documento");
                 return;
             }

             string Documento = txtNit.Text;
            string PrimerNombre=txtPrimerNombre.Text;
            string segundonombre=txtSegundoNombre.Text;
            string segundoapellido=txtSegundoApellido.Text;
            string primerapellido=txtPrimerApellido.Text;
            string Telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;
            string Contacto = txtContacto.Text;
            string Email = txtEmail.Text;
            string telofc = txtTelOfc.Text;
            string ext = txtExt.Text;
           
            string nombrecompleto = txtNombreCompleto.Text;

                string q = "update tblCliente set Nombrecompleto ='" + nombrecompleto + "',Telefono='" + Telefono + "',Telofc='" + telofc + "',Direccion='" + Direccion + "',Email='" + Email + "',Contacto='" + Contacto + "' where Documento=@Documento";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", Documento);


                comando.ExecuteNonQuery();
                comando.Connection.Close();
                MessageBox.Show("Cliente actualizado con éxito");
           

                limpiar();
                Mostrarcliente();
                reiniciar();
                limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void btnConsultarCliente_Click_1(object sender, EventArgs e)
        {

            if (txtNit.Text == "")
            {
                MessageBox.Show("Ingrese el Documento");
                return;
            }




            string documento = txtNit.Text;
            try
            {
                string q = "SELECT * from tblCliente WHERE tblCliente.Documento=@Documento";

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
                    txtExt.Text = dr["Ext"].ToString();
                    txtDireccion.Text = dr["Direccion"].ToString();
                    txtContacto.Text = dr["Contacto"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtNombreCompleto.Text = dr["Nombrecompleto"].ToString();





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
                    MessageBox.Show("Ingrese el Documento");
                    return;
                }




                string documento = txtNit.Text;
                try
                {
                    string q = "SELECT * from tblCliente WHERE tblCliente.Documento=@Documento";

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
                        txtExt.Text = dr["Ext"].ToString();
                        txtDireccion.Text = dr["Direccion"].ToString();
                        txtContacto.Text = dr["Contacto"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                        txtNombreCompleto.Text = dr["Nombrecompleto"].ToString();





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

            try
            {
                string q = "SELECT  tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo, tblCliente.Telefono as Teléfono, tblCliente.Telofc as Teléfono_Oficina, tblCliente.Ext as Extensión, tblCliente.Direccion as Dirección, tblCliente.Contacto, tblCliente.Email  FROM tblCliente";

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
                    salida = "(Documento LIKE '%" + palabra + "%' OR Nombre_completo LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida += "(Documento LIKE '%" + palabra + "%' OR Nombre_completo LIKE '%" + palabra + "%')";
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
                    MessageBox.Show("Ingrese el documento del cliente");
                    return;
                }

                if (InsertarCliente())
                {
                    MessageBox.Show("Cliente ingresado con éxito");
                    limpiar();
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
            txtNombreCompleto.Text = "" + PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido + "";
            
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;
            txtNombreCompleto.Text = "" + PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido + "";
            
        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;
            txtNombreCompleto.Text = "" + PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido + "";
            
        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {
            string PrimerNombre = txtPrimerNombre.Text;
            string segundonombre = txtSegundoNombre.Text;
            string segundoapellido = txtSegundoApellido.Text;
            string primerapellido = txtPrimerApellido.Text;
            txtNombreCompleto.Text = "" + PrimerNombre + " " + segundonombre + " " + primerapellido + " " + segundoapellido + "";
            
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
                    salida = "(Documento LIKE '%" + palabra + "%' OR Nombre_completo LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida += "(Documento LIKE '%" + palabra + "%' OR Nombre_completo LIKE '%" + palabra + "%')";
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

        private void BTNrEGRESAR_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //Form1 clien = new Form1();




            //this.Hide();

            //clien.ShowDialog();
            //this.Close();
        }
    }
}
