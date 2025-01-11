using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Diagnostics;




namespace OrdenesdeServicio
{





    
    public partial class Form1 : Form,IForm

    {
        
        private int Contador;
        private int cont;   
        private string stringToPrint;
      
    
        DataSet resultados = new DataSet();
        private string Telefono;
        private string Celular;
        private string Contacto;
      
        DataSet resultados1 = new DataSet();
   
        OleDbConnection conexion;
        private string iusuario;
        private string icontraseña;
        private string nomc;
  
        private string consecutivo;
        private string caracteristicas;
        private string documentoc;
        private string doc;
        public static Form1 f1;
       
   
       
        public DataGridViewTriState WrapMode { get; set; }
        public Form1(string USER)
        {
           
            iusuario = USER;
            this.Refresh();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
            txtcRelog.Text ="1";

        

        }
        #region IForm Members

        public void ChangeTextBoxText(string text)
        {
            txtCabonos.Text= text;
        }
        #endregion


        public void acceso(string usuario, string contraseña)
        {
            iusuario = usuario;
            icontraseña = contraseña;
            lblUsuario.Text = usuario;

        }




        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Clientes cli = new Clientes(iusuario,txtDocumento.Text);
            cli.Show();


          


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
                CboVendedor.DataSource = pr;
                CboVendedor.DisplayMember = "tblvendedor";
                CboVendedor.ValueMember = "Vendedor";

                comando.Connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }


        }


      

        private void consultarIMPRIMIR()
        {

            try
            {
                consecutivo = txtDocumento.Text;
                //string q = "SELECT tblCliente.Documento,tblCliente.Nombrecompleto, tblOrden.Consecutivo, tblOrden.Usuario FROM tblCliente INNER JOIN tblOrden ON tblCliente.[Documento] = tblOrden.[Documento] WHERE(((tblOrden.Consecutivo) = @Documento) AND((tblOrden.Usuario) = @Document))";

                string q = "SELECT Documento,Telefono,Telofc,Nombrecompleto,Contacto FROM tblCliente WHERE((tblCliente.Documento) = @Documento)";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", consecutivo);
                //comando.Parameters.AddWithValue("@Document", iusuario);


                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                   
                    documentoc = dr["Documento"].ToString();
                    caracteristicas = dr["Nombrecompleto"].ToString();
                    Telefono = dr["Telefono"].ToString();
                   Celular = dr["Telofc"].ToString();
                   Contacto = dr["Contacto"].ToString();
                    

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
        public void cortarticket()
        {
            
     
        string GS = Convert.ToString((char)29);
        string ESC = Convert.ToString((char)27);

        string COMMAND = "";
        COMMAND = ESC + "@";
        COMMAND += GS + "V" + (char)1;


        PrintDialog pd = new PrintDialog();
                    pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
            RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName,  COMMAND);
            }


        }

   

        public void CREARTICKET()
        {
            if (iusuario == "La Central" || iusuario == "San Diego" || iusuario == "Molinos" || iusuario == "Mayorca" || iusuario == "Puerta del Norte")
            {
                consultarIMPRIMIR();
                DateTime fechad = DateTime.Now;

                String FECHALARGAj = fechad.ToString("hh:mm tt");

                String FECHALARGA = fechad.Date.ToShortDateString();
                FECHALARGA = FECHALARGA + " " + FECHALARGAj;





                string codigoo, codigor, plug;
                codigoo = txtCodigo.Text;
                plug = txtPlug.Text;
                codigor = txtcRelog.Text;
                int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
                string Documento = txtDocumento.Text;
                decimal total = Convert.ToDecimal(txtTotal.Text);
                String VENDEDOR = CboVendedor.Text;
                string fecha = dtFecha.Value.Date.ToShortDateString();
                string fechaentrega = dtfechaentrega.Value.Date.ToShortDateString();
                string robservaciones = txtCodigo.Text;
                decimal abono = Convert.ToDecimal(txtCabonos.Text);
                //Creamos una instancia d ela clase CrearTicket
                CrearTicket ticket = new CrearTicket();
                //Ya podemos usar todos sus metodos
                ///*  ticket.AbreCajon();//*/Para abrir el cajon de dinero.

                //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

                //Datos de la cabecera del Ticket.
                ticket.TextoCentro("SERVIPILAS");
                ticket.TextoCentro("ORDEN DE SERVICIO");
                ticket.TextoCentro("");
                ticket.TextoCentro("DOCUMENTO NO VALIDO COMO FACTURA");
                ticket.TextoCentro("DE COMPRA");
                ticket.lineasGuio();

                ticket.TextoIzquierda("FECHA.....:" + FECHALARGA);
                ticket.TextoIzquierda("PUNTO DE VENTA...:" + iusuario);
                ticket.TextoIzquierda("ORDEN NRO...:" + Consecutivo);
                ticket.TextoIzquierda("DOCUMENTO...:" + documentoc);
                ticket.TextoIzquierda("CLIENTE.....:" + caracteristicas);
                ticket.TextoIzquierda("TELEFONO....:" + Telefono);
                ticket.TextoIzquierda("CELULAR.....:" + Celular);
                ticket.TextoIzquierda("CONTACTO....:" + Contacto);

                ticket.lineasGuio();
                //Articulos a vender.
                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                ticket.lineasGuio();
                //grdOrdenes.Rows.Add(consecutivo, txtcRelog.Text, referencia, cantidad, descuento, resultado, Observacionesr, caracteristicas, usuario, txtCodigo.Text, txtPlug.Text);
                //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
                foreach (DataGridViewRow fila in grdOrdenes.Rows)//dgvLista es el nombre del datagridview
                {
                    ticket.AgregaArticulo(fila.Cells[11].Value.ToString(), int.Parse(fila.Cells[10].Value.ToString()),
                        int.Parse(fila.Cells[3].Value.ToString()), decimal.Parse(fila.Cells[5].Value.ToString()));
                }
                ticket.lineasGuio();

                try
                {

                    //Resumen de la venta. Sólo son ejemplos

                    ticket.AgregarTotales("    TOTAL......$", total);
                    ticket.lineasGuio();
                    foreach (DataGridViewRow fila in grdOrdenes.Rows)//dgvLista es el nombre del datagridview
                    {
                        ticket.TextoIzquierda("CODIGO RELOJ:" + fila.Cells[1].Value.ToString());
                        ticket.TextoIzquierda("MARCA Y REFERENCIA:" + fila.Cells[2].Value.ToString());
                        ticket.TextoIzquierda("OBSERVACIONES:" + fila.Cells[7].Value.ToString());
                        ticket.TextoIzquierda("CARACTERISTICAS:" + fila.Cells[8].Value.ToString());
                    }
                    ticket.lineasGuio();
                    ticket.TextoIzquierda("Abonos:" + abono.ToString());
                    ticket.lineasGuio();

                    ticket.TextoIzquierda("VENDEDOR:" + VENDEDOR);
                    ticket.lineasGuio();
                    //Texto final del Ticket.
                    //ticket.TextoIzquierda("");
                    ticket.TextoCentro("PASADOS 60 DIAS NO NOS HACEMOS");
                    ticket.TextoCentro("RESPONSABLES POR EL ARTICULO");
                    ticket.TextoCentro("PBX: 444 08 01");
                    ticket.TextoCentro("E-MAIL:INFO@SERVIPILAS.COM");

                    ticket.lineasGuio();
                    //ticket.TextoCentro("");
                    ticket.TextoCentro("");

                    ticket.TextoIzquierda("FIRMA EMPLEADO:___________________");

                    ticket.TextoCentro("");

                    ticket.TextoIzquierda("FIRMA CLIENTE:____________________");
                    ticket.TextoCentro("");
                    ticket.TextoCentro("");
                    ticket.TextoCentro("");
                    ticket.TextoCentro("");
                    ticket.CortaTicket();
                    string usu = "";
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
                    //if (iusuario == "La Central")
                    //{
                    //    usu = "print";
                    //}
                    //if (iusuario == "San Diego")
                    //{
                    //    usu = "impre";
                    //}
                    //if (iusuario == "Molinos")
                    //{
                    //    usu = "printmo";
                    //}
                    //if (iusuario == "Mayorca")
                    //{
                    //    usu = "generic2";
                    //}
                    //if (iusuario == "Puerta del Norte")
                    //{
                    //    usu = "print";
                    //}

                    ticket.ImprimirTicket(usu);

                    //string impresion = Impresora.getImpresoraPorDefecto();
                    //ticket.ImprimirTicket("print");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }


        public void CREARTICKETMODIFICAR()
        {
            if (iusuario == "La Central" || iusuario == "San Diego" || iusuario == "Molinos" || iusuario == "Mayorca" || iusuario == "Puerta del Norte")
            {
                consultarIMPRIMIR();
                DateTime fechad = DateTime.Now;

                String FECHALARGAj = fechad.ToString("hh:mm tt");

                String FECHALARGA = dtFecha.Value.Date.ToShortDateString();
                FECHALARGA = FECHALARGA + " " + FECHALARGAj;





                string codigoo, codigor, plug;
                codigoo = txtCodigo.Text;
                plug = txtPlug.Text;
                codigor = txtcRelog.Text;
                int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
                string Documento = txtDocumento.Text;
                decimal total = Convert.ToDecimal(txtTotal.Text);
                string VENDEDOR = CboVendedor.Text;

                string fecha = dtFecha.Value.Date.ToShortDateString();
                string fechaentrega = dtfechaentrega.Value.Date.ToShortDateString();
                string robservaciones = txtCodigo.Text;
                decimal abono = Convert.ToDecimal(txtCabonos.Text);
                //Creamos una instancia d ela clase CrearTicket
                CrearTicket ticket = new CrearTicket();
                //Ya podemos usar todos sus metodos
                ///*  ticket.AbreCajon();//*/Para abrir el cajon de dinero.

                //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

                //Datos de la cabecera del Ticket.
                ticket.TextoCentro("SERVIPILAS");
                ticket.TextoCentro("ORDEN DE SERVICIO");
                ticket.TextoCentro("");
                ticket.TextoCentro("DOCUMENTO NO VALIDO COMO FACTURA");
                ticket.TextoCentro("DE COMPRA");
                ticket.lineasGuio();

                ticket.TextoIzquierda("FECHA.....:" + FECHALARGA);
                ticket.TextoIzquierda("PUNTO DE VENTA...:" + iusuario);
                ticket.TextoIzquierda("ORDEN NRO...:" + txtmodificaro.Text);
                ticket.TextoIzquierda("DOCUMENTO...:" + documentoc);
                ticket.TextoIzquierda("CLIENTE.....:" + caracteristicas);
                ticket.TextoIzquierda("TELEFONO....:" + Telefono);
                ticket.TextoIzquierda("CELULAR.....:" + Celular);
                ticket.TextoIzquierda("CONTACTO....:" + Contacto);

                ticket.lineasGuio();
                //Articulos a vender.
                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                ticket.lineasGuio();
                //grdOrdenes.Rows.Add(consecutivo, txtcRelog.Text, referencia, cantidad, descuento, resultado, Observacionesr, caracteristicas, usuario, txtCodigo.Text, txtPlug.Text);
                //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
                foreach (DataGridViewRow fila in GRDCONSULTAORDEN.Rows)//dgvLista es el nombre del datagridview
                {
                    ticket.AgregaArticulo(fila.Cells[8].Value.ToString(), int.Parse(fila.Cells[7].Value.ToString()),
                        int.Parse(fila.Cells[3].Value.ToString()), decimal.Parse(fila.Cells[5].Value.ToString()));
                }
                ticket.lineasGuio();

                try
                {

                    //Resumen de la venta. Sólo son ejemplos

                    ticket.AgregarTotales("    TOTAL......$", total);
                    ticket.lineasGuio();
                    foreach (DataGridViewRow fila in GRDCONSULTAORDEN.Rows)//dgvLista es el nombre del datagridview
                    {
                        ticket.TextoIzquierda("CODIGO RELOJ:" + fila.Cells[1].Value.ToString());
                        ticket.TextoIzquierda("MARCA Y REFERENCIA:" + fila.Cells[2].Value.ToString());
                        ticket.TextoIzquierda("OBSERVACIONES:" + fila.Cells[10].Value.ToString());
                        ticket.TextoIzquierda("CARACTERISTICAS:" + fila.Cells[9].Value.ToString());
                    }
                    ticket.lineasGuio();
                    ticket.TextoIzquierda("Abonos:" + abono.ToString());
                    ticket.lineasGuio();

                    ticket.TextoIzquierda("VENDEDOR:" + VENDEDOR);
                    ticket.lineasGuio();
                    //Texto final del Ticket.
                    //ticket.TextoIzquierda("");
                    ticket.TextoCentro("PASADOS 60 DIAS NO NOS HACEMOS");
                    ticket.TextoCentro("RESPONSABLES POR EL ARTICULO");
                    ticket.TextoCentro("PBX: 444 08 01");
                    ticket.TextoCentro("E-MAIL:INFO@SERVIPILAS.COM");

                    ticket.lineasGuio();
                    //ticket.TextoCentro("");
                    ticket.TextoCentro("");

                    ticket.TextoIzquierda("FIRMA EMPLEADO:___________________");

                    ticket.TextoCentro("");

                    ticket.TextoIzquierda("FIRMA CLIENTE:____________________");
                    ticket.TextoCentro("");
                    ticket.TextoCentro("");
                    ticket.TextoCentro("");
                    ticket.TextoCentro("");
                    ticket.CortaTicket();
                    string usu = "";
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


        private void Form1_Load(object sender, EventArgs e)
        {
             grdOrdenes .Columns[0].ReadOnly = true;
            //this.grdOrdenes.DefaultCellStyle.WrapMode =DataGridViewTriState.True;
            lblmodificarcaracteristicas.Visible = false;
            GRDCONSULTAORDEN.Visible = false;
         
            llenarcombo();
      


        
         

            txtmodificaro.Enabled = true;
            txtPlug.Enabled = false;

            txtConsecutivo.Enabled = false;

            //txtCantidad.Enabled = false;
            acceso(iusuario, icontraseña);




            TTIPACTUALIZAR.SetToolTip(BTNrEGRESAR, "Actualizar");
            toolTip2.SetToolTip(btnModificar, "Modificar Registro");

            toolTip3.SetToolTip(btnNuevaorden, "Nuevo registro");

            toolTip4.SetToolTip(btnBorrar, "Eliminar registro");

            toolTip5.SetToolTip(btnCerrar, "Cerrar");
            toolTip1.SetToolTip(btnguardarcliente, "Guardar Registro");
            txtCantidad.Text = "1";
            txtValor.Text = "0";
            txtdescuento.Text = "0";
        
            txtTotal.Text = "0";


            //grdCliente.Columns[1].Width = 170;
            //grdCliente.Columns[5].Width = 170;
            //grdCliente.Columns[7].Width = 170;



            if (string.IsNullOrEmpty(this.txtdescuento.Text))
            {
                this.txtdescuento.Text = "0";
            }


        }
       

        


        public void Consultarordenescliente()
        {
   

            string Documento = txtDocumento.Text;

            try
            {
                string q = "SELECT  tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo, tblCliente.Telefono as Teléfono, tblCliente.Telofc as Celular, tblCliente.Direccion as Dirección, tblCliente.Contacto, tblCliente.Email  FROM tblCliente where tblCliente.Documento = '" + Documento+ "'";

                OleDbCommand comando = new OleDbCommand(q, conexion);


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
              grdCliente.DataSource = pr.Tables[0];
                grdCliente.Columns[6].Width = 420;
                grdCliente.Columns[5].Width = 160;
                grdCliente.Columns[4].Width = 280;
                grdCliente.Columns[1].Width = 240;
                comando.Connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }








        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }






        private void grdCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char[] delimitador = { '/' };
            txtDocumento.Text = Convert.ToString(this.grdCliente.CurrentRow.Cells[0].Value);
        }


   

        private bool clienteexiste()

        {

            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese un cliente que exista");

                return false;
            }

            string id = txtDocumento.Text;
            string query = "SELECT COUNT(*) FROM tblCliente WHERE Documento=@Id";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Connection.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("Ingrese un cliente que exista");
                cmd.Connection.Close();
                return false;

            }
            cmd.Connection.Close();
            return true;
        }


        private bool ordenexisteactualizada()

        {

          

            string id = txtDocumento.Text;
            string query = "SELECT COUNT(*) FROM tblOrden WHERE Consecutivo=@Id";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Connection.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("La orden ya existe");
                cmd.Connection.Close();
                return false;

            }
            cmd.Connection.Close();
            return true;
        }





        private void clienteexistenombre()

        {
            nomc = "";
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese un cliente que exista");

                return;
            }

            string documento = txtDocumento.Text;
            try
            {
                string q = "SELECT Documento,Nombrecompleto from tblCliente WHERE tblCliente.Documento=@Documento";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    
                 string nomc = dr["Nombrecompleto"].ToString();





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





        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Contador = 0;
            Consultarordenescliente();
          
            //if(GRDCONSULTAORDEN.Visible==true)
            //{
                
            //    this.tabOrdenes.SelectedIndex = 1;
            
            //    txtCantidad.Text = "1";
            //    txtValor.Text = "0";
            //    txtdescuento.Text = "0";
            //    txtCodigo.Focus();
            //    Contador = 1;
            //    return;
            //}

            if (CboVendedor.Text == "")
            {
                MessageBox.Show("Ingrese un Vendedor que exista");

                return;
            }

            this.Nuevaorden.Visible = true;
            if (clienteexiste() == false)
            {
                return;

            }
            else
            {
                GRDCONSULTAORDEN.Visible = false;
                lblmodificarcaracteristicas.Visible = false;
                this.tabOrdenes.SelectedIndex = 1;
                limpiarOrdenr();
                txtCantidad.Text = "1";
                txtValor.Text = "0";
                txtdescuento.Text = "0";
                txtCodigo.Focus();
              
      
            }
        }

        private void limpiarOrden()
        {
            grdCliente.Enabled = true;
            grdCliente.DataSource = null;

            Contador = 0;

            rthfechamod.Text = "";
            txtDocumento.Enabled = true;

            txtDocumento.Text = "";
            CboVendedor.Text = "";
            txtTotal.Text = "0";
            txtCabonos.Text = "0";
        
            txtPlug.Text = "";
            chkcajarayada.Checked = false;
            chkCajaquebrada.Checked = false;

            txtcajadec.Checked = false;


            chkcajaporosa.Checked = false;
            chkchapetarayada.Checked = false;
           
            txtEslabones.Text = "";
            richobservaciones.Text = "";

            chkcajasintornillo.Checked = false;

            chkcajamanchada.Checked = false;


           

            chkcristaldespicado.Checked = false;
            chkcristalhumedad.Checked = false;

            chkCristalmanchado.Checked = false;

            chkcristalquebrado.Checked = false;

            chkcristalrayado.Checked = false;


     
            chkcoronadesgastada.Checked = false;
            chkcoronafloja.Checked = false;
       
            chkcoronaoriginal.Checked = false;
            chkcoronaoxidada.Checked = false;
            chkcoronasuelta.Checked = false;



            chkescafandranumeracion.Checked = false;

            chkescafandrapintada.Checked = false;

            chkEscafandrarayada.Checked = false;


            chkEscafandrasuelta.Checked = false;

       

            chkTaparayada.Checked = false;

            chkpulsopartido.Checked = false;
         
            chkTaparayada.Checked = false;
            txtEslabones.Text = "";
          
            chkchapetaoriginal.Checked = false;
            chkchapetasinpin.Checked = false;
            chkchapetaoriginal.Checked = false;

            chkpulsorayado.Checked = false;

            chkpulsosinhebilla.Checked = false;

            chkpulsodespintado.Checked = false;


            chktableromanchado.Checked = false;

            chktableronumero.Checked = false;

            chktableroquebrado.Checked = false;

            chkTablerorayado.Checked = false;
            chktablerosinsegundero.Checked = false;



            chkfuncionaanalogo.Checked = false;
            chkfuncionadigital.Checked = false;
            chknofuncionadigital.Checked = false;

            chknofuncionananalogo.Checked = false;

            pulsonoo.Checked = false;
            pulsocristalizado.Checked = false;
            pulsoadaptaciones.Checked = false;
            tapanoenros.Checked = false;
            txtcajadec.Checked = false;
            chapnoa.Checked = false;




            rdbgarantiaimpermeabilidad.Checked = false;
            rbdnogarantiaimpermeabilidad.Checked = false;
            rbdimitacion.Checked = false;
            rbdoriginal.Checked = false;
            txtCantidad.Text = "1";
            txtReferencia.Text = "";
            txtValor.Text = "0";
            txtdescuento.Text = "0";
            int gr = 0;
            txtCodigo.Text = "";
            txtDocumento.Text = "";
        



        }

        private void limpiarOrdenr()
        {

            txtTotal.Text = "0";
            //txtCabonos.Text = "0";
  
            txtPlug.Text = "";
            chkcajarayada.Checked = false;
            chkCajaquebrada.Checked = false;
            

            chkcajaporosa.Checked = false;
            chkchapetarayada.Checked = false;
      
            txtEslabones.Text = "";
            richobservaciones.Text = "";

            chkcajasintornillo.Checked = false;

            chkcajamanchada.Checked = false;

            txtcajadec.Checked = false;



            chkcristaldespicado.Checked = false;
            chkcristalhumedad.Checked = false;

            chkCristalmanchado.Checked = false;

            chkcristalquebrado.Checked = false;

            chkcristalrayado.Checked = false;


         
            chkcoronadesgastada.Checked = false;
            chkcoronafloja.Checked = false;
            chkcoronafloja.Checked = false;
            chkcoronaoriginal.Checked = false;
            chkcoronaoxidada.Checked = false;
            chkcoronasuelta.Checked = false;


            pulsoadaptaciones.Checked = false;
            pulsocristalizado.Checked = false;
            pulsonoo.Checked = false;
            chapnoa.Checked = false;
            tapanoenros.Checked = false;
            escap.Checked = false;
           

            chkescafandranumeracion.Checked = false;

            chkescafandrapintada.Checked = false;

            chkEscafandrarayada.Checked = false;


            chkEscafandrasuelta.Checked = false;

           

            chkTaparayada.Checked = false;

            chkpulsopartido.Checked = false;
        
            chkTaparayada.Checked = false;
            txtEslabones.Text = "";
          
            chkchapetaoriginal.Checked = false;
            chkchapetasinpin.Checked = false;
            chkchapetaoriginal.Checked = false;

            chkpulsorayado.Checked = false;

            chkpulsosinhebilla.Checked = false;

            chkpulsodespintado.Checked = false;


           
            chktableromanchado.Checked = false;

            chktableronumero.Checked = false;

            chktableroquebrado.Checked = false;

            chkTablerorayado.Checked = false;
            chktablerosinsegundero.Checked = false;



            chkfuncionaanalogo.Checked = false;
            chkfuncionadigital.Checked = false;
            chknofuncionadigital.Checked = false;

            chknofuncionananalogo.Checked = false;





            rdbgarantiaimpermeabilidad.Checked = false;
            rbdnogarantiaimpermeabilidad.Checked = false;
            rbdimitacion.Checked = false;
            rbdoriginal.Checked = false;
            txtCantidad.Text = "1";
            txtReferencia.Text = "";
            txtValor.Text = "0";
            txtdescuento.Text = "0";

            txtCodigo.Text = "";



        }
        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void mdescuento()
        {
            try
            {
              
                decimal totalapagar = 0;
              


                totalapagar = Convert.ToDecimal(txtTotal.Text);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public void sumargridmodificar()
        {

            double sumatoria = 0;
            double desxcuento = 0;
            double cantidad = 0;
            double valor = 0;

            foreach (DataGridViewRow row in GRDCONSULTAORDEN.Rows)
            {
                desxcuento = 0;
                cantidad = 0;
                 valor = 0;
                cantidad += Convert.ToDouble(row.Cells[3].Value);
                desxcuento += Convert.ToDouble(row.Cells[4].Value);
                valor += Convert.ToDouble(row.Cells[5].Value);
                valor = valor - (valor * desxcuento / 100);
                valor = cantidad * valor;
                row.Cells[6].Value=valor;


                sumatoria += Convert.ToDouble(row.Cells[6].Value);

            }
            txtTotal.Text = sumatoria.ToString();

        }
        public void    Consecuticoreloj()
        {
            double min = 1;
            double mayor = 0;
            double valor = 0;
            double valorf = 0;

            foreach (DataGridViewRow row in GRDCONSULTAORDEN.Rows)
            {
              
                valor= Convert.ToDouble(row.Cells[1].Value);
             
                if (min>valor)
                {

                    mayor = valor;

                    mayor = mayor + 1;
                    txtcRelog.Text = mayor.ToString();
                    min = valor;
                }
                if (min <= valor)
                {
                    mayor = valor;
              

                    mayor = mayor + 1;
        

                    txtcRelog.Text = mayor.ToString();

                    min = valor;
                }


            }
            

        }
        public void sumargrid()
        {

            double sumatoria = 0;
            double desxcuento = 0;
            double cantidad = 0;
            double valor = 0;

            foreach (DataGridViewRow row in grdOrdenes.Rows)
            {
                desxcuento = 0;
                cantidad = 0;
                valor = 0;
                cantidad += Convert.ToDouble(row.Cells[3].Value);
                desxcuento += Convert.ToDouble(row.Cells[4].Value);
                valor += Convert.ToDouble(row.Cells[5].Value);
                valor = valor - (valor * desxcuento / 100);
                valor = cantidad * valor;
                row.Cells[6].Value = valor;


                sumatoria += Convert.ToDouble(row.Cells[6].Value);

            }
            txtTotal.Text = sumatoria.ToString("N2");

        }

        private void grdOrdenes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sumargrid();
        }

        private void grdOrdenes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sumargrid();
        }

        private void txtDocumento_KeyUp(object sender, KeyEventArgs e)
        {
           

        }


private void btnBorrarregistro_Click(object sender, EventArgs e)
        {
            int gr = 0;

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }




        //    if (GRDCONSULTAORDEN.CurrentRow == null)

        //        return;

        //    else
        //    {
        //        string id = GRDCONSULTAORDEN.CurrentRow.Cells["Consecutivo"].Value.ToString();
        //string Nombre = GRDCONSULTAORDEN.CurrentRow.Cells["Codigo_reloj"].Value.ToString();

        //    {




        //        string query = "delete from tblDetalleorden where codigo_r = @nombre and Codigo=@codigo";



        //  OleDbCommand cmd = new OleDbCommand(query, conexion);
        //        cmd.Connection.Open();
               
        //         cmd.Parameters.AddWithValue("@Nombre", Nombre);
        //        cmd.Parameters.AddWithValue(" @codigo", id);
            
        //        cmd.ExecuteNonQuery();

        //        cmd.Connection.Close();
        //            sumargridmodificar();
            
        //    }

        //   GRDCONSULTAORDEN.Rows.Remove(GRDCONSULTAORDEN.CurrentRow);

        //    }
        }

        private void ultimoregistro()
        {

            string usuario = lblUsuario.Text;

            if (lblUsuario.Text == "San Diego")
            {
                try
                {

                    string q = "SELECT * FROM SanDiego WHERE Consecutivo  = (SELECT MAX(Consecutivo) FROM SanDiego)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        string casa = dr["Consecutivo"].ToString();

                        int llenar = Convert.ToInt32(casa);
                        llenar = llenar + 1;
                        txtConsecutivo.Text = llenar.ToString();



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


            if (lblUsuario.Text == "La Central")
            {
                try
                {

                    string q = "SELECT * FROM Central WHERE Consecutivo  = (SELECT MAX(Consecutivo) FROM Central)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        string casa = dr["Consecutivo"].ToString();

                        int llenar = Convert.ToInt32(casa);
                        llenar = llenar + 1;
                        txtConsecutivo.Text = llenar.ToString();



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


            if (lblUsuario.Text == "Puerta del Norte")
            {
                try
                {

                    string q = "SELECT * FROM Puerta WHERE Consecutivo  = (SELECT MAX(Consecutivo) FROM Puerta)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        string casa = dr["Consecutivo"].ToString();

                        int llenar = Convert.ToInt32(casa);
                        llenar = llenar + 1;
                        txtConsecutivo.Text = llenar.ToString();



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


            if (lblUsuario.Text == "Mayorca")
            {
                try
                {

                    string q = "SELECT * FROM Mayorca WHERE Consecutivo  = (SELECT MAX(Consecutivo) FROM Mayorca)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        string casa = dr["Consecutivo"].ToString();

                        int llenar = Convert.ToInt32(casa);
                        llenar = llenar + 1;
                        txtConsecutivo.Text = llenar.ToString();



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




            if (lblUsuario.Text == "Molinos")
            {
                try
                {

                    string q = "SELECT * FROM Molinos WHERE Consecutivo  = (SELECT MAX(Consecutivo) FROM Molinos)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        string casa = dr["Consecutivo"].ToString();

                        int llenar = Convert.ToInt32(casa);
                        llenar = llenar + 1;
                        txtConsecutivo.Text = llenar.ToString();



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

        private void insertarsucursales()
        {
            int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
            if (lblUsuario.Text == "Mayorca")
            {
                try
                {


                    string q = "insert into Mayorca(Consecutivo) values(@consecutivo)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);

                    cmd.ExecuteNonQuery();





                    cmd.Connection.Close();

                    //return true;

                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }

            }




            if (lblUsuario.Text == "Puerta del Norte")
            {
                try
                {

                    string q = "insert into Puerta(Consecutivo) values(@consecutivo)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);

                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    //return true;

                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }

            }

            if (lblUsuario.Text == "Molinos")
            {
                try
                {


                    string q = "insert into Molinos(Consecutivo) values(@consecutivo)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);

                    cmd.ExecuteNonQuery();





                    cmd.Connection.Close();

                    //return true;

                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }

            }

            if (lblUsuario.Text == "San Diego")
            {
                try
                {


                    string q = "insert into SanDiego(Consecutivo) values(@consecutivo)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);

                    cmd.ExecuteNonQuery();





                    cmd.Connection.Close();

                    //return true;

                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }

            }


            if (lblUsuario.Text == "La Central")
            {
                try
                {


                    string q = "insert into Central(Consecutivo) values(@consecutivo)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);

                    cmd.ExecuteNonQuery();





                    cmd.Connection.Close();

                    //return true;

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
        private bool Ordenexiste()

        {
            try
            {

                if (txtConsecutivo.Text == "")
                {
                    MessageBox.Show("Ingrese una orden que exista");

                    return false;
                }


                string id = txtConsecutivo.Text;
                string query = "SELECT COUNT(*) FROM tblDetalleOrden WHERE Codigo=@Id  and Usuario=@Usuario";
                OleDbCommand cmd = new OleDbCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Usuario", iusuario);
                cmd.Connection.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {

                    cmd.Connection.Close();
                    return false;
                    MessageBox.Show("La orden y código del reloj existen");
                }
                cmd.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return false;
            }
        

}
        private void btnIngresar_Click_2(object sender, EventArgs e)
        {
            clienteexistenombre();
            if (Ordenexiste())
            {
                return;
            }
         

            DateTime fechad = DateTime.Now;

            String FECHALARGAj = fechad.ToString("hh:mm tt");
          
           String FECHALARGA = dtFecha.Value.Date.ToShortDateString();
            FECHALARGA = FECHALARGA + " "+ FECHALARGAj;





          string codigoo, codigor, plug;
            codigoo = txtCodigo.Text;
            plug = txtPlug.Text;
            codigor = txtcRelog.Text;

            if (CboVendedor.Text == "")
            {
                MessageBox.Show("Ingrese un Vendedor que exista");

                return;
            }

            string Vendedor = CboVendedor.Text;

            if (clienteexiste() == false)
            {
                return;

            }
            else
            {

               

                int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
                string Documento = txtDocumento.Text;
                decimal total = Convert.ToDecimal(txtTotal.Text);

         

                DateTime localDate = DateTime.Now;
                DateTime fecha = localDate.Date;
                string fechaentrega = dtfechaentrega.Value.Date.ToShortDateString();
                string robservaciones = txtCodigo.Text;
                decimal abono = 0;
                abono = Convert.ToDecimal(txtCabonos.Text);
                string stadofactura = "SinPagar";


                try
                {





                    if (grdOrdenes.Rows.Count == 0)
                    {
                        MessageBox.Show("Realiza la orden");
                        return;

                    }
                    string consecutivos = Consecutivo.ToString();


                    string q = "insert into tblOrden(Consecutivo,Documento,Fecha,Fecha_entrega,Total,Estado,Usuario,Observaciones,Vendedor,Consecutivos,Fechalarga,Nombrecompleto,Abono,Doc) values(@consecutivo,@documento,@Fecha,@Fechaentrega,@total,@estado,@usuario,@observaciones,@Vendedor,@Consecutivos,@Fechalarga,@Nombrecompleto,@Abono,@Doc)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);
                    cmd.Parameters.AddWithValue("@documento", Documento);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Fechaentrega", fechaentrega);
                    cmd.Parameters.AddWithValue("@total", total);

                    cmd.Parameters.AddWithValue("@estado", stadofactura);
                    cmd.Parameters.AddWithValue("@usuario", iusuario);
                    cmd.Parameters.AddWithValue("@observaciones", robservaciones);
                    cmd.Parameters.AddWithValue("@Vendedor", Vendedor);
                    cmd.Parameters.AddWithValue("@Consecutivos", consecutivos);
                    cmd.Parameters.AddWithValue("@Fechalarga", FECHALARGA);
                    cmd.Parameters.AddWithValue("@Nombrecompleto", nomc);
                    cmd.Parameters.AddWithValue("@Abono", abono);
                    cmd.Parameters.AddWithValue("@Doc", Documento);
                    cmd.ExecuteNonQuery();





                    cmd.Connection.Close();
                    
                    //return true;

                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }












                try
                {




                    string q = "insert into tblDetalleOrden(Codigo,referencia,Cantidad,Descuento,Valor,Observacionesr,Caracteristicas,Usuario,Codigo_p,Plug,Codigo_r,Precio) values(@consecutivo,@referencia,@cantidad,@descuento,@valor,@observaciones,@caracteristicas,@Usuario,@codigop,@codigor,@plug,@Precio)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();
                    foreach (DataGridViewRow row in grdOrdenes.Rows)
                    {



                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@consecutivo", Convert.ToString(row.Cells["Codigo"].Value));
                        cmd.Parameters.AddWithValue("@referencia", Convert.ToString(row.Cells["Referencia"].Value));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(row.Cells["Cantidad"].Value));
                        cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells["Descuento"].Value));
                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(row.Cells["Subtotal"].Value));
                        cmd.Parameters.AddWithValue("@observaciones", Convert.ToString(row.Cells["Observaciones"].Value));
                        cmd.Parameters.AddWithValue("@caracteristicas", Convert.ToString(row.Cells["Caracteristica"].Value));
                        cmd.Parameters.AddWithValue("@Usuario", Convert.ToString(row.Cells["Usuario"].Value));
                        cmd.Parameters.AddWithValue("@codigop", Convert.ToString(row.Cells["Codigop"].Value));
                        cmd.Parameters.AddWithValue("@plug", Convert.ToString(row.Cells["Plug"].Value));
                        cmd.Parameters.AddWithValue("@codigor", Convert.ToString(row.Cells["Codigor"].Value));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToString(row.Cells["Valor"].Value));

                        cmd.ExecuteNonQuery();
                     
                    }
                    cmd.Connection.Close();

                    MessageBox.Show("registro almacenado");
                    insertarsucursales();
                    ultimoregistro();
                    CREARTICKET();
                    CREARTICKET();

                    cont = 1;
                    
                    txtmodificaro.Text = "";
                    limpiarOrden();

                    GRDCONSULTAORDEN.Visible = false;
                    lblmodificarcaracteristicas.Visible = false;
                   

                    //foreach (DataGridViewRow row in grdOrdenes.Rows)
                    //{
   
                    int gr = 0;

                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }


                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }

                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }
                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }
                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }
        

                }
                


                catch (Exception ex)
                {
                    conexion.Close();
                
                    MessageBox.Show(ex.Message);
                    return;


                }

              

            }


        }



        private void borrargrid()
        {
            txtTotal.Text = "0";
          

         
       


            foreach (DataGridViewRow c in grdOrdenes.Rows)
            {
                


                grdOrdenes.Rows.Remove(c);

            }

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      

      


        private bool OrdenexisteMODIFICAR()

        {

            if (txtmodificaro.Text == "")
            {
                MessageBox.Show("Ingrese una orden que exista");

                return false;
            }
           
            string user = iusuario;
            string id = txtmodificaro.Text;
            string query = "SELECT COUNT(*) FROM tblDetalleOrden WHERE Codigo=@Id and Usuario=@Usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
           
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
        private void grdCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            char[] delimitador = { '/' };
            txtDocumento.Text = Convert.ToString(this.grdCliente.CurrentRow.Cells[0].Value);
        }

        private void txtDocumento_TextChanged_1(object sender, EventArgs e)
        {
        

        }

        private void btnNuevaorden_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";


            txtTotal.Text = "0";
       
            //borrargrid();
            grdOrdenes.Rows.Clear();
            ultimoregistro();
        }

       

        private void btnBorrar_Click_2(object sender, EventArgs e)
        {
            string conse = iusuario;
            EliminarOrden elor = new EliminarOrden(conse);
            elor.Show();
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaorden_Click_1(object sender, EventArgs e)
        {
            txtmodificaro.Text = "";
            limpiarOrden();
            ultimoregistro();
            GRDCONSULTAORDEN.Visible = false;
            lblmodificarcaracteristicas.Visible = false;
          

            //foreach (DataGridViewRow row in grdOrdenes.Rows)
            //{

                int gr = 0;

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }


                if (grdOrdenes.Rows.Count > 0)
                {
                    gr = (grdOrdenes.Rows.Count - 1);

                    grdOrdenes.Rows.RemoveAt(gr);
                }

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            txtDocumento.Text = "";
            if (grdCliente.Rows.Count > 0)
            {
                gr = (grdCliente.Rows.Count - 1);

                grdCliente.Rows.RemoveAt(gr);
            }
            if (grdCliente.Rows.Count > 0)
            {
                gr = (grdCliente.Rows.Count - 1);

                grdCliente.Rows.RemoveAt(gr);
            }
            if (grdCliente.Rows.Count > 0)
            {
                gr = (grdCliente.Rows.Count - 1);

                grdCliente.Rows.RemoveAt(gr);
            }


        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
           
                clienteexistenombre();

                if (OrdenexisteMODIFICAR() == false)
                {

                    return;

                }
                else
                {




                string pagofactura = "";
                string codigoo, codigor, plug;
                codigoo = txtCodigo.Text;
                plug = txtPlug.Text;
                codigor = txtcRelog.Text;
                if (clienteexiste() == false)
                {
                    return;

                }
                else
                {


                   string Consecutivo = txtmodificaro.Text;
                    string Documento = txtDocumento.Text;
                    decimal total = Convert.ToDecimal(txtTotal.Text);

          
                    DateTime fecha = Convert.ToDateTime(dtFecha.Text);
                    DateTime fechaentrega = Convert.ToDateTime(dtfechaentrega.Text);
                    DateTime fechad = DateTime.Now;

                    String FECHALARGAj = fechad.ToString("hh:mm tt");
                    DateTime localDate = DateTime.Now;
                    
                    string fechalarga = dtFecha.Value.Date.ToShortDateString();
                    string robservaciones = rthfechamod.Text+ " " + localDate.ToString();
                        decimal valor = Convert.ToDecimal(txtValor.Text);
                        decimal descuentoo = Convert.ToDecimal(txtdescuento.Text);
                       int cantidad = Convert.ToInt32(txtCantidad.Text);
                        string codigop=txtCodigo.Text;
                        string plugo = txtPlug.Text;
                        string stadofactura ="SinPagar";
                        string referencia = txtReferencia.Text;
                        string caracteristicas = GRDCONSULTAORDEN.Text;


                    int codord = Convert.ToInt32(txtmodificaro.Text);
                    string cusuario = iusuario;
                    string estadoconsulta = "";
                    try
                    {
                        string cq = "SELECT tblOrden.[Pago_Orden] FROM tblOrden WHERE tblOrden.Consecutivo = @Documento AND tblOrden.Usuario = '" + cusuario + "'";
                        OleDbCommand comand = new OleDbCommand(cq, conexion);
                        comand.Connection.Open();
                        comand.Parameters.AddWithValue("@Documento", codord);



                        OleDbDataReader dr = comand.ExecuteReader();

                        if (dr.Read())
                        {



                            estadoconsulta = dr["Pago_Orden"].ToString();


                        }
                        dr.Close();

                        comand.Connection.Close();




                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexion.Close();
                    }






                    try
                    {
                       




                                                

                        decimal abono =Convert.ToDecimal(txtCabonos.Text);
                    
                        fechalarga = fechalarga + " " + FECHALARGAj;
                        string q = "update tblOrden set Documento='" + Documento + "',Fecha_entrega='" + fechaentrega + "',Total='" + total + "',Estado='" + stadofactura + "',Fechalarga='" + fechalarga + "',Nombrecompleto='" + nomc + "',Abono='" + abono + "',Pago_Orden='" + pagofactura + "',Observaciones='" + robservaciones + "' where Consecutivo=@Documento and Usuario=@Usuario";



                        OleDbCommand comando = new OleDbCommand(q, conexion);
                        comando.Connection.Open();
                        comando.Parameters.AddWithValue("@Documento", Consecutivo);
                        comando.Parameters.AddWithValue("@Usuario", iusuario);






                        comando.ExecuteNonQuery();
                        comando.Connection.Close();
                        lblmodificarcaracteristicas.Visible = true;
                          GRDCONSULTAORDEN.Visible = true;
                            //MessageBox.Show("Orden actualizada con éxito");

                            //return true;

                        }

                    catch (Exception ex)
                    {
                        conexion.Close();
                        //return false;
                        MessageBox.Show(ex.Message);
                        return;


                    }








                        try
                        {


                            string q = "update tblDetalleOrden set Observacionesr=@observaciones,Precio=@precio,Valor=@valor,referencia=@referencia,Plug=@plug,Descuento=@descuento,Codigo_p=@codigop,Caracteristicas=@caracteristicas,Cantidad=@cantidad where Codigo=@consecutivo and Usuario=@Usuario and tblDetalleOrden.Codigo_r=@codigor";


                            OleDbCommand cmd = new OleDbCommand(q, conexion);
                            cmd.Connection.Open();
                            foreach (DataGridViewRow row in GRDCONSULTAORDEN.Rows)
                            {



                                cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@observaciones", Convert.ToString(row.Cells["Observacionesr"].Value));
                            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(row.Cells["Valor"].Value));
                            cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(row.Cells["Subtotal"].Value));
                            cmd.Parameters.AddWithValue("@referencia", Convert.ToString(row.Cells["referencia"].Value));
                        
                            cmd.Parameters.AddWithValue("@plug", Convert.ToString(row.Cells["Plug"].Value));
                            cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells["Descuento"].Value));
                            cmd.Parameters.AddWithValue("@codigop", Convert.ToString(row.Cells["Codigo_p"].Value));
                            cmd.Parameters.AddWithValue("@caracteristicas", Convert.ToString(row.Cells["Caracteristicas"].Value));
                            cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(row.Cells["Cantidad"].Value));
                            cmd.Parameters.AddWithValue("@consecutivo", Convert.ToString(row.Cells["Consecutivo"].Value));
                            
                             
              
              
                      
                                
                                cmd.Parameters.AddWithValue("@Usuario", Convert.ToString(row.Cells["Usuario"].Value));
                            
                                cmd.Parameters.AddWithValue("@codigor", Convert.ToString(row.Cells["Codigo_reloj"].Value));

                                cmd.ExecuteNonQuery();
                             

                        }
                        conexion.Close();

                        //MessageBox.Show("Registro Actualizado");
                        if (MessageBox.Show("Orden modificada desea imprimir", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            CREARTICKETMODIFICAR();
                        }
                        txtDocumento.Enabled = true;
                        
                        txtmodificaro.Text = "";


                        GRDCONSULTAORDEN.Visible = false;
                        lblmodificarcaracteristicas.Visible = false;

                        limpiarOrden();

                        int gr = 0;

                        if (GRDCONSULTAORDEN.Rows.Count > 0)
                        {
                            gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                            GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                        }


                        if (GRDCONSULTAORDEN.Rows.Count > 0)
                        {
                            gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                            GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                        }

                        if (GRDCONSULTAORDEN.Rows.Count > 0)
                        {
                            gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                            GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                        }

                        if (GRDCONSULTAORDEN.Rows.Count > 0)
                        {
                            gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                            GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                        }

                        if (GRDCONSULTAORDEN.Rows.Count > 0)
                        {
                            gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                            GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                        }


                            //return true;
                            GRDCONSULTAORDEN.Visible = false;
                            lblmodificarcaracteristicas.Visible = false;
                        Contador = 0;
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
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {



            mdescuento();
            if (txtCabonos.Text == "")
            {
                MessageBox.Show("Ingrese el Consecutivo");
                return;
            }



            string conse = iusuario;
            int documento = Convert.ToInt32(txtCabonos.Text);
            try
            {
                string q = "SELECT Sum(Abono.Abono) AS SumaDeAbono, Abono.Usuario, Abono.Consecutivo FROM Abono GROUP BY Abono.Usuario, Abono.Consecutivo HAVING(((Abono.Usuario) = '" + conse + "')) and(((Abono.Consecutivo) = @Documento))";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);
                //comando.Parameters.AddWithValue("@Usuario", conse);


                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                txtCabonos.Text = dr["SumaDeAbono"].ToString();





                }
                dr.Close();

                comando.Connection.Close();



                string c = "SELECT tblOrden.Total, tblOrden.Consecutivo, tblOrden.Usuario FROM tblOrden, tblOrden AS tblOrden_1 WHERE(((tblOrden.Consecutivo) = @Documento) AND((tblOrden.Usuario) =  '" + conse + "'))";




                OleDbCommand comand = new OleDbCommand(c, conexion);
                comand.Connection.Open();
                comand.Parameters.AddWithValue("@Documento", documento);
                //comando.Parameters.AddWithValue("@Usuario", conse);


                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader d = comand.ExecuteReader();

                if (d.Read())
                {

                    txtTotal.Text = d["Total"].ToString();





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

        private void consultarYModificarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string user = iusuario;
            ConsultarCliente ord = new ConsultarCliente(user);
            ord.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el Código");
                return;
            }




            string documento = txtCodigo.Text;
            try
            {
                txtPlug.Text = "";
                string q = "SELECT * from Plug WHERE plug.Id=@Documento";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtPlug.Text = dr["Descripcion"].ToString();






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

        private void ingresarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = iusuario;
            Repuestosreloj ord = new Repuestosreloj(user);
            ord.Show();
        }

        private void BTNrEGRESAR_Click(object sender, EventArgs e)
        {
     
  
            GRDCONSULTAORDEN.Visible = false;
            lblmodificarcaracteristicas.Visible = false;
         
       
        }

        private void btnconsultarorden_Click(object sender, EventArgs e)
        {
            if (txtmodificaro.Text == "")
            {
                MessageBox.Show("Ingrese el número de orden");
                return;
            }

        

            int codord = Convert.ToInt32(txtmodificaro.Text);
            string usuario = iusuario;
            try
            {
                string q = "SELECT tblOrden.[Número], tblOrden.[Consecutivo],tblDetalleOrden.Codigo_r as Codigo_reloj,tblDetalleOrden.referencia, tblOrden.[Documento], tblOrden.[Fecha], tblOrden.[Fecha_entrega], tblOrden.[Total], tblOrden.[Estado], tblOrden.[Usuario], tblDetalleOrden.[Observacionesr], tblOrden.[Vendedor], tblDetalleOrden.Cantidad, tblDetalleOrden.Descuento, tblDetalleOrden.Valor, tblDetalleOrden.Plug, tblDetalleOrden.Codigo_p, tblDetalleOrden.Caracteristicas FROM tblSucursal INNER JOIN(tblOrden INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblSucursal.Sucursal = tblOrden.Usuario WHERE(((tblDetalleOrden.Codigo) = @Documento)AND((tblOrden.Usuario) = '" + usuario + "'))";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", codord);
                comando.Parameters.AddWithValue("@Usuario", usuario);
               

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtDocumento.Text = dr["Documento"].ToString();
                    dtFecha.Text = dr["Fecha"].ToString();
                    dtfechaentrega.Text = dr["Fecha_entrega"].ToString();
                    CboVendedor.Text = dr["Vendedor"].ToString();
                    txtTotal.Text = dr["Total"].ToString();
                    richobservaciones.Text = dr["Observacionesr"].ToString();
                    string estadoo;
                    estadoo = dr["Estado"].ToString();
                    txtCantidad.Text = dr["Cantidad"].ToString();
                    txtCodigo.Text = dr["Codigo_p"].ToString();
                    txtPlug.Text = dr["Plug"].ToString();
                    txtValor.Text = dr["Valor"].ToString();
                    txtdescuento.Text = dr["Descuento"].ToString();
                    txtCantidad.Text = dr["Cantidad"].ToString();
                    txtReferencia.Text = dr["referencia"].ToString();
                    GRDCONSULTAORDEN.Text = dr["Caracteristicas"].ToString();

                  
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



        private void txtbuscarorden_KeyUp(object sender, KeyEventArgs e)
        {

        


            //try
            //{


            //    string salida = "";
            //    string[] palabrasb = this.txtbuscarorden.Text.Split(' ');
            //    foreach (string palabra in palabrasb)
            //    {
            //        if (salida.Length == 0)
            //        {
            //            salida = "(Documento LIKE '%" + palabra + "%' OR Nombre_completo LIKE '%" + palabra + "%'OR Consecutivo LIKE '%" + palabra + "%')";
            //        }

            //        else
            //        {
            //            salida += "(Documento LIKE '%" + palabra + "%' OR Nombre_completo LIKE '%" + palabra + "%'OR Consecutivo LIKE '%" + palabra + "%')";
            //        }
            //        this.mifiltro1.RowFilter = salida;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No dejes espacios");
            //    conexion.Close();
            //}
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (e.KeyChar == (char)13)
            {

                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Ingrese el Código");
                    return;
                }




                string documento = txtCodigo.Text;
                try
                {
                    txtPlug.Text = "";
                    string q = "SELECT * from Plug WHERE plug.Id=@Documento";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@Documento", documento);

                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        txtPlug.Text = dr["Descripcion"].ToString();






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
      

        private void txtcRelog_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Abonos_Click(object sender, EventArgs e)
        {
            Abonos ab = new Abonos(iusuario,txtDocumento.Text);
            ab.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarOrden();
            grdCliente.Enabled = false;
            txtDocumento.Enabled = false;
            //CREARTICKETMODIFICAR();
            GRDCONSULTAORDEN.Visible = false;
            lblmodificarcaracteristicas.Visible = false;
         

            //foreach (DataGridViewRow row in grdOrdenes.Rows)
            //{

            int gr = 0;

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }


            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            GRDCONSULTAORDEN.Visible = true;
            lblmodificarcaracteristicas.Visible = true;
            if (txtmodificaro.Text == "")
            {
                MessageBox.Show("Ingrese el número de orden");
                return;
            }



            int codord = Convert.ToInt32(txtmodificaro.Text);
            string usuario = iusuario;
            try
            {
                string q = "SELECT tblOrden.[Documento],tblOrden.[Fecha], tblOrden.[Fecha_entrega], tblOrden.[Total],tblOrden.[Vendedor],tblOrden.[Estado],tblOrden.[Abono],tblOrden.[Observaciones] FROM tblOrden WHERE tblOrden.Consecutivo = @Documento AND tblOrden.Usuario = '" + usuario + "'";
                OleDbCommand omando = new OleDbCommand(q, conexion);
                omando.Connection.Open();
                omando.Parameters.AddWithValue("@Documento", codord);




                OleDbDataReader KR = omando.ExecuteReader();

                if (KR.Read())
                {



                    dtFecha.Text = KR["Fecha"].ToString();
                    dtfechaentrega.Text = KR["Fecha_entrega"].ToString();
                    CboVendedor.Text = KR["Vendedor"].ToString();
                    txtTotal.Text = KR["Total"].ToString();
                    txtCabonos.Text = KR["Abono"].ToString();
                    string estadoo;
                    estadoo = KR["Estado"].ToString();
                    txtDocumento.Text=KR["Documento"].ToString();
                    rthfechamod.Text = KR["Observaciones"].ToString();

                }
                KR.Close();

                omando.Connection.Close();

                //txtDocumento.Text = doc;

                string qf = "SELECT tblDetalleOrden.Codigo as Consecutivo,tblDetalleOrden.Codigo_r as Codigo_reloj,tblDetalleOrden.referencia, tblDetalleOrden.Cantidad, tblDetalleOrden.Descuento,tblDetalleOrden.Precio as Valor, tblDetalleOrden.Valor as Subtotal,tblDetalleOrden.Codigo_p, tblDetalleOrden.Plug, tblDetalleOrden.Caracteristicas,tblDetalleOrden.Observacionesr,tblDetalleOrden.Usuario FROM tblDetalleOrden  WHERE tblDetalleOrden.Codigo = @Documento AND tblDetalleOrden.Usuario = '" + usuario + "'";
                    OleDbCommand comandod = new OleDbCommand(qf, conexion);
                    comandod.Connection.Open();
                    comandod.Parameters.AddWithValue("@Documento", codord);
                  


                OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                GRDCONSULTAORDEN.DataSource = pr.Tables[0];
                GRDCONSULTAORDEN.Columns[1].Width = 120;
                GRDCONSULTAORDEN.Columns[2].Width = 280;
                GRDCONSULTAORDEN.Columns[8] .Width = 140;
                GRDCONSULTAORDEN.Columns[9].Width = 900;
                GRDCONSULTAORDEN.Columns[10].Width = 900;

               

                GRDCONSULTAORDEN.Columns[0].ReadOnly = true;
                GRDCONSULTAORDEN.Columns[1].ReadOnly = true;
                //GRDCONSULTAORDEN.Columns[7].ReadOnly = true;
                GRDCONSULTAORDEN.Columns[8].ReadOnly = true;
                GRDCONSULTAORDEN.Columns[6].ReadOnly = true;
                comandod.Connection.Close();

                Consultarordenescliente();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }
          

        }

        private void txtmodificaro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                limpiarOrden();
                grdCliente.Enabled = false;
                txtDocumento.Enabled = false;
                GRDCONSULTAORDEN.Visible = false;
                lblmodificarcaracteristicas.Visible = false;


                //foreach (DataGridViewRow row in grdOrdenes.Rows)
                //{

                int gr = 0;

                if (grdOrdenes.Rows.Count > 0)
                {
                    gr = (grdOrdenes.Rows.Count - 1);

                    grdOrdenes.Rows.RemoveAt(gr);
                }


                if (grdOrdenes.Rows.Count > 0)
                {
                    gr = (grdOrdenes.Rows.Count - 1);

                    grdOrdenes.Rows.RemoveAt(gr);
                }

                if (grdOrdenes.Rows.Count > 0)
                {
                    gr = (grdOrdenes.Rows.Count - 1);

                    grdOrdenes.Rows.RemoveAt(gr);
                }
                if (grdOrdenes.Rows.Count > 0)
                {
                    gr = (grdOrdenes.Rows.Count - 1);

                    grdOrdenes.Rows.RemoveAt(gr);
                }
                if (grdOrdenes.Rows.Count > 0)
                {
                    gr = (grdOrdenes.Rows.Count - 1);

                    grdOrdenes.Rows.RemoveAt(gr);
                }
                GRDCONSULTAORDEN.Visible = true;
                lblmodificarcaracteristicas.Visible = true;
                if (txtmodificaro.Text == "")
                {
                    MessageBox.Show("Ingrese el número de orden");
                    return;
                }



                int codord = Convert.ToInt32(txtmodificaro.Text);
                string usuario = iusuario;
                try
                {
                    string q = "SELECT tblOrden.[Documento],tblOrden.[Fecha], tblOrden.[Fecha_entrega], tblOrden.[Total],tblOrden.[Vendedor],tblOrden.[Estado],tblOrden.[Abono],tblOrden.[Observaciones] FROM tblOrden WHERE tblOrden.Consecutivo = @Documento AND tblOrden.Usuario = '" + usuario + "'";
                    OleDbCommand omando = new OleDbCommand(q, conexion);
                    omando.Connection.Open();
                    omando.Parameters.AddWithValue("@Documento", codord);




                    OleDbDataReader KR = omando.ExecuteReader();

                    if (KR.Read())
                    {



                        dtFecha.Text = KR["Fecha"].ToString();
                        dtfechaentrega.Text = KR["Fecha_entrega"].ToString();
                        CboVendedor.Text = KR["Vendedor"].ToString();
                        txtTotal.Text = KR["Total"].ToString();
                        txtCabonos.Text = KR["Abono"].ToString();
                        string estadoo;
                        estadoo = KR["Estado"].ToString();
                        doc = KR["Documento"].ToString();
                        rthfechamod.Text = KR["Observaciones"].ToString();

                    }
                    KR.Close();

                    omando.Connection.Close();

                    txtDocumento.Text = doc;

                    string qf = "SELECT tblDetalleOrden.Codigo as Consecutivo,tblDetalleOrden.Codigo_r as Codigo_reloj,tblDetalleOrden.referencia, tblDetalleOrden.Cantidad, tblDetalleOrden.Descuento,tblDetalleOrden.Precio as Valor, tblDetalleOrden.Valor as Subtotal,tblDetalleOrden.Codigo_p, tblDetalleOrden.Plug, tblDetalleOrden.Caracteristicas,tblDetalleOrden.Observacionesr,tblDetalleOrden.Usuario FROM tblDetalleOrden  WHERE tblDetalleOrden.Codigo = @Documento AND tblDetalleOrden.Usuario = '" + usuario + "'";
                    OleDbCommand comandod = new OleDbCommand(qf, conexion);
                    comandod.Connection.Open();
                    comandod.Parameters.AddWithValue("@Documento", codord);



                    OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                    DataSet pr = new DataSet();
                    ad.Fill(pr);
                    GRDCONSULTAORDEN.DataSource = pr.Tables[0];
                    GRDCONSULTAORDEN.Columns[1].Width = 120;
                    GRDCONSULTAORDEN.Columns[2].Width = 280;
                    GRDCONSULTAORDEN.Columns[8].Width = 140;
                    GRDCONSULTAORDEN.Columns[9].Width = 900;
                    GRDCONSULTAORDEN.Columns[10].Width = 900;



                    GRDCONSULTAORDEN.Columns[0].ReadOnly = true;
                    GRDCONSULTAORDEN.Columns[1].ReadOnly = true;
                    //GRDCONSULTAORDEN.Columns[7].ReadOnly = true;
                    GRDCONSULTAORDEN.Columns[8].ReadOnly = true;
                    GRDCONSULTAORDEN.Columns[6].ReadOnly = true;
                    comandod.Connection.Close();

                    Consultarordenescliente();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }
        }

        private void grdCliente_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void GRDCONSULTAORDEN_KeyUp(object sender, KeyEventArgs e)
        {

            sumargridmodificar();
           
        }

        private void imprimirOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String CONSECUTIVO = txtmodificaro.Text;
            //Imprimir imp = new Imprimir(iusuario,CONSECUTIVO);
            //imp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            GRDCONSULTAORDEN.Visible = false;
            lblmodificarcaracteristicas.Visible = false;


            //foreach (DataGridViewRow row in grdOrdenes.Rows)
            //{

            int gr = 0;

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }


            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }

            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            if (grdOrdenes.Rows.Count > 0)
            {
                gr = (grdOrdenes.Rows.Count - 1);

                grdOrdenes.Rows.RemoveAt(gr);
            }
            GRDCONSULTAORDEN.Visible = true;
            lblmodificarcaracteristicas.Visible = true;
            if (txtmodificaro.Text == "")
            {
                MessageBox.Show("Ingrese el número de orden");
                return;
            }



            int codord = Convert.ToInt32(txtmodificaro.Text);
            string usuario = iusuario;
            try
            {
                string q = "SELECT tblOrden.[Fecha], tblOrden.[Fecha_entrega], tblOrden.[Total],tblOrden.[Vendedor],tblOrden.[Estado],tblOrden.[Abono],tblOrden.[Doc] FROM tblOrden WHERE tblOrden.Consecutivo = @Documento AND tblOrden.Usuario = '" + usuario + "'";
                OleDbCommand omando = new OleDbCommand(q, conexion);
                omando.Connection.Open();
                omando.Parameters.AddWithValue("@Documento", codord);




                OleDbDataReader KR = omando.ExecuteReader();

                if (KR.Read())
                {



                    dtFecha.Text = KR["Fecha"].ToString();
                    dtfechaentrega.Text = KR["Fecha_entrega"].ToString();
                    CboVendedor.Text = KR["Vendedor"].ToString();
                    txtTotal.Text = KR["Total"].ToString();
                    txtCabonos.Text = KR["Abono"].ToString();
                    string estadoo;
                    estadoo = KR["Estado"].ToString();
                    doc = KR["Doc"].ToString();


                }
                KR.Close();

                omando.Connection.Close();

                txtDocumento.Text = doc;

                string qf = "SELECT tblDetalleOrden.Codigo as Consecutivo,tblDetalleOrden.Codigo_r as Codigo_reloj,tblDetalleOrden.referencia, tblDetalleOrden.Cantidad, tblDetalleOrden.Descuento,tblDetalleOrden.Precio as Valor, tblDetalleOrden.Valor as Subtotal,tblDetalleOrden.Codigo_p, tblDetalleOrden.Plug, tblDetalleOrden.Caracteristicas,tblDetalleOrden.Observacionesr,tblDetalleOrden.Usuario FROM tblDetalleOrden  WHERE tblDetalleOrden.Codigo = @Documento AND tblDetalleOrden.Usuario = '" + usuario + "'";
                OleDbCommand comandod = new OleDbCommand(qf, conexion);
                comandod.Connection.Open();
                comandod.Parameters.AddWithValue("@Documento", codord);



                OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                GRDCONSULTAORDEN.DataSource = pr.Tables[0];
                GRDCONSULTAORDEN.Columns[1].Width = 120;
                GRDCONSULTAORDEN.Columns[2].Width = 280;
                GRDCONSULTAORDEN.Columns[8].Width = 140;
                GRDCONSULTAORDEN.Columns[9].Width = 900;
                GRDCONSULTAORDEN.Columns[10].Width = 900;



                GRDCONSULTAORDEN.Columns[0].ReadOnly = true;
                GRDCONSULTAORDEN.Columns[1].ReadOnly = true;
                //GRDCONSULTAORDEN.Columns[7].ReadOnly = true;
                GRDCONSULTAORDEN.Columns[8].ReadOnly = true;
                GRDCONSULTAORDEN.Columns[6].ReadOnly = true;
                comandod.Connection.Close();
                CREARTICKETMODIFICAR();
                limpiarOrden();

       

                if (GRDCONSULTAORDEN.Rows.Count > 0)
                {
                    gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                    GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                }


                if (GRDCONSULTAORDEN.Rows.Count > 0)
                {
                    gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                    GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                }

                if (GRDCONSULTAORDEN.Rows.Count > 0)
                {
                    gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                    GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                }

                if (GRDCONSULTAORDEN.Rows.Count > 0)
                {
                    gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                    GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                }

                if (GRDCONSULTAORDEN.Rows.Count > 0)
                {
                    gr = (GRDCONSULTAORDEN.Rows.Count - 1);

                    GRDCONSULTAORDEN.Rows.RemoveAt(gr);
                }

         
                //return true;
                GRDCONSULTAORDEN.Visible = false;
                lblmodificarcaracteristicas.Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }

        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
        }


        public void consultarplug()
        {
            foreach (DataGridViewRow row in GRDCONSULTAORDEN.Rows)
            {

                string documento = Convert.ToString(row.Cells[7].Value);
                try
            {
                txtPlug.Text = "";
                string q = "SELECT * from Plug WHERE plug.Id=@Documento";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", documento);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

              
                    if (dr.Read())
                {

                        
                        
                        row.Cells[8].Value = dr["Descripcion"].ToString();


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



        public void consultarplugord()
        {
            foreach (DataGridViewRow row in grdOrdenes.Rows)
            {

                string documento = Convert.ToString(row.Cells[10].Value);
                try
                {
                    txtPlug.Text = "";
                    string q = "SELECT * from Plug WHERE plug.Id=@Documento";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@Documento", documento);

                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();


                    if (dr.Read())
                    {



                        row.Cells[11].Value = dr["Descripcion"].ToString();


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

        private void GRDCONSULTAORDEN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            sumargridmodificar();
            consultarplug();
      
       }

        private void grdOrdenes_KeyUp(object sender, KeyEventArgs e)
        {
            sumargrid();
            if (txtCabonos.Text == "")
            {
                return;
            }
         

            decimal total = 0;
            total = Convert.ToDecimal(txtTotal.Text);
            decimal abono = 0;
            abono = Convert.ToDecimal(txtCabonos.Text);

            decimal saldopendiente = 0;


            saldopendiente = total - abono;
     
            
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtTotal.Enabled = false;
            txtcRelog.Visible = false;

            grdOrdenes.Columns[11].ReadOnly = true;
            grdOrdenes.Columns[9].ReadOnly = true;


            grdOrdenes.Columns[8].ReadOnly = true;
            grdOrdenes.Columns[1].ReadOnly = true;
            grdOrdenes.Columns[0].ReadOnly = true;

            //this.grdOrdenes.DefaultCellStyle.WrapMode =DataGridViewTriState.True;
            lblmodificarcaracteristicas.Visible = false;
            GRDCONSULTAORDEN.Visible = false;


            llenarcombo();
            txtCabonos.Text = "0";




            txtmodificaro.Enabled = true;
            txtPlug.Enabled = false;

            txtConsecutivo.Enabled = false;

            //txtCantidad.Enabled = false;
            acceso(iusuario, icontraseña);



            ultimoregistro();
            TTIPACTUALIZAR.SetToolTip(BTNrEGRESAR, "Actualizar");
            toolTip2.SetToolTip(btnModificar, "Modificar Registro");

            toolTip3.SetToolTip(btnNuevaorden, "Nuevo registro");

            toolTip4.SetToolTip(btnBorrar, "Eliminar registro");

            toolTip5.SetToolTip(btnCerrar, "Cerrar");
            toolTip1.SetToolTip(btnguardarcliente, "Guardar Registro");
            txtCantidad.Text = "1";
            txtValor.Text = "0";
            txtdescuento.Text = "0";

            txtTotal.Text = "0";

            if (iusuario == "Administrativo")
            {
                groupBox3.Visible = false;
                groupBox14.Visible = true;
            }
            else
            {
                groupBox3.Visible = true;
                groupBox14.Visible = false;
            }


            if (string.IsNullOrEmpty(this.txtdescuento.Text))
            {
                this.txtdescuento.Text = "0";
            }
        }

        private void grdOrdenes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            consultarplugord();
            sumargrid();
        }

        private void grdOrdenes_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            sumargrid();
        }

    

        private void txtCabonos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                try
                {
                    string q = "SELECT Abono FROM sumaabono where Documento=@documentoc";




                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();



                    comando.Parameters.AddWithValue("@Documentoc",txtDocumento.Text);


                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {


                        txtCabonos.Text = dr["Abono"].ToString();





                    }
                    else
                    {




                        txtCabonos.Text = "0";



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

        private void button5_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string q = "SELECT Abono FROM sumaabono where Documento=@documentoc";




                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();



                    comando.Parameters.AddWithValue("@Documentoc", txtDocumento.Text);


                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {


                        txtCabonos.Text = dr["Abono"].ToString();





                    }
                    else
                    {


                        double ca =Convert.ToInt32(txtCabonos.Text);
                        txtCabonos.Text = ca.ToString("N2");


                        txtCabonos.Text = "0";



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

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
           
            {

                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Ingrese el Código");
                    return;
                }




                string documento = txtCodigo.Text;
                try
                {
                    txtPlug.Text = "";
                    string q = "SELECT * from Plug WHERE plug.Id=@Documento";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();
                    comando.Parameters.AddWithValue("@Documento", documento);

                    /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                    ///comando.Parameters["@fechafactura"].Value = fecha1;
                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        txtPlug.Text = dr["Descripcion"].ToString();






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

        private void button6_Click(object sender, EventArgs e)
        {
            this.tabOrdenes.SelectedIndex = 0;
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
            {
                
              


            }
            catch (Exception ex)
            {
                MessageBox.Show("No dejes espacios");
                conexion.Close();
            }
            }
        }

        private void txtbuscarorden_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                try
                {


                }
            catch (Exception ex)
            {
                MessageBox.Show("No dejes espacios");
                conexion.Close();
            }
        }
    }

        private void txtDocumento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
          
                if (clienteexiste() == false)
                {                    
                Clientes cli = new Clientes(iusuario,txtDocumento.Text);
                cli.Show();
                    return;

            }
            if (e.KeyChar == (char)13)
            {
                Consultarordenescliente();
            }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (clienteexiste() == false)
            {
                Clientes cli = new Clientes(iusuario,txtDocumento.Text);
                cli.Show();
                return;

            }
            Consultarordenescliente();
        }

        private void eliminarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conse = iusuario;
            EliminarOrden elor = new EliminarOrden(conse);
            elor.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string conse = iusuario;
            EliminarOrden elor = new EliminarOrden(conse);
            elor.Show();

        }

        private void consultarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Ordenes cor = new Consultar_Ordenes();
            cor.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnguardarcliente_Click(object sender, EventArgs e)
        {

            ultimoregistro();
            clienteexistenombre();
            if (Ordenexiste())
            {
                MessageBox.Show("El número de orden ya esta registrado");
                return;
            }


            DateTime fechad = DateTime.Now;

            String FECHALARGAj = fechad.ToString("hh:mm tt");

            String FECHALARGA = dtFecha.Value.Date.ToShortDateString();
            FECHALARGA = FECHALARGA + " " + FECHALARGAj;

            string codigoo, codigor, plug;
            codigoo = txtCodigo.Text;
            plug = txtPlug.Text;
            codigor = txtcRelog.Text;

            if (CboVendedor.Text == "")
            {
                MessageBox.Show("Ingrese un Vendedor que exista");

                return;
            }

            string Vendedor = CboVendedor.Text;

            if (clienteexiste() == false)
            {
                return;

            }
            else
            {



                int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
                string Documento = txtDocumento.Text;
                decimal total = Convert.ToDecimal(txtTotal.Text);



                DateTime localDate = DateTime.Now;
                DateTime fecha = localDate.Date;
                string fechaentrega = dtfechaentrega.Value.Date.ToShortDateString();
                string robservaciones = txtCodigo.Text;
                decimal abono = 0;
                abono = Convert.ToDecimal(txtCabonos.Text);
                string stadofactura = "SinPagar";


                try
                {





                    if (grdOrdenes.Rows.Count == 0)
                    {
                        MessageBox.Show("Realiza la orden");
                        return;

                    }
                    string consecutivos = Consecutivo.ToString();


                    string q = "insert into tblOrden(Consecutivo,Documento,Fecha,Fecha_entrega,Total,Estado,Usuario,Observaciones,Vendedor,Consecutivos,Fechalarga,Nombrecompleto,Abono,Doc) values(@consecutivo,@documento,@Fecha,@Fechaentrega,@total,@estado,@usuario,@observaciones,@Vendedor,@Consecutivos,@Fechalarga,@Nombrecompleto,@Abono,@Doc)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);
                    cmd.Parameters.AddWithValue("@documento", Documento);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Fechaentrega", fechaentrega);
                    cmd.Parameters.AddWithValue("@total", total);

                    cmd.Parameters.AddWithValue("@estado", stadofactura);
                    cmd.Parameters.AddWithValue("@usuario", iusuario);
                    cmd.Parameters.AddWithValue("@observaciones", robservaciones);
                    cmd.Parameters.AddWithValue("@Vendedor", Vendedor);
                    cmd.Parameters.AddWithValue("@Consecutivos", consecutivos);
                    cmd.Parameters.AddWithValue("@Fechalarga", FECHALARGA);
                    cmd.Parameters.AddWithValue("@Nombrecompleto", nomc);
                    cmd.Parameters.AddWithValue("@Abono", abono);
                    cmd.Parameters.AddWithValue("@Doc", Documento);
                    cmd.ExecuteNonQuery();





                    cmd.Connection.Close();


                }

                catch (Exception ex)
                {
                    conexion.Close();
    
                    MessageBox.Show(ex.Message);
                    return;


                }





                try
                {




                    string q = "insert into tblDetalleOrden(Codigo,referencia,Cantidad,Descuento,Valor,Observacionesr,Caracteristicas,Usuario,Codigo_p,Plug,Codigo_r,Precio) values(@consecutivo,@referencia,@cantidad,@descuento,@valor,@observaciones,@caracteristicas,@Usuario,@codigop,@codigor,@plug,@Precio)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();
                    foreach (DataGridViewRow row in grdOrdenes.Rows)
                    {



                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@consecutivo", Convert.ToString(row.Cells["Codigo"].Value));
                        cmd.Parameters.AddWithValue("@referencia", Convert.ToString(row.Cells["Referencia"].Value));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(row.Cells["Cantidad"].Value));
                        cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells["Descuento"].Value));
                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(row.Cells["Subtotal"].Value));
                        cmd.Parameters.AddWithValue("@observaciones", Convert.ToString(row.Cells["Observaciones"].Value));
                        cmd.Parameters.AddWithValue("@caracteristicas", Convert.ToString(row.Cells["Caracteristica"].Value));
                        cmd.Parameters.AddWithValue("@Usuario", Convert.ToString(row.Cells["Usuario"].Value));
                        cmd.Parameters.AddWithValue("@codigop", Convert.ToString(row.Cells["Codigop"].Value));
                        cmd.Parameters.AddWithValue("@plug", Convert.ToString(row.Cells["Plug"].Value));
                        cmd.Parameters.AddWithValue("@codigor", Convert.ToString(row.Cells["Codigor"].Value));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToString(row.Cells["Valor"].Value));

                        cmd.ExecuteNonQuery();

                    }
                    cmd.Connection.Close();

                    MessageBox.Show("Registro almacenado");
                    insertarsucursales();
                    
                    CREARTICKET();
                    CREARTICKET();
                    ultimoregistro();
                    cont = 1;

                    txtmodificaro.Text = "";
                    limpiarOrden();

                    GRDCONSULTAORDEN.Visible = false;
                    lblmodificarcaracteristicas.Visible = false;


                    //foreach (DataGridViewRow row in grdOrdenes.Rows)
                    //{

                    int gr = 0;

                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }


                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }

                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }
                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }
                    if (grdOrdenes.Rows.Count > 0)
                    {
                        gr = (grdOrdenes.Rows.Count - 1);

                        grdOrdenes.Rows.RemoveAt(gr);
                    }


                }



                catch (Exception ex)
                {
                    conexion.Close();

                    MessageBox.Show(ex.Message);
                    return;


                }
            }
        }

        private void Ordenes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Voltaje = txtVoltaje.Text;
                string Amperaje = txtVoltaje.Text;
                string DurDias = txtVoltaje.Text;
                string Componente = txtVoltaje.Text;
                if (txtPlug.Text == "")
                {
                    MessageBox.Show("Ingrese un plug que exista");
                    return;
                }
                string referencia = txtReferencia.Text;
                string observaciones = "";
                string caracteristicas = "";
                observaciones = txtCodigo.Text;
                if (iusuario == "Administrativo")
                {
                    if (Voltaje == "" || Amperaje == "" || DurDias == "" ||Componente == "")
                    {
                        MessageBox.Show("Ingrese todas las características del ensamble");
                        return;
                    }
                    referencia = "Voltaje:" + txtVoltaje.Text + "V, " + "Amperaje:" + txtAmperaje.Text + ", " + "Componente:" + txtComponente.Text + "Ah, " + "Duración ensamble:" + txtDurDias.Text + " días";
                }
                if (observaciones == "79009")
                {
                    caracteristicas = "Enamble de bateria";
                }
                else
                {


                    int caja = 0;


                    string eslabones = "0";

                    {
                        eslabones = txtEslabones.Text;


                        eslabones = "Eslabones:" + txtEslabones.Text + ", ";
                    }


                    string cajarayada = "", cajaquebrada = "", cajaporosa = "", cajasintornillo = "", cajamanchada = "", chapetano = "", escafnpga = "", pulsonoorg = "", tapanoenrosca = "", cajadecolorada = "";
                    if (txtcajadec.Checked == true)
                    {
                        cajadecolorada = txtcajadec.Text + ", ";
                        caja = 1;

                    }

                    if (tapanoenros.Checked == true)
                    {
                        tapanoenrosca = tapanoenros.Text + ", ";
                        caja = 1;

                    }
                    if (escap.Checked == true)
                    {
                        escafnpga = escap.Text + ", ";
                        caja = 1;

                    }
                    if (pulsonoo.Checked == true)
                    {
                        pulsonoorg = pulsonoo.Text + ", ";
                        caja = 1;

                    }
                    if (chapnoa.Checked == true)
                    {
                        chapetano = chapnoa.Text + ", ";
                        caja = 1;

                    }
                    if (chkcajarayada.Checked == true)
                    {
                        cajarayada = chkcajarayada.Text + ", ";
                        caja = 1;

                    }
                    if (chkCajaquebrada.Checked == true)
                    {
                        cajaquebrada = chkCajaquebrada.Text + ", ";
                        caja = 1;
                    }

                    if (chkcajaporosa.Checked == true)
                    {
                        cajaporosa = chkcajaporosa.Text + ", ";
                        caja = 1;
                    }

                    if (chkcajasintornillo.Checked == true)
                    {
                        cajasintornillo = chkcajasintornillo.Text + ", ";
                        caja = 1;
                    }
                    if (chkcajamanchada.Checked == true)
                    {
                        cajamanchada = chkcajamanchada.Text + ", ";
                        caja = 1;
                    }


                    caja = 0;
                    string coronadesgastada = "", coronafloja = "", coronaoriginal = "", coronasuelta = "", coronaoxidada = "";


                    if (chkcoronadesgastada.Checked == true)
                    {
                        coronadesgastada = chkcoronadesgastada.Text + ", ";
                        caja = 1;
                    }

                    if (chkcoronafloja.Checked == true)
                    {
                        coronafloja = chkcoronafloja.Text + ", ";
                        caja = 1;
                    }
                    if (chkcoronaoriginal.Checked == true)
                    {
                        coronaoriginal = chkcoronaoriginal.Text + ", ";
                        caja = 1;
                    }
                    if (chkcoronaoxidada.Checked == true)
                    {
                        coronaoxidada = chkcoronaoxidada.Text + ", ";
                        caja = 1;
                    }
                    if (chkcoronasuelta.Checked == true)
                    {
                        coronasuelta = chkcoronasuelta.Text + ", ";
                        caja = 1;
                    }


                    string chapetasinpin = "", chapetarayada = "", chapetaoriginal = "";
                    int chapeta = 0;

                    if (chkchapetasinpin.Checked == true)
                    {
                        chapetasinpin = chkchapetasinpin.Text + ", ";
                        chapeta = 1;
                    }
                    if (chkchapetarayada.Checked == true)
                    {
                        chapetarayada = chkchapetarayada.Text + ", ";
                        chapeta = 1;
                    }

                    if (chkchapetaoriginal.Checked == true)
                    {
                        chapetaoriginal = chkchapetaoriginal.Text + ", ";
                        chapeta = 1;
                    }


                    caja = 0;
                    string cristaldespicado = "", cristalhumedad = "", cristalmanchado = "", cristalquebrado = "", cristalrayado = "";


                    if (chkcristaldespicado.Checked == true)
                    {
                        cristaldespicado = chkcristaldespicado.Text + ", ";
                        caja = 1;
                    }
                    if (chkcristalhumedad.Checked == true)
                    {
                        cristalhumedad = chkcristalhumedad.Text + ", ";
                        caja = 1;
                    }
                    if (chkCristalmanchado.Checked == true)
                    {
                        cristalmanchado = chkCristalmanchado.Text + ", ";

                        caja = 1;
                    }

                    if (chkcristalquebrado.Checked == true)
                    {
                        cristalquebrado = chkcristalquebrado.Text + ", ";

                        caja = 1;
                    }
                    if (chkcristalrayado.Checked == true)
                    {
                        cristalrayado = chkcristalrayado.Text + ", ";
                        caja = 1;
                    }


                    string taparayada = "";
                    caja = 0;

                    if (chkTaparayada.Checked == true)
                    {
                        taparayada = chkTaparayada.Text + ", ";
                        caja = 1;
                    }



                    caja = 0;
                    string escafandranumeracion = "", escafandrapintada = "", escafandrarayada = "", escafandrasuelta = "", sinescafandra = "";


                    if (chkescafandranumeracion.Checked == true)
                    {
                        escafandranumeracion = chkescafandranumeracion.Text + ", ";
                        caja = 1;
                    }
                    if (chkescafandrapintada.Checked == true)
                    {
                        escafandrapintada = chkescafandrapintada.Text + ", ";
                        caja = 1;
                    }
                    if (chkEscafandrarayada.Checked == true)
                    {
                        escafandrarayada = chkEscafandrarayada.Text + ", ";
                        caja = 1;
                    }

                    if (chkEscafandrasuelta.Checked == true)
                    {
                        escafandrasuelta = chkEscafandrasuelta.Text + ", ";
                        caja = 1;
                    }



                    caja = 0;
                    string pulsopartido = "", pulsorayado = "", pulsosinhebilla = "", pulsobuenestado = "", pulsodespintado = "";
                    if (chkpulsopartido.Checked == true)
                    {

                        caja = 1;

                    }
                    if (chkpulsorayado.Checked == true)
                    {
                        pulsorayado = chkpulsorayado.Text + ", ";
                        caja = 1;
                    }
                    if (chkpulsosinhebilla.Checked == true)
                    {
                        pulsosinhebilla = chkpulsosinhebilla.Text + ", ";
                        caja = 1;
                    }
                    if (chkpulsodespintado.Checked == true)
                    {
                        pulsodespintado = chkpulsodespintado.Text + ", ";

                        caja = 1;
                    }






                    caja = 0;
                    string tableromanchado = "", tableronumero = "", tableroquebrado = "", tablerorayado = "", tablerosinsegundero = "";

                    if (chktableromanchado.Checked == true)
                    {
                        tableromanchado = chktableromanchado.Text + ", ";
                        caja = 1;
                    }
                    if (chktableronumero.Checked == true)
                    {
                        tableronumero = chktableronumero.Text + ", ";
                        caja = 1;
                    }
                    if (chktableroquebrado.Checked == true)
                    {
                        tableroquebrado = chktableroquebrado.Text + ", ";
                        caja = 1;
                    }

                    if (chkTablerorayado.Checked == true)
                    {
                        tablerorayado = chkTablerorayado.Text + ", ";
                        caja = 1;
                    }
                    if (chktablerosinsegundero.Checked == true)
                    {
                        tablerosinsegundero = chktablerosinsegundero.Text + ", ";
                        caja = 1;
                    }
                    string pulsoad = "", pilsocrista = "";
                    if (pulsoadaptaciones.Checked == true)
                    {
                        pulsoad = pulsoadaptaciones.Text + ", ";
                        caja = 1;
                    }
                    if (pulsocristalizado.Checked == true)
                    {
                        pilsocrista = pulsocristalizado.Text + ", ";
                        caja = 1;
                    }


                    caja = 0;
                    string funcionaanalogo = "", funcionadigital = "", nofuncionananalogo = "", nofuncionadigital = "";
                    if (chkfuncionaanalogo.Checked == true)
                    {
                        caja = 1;
                        funcionaanalogo = chkfuncionaanalogo.Text + ", ";
                    }
                    if (chkfuncionadigital.Checked == true)
                    {
                        funcionadigital = chkfuncionadigital.Text + ", ";

                        caja = 1;
                    }
                    if (chknofuncionadigital.Checked == true)
                    {
                        nofuncionadigital = chknofuncionadigital.Text + ", ";
                        caja = 1;
                    }
                    if (chknofuncionananalogo.Checked == true)
                    {
                        nofuncionananalogo = chknofuncionananalogo.Text + ", ";
                        caja = 1;
                    }





                    caja = 0;
                    string garantiaimpermeabilidad = "", nogarantiaimpermeabilidad = "";

                    if (rdbgarantiaimpermeabilidad.Checked == true)
                    {
                        caja = 1;
                        garantiaimpermeabilidad = rdbgarantiaimpermeabilidad.Text + ", ";

                    }
                    if (rbdnogarantiaimpermeabilidad.Checked == true)
                    {
                        nogarantiaimpermeabilidad = rbdnogarantiaimpermeabilidad.Text + ", ";
                        caja = 1;
                    }



                    caja = 0;
                    string original = "", imitacion = "";
                    if (rbdoriginal.Checked == true)
                    {
                        original = rbdoriginal.Text + ", ";
                        caja = 1;

                    }
                    if (rbdimitacion.Checked == true)
                    {
                        imitacion = rbdimitacion.Text + ", ";
                        caja = 1;
                    }



                    caracteristicas = cajarayada + cajaquebrada + cajaporosa + cajasintornillo + cajamanchada + cajadecolorada + chapetasinpin + chapetarayada + chapetaoriginal + chapetano + cristaldespicado + cristalhumedad + cristalmanchado + cristalquebrado + cristalrayado + coronasuelta + coronaoxidada + coronaoriginal + coronafloja + escafandranumeracion + escafandrapintada + escafandrarayada + escafandrasuelta + escafnpga + sinescafandra + funcionaanalogo + funcionadigital + garantiaimpermeabilidad + nogarantiaimpermeabilidad + nofuncionananalogo + " " + nofuncionadigital + original + imitacion + pulsopartido + pulsorayado + pulsosinhebilla + pulsodespintado + pulsoad + pilsocrista + pulsonoorg + tableromanchado + tableronumero + tableroquebrado + tablerorayado + tablerosinsegundero + taparayada + tapanoenrosca + eslabones;

                }

                if (txtReferencia.Text == "")
                {
                    MessageBox.Show("Ingrese la referencia");
                    return;
                }

                decimal cantidad = 0;
                cantidad = Convert.ToInt32(txtCantidad.Text);

                decimal valor = 0;
                valor = Convert.ToDecimal(txtValor.Text);
                decimal precio = 0;
                precio = valor;
                decimal descuento = 0;
                descuento = Convert.ToInt32(txtdescuento.Text);
                decimal resultad = cantidad * valor;
                decimal resultado = (resultad - (resultad * descuento / 100));


                ultimoregistro();
                string consecutivo = txtConsecutivo.Text;
                string usuario = iusuario;
                string Observacionesr = richobservaciones.Text;
                //if(Contador==1)
                //{
                //    Consecuticoreloj();
                //    try
                //    {




                //        string q = "insert into tblDetalleOrden(Codigo,referencia,Cantidad,Descuento,Valor,Observacionesr,Caracteristicas,Usuario,Codigo_p,Plug,Codigo_r,Precio) values(@consecutivo,@referencia,@cantidad,@descuento,@valor,@observaciones,@caracteristicas,@Usuario,@codigop,@plug,@codigor,@Precio)";

                //        OleDbCommand cmd = new OleDbCommand(q, conexion);
                //        cmd.Connection.Open();

                //        {




                //            cmd.Parameters.AddWithValue("@consecutivo", txtmodificaro.Text);
                //            cmd.Parameters.AddWithValue("@referencia", referencia);
                //            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                //            cmd.Parameters.AddWithValue("@descuento", descuento);

                //            cmd.Parameters.AddWithValue("@valor", resultado);
                //            cmd.Parameters.AddWithValue("@observaciones", Observacionesr);
                //            cmd.Parameters.AddWithValue("@caracteristicas", caracteristicas);
                //            cmd.Parameters.AddWithValue("@usuario", iusuario);
                //            cmd.Parameters.AddWithValue("@codigop", txtCodigo.Text);
                //            cmd.Parameters.AddWithValue("@plug", txtPlug.Text);
                //            cmd.Parameters.AddWithValue("@codigor", txtcRelog.Text);

                //            cmd.Parameters.AddWithValue("@Precio", precio);



                //            cmd.ExecuteNonQuery();
                //            cmd.Connection.Close();


                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //        conexion.Close();
                //    }



                //    int codord = Convert.ToInt32(txtmodificaro.Text);

                //    try
                //    {




                //        txtDocumento.Text = doc;

                //        string qf = "SELECT tblDetalleOrden.Codigo as Consecutivo,tblDetalleOrden.Codigo_r as Codigo_reloj,tblDetalleOrden.referencia, tblDetalleOrden.Cantidad, tblDetalleOrden.Descuento,tblDetalleOrden.Precio as Valor, tblDetalleOrden.Valor as Subtotal,tblDetalleOrden.Codigo_p, tblDetalleOrden.Plug, tblDetalleOrden.Caracteristicas,tblDetalleOrden.Observacionesr,tblDetalleOrden.Usuario FROM tblDetalleOrden  WHERE tblDetalleOrden.Codigo = @Documento AND tblDetalleOrden.Usuario = '" + iusuario + "'";
                //        OleDbCommand comandod = new OleDbCommand(qf, conexion);
                //        comandod.Connection.Open();
                //        comandod.Parameters.AddWithValue("@Documento",txtmodificaro.Text);



                //        OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                //        DataSet pr = new DataSet();
                //        ad.Fill(pr);
                //        GRDCONSULTAORDEN.DataSource = pr.Tables[0];
                //        GRDCONSULTAORDEN.Columns[1].Width = 120;
                //        GRDCONSULTAORDEN.Columns[2].Width = 280;
                //        GRDCONSULTAORDEN.Columns[8].Width = 140;
                //        GRDCONSULTAORDEN.Columns[9].Width = 900;
                //        GRDCONSULTAORDEN.Columns[10].Width = 900;



                //        GRDCONSULTAORDEN.Columns[0].ReadOnly = true;
                //        GRDCONSULTAORDEN.Columns[1].ReadOnly = true;
                //        //GRDCONSULTAORDEN.Columns[7].ReadOnly = true;
                //        GRDCONSULTAORDEN.Columns[8].ReadOnly = true;
                //        GRDCONSULTAORDEN.Columns[6].ReadOnly = true;
                //        comandod.Connection.Close();
                //        limpiarOrdenr();
                //        sumargridmodificar();

                //        this.tabOrdenes.SelectedIndex = 0;
                //        return;

                //    }

                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //        conexion.Close();
                //        return;
                //    }

                //}
                //else
                if (cont == 0)
                {
                    cont = 1;
                }

                txtcRelog.Text = Convert.ToString(cont);
                cont = cont + 1;

                grdOrdenes.Rows.Add(consecutivo, txtcRelog.Text, referencia, cantidad, descuento, precio, resultado, Observacionesr, caracteristicas, usuario, txtCodigo.Text, txtPlug.Text + " ");
                this.tabOrdenes.SelectedIndex = 0;
                limpiarOrdenr();
                grdOrdenes.Columns[6].ReadOnly = true;
                sumargrid();


                mdescuento();
                //this.grdOrdenes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
    }


}

