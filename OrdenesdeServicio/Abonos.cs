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
    public partial class Abonos : Form
    {
        DataSet resultados = new DataSet();
        DataView mifiltro;
        OleDbConnection conexion;
        private string user;

        private string documento;











            public Abonos(string sucursal,string documentoa)
        {
            documento = documentoa;
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
       
            InitializeComponent();
            user = sucursal;
            lblSu.Text = user;
        }
        
        public void Consultarcliente(string query, ref DataSet dsprincipal, string tabla)
        {
            
            
            try
            {
                resultados.Clear();
                
                string q = "SELECT  Abono.id as Codigo,tblCliente.Documento,tblCliente.Nombrecompleto as Nombre_completo, Abono.Fecha, Abono.Abono FROM tblCliente INNER JOIN Abono ON tblCliente.Documento = Abono.Consecutivo WHERE(((Abono.Usuario) = '" + user + "'))";

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
                return;


            }



        }

    


public void reiniciar()
        {
            try
            {

                resultados.Clear();
            this.Consultarcliente("SELECT  Abono.id as Codigo,tblCliente.Documento,tblCliente.Nombrecompleto as Nombre_completo, Abono.Fecha, Abono.Abono,Abono.Estado As Estado FROM tblCliente INNER JOIN Abono ON tblCliente.Documento = Abono.Consecutivo WHERE(((Abono.Usuario) = '" + user + "')) order by Abono.Fecha desc", ref resultados, "Abono");
            this.mifiltro = ((DataTable)resultados.Tables["Abono"]).DefaultView;
            this.grdConsultarAbono.DataSource = mifiltro;
                this.grdConsultarAbono.Columns[2].Width = 150;
                this.grdConsultarAbono.Columns[5].Width = 200;
                //Form1 fr = new Form1();
                //fr.llenarordenes();
                //fr.Visible=true;
            }
            

            catch (Exception ex)
            {
                conexion.Close();
             
                MessageBox.Show(ex.Message);



            }
        }
        private void Abonos_Load(object sender, EventArgs e)
        {
            txtConsecutivo.Text = documento;
            reiniciar();
           
        }

        

        private void abonos()
        {
            try
            {


                string Documento = txtConsecutivo.Text;
                decimal abono = Convert.ToDecimal(txtAbono.Text);


                DateTime localDate = DateTime.Now;
                DateTime fecha = localDate.Date;


                string q = "insert into Abono (Consecutivo,Abono,Fecha,Usuario) values('" + Documento + "','" + abono.ToString("N2") + "','" + fecha + "','" + lblSu.Text + "')";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();


                MessageBox.Show("Abono ingresado con éxito");
              


                reiniciar();
            }

            catch (Exception ex)
            {
                conexion.Close();
             
                MessageBox.Show(ex.Message);



            }

        }
        private void limpiarabono()
        {
            txtAbono.Text ="0";
            lblCliente.Text = "";
            txtConsecutivo.Text = "";


        }
      
        private bool clienteexiste()

        {

            if (txtConsecutivo.Text == "")
            {
                MessageBox.Show("Ingrese un cliente que exista");

                return false;
            }

            string id = txtConsecutivo.Text;
            string query = "SELECT COUNT(*) FROM sumaabono WHERE Documento=@Id";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IForm formInterface = this.Owner as IForm;

            if (formInterface != null)
                formInterface.ChangeTextBoxText(txtAbono.Text);




            abonos();
            if (clienteexiste() == false)
            {

                try
                {


                    string Documento = txtConsecutivo.Text;
                    decimal abono = Convert.ToDecimal(txtAbono.Text);


              
                    string q = "insert into sumaabono(Documento,Abono) values('" + Documento + "','" + abono.ToString("N2") + "')";

                    OleDbCommand comando = new OleDbCommand(q, conexion);



                    comando.Connection.Open();
                    comando.ExecuteNonQuery();
                    comando.Connection.Close();


                  



                }

                catch (Exception ex)
                {
                    conexion.Close();

                    MessageBox.Show(ex.Message);
                    return;


                }


            }
            else
            {



                try
                {


                    string Documento = txtConsecutivo.Text;
                    decimal abono = Convert.ToDecimal(txtAbono.Text);



                    string q = "update sumaabono set Abono=Abono+'" + abono.ToString("N2") + "' where Documento='" + Documento + "' ";

                    OleDbCommand comando = new OleDbCommand(q, conexion);



                    comando.Connection.Open();
                    comando.ExecuteNonQuery();
                    comando.Connection.Close();






                }

                catch (Exception ex)
                {
                    conexion.Close();

                    MessageBox.Show(ex.Message);

                    return;

                }
            }

            limpiarabono();
          
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (txtConsecutivo.Text == "")
            {
                MessageBox.Show("Ingrese el Documento");
                return;
            }


           
            string documento = txtConsecutivo.Text;
            try
            {
                string q = "SELECT tblCliente.Nombrecompleto FROM tblCliente  WHERE(((tblCliente.Documento) = @Documento))";




                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);
               
      

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                 
                    lblCliente.Text = dr["Nombrecompleto"].ToString();





                }
                dr.Close();

                comando.Connection.Close();
                reiniciar();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void txtbuscarorden_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string salida = "";
                string[] palabrasb = this.txtbuscarorden.Text.Split(' ');
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
               
            }
        }

        private void BTNrEGRESAR_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtConsecutivo.Text == "")
            {
                MessageBox.Show("Ingrese el Documento");
                return;
            }
               


                string documento = txtConsecutivo.Text;
            try
            {
                string q = "SELECT tblCliente.Nombrecompleto FROM tblCliente  WHERE(((tblCliente.Documento) = @Documento))";




                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);



                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {


                    lblCliente.Text = dr["Nombrecompleto"].ToString();


                }
                dr.Close();

                comando.Connection.Close();
                reiniciar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string docus = "";
          
            string docu = txtConsecutivo.Text;
            double ValorAbono = 0;
            
            try
            {
                if (docu=="")
                {
                    MessageBox.Show("Ingrese el consecutivo del Abono");
                    return;
                }
                string q = "SELECT * FROM abono  WHERE(((abono.id) = @Documento))";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", docu);

  
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    ValorAbono = double.Parse(dr["Abono"].ToString());
                    txtAbono.Text = ValorAbono.ToString();
                    docus = dr["Consecutivo"].ToString();
                    if (ValorAbono <1)
                    {
                        MessageBox.Show("El Abono ya fué anulado");
                        return;
                    }
                }
                dr.Close();

                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }


            try
            {
                if (docus == ""|| docus ==null)
                {
                    MessageBox.Show("Revise que el Abono exista");
                    return;
                }

                string Documentof = txtConsecutivo.Text;
                decimal abono = Convert.ToDecimal(txtAbono.Text);



                string q = "update sumaabono set Abono=Abono-'" + abono.ToString("N2") + "' where Documento='" + docus+ "' ";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();






            }

            catch (Exception ex)
            {
                conexion.Close();

                MessageBox.Show(ex.Message);

                return;

            }


            string Documento = txtConsecutivo.Text;

            try
            {
                string Anulado= "Anulado "+ValorAbono.ToString("C0")+" "+DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                string q = "update Abono set Estado='" + Anulado+ "', Abono=0  WHERE Abono.id=@Documento";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Documento", Documento);
                

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                MessageBox.Show("Abono anulado con éxito");

                comando.Connection.Close();
                IForm formInterface = this.Owner as IForm;

                if (formInterface != null)
                    formInterface.ChangeTextBoxText("0");

                limpiarabono();

                reiniciar();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }



          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                abonos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string documentot = "";
            string nombreabono="";
            if (txtConsecutivo.Text=="")
            {
                MessageBox.Show("Debe ingresar el consecutivo de Abono");
            }

            string docus = txtConsecutivo.Text;

            string docu = "";
           
            try
            {
                string q = "SELECT * FROM abono  WHERE(((abono.id) = @Documento))";




                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", docus);



                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    documentot = dr["Consecutivo"].ToString();
                    docu = dr["Abono"].ToString();





                }
                dr.Close();

                comando.Connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
            try
            {
                string q = "SELECT tblCliente.Nombrecompleto FROM tblCliente  WHERE(((tblCliente.Documento) = @Documento))";




                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documentot);



                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {


                    nombreabono = dr["Nombrecompleto"].ToString();





                }
                dr.Close();

                comando.Connection.Close();
                reiniciar();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
            try
            {


                DateTime fechad = DateTime.Now;

            String FECHALARGAj = fechad.ToString();






    
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ///*  ticket.AbreCajon();//*/Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("SERVIPILAS");
            ticket.TextoCentro("SOMOS SU ENERGIA");
            ticket.TextoCentro("");
          

            ticket.TextoIzquierda("FECHA.....:" + FECHALARGAj);
            ticket.TextoIzquierda("CONSECUTIVO ABONO...:" + docus);
            ticket.TextoIzquierda("PUNTO DE VENTA...:" +user );
                ticket.TextoIzquierda("DOCUMENTO...:" + documentot);
                ticket.TextoIzquierda("DOCUMENTO...:" + nombreabono);
                ticket.lineasGuio();
            ticket.TextoIzquierda("ABONO...:" +docu );
            ticket.lineasGuio();

                ticket.TextoCentro("PBX: 444 08 01");
                ticket.TextoCentro("E-MAIL:INFO@SERVIPILAS.COM");
                ticket.TextoCentro("WWW.SERVIPILAS.COM");


                ticket.lineasGuio();
                //ticket.TextoCentro("");
                ticket.TextoCentro("");

                ticket.TextoCentro("");
                ticket.TextoCentro("");
                ticket.TextoCentro("");
                ticket.TextoCentro("");
                ticket.CortaTicket();
                string usu = "";
            string iusuario = user;

                if (iusuario == "La Central")
                {
                    usu = "\\\\10.10.2.200\\PRINT";
                }
                if (iusuario == "San Diego")
                {
                    usu = "\\\\10.10.3.20\\impre";
                }
                if (iusuario == "Molinos")
                {
                    usu = "\\\\10.10.4.202\\printmo";
                }
                if (iusuario == "Mayorca")
                {
                    usu = "\\\\10.10.1.200\\generic2";
                }
                if (iusuario == "Puerta del Norte")
                {
                    usu = "\\\\10.10.8.253\\PRINT";
                }
                ticket.ImprimirTicket(usu);

 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}



