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
    public partial class Reparaciones : Form
    {
        private string usuario;
        DataSet resultados1 = new DataSet();

        OleDbConnection conexion;
        private string documentocliente;
        DataSet resultados = new DataSet();
    
       private int consecutivo;
   
    
        private string iusuario;
        private string icontraseña;
        private double ytotal;
        private double abonosa;
       
   
  
        public Reparaciones(string USER)
        {
            usuario = USER;
            iusuario = USER;
          
     
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }
        public void acceso(string usuario, string contraseña)
        {
            iusuario = usuario;
            icontraseña = contraseña;
            lblUsuario.Text = usuario;

        }
      
      


        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            //consultarordenesgrid();
        }
        public void Grabarventas1()
        {
            if (iusuario == "Administrativo")
            {
                MessageBox.Show("Este usuario solo puede infresar al ttaller de relojeria");
                return;
            }
            if (iusuario == "San Diego")
            {
                try
                {

                    string q = "SELECT * FROM sandiegov WHERE id  = (SELECT MAX(id) FROM sandiegov)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;



                    }
                    dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }


            if (iusuario == "La Central")
            {
                try
                {

                    string q = "SELECT * FROM centralv WHERE id  = (SELECT MAX(id) FROM centralv)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;



                    }
                    dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }





            if (iusuario == "Molinos")
            {
                try
                {

                    string q = "SELECT * FROM molinosv WHERE id  = (SELECT MAX(id) FROM molinosv)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;



                    }
                    dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }




            if (iusuario == "Mayorca")
            {
                try
                {

                    string q = "SELECT * FROM mayorcav WHERE id  = (SELECT MAX(id) FROM mayorcav)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;



                    }
                    dr.Close();

                    comando.Connection.Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }

            if (iusuario == "Puerta del Norte")
            {
                try
                {

                    string q = "SELECT * FROM Puertav WHERE id  = (SELECT MAX(id) FROM Puertav)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;



                    }
                    dr.Close();

                    comando.Connection.Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }
            txtmodificaro.Text = consecutivo.ToString();

            if (MessageBox.Show("Desea guardar el registro", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    DateTime localDate = DateTime.Now;
                    DateTime fechat = localDate.Date;


                    double total = 0;
                    int cantidad = 0;
                    string fecha = "";
                    DateTime dt = DateTime.Now;

                    DateTime fechag = dt.Date;
                    fecha = Convert.ToString(dt.ToString());


                    total = Convert.ToDouble(txtTotal.Text);
                    ytotal = total;
                    string observaciones = rtxtobservaciones.Text;

                    double abono = 0;
                    abono = Convert.ToDouble(txtCabonos.Text);
                    int orden = 0;
                    orden = Convert.ToInt32(txtConsecutivo.Text);

                    string q = "insert into venta(Consecutivo,Fecha,Observaciones,Total,Usuario,Orden,Abono,Fechav) values(@consecuti,@Fecha,@observaciones,@totall,@usuario,@Orden,@Abono,@Fechav)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();




                    cmd.Parameters.Clear();


                    cmd.Parameters.AddWithValue("@consecuti", consecutivo.ToString());
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@observaciones", observaciones);
                    cmd.Parameters.AddWithValue("@total", total.ToString("N2"));
                    cmd.Parameters.AddWithValue("@usuario", iusuario);

                    cmd.Parameters.AddWithValue("@Orden", orden.ToString());

                    cmd.Parameters.AddWithValue("@Abono", abono.ToString("N2"));
                    cmd.Parameters.AddWithValue("@Fechav", fechat);


                    cmd.ExecuteNonQuery();






                    cmd.Connection.Close();


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
                    DateTime localDate = DateTime.Now;
                    DateTime fechat = localDate.Date;




                    string q = "insert into Detalle_venta(Consecutivo,Codigo_plug,plug,Cantidad,Descuento,Valor,Subtotal,usuario,Fecha,FechaS) values(@consecutivo,@codigop,@plug,@cantidad,@descuento,@Precio,@valor,@Usuario,@Fecha,@FechaS)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();

                    foreach (DataGridViewRow row in grdOrdenes1.Rows)
                    {



                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@consecutivo", consecutivo);
                        cmd.Parameters.AddWithValue("@codigop", Convert.ToString(row.Cells["codigop1"].Value));

                        cmd.Parameters.AddWithValue("@plug", Convert.ToString(row.Cells["Plug1"].Value));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Cantidad1"].Value));
                        cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells["Descuento1"].Value));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(row.Cells["Valor1"].Value));

                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(row.Cells["Subtotal1"].Value));
                        cmd.Parameters.AddWithValue("@Usuario", iusuario);
                        cmd.Parameters.AddWithValue("@Fecha", fechat);
                        cmd.Parameters.AddWithValue("@FechaS", localDate);

                        cmd.ExecuteNonQuery();



                    }
                    cmd.Connection.Close();

                    if (MessageBox.Show("Registro almacenado, Desea imprimir", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CREARTICKET1();
                    }
             
                    //facturaentregada();

                    int gr = 0;

                    if (grdOrdenes1.Rows.Count > 0)
                    {
                        gr = (grdOrdenes1.Rows.Count - 1);

                        grdOrdenes1.Rows.RemoveAt(gr);
                    }


                    if (grdOrdenes1.Rows.Count > 0)
                    {
                        gr = (grdOrdenes1.Rows.Count - 1);

                        grdOrdenes1.Rows.RemoveAt(gr);
                    }

                    if (grdOrdenes1.Rows.Count > 0)
                    {
                        gr = (grdOrdenes1.Rows.Count - 1);

                        grdOrdenes1.Rows.RemoveAt(gr);
                    }
                    if (grdOrdenes1.Rows.Count > 0)
                    {
                        gr = (grdOrdenes1.Rows.Count - 1);

                        grdOrdenes1.Rows.RemoveAt(gr);
                    }
                    if (grdOrdenes1.Rows.Count > 0)
                    {
                        gr = (grdOrdenes1.Rows.Count - 1);

                        grdOrdenes1.Rows.RemoveAt(gr);
                    }




                    limpiarOrdentotal();

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
        public void sumarventas1()
        {

            double sumatoria = 0;


            foreach (DataGridViewRow row in grdOrdenes1.Rows)
            {

                sumatoria += Convert.ToDouble(row.Cells[5].Value);

            }
            txtTotal.Text = sumatoria.ToString("N2");

        }
        private void Reparaciones_Load(object sender, EventArgs e)
        {
            txtConsecutivo.Enabled = false;
            toolTip1.SetToolTip(btnAgregar, "Grabar venta");
            toolTip2.SetToolTip(btnCerrar, "Cerrar Plicación");
         

            toolTip3.SetToolTip(btnNuevaorden, "Nuevo registro");

            toolTip4.SetToolTip(btnBorrar, "Eliminar registro");


            txtPlug.Enabled = false;
            
            limpiarOrdentotal();
            txtCodigo.Focus();
      
         
          
        }

        public void consultarticket()
        {
            {
                try
                {

                  string  codord = txtmodificaro.Text;

                    string qf = "SELECT Codigo_Plug as Codigo_p,Plug,Cantidad,Descuento,Valor as Precio,Subtotal as Valor FROM Detalle_venta  WHERE Detalle_venta.Consecutivo = @Documento AND Detalle_venta.Usuario = '" + iusuario + "'";
                    OleDbCommand comandod = new OleDbCommand(qf, conexion);
                    comandod.Connection.Open();
                    comandod.Parameters.AddWithValue("@Documento", codord);



                    OleDbDataAdapter ad = new OleDbDataAdapter(comandod);
                    DataSet pr = new DataSet();
                    ad.Fill(pr);
                    grdOrdenes.DataSource = pr.Tables[0];

                    grdOrdenes.Columns[0].Width = 150;
                    grdOrdenes.Columns[1].Width = 300;
                    grdOrdenes.Columns[2].Width = 100;
                    grdOrdenes.Columns[3].Width = 100;

                    grdOrdenes.Columns[4].Width = 200;
                    grdOrdenes.Columns[5].Width = 250;


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
        public void CREARTICKET()
        {
       
            DateTime fechad = DateTime.Now;

            String FECHALARGAj = fechad.ToString();






            sumarventas();

            string codigoo, codigor, plug;
            codigoo = txtCodigo.Text;
            plug = txtPlug.Text;
     
            int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
            string Documento = txtDocumento.Text;
            decimal total = Convert.ToDecimal(txtTotal.Text);
      
            decimal totalcancelado = Convert.ToDecimal(txtTotal.Text);
            
          
            string robservaciones = txtCodigo.Text;
            decimal abono = Convert.ToDecimal(txtCabonos.Text);
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ///*  ticket.AbreCajon();//*/Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("SERVIPILAS");
            ticket.TextoCentro("SOMOS SU ENERGIA");
            ticket.TextoCentro("");
            ticket.TextoCentro("ORDEN DE SERVICIO REALIZADA");
            ticket.TextoCentro("CON EXITO");
            ticket.lineasGuio();

            ticket.TextoIzquierda("FECHA.....:" +FECHALARGAj);
            ticket.TextoIzquierda("CONSECUTIVO ORDEN...:" + txtmodificaro.Text);
            ticket.TextoIzquierda("PUNTO DE VENTA...:" + iusuario);
   
          
     

            ticket.lineasGuio();
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasGuio();
            //grdOrdenes.Rows.Add(consecutivo, txtcRelog.Text, referencia, cantidad, descuento, resultado, Observacionesr, caracteristicas, usuario, txtCodigo.Text, txtPlug.Text);
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in grdOrdenes.Rows)//dgvLista es el nombre del datagridview
            {
                ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), int.Parse(fila.Cells[0].Value.ToString()),
                    int.Parse(fila.Cells[2].Value.ToString()), decimal.Parse(fila.Cells[4].Value.ToString()));
            }
            ticket.lineasGuio();

            try
            {

                //Resumen de la venta. Sólo son ejemplos

                ticket.AgregarTotales("    TOTAL......$", total);
                ticket.lineasGuio();
                ticket.TextoIzquierda("ORDEN DE SERVICIO CANCELADA");
                ticket.lineasGuio();
           
                //Texto final del Ticket.
                //ticket.TextoIzquierda("");
                ticket.TextoCentro("GRACIAS POR PREFERIRNOS");
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

                //string impresion = Impresora.getImpresoraPorDefecto();
                ////ticket.ImprimirTicket("print");
                //CrearTicket ct = new CrearTicket();
                //using (Font font = new Font("Arial", 9.0f))
                //{


                //    string casa = ticket.Linea.ToString();




                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }




        public void CREARTICKET1()
        {

            DateTime fechad = DateTime.Now;

            String FECHALARGAj = fechad.ToString();






            sumarventas1();

            string codigoo, codigor, plug;
            codigoo = txtCodigo.Text;
            plug = txtPlug.Text;

            int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
            string Documento = txtDocumento.Text;
            decimal total = Convert.ToDecimal(txtTotal.Text);

            decimal totalcancelado = Convert.ToDecimal(txtTotal.Text);


            string robservaciones = txtCodigo.Text;
            decimal abono = Convert.ToDecimal(txtCabonos.Text);
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ///*  ticket.AbreCajon();//*/Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
          
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("SERVIPILAS");
            ticket.TextoCentro("SOMOS SU ENERGIA");
            ticket.TextoCentro("");
            ticket.TextoCentro("ORDEN DE SERVICIO REALIZADA");
            ticket.TextoCentro("CON EXITO");
            ticket.lineasGuio();

            ticket.TextoIzquierda("FECHA.....:" + FECHALARGAj);
            ticket.TextoIzquierda("CONSECUTIVO ORDEN...:" + txtmodificaro.Text);
            ticket.TextoIzquierda("PUNTO DE VENTA...:" + iusuario);




            ticket.lineasGuio();
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasGuio();
            //grdOrdenes.Rows.Add(consecutivo, txtcRelog.Text, referencia, cantidad, descuento, resultado, Observacionesr, caracteristicas, usuario, txtCodigo.Text, txtPlug.Text);
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in grdOrdenes1.Rows)//dgvLista es el nombre del datagridview
            {
                ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), int.Parse(fila.Cells[0].Value.ToString()),
                    int.Parse(fila.Cells[2].Value.ToString()), decimal.Parse(fila.Cells[4].Value.ToString()));
            }
            ticket.lineasGuio();

            try
            {

                //Resumen de la venta. Sólo son ejemplos

                ticket.AgregarTotales("    TOTAL......$", total);
                ticket.lineasGuio();
                ticket.TextoIzquierda("ORDEN DE SERVICIO CANCELADA");
                ticket.lineasGuio();

                //Texto final del Ticket.
                //ticket.TextoIzquierda("");
                ticket.TextoCentro("GRACIAS POR PREFERIRNOS");
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


        public void aumentarconsecutivos()

        {
            if (iusuario == "San Diego")
            {
                try
                {

                    string q = "insert into sandiegov(Campo1) values('s')";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();

                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }
            }

            if (iusuario == "La Central")
                {
                    try
                    {

                        string q = "insert into centralv(Campo1) values('s')";

                        OleDbCommand cmd = new OleDbCommand(q, conexion);
                        cmd.Connection.Open();

                        cmd.ExecuteNonQuery();

                        cmd.Connection.Close();
                    }

                    catch (Exception ex)
                    {
                        conexion.Close();
                        //return false;
                        MessageBox.Show(ex.Message);
                        return;


                    }
                }
                if (iusuario == "Molinos")
                {
                    try
                    {

                        string q = "insert into molinosv(Campo1) values('s')";

                        OleDbCommand cmd = new OleDbCommand(q, conexion);
                        cmd.Connection.Open();

                        cmd.ExecuteNonQuery();

                        cmd.Connection.Close();
                    }

                    catch (Exception ex)
                    {
                        conexion.Close();
                        //return false;
                        MessageBox.Show(ex.Message);
                        return;


                    }
                }

            if (iusuario == "Puerta del Norte")
            {
                try
                {

                    string q = "insert into Puertav(Campo1) values('s')";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();

                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }

                catch (Exception ex)
                {
                    conexion.Close();
                    //return false;
                    MessageBox.Show(ex.Message);
                    return;


                }
            }


            if (iusuario == "Mayorca")
                {
                    try
                    {

                        string q = "insert into mayorcav(Campo1) values('s')";

                        OleDbCommand cmd = new OleDbCommand(q, conexion);
                        cmd.Connection.Open();

                        cmd.ExecuteNonQuery();

                        cmd.Connection.Close();
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



        public void Grabarventas()
        {
            if (iusuario == "Administrativo")
            {
                MessageBox.Show("Este usuario solo puede infresar al ttaller de relojeria");
                return;
            }
            if (iusuario=="San Diego")
            {
                try
                {

                    string q = "SELECT * FROM sandiegov WHERE id  = (SELECT MAX(id) FROM sandiegov)";

        OleDbCommand comando = new OleDbCommand(q, conexion);
        comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                       consecutivo = Convert.ToInt32(dr["Id"].ToString());


                     consecutivo= consecutivo - 1;

                      

                    }
                      dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }


            if (iusuario == "La Central")
            {
                try
                {

                    string q = "SELECT * FROM centralv WHERE id  = (SELECT MAX(id) FROM centralv)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;

                     

                    }
                    dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }





            if (iusuario == "Molinos")
            {
                try
                {

                    string q = "SELECT * FROM molinosv WHERE id  = (SELECT MAX(id) FROM molinosv)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;

        

                    }
                    dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }


            if (iusuario == "Puerta del Norte")
            {
                try
                {

                    string q = "SELECT * FROM Puertav WHERE id  = (SELECT MAX(id) FROM Puertav)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;



                    }
                    dr.Close();

                    comando.Connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }

            if (iusuario == "Mayorca")
            {
                try
                {

                    string q = "SELECT * FROM mayorcav WHERE id  = (SELECT MAX(id) FROM mayorcav)";

                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {

                        consecutivo = Convert.ToInt32(dr["Id"].ToString());


                        consecutivo = consecutivo - 1;

                   

                    }
                    dr.Close();

                    comando.Connection.Close();

                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                    return;
                }
            }


            txtmodificaro.Text = consecutivo.ToString();

            if (MessageBox.Show("Desea guardar el registro", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
            {
               
                    DateTime localDate = DateTime.Now;
                DateTime fechat = localDate;


                double total = 0;
                int cantidad = 0;
                string fecha = "";
                DateTime dt = DateTime.Now;

                DateTime fechag = dt.Date;
                fecha = Convert.ToString(dt.ToString());
             
              
                total = Convert.ToDouble(txtTotal.Text);

                string observaciones = rtxtobservaciones.Text;

                double abono = 0;
                abono = Convert.ToDouble(txtCabonos.Text);
                int orden = 0;
                orden = Convert.ToInt32(txtConsecutivo.Text);


               

                    string q = "insert into venta(Consecutivo,Fecha,Observaciones,Total,Usuario,Orden,Abono,Fechav) values(@consecuti,@Fecha,@observaciones,@total,@usuario,@Orden,@Abono,@Fechav)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();




                cmd.Parameters.Clear();

                //cmd.Parameters.AddWithValue("@consecutivo", consecutivo);
                cmd.Parameters.AddWithValue("@consecuti", consecutivo.ToString());
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@observaciones", observaciones);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@usuario", iusuario);
              
                cmd.Parameters.AddWithValue("@Orden", orden.ToString());
                
                cmd.Parameters.AddWithValue("@Abono", abono);
                cmd.Parameters.AddWithValue("@Fechav", fechat.ToShortDateString());
  
                
                cmd.ExecuteNonQuery();

             

              


                cmd.Connection.Close();
                    

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
                    DateTime localDate = DateTime.Now;
                    DateTime fechat = localDate.Date;



                    string q = "insert into Detalle_venta(Consecutivo,Codigo_plug,plug,Cantidad,Descuento,Valor,Subtotal,usuario,Fecha,FechaS) values(@consecutivo,@codigop,@plug,@cantidad,@descuento,@Precio,@valor,@Usuario,@Fecha,@FechaS)";

                    OleDbCommand cmd = new OleDbCommand(q, conexion);
                    cmd.Connection.Open();

                    foreach (DataGridViewRow row in grdOrdenes1.Rows)
                    {



                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@consecutivo", consecutivo);
                        cmd.Parameters.AddWithValue("@codigop", Convert.ToString(row.Cells["codigop1"].Value));

                        cmd.Parameters.AddWithValue("@plug", Convert.ToString(row.Cells["Plug1"].Value));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Cantidad1"].Value));
                        cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells["Descuento1"].Value));
                        cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(row.Cells["Valor1"].Value));

                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(row.Cells["Subtotal1"].Value));
                        cmd.Parameters.AddWithValue("@Usuario", iusuario);
                        cmd.Parameters.AddWithValue("@Fecha", fechat);
                        cmd.Parameters.AddWithValue("@FechaS", localDate);




                        cmd.ExecuteNonQuery();
                   

                    }
                    cmd.Connection.Close();
                    abonosa = Convert.ToDouble(txtCabonos.Text);
                

                    if (MessageBox.Show("Registro almacenado, Desea imprimir", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CREARTICKET();
                }
              
             
              
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
                //return false;
                MessageBox.Show(ex.Message);
                    return;


                }
            }
        }


        private void facturaentregada()
             {
        try
            {



                string estado = "Pagada";


                DateTime localDate = DateTime.Now;
                DateTime fecha = localDate.Date;
                int consecutivo = Convert.ToInt32(txtConsecutivo.Text);

  
                string q = "update tblOrden set Fecha_entrega='" +fecha + "',Estado='" +estado+ "' where Consecutivo=@Documento and Usuario=@Usuario";



        OleDbCommand comando = new OleDbCommand(q, conexion);
        comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", consecutivo);
                comando.Parameters.AddWithValue("@Usuario", iusuario);






                comando.ExecuteNonQuery();
                comando.Connection.Close();
       
              
            }

            catch (Exception ex)
            {
                conexion.Close();
                //return false;
                MessageBox.Show(ex.Message);
                return;

            }
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
                    txtValor.Text= dr["Precio"].ToString();





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


        public void grabar()

        {



        

        }









        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)13)
            {
                if (iusuario == "Administrativo")
                {
                    MessageBox.Show("Este usuario solo puede ingresar al taller de relojeria");
                    return;
                }
                if (txtConsecutivo.Text != "0") 

                {
                    MessageBox.Show("Para sacar una orden pulsa en el boton Grabar Orden, de lo contrario pulsa en  el boton Limpiar.  NOTA: Recuerda darle en Aplicar Anticipo si adelanto saldo");
                    return;

                }

                if (txtCodigo.Text == "")
                {
                    if (grdOrdenes1.Rows.Count == 0)
                    {
                        MessageBox.Show("Nos has registrado ninguna reparación");
                        return;

                    }
                    else
                    {
                        Grabarventas1();

                        aumentarconsecutivos();
                        //eliminarregistro();



                        sumarventas1();


                        return;

                    }


                }


                string texto = txtCodigo.Text;
                List<String> lista = texto.Split(Convert.ToChar("*")).ToList<String>();
                string valor;
                int carac = 1;
                foreach (String item in lista)
                {


                    int mayor;
                    valor = item;

                    mayor = Convert.ToInt32(valor.ToString());
                    if (mayor >= 500)
                    {
                        txtCodigo.Text = item;
                    }
                    else
                    {
                        txtCantidad.Text = valor;
                    }


                    carac = carac + 1;
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
                        txtValor.Text = dr["Precio"].ToString();





                    }
                    //double ca = Convert.ToInt32(txtValor);
                    //txtValor.Text = ca.ToString("N2");
                    dr.Close();

                    comando.Connection.Close();


                    txtCantidad.Focus();


               


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                }
            }
        }



        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtValor.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (e.KeyChar == (char)13)
            {
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
            


            decimal cantidad = 0;
            cantidad = Convert.ToInt32(txtCantidad.Text);
                string codigo = txtCodigo.Text;
            decimal valor = 0;
            valor = Convert.ToDecimal(txtValor.Text);
            decimal precio = 0;
            precio = valor;
            decimal descuento = 0;
            descuento = Convert.ToInt32(txtdescuento.Text);
            decimal resultad = cantidad * valor;
            decimal resultado = (resultad - (resultad * descuento / 100));
                string plug = txtPlug.Text;
     
                if(txtPlug.Text=="")
                {
                    MessageBox.Show("Debe ingresar el plug");
                    return;
                }

              
                grdOrdenes1.Rows.Add(codigo, plug, cantidad, descuento, valor, resultado);
                txtCodigo.Focus();
                limpiarOrdenr();
                sumarventas1();
                
            }
        }
    

        public void eliminarregistro()
        {
            try
            {
                string q = "delete * from detalle WHERE detalle.Usuario='" + iusuario + "' ";


        OleDbCommand comando = new OleDbCommand(q, conexion);
        comando.Connection.Open();


                OleDbDataReader dr = comando.ExecuteReader();



        comando.Connection.Close();


           




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
  }
private void limpiarOrdenr()
        {

            //txtTotal.Text = "0";

            txtPlug.Text = "";
            
            txtCantidad.Text = "1";
      
            txtValor.Text = "0";
            txtdescuento.Text = "0";

            txtCodigo.Text = "";
            txtCabonos.Text = "0";
            txtConsecutivo.Text = "0";



        }


        private void limpiarOrdentotal()
        {
            rtxtobservaciones.Text = "";
            grdOrdenes1.Visible = true;
            grdCliente.DataSource = null;
            txtSaldopendiente.Text = "0";
          txtTotal.Text = "0";

            txtPlug.Text = "";

            txtCantidad.Text = "1";

            txtValor.Text = "0";
            txtdescuento.Text = "0";

            txtCodigo.Text = "";
            txtCabonos.Text = "0";
            txtConsecutivo.Text = "0";
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


           

            if (grdOrdenes1.Rows.Count > 0)
            {
                gr = (grdOrdenes1.Rows.Count - 1);

                grdOrdenes1.Rows.RemoveAt(gr);
            }

            if (grdOrdenes1.Rows.Count > 0)
            {
                gr = (grdOrdenes1.Rows.Count - 1);

                grdOrdenes1.Rows.RemoveAt(gr);
            }

            if (grdOrdenes1.Rows.Count > 0)
            {
                gr = (grdOrdenes1.Rows.Count - 1);

                grdOrdenes1.Rows.RemoveAt(gr);
            }

            if (grdOrdenes1.Rows.Count > 0)
            {
                gr = (grdOrdenes1.Rows.Count - 1);

                grdOrdenes1.Rows.RemoveAt(gr);
            }

            if (grdOrdenes1.Rows.Count > 0)
            {
                gr = (grdOrdenes1.Rows.Count - 1);

                grdOrdenes1.Rows.RemoveAt(gr);
            }






            txtDocumento.Text = "";


        }
      
        
        

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtValor.Focus();
            }

        }

        private void btnNuevaorden_Click(object sender, EventArgs e)
        {
            limpiarOrdentotal();
            grdOrdenes1.Visible = true;
            eliminarregistro();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdOrdenes1.Visible = false;
            if (txtConsecutivo.Text == "0")
            {
                MessageBox.Show("Ingrese el Número de orden");
                return;
            }
      
          
            string conse = iusuario;
            string documento = txtConsecutivo.Text;
            try
            {
                string q = "SELECT tblDetalleorden.Codigo_p,tblDetalleorden.plug,tblDetalleorden.cantidad,tblDetalleorden.descuento,tblDetalleorden.precio,tblDetalleorden.valor from tblDetalleorden WHERE(((tblDetalleorden.codigo) = '" + documento + "') AND((tblDetalleorden.Usuario) = '" + conse + "'))";



                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdOrdenes.DataSource = pr.Tables[0];
                

                comando.Connection.Close();
                grdOrdenes.Enabled = false;
                sumarventas();
                double int1 = Convert.ToDouble(txtTotal.Text);
                double int2 = Convert.ToDouble(txtCabonos.Text);
                
                double int4 = 0;
                int4 = int1 - int2;
                txtSaldopendiente.Text = int4.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        private void grdOrdenes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                cantidad += Convert.ToDouble(row.Cells[2].Value);
                desxcuento += Convert.ToDouble(row.Cells[3].Value);
                valor += Convert.ToDouble(row.Cells[4].Value);
                valor = valor - (valor * desxcuento / 100);
                valor = cantidad * valor;
                row.Cells[5].Value = valor;


                sumatoria += Convert.ToDouble(row.Cells[5].Value);

            }
            txtTotal.Text = sumatoria.ToString();
        }

   

     

        private void button2_Click(object sender, EventArgs e)
        {
            Abonos ab =new  Abonos(iusuario,txtDocumento.Text);
            ab.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string documentoc = documentocliente;
            double ValorAbono = 0;
            try
            {
                string q = "SELECT Abono FROM sumaabono where Documento=@documentoc";




                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
               

            
                comando.Parameters.AddWithValue("@Documentoc", documentoc);


                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    ValorAbono = double.Parse(dr["Abono"].ToString());
                    
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

            double int1 = Convert.ToDouble(txtTotal.Text);
            double int2 = ValorAbono;
            txtCabonos.Text = (int1 >= int2 ?  int2 : (int2 - (int2 - int1))).ToString();
            double int4 = 0;
            int4 = int1 >= int2 ? int1 - int2: int1 - (int2-(int2-int1));
            txtSaldopendiente.Text = int4.ToString("N2");

        }




        private bool OrdenexisteModificar()

        {

            if (txtConsecutivo.Text == "")
            {
                MessageBox.Show("ingrese una orden que exista");

                return false;
            }
            string id = txtConsecutivo.Text;

            string query = "SELECT COUNT(*) FROM venta WHERE orden=@Id and Usuario=@Usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
          
            cmd.Parameters.AddWithValue("@Usuario", iusuario);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (OrdenexisteModificar() == true)
            {
                MessageBox.Show("El Número de orden ya esta registrado");
                return;

            }

            if (grdOrdenes.Rows.Count == 0)
            {
                MessageBox.Show("Nos has ingresado ninguna orden de Servicio");
                return;

            }
            if (txtConsecutivo.Text =="")
            {
                MessageBox.Show("Selecciona la orden de Servicio");
                return;

            }
            Grabarventas();
            facturaentregada();
            aumentarconsecutivos();
            eliminarabonos();
            limpiarOrdentotal();
            sumarventas();
            grdOrdenes1.Visible = true;

        }

        public void eliminarabonos()
        {
            string documentoc = documentocliente;
            try
            {


                string Documento = txtConsecutivo.Text;
                double abono = abonosa;



                string q = "update sumaabono set Abono=Abono-'" + abono + "' where Documento='" + documentoc + "' ";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();



                abonosa = 0;


            }

            catch (Exception ex)
            {
                conexion.Close();

                MessageBox.Show(ex.Message);



            }
        }
private void btnBorrar_Click(object sender, EventArgs e)
        {
            Anular_venta an = new Anular_venta(iusuario);
            an.Show();

        }
        public void sumaranticipos()
        {

            double sumatoria = 0;
           
            foreach (DataGridViewRow row in grdOrdenes.Rows)
            {
                               
                sumatoria += Convert.ToDouble(row.Cells[7].Value);

            }
         
            txtTotal.Text = sumatoria.ToString();

        }

        public void sumarventas()
        {

            double sumatoria = 0;
      

            foreach (DataGridViewRow row in grdOrdenes.Rows)
            {
                
                sumatoria += Convert.ToDouble(row.Cells[5].Value);

            }
            txtTotal.Text = sumatoria.ToString("N2");
            
        }
       

      

        private void rdbhoy_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            
            fecha.Date.ToShortDateString();

        }

        private void rdbayer_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.AddDays(-1);


        }


         private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (OrdenexisteModificar() == true)
            {
                MessageBox.Show("El Número de orden ya esta registrado");
                return;

            }

            if (grdOrdenes.Rows.Count == 0)
            {
                MessageBox.Show("Nos has ingresado ninguna orden de Servicio");
                return;

            }
            if (txtConsecutivo.Text == "")
            {
                MessageBox.Show("Selecciona la orden de Servicio");
                return;

            }
            Grabarventas();
            aumentarconsecutivos();
            facturaentregada();
            eliminarabonos();
            limpiarOrdentotal();
            sumarventas();
            grdOrdenes1.Visible = true;
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimirventas rp = new imprimirventas();
            rp.Show();

        }

        private void tallerDeRelojeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repuestosreloj rep = new Repuestosreloj(iusuario);
            rep.Show();
        }

        private void ordenesDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1(iusuario);
            fr.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empl = new OrdenesdeServicio.Empleados();
            empl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            consultarticket();
            CREARTICKET();
            limpiarOrdentotal();
        }

        private void comprobanteDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ventasYAbonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultarabonos ab = new Consultarabonos();
            ab.Show();
        }
        public void Consultarordenescliente()
        {


            string Documento = txtDocumento.Text;

            try
            {
                string q = "select tblOrden.Consecutivo, tblDetalleOrden.Codigo_r as Codigo_reloj,tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo,  tblOrden.Usuario, tblOrden.Total,tblOrden.Estado,tblOrden.Fecha_entrega,tblDetalleOrden.Referencia,tblDetalleOrden.Caracteristicas,tblDetalleOrden.Observacionesr FROM tblCliente INNER JOIN(tblOrden INNER JOIN tblDetalleOrden ON tblOrden.Consecutivo = tblDetalleOrden.Codigo) ON tblCliente.Documento = tblOrden.Documento where tblOrden.Documento = '" + Documento + "' and tblOrden.Usuario = '" + iusuario + "'";

                OleDbCommand comando = new OleDbCommand(q, conexion);


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdCliente.DataSource = pr.Tables[0];
       
                grdCliente.Columns[10].Width = 420;
                grdCliente.Columns[9].Width = 420;
                grdCliente.Columns[3].Width = 180;
                comando.Connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Consultarordenescliente();
                
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultarordenescliente();
        }

        private void grdCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtConsecutivo.Text = grdCliente.CurrentRow.Cells["Consecutivo"].Value.ToString();
            documentocliente = grdCliente.CurrentRow.Cells["Documento"].Value.ToString();
        }

        private void salidaMercanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Totales frmt = new Totales(iusuario);
            frmt.Show();
        }

        private void grdOrdenes1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double sumatoria = 0;
            double desxcuento = 0;
            double cantidad = 0;
            double valor = 0;

            foreach (DataGridViewRow row in grdOrdenes1.Rows)
            {
                desxcuento = 0;
                cantidad = 0;
                valor = 0;
                cantidad += Convert.ToDouble(row.Cells[2].Value);
                desxcuento += Convert.ToDouble(row.Cells[3].Value);
                valor += Convert.ToDouble(row.Cells[4].Value);
                valor = valor - (valor * desxcuento / 100);
                valor = cantidad * valor;
                row.Cells[5].Value = valor;


                sumatoria += Convert.ToDouble(row.Cells[5].Value);

            }
            txtTotal.Text = sumatoria.ToString();
        }

        private void txtCabonos_TextChanged(object sender, EventArgs e)
        {
            if(txtCabonos.Text=="")
            {
                return;
            }

            double int1 = Convert.ToDouble(txtTotal.Text);
            double int2 = Convert.ToDouble(txtCabonos.Text);

            double int4 = 0;
            int4 = int1 - int2;
            txtSaldopendiente.Text = int4.ToString();
        }

        private void actividadesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actividades_Realizadas act = new Actividades_Realizadas();
            act.Show();
        }

        private void cuadreCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuadres_Punto_de_Venta cuadre = new Cuadres_Punto_de_Venta(usuario);
            cuadre.Show();

        }

     

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

