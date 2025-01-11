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
    
    public partial class Form1 : Form
    {
       
        private string ireferencia, icaracteristicas, iobservaciones;
        private decimal icantidad, idescuento, ivalor;
        DataSet resultados = new DataSet();
        DataView mifiltro;
        OleDbConnection conexion;
        private string iusuario;
        private string icontraseña;
        
            
        public Form1()
        {

           
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
            InitializeComponent();
        }

        public void acceso(string usuario, string contraseña)
        {
            iusuario = usuario;
            icontraseña = contraseña;
            lblUsuario.Text = usuario;

        }
       
      
        

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clien = new Clientes();
            clien.Show();

        }

        public void llenarordenes()
        {
            resultados.Clear();
            this.Consultarcliente("SELECT  tblCliente.Documento, tblCliente.Nombrecompleto as Nombre_Completo, tblCliente.Telefono as Teléfono, tblCliente.Telofc as Teléfono_Oficina, tblCliente.Ext as Extensión, tblCliente.Direccion as Dirección, tblCliente.Contacto, tblCliente.Email  FROM tblCliente", ref resultados, "tblCliente");
            this.mifiltro = ((DataTable)resultados.Tables["tblCliente"]).DefaultView;
            this.grdCliente.DataSource = mifiltro;
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            
            txtCantidad.Enabled = false;
            acceso(iusuario,icontraseña);

            llenarordenes();
            
            ultimoregistro();
            
            toolTip2.SetToolTip(btnModificar, "Modificar Registro");

            toolTip3.SetToolTip(btnNuevaorden, "Nuevo registro");

            toolTip4.SetToolTip(btnBorrar, "Eliminar registro");

            toolTip5.SetToolTip(btnCerrar, "Cerrar");
            toolTip1.SetToolTip(btnIngresar, "Guardar Registro");
            txtCantidad.Text = "1";
            txtValor.Text = "0";
            txtdescuento.Text = "0";
            txttotalcancelado.Text = "0";
            txtTotal.Text = "0";
            txttotalcancelado.Text = "0";
            txtAnticipo.Text = "0";
            grdCliente.Columns[1].Width = 170;
            grdCliente.Columns[5].Width = 170;
            grdCliente.Columns[7].Width = 170;
           
          

            if (string.IsNullOrEmpty(this.txtdescuento.Text))
            {
                this.txtdescuento.Text = "0";
            }
           
            
        }
        public void Consultarcliente(string query, ref DataSet dsprincipal, string tabla)
        {

            string Documento = txtDocumento.Text;

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
            string documento = txtDocumento.Text;
            string consecutivo = txtConsecutivo.Text;
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese el documento");
                return;
            }
        }






        private void grdCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            char[] delimitador = { '/' };
            txtDocumento.Text = Convert.ToString(this.grdCliente.CurrentRow.Cells[0].Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevaOrden nueva = new NuevaOrden();
            nueva.Show();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

      

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private bool clienteexiste()

          {
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
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
            if (clienteexiste() == false)
            {
                return;
                
            }
            else
            {
                
                this.tabOrdenes.SelectedIndex = 1;
                limpiarOrden();
                txtCantidad.Text = "1";
                txtValor.Text = "0";
                txtdescuento.Text = "0";
                
            }
        }

        private void limpiarOrden()
        {
            chkcajarayada.Checked =false;
            chkCajaquebrada.Checked =false;
            
            chkcajabuenestado.Checked = false;

            chkcajaporosa.Checked =false;
            chkchapetarayada.Checked = false;
            chksineslabones.Checked = false;
            txtEslabones.Text = "";
           

            chkcajasintornillo.Checked =false;
            
            chkcajamanchada.Checked =false;
   
           
            chkcristalbuenestado.Checked =false;
           
            chkcristaldespicado.Checked =false;
            chkcristalhumedad.Checked =false;
            
            chkCristalmanchado.Checked =false;
            
            chkcristalquebrado.Checked =false;
            
          chkcristalrayado.Checked =false;


          chkcoronabuesestado.Checked = false;
          chkcoronadesgastada.Checked = false;
          chkcoronafloja.Checked = false;
          chkcoronafloja.Checked = false;
          chkcoronaoriginal.Checked = false;
          chkcoronaoxidada.Checked = false;
          chkcoronasuelta.Checked = false;


           chkescafandrabuenestado.Checked =false;
            
          chkescafandranumeracion.Checked =false;
           
            chkescafandrapintada.Checked =false;
           
           chkEscafandrarayada.Checked =false;
                

           chkEscafandrasuelta.Checked =false;
            
           chksinescafandra.Checked =false;

           chkTaparayada.Checked = false;

          chkpulsopartido.Checked =false;
          chkTapabuenestado.Checked = false;
          chkTaparayada.Checked = false;
          txtEslabones.Text = "";
          chkchapetaenbuenestado.Checked = false;
          chkchapetaoriginal.Checked = false;
          chkchapetasinpin.Checked = false;
          chkchapetaoriginal.Checked = false;
           
           chkpulsorayado.Checked =false;
            
           chkpulsosinhebilla.Checked =false;
            
           chkpulsodespintado.Checked =false;
           

           chkpulsoenbuenestado.Checked =false;
            

           


           chktablerobuenestado.Checked =false;
           chktableromanchado.Checked =false;
            
          chktableronumero.Checked =false;
           
          chktableroquebrado.Checked =false;
            
            chkTablerorayado.Checked =false;
           chktablerosinsegundero.Checked =false;
            


           chkfuncionaanalogo.Checked =false;
              chkfuncionadigital.Checked =false;
           chknofuncionadigital.Checked =false;
            
          chknofuncionananalogo.Checked =false;
          




          rdbgarantiaimpermeabilidad.Checked =false;
            rbdnogarantiaimpermeabilidad.Checked =false;
            rbdimitacion.Checked = false;
            rbdoriginal.Checked = false;
            txtCantidad.Text = "1";
            txtReferencia.Text = "";
            txtValor.Text ="0";
            txtdescuento.Text = "0";

            rtxtObservaciones.Text = "";
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string referencia = txtReferencia.Text;
            int caja = 0;

            string eslabones = txtEslabones.Text;
            if (chksineslabones.Checked == false)
            {
                if (txtEslabones.Text == "")
                {
                    MessageBox.Show("Ingrese el número de Eslabones");
                    return;
                }
            }
            
            string cajarayada = "", cajaquebrada = "", cajaenbuenestado = "", cajaporosa = "", cajasintornillo = "", cajamanchada = "";
            if (chkcajarayada.Checked == true)
            {
                cajarayada = chkcajarayada.Text;
                caja = 1;

            }
            if (chkCajaquebrada.Checked == true)
            {
                cajaquebrada = chkCajaquebrada.Text;
                caja = 1;
            }
            if (chkcajabuenestado.Checked == true)
            {
                cajaenbuenestado = chkcristalbuenestado.Text;
                caja = 1;
            }
            if (chkcajaporosa.Checked == true)
            {
                cajaporosa = chkcajaporosa.Text;
                caja = 1;
            }

            if (chkcajasintornillo.Checked == true)
            {
                cajasintornillo = chkcajasintornillo.Text;
                caja = 1;
            }
            if (chkcajamanchada.Checked == true)
            {
                cajamanchada = chkcajamanchada.Text;
                caja = 1;
            }
            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características de la caja del reloj");
                return;
            }

            caja = 0;
            string coronadesgastada="", coronafloja="", coronaoriginal="", coronaenbuenestado="", coronasuelta="", coronaoxidada="";

            if (chkcoronabuesestado.Checked == true)
            {
                coronaenbuenestado = chkcoronabuesestado.Text;
                caja = 1;
            }
            if (chkcoronadesgastada.Checked == true)
            {
                coronadesgastada = chkcoronadesgastada.Text;
                caja = 1;
            }

            if (chkcoronafloja.Checked == true)
            {
                coronafloja = chkcoronafloja.Text;
                caja = 1;
            }
            if (chkcoronaoriginal.Checked == true)
            {
                coronaoriginal = chkcoronaoriginal.Text;
                caja = 1;
            }
            if (chkcoronaoxidada.Checked == true)
            {
                coronaoxidada = chkcoronaoxidada.Text;
                caja = 1;
            }
            if (chkcoronasuelta.Checked == true)
            {
                coronasuelta = chkcoronasuelta.Text;
                caja = 1;
            }
            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características de la Corona del reloj");
                return;
            }
           
            string chapetasinpin = "", chapetarayada = "", chapetaoriginal = "", chapetaenbuenestado = "";
            int chapeta = 0;

            if (chkchapetasinpin.Checked == true)
            {
                chapetasinpin = chkchapetasinpin.Text;
                chapeta = 1;
            }
            if (chkchapetarayada.Checked == true)
            {
                chapetarayada = chkchapetarayada.Text;
                chapeta = 1;
            }

            if (chkchapetaoriginal.Checked == true)
            {
                chapetaoriginal = chkchapetaoriginal.Text;
                chapeta = 1;
            }

            if (chkchapetaenbuenestado.Checked == true)
            {
                chapetaenbuenestado = chkchapetaenbuenestado.Text;
                chapeta = 1;
            }
            if (chapeta == 0)
            {
                MessageBox.Show("Seleccione las características de la Chapeta del reloj");
                return;
            }

            caja = 0;
            string cristalbuenestado = "", cristaldespicado = "", cristalhumedad = "", cristalmanchado = "", cristalquebrado = "", cristalrayado = "";

            if (chkcristalbuenestado.Checked == true)
            {
                cristalbuenestado = chkcristalbuenestado.Text;
                caja = 1;

            }
            if (chkcristaldespicado.Checked == true)
            {
                cristaldespicado = chkcristaldespicado.Text;
                caja = 1;
            }
            if (chkcristalhumedad.Checked == true)
            {
                cristalhumedad = chkcristalhumedad.Text;
                caja = 1;
            }
            if (chkCristalmanchado.Checked == true)
            {
                cristalmanchado = chkCristalmanchado.Text;

                caja = 1;
            }

            if (chkcristalquebrado.Checked == true)
            {
                cristalquebrado = chkcristalquebrado.Text;

                caja = 1;
            }
            if (chkcristalrayado.Checked == true)
            {
                cristalrayado = chkcristalrayado.Text;
                caja = 1;
            }
            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características del cristal del reloj");
                return;
            }


            caja = 0;
            string taparayada="", tapabuenestado="";
            if (chkTaparayada.Checked == true)
            {
                taparayada = chkTaparayada.Text;
                caja = 1;
            }

            if (chkTapabuenestado.Checked == true)
            {
                tapabuenestado = chkTapabuenestado.Text;
                caja = 1;
            }

            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características de la tapa del reloj");
                return;
            }
            caja = 0;
            string escafandrabuenestado = "", escafandranumeracion = "", escafandrapintada = "", escafandrarayada = "", escafandrasuelta = "", sinescafandra = "";

            if (chkescafandrabuenestado.Checked == true)
            {
                escafandrabuenestado = chkescafandrabuenestado.Text;
                caja = 1;

            }
            if (chkescafandranumeracion.Checked == true)
            {
                escafandranumeracion = chkescafandranumeracion.Text;
                caja = 1;
            }
            if (chkescafandrapintada.Checked == true)
            {
                escafandrapintada = chkescafandrapintada.Text;
                caja = 1;
            }
            if (chkEscafandrarayada.Checked == true)
            {
                escafandrarayada = chkEscafandrarayada.Text;
                caja = 1;
            }

            if (chkEscafandrasuelta.Checked == true)
            {
                escafandrasuelta = chkEscafandrasuelta.Text;
                caja = 1;
            }
            if (chksinescafandra.Checked == true)
            {
                sinescafandra = chksinescafandra.Text;
                caja = 1;
            }
            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características de la Escafandra del reloj");
                return;
            }

            caja = 0;
            string pulsopartido = "", pulsorayado = "", pulsosinhebilla = "", pulsobuenestado = "", pulsodespintado = "";
            if (chkpulsopartido.Checked == true)
            {

                caja = 1;

            }
            if (chkpulsorayado.Checked == true)
            {
                pulsorayado = chkpulsorayado.Text;
                caja = 1;
            }
            if (chkpulsosinhebilla.Checked == true)
            {
                pulsosinhebilla = chkpulsosinhebilla.Text;
                caja = 1;
            }
            if (chkpulsodespintado.Checked == true)
            {
                pulsodespintado = chkpulsodespintado.Text;

                caja = 1;
            }

            if (chkpulsoenbuenestado.Checked == true)
            {
                pulsobuenestado = chkpulsosinhebilla.Text;
                caja = 1;
            }

            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características del puso del reloj");
                return;
            }


            caja = 0;
            string tablerobuenestado = "", tableromanchado = "", tableronumero = "", tableroquebrado = "", tablerorayado = "", tablerosinsegundero = "";
            if (chktablerobuenestado.Checked == true)
            {
                tablerobuenestado = chktablerobuenestado.Text;
                caja = 1;

            }
            if (chktableromanchado.Checked == true)
            {
                tableromanchado = chktableromanchado.Text;
                caja = 1;
            }
            if (chktableronumero.Checked == true)
            {
                tableronumero = chktableronumero.Text;
                caja = 1;
            }
            if (chktableroquebrado.Checked == true)
            {
                tableroquebrado = chktableroquebrado.Text;
                caja = 1;
            }

            if (chkTablerorayado.Checked == true)
            {
                tablerorayado = chkTablerorayado.Text;
                caja = 1;
            }
            if (chktablerosinsegundero.Checked == true)
            {
                tablerosinsegundero = chktablerosinsegundero.Text;
                caja = 1;
            }

            if (caja == 0)
            {
                MessageBox.Show("Seleccione las características del tablero del reloj");
                return;
            }


            caja = 0;
            string funcionaanalogo = "", funcionadigital = "", nofuncionananalogo = "", nofuncionadigital = "";
            if (chkfuncionaanalogo.Checked == true)
            {
                caja = 1;
                funcionaanalogo = chkfuncionaanalogo.Text;
            }
            if (chkfuncionadigital.Checked == true)
            {
                funcionadigital = chkfuncionadigital.Text;

                caja = 1;
            }
            if (chknofuncionadigital.Checked == true)
            {
                nofuncionadigital = chknofuncionadigital.Text;
                caja = 1;
            }
            if (chknofuncionananalogo.Checked == true)
            {
                nofuncionananalogo = chknofuncionananalogo.Text;
                caja = 1;
            }



            if (caja == 0)
            {
                MessageBox.Show("Seleccione el funcionamiento del reloj");
                return;
            }


            caja = 0;
            string garantiaimpermeabilidad = "", nogarantiaimpermeabilidad = "";

            if (rdbgarantiaimpermeabilidad.Checked == true)
            {
                caja = 1;
                garantiaimpermeabilidad = rdbgarantiaimpermeabilidad.Text;

            }
            if (rbdnogarantiaimpermeabilidad.Checked == true)
            {
                nogarantiaimpermeabilidad = rbdnogarantiaimpermeabilidad.Text;
                caja = 1;
            }

            if (caja == 0)
            {
                MessageBox.Show("Seleccione si tiane o no garantía de impermeabilidad");
                return;
            }



            caja = 0;
            string original = "", imitacion = "";
            if (rbdoriginal.Checked == true)
            {
                original = rbdoriginal.Text;
                caja = 1;

            }
            if (rbdimitacion.Checked == true)
            {
                imitacion = rbdimitacion.Text;
                caja = 1;
            }

            if (caja == 0)
            {
                MessageBox.Show("Seleccione si es original o imitación");
                return;
            }

            //if (txtCantidad.Text == "0")
            //{
            //    MessageBox.Show("Ingrese la cantidad");
            //    return;
            //}

            //if (txtValor.Text == "0")
            //{
            //    MessageBox.Show("Ingrese el valor");
            //    return;
            //}
            if(txtReferencia.Text=="")
            {
                MessageBox.Show("Ingrese la referencia");
                return;
            }

            decimal cantidad = 0;
            cantidad = Convert.ToInt32(txtCantidad.Text);

            decimal valor = 0;
            valor = Convert.ToInt32(txtValor.Text);

            decimal descuento = 0;
            descuento = Convert.ToInt32(txtdescuento.Text);
            decimal resultado = cantidad * valor;
            resultado = (resultado - (resultado * descuento / 100));
            string caracteristicas = "" + cajarayada + " " + cajaquebrada + " " + cajaenbuenestado + " " + cajaporosa + " " + cajasintornillo + " " + cajamanchada + " " + chapetasinpin + " " + chapetarayada + " " + chapetaoriginal + " " + chapetaenbuenestado + " " + cristalbuenestado + " " + cristaldespicado + " " + cristalhumedad + " " + cristalmanchado + " " + cristalquebrado + " " + cristalrayado + " " + coronasuelta + " " + coronaoxidada + " " + coronaoriginal + " " + coronafloja + " " + coronaenbuenestado + " " + escafandrabuenestado + " " + escafandranumeracion + " " + escafandrapintada + " " + escafandrarayada + " " + escafandrasuelta + " " + sinescafandra + " " + funcionaanalogo + " " + funcionadigital + " " + garantiaimpermeabilidad + " " + nogarantiaimpermeabilidad + " " + nofuncionananalogo + " " + nofuncionadigital + " " + original + " " + imitacion + " " + pulsopartido + " " + pulsorayado + " " + pulsosinhebilla + " " + pulsobuenestado + " " + pulsodespintado + " " + tablerobuenestado + " " + tableromanchado + " " + tableronumero + " " + tableroquebrado + " " + tablerorayado + " " + tablerosinsegundero + " " + taparayada + " " + tapabuenestado + "";
            string observaciones = "";
            observaciones = rtxtObservaciones.Text;
            int consecutivo = Convert.ToInt32(txtConsecutivo.Text);

            grdOrdenes.Rows.Add(referencia, cantidad, descuento, resultado, observaciones, caracteristicas,consecutivo);
            this.tabOrdenes.SelectedIndex = 0;
            limpiarOrden();

            sumargrid();


            mdescuento();


        }


        private void mdescuento()
        {
            decimal anticipo = 0;
            decimal totalapagar;
            decimal totalcancelado = 0;
           
            anticipo = Convert.ToDecimal(txtAnticipo.Text);
            totalapagar = Convert.ToDecimal(txtTotal.Text);
            totalcancelado = Convert.ToDecimal(txttotalcancelado.Text);
            if(txtSaldopendiente.Text=="0")
            {
                string cancelado = "Factura Cancelada";
                Lblestadofactura.Text = cancelado;
            }
          
            if (totalcancelado == totalapagar)
            {
                string cancelado = "Factura Cancelada";
                Lblestadofactura.Text = cancelado;
            }
            else
            {
                string sincancelado = "Factura pendiente";
                Lblestadofactura.Text = sincancelado;
            }
           
            txtSaldopendiente.Text = (totalapagar-anticipo).ToString();
        }


        public void sumargrid()
        {

            double sumatoria = 0;

            foreach (DataGridViewRow row in grdOrdenes.Rows)
            {

                sumatoria += Convert.ToDouble(row.Cells[3].Value);
         
            }
            txtTotal.Text = sumatoria.ToString();
        
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
            string salida = "";
            string[] palabrasb = this.txtDocumento.Text.Split(' ');
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

        private void btnBorrarregistro_Click(object sender, EventArgs e)
        {
           int gr=0;
           
        if(grdOrdenes.Rows.Count>0)
         {
           gr = (grdOrdenes.Rows.Count - 1);

       grdOrdenes.Rows.RemoveAt(gr);
      }


         //grdOrdenes.Rows.RemoveAt(0);
        }

        private void ultimoregistro()
        {

            string usuario = lblUsuario.Text;

            if (lblUsuario.Text == "SanDiego")
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


            if (lblUsuario.Text == "Diamante")
            {
                try
                {

                    string q = "SELECT * FROM Diamante WHERE Consecutivo  = (SELECT MAX(Consecutivo) FROM Diamante)";

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



            if (lblUsuario.Text == "SanDiego")
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


            if (lblUsuario.Text == "Diamante")
            {
                try
                {


                    string q = "insert into Diamante(Consecutivo) values(@consecutivo)";

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
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            if (clienteexiste() == false)
            {
                return;

            }
            else
            {

                insertarsucursales();
            
            int Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
            string Documento= txtDocumento.Text;
            decimal total=Convert.ToDecimal(txtTotal.Text);
            decimal anticipo=Convert.ToDecimal(txtAnticipo.Text);
            decimal totalcancelado=Convert.ToDecimal(txttotalcancelado.Text);
            DateTime fecha = Convert.ToDateTime(dtFecha.Text);
            DateTime fechaentrega=Convert.ToDateTime(dtfechaentrega.Text);
            string robservaciones = rtxtObservaciones.Text;

            string stadofactura=Lblestadofactura.Text;
            

            try
            {
                if (grdOrdenes.Rows.Count == 0)
                {
                    MessageBox.Show("Realiza la orden");
                    return;

                }



                string q = "insert into tblOrden(Consecutivo,Documento,Fecha,Fecha_entrega,Total,Anticipo,Estado,Usuario,Observaciones) values(@consecutivo,@documento,@Fecha,@Fechaentrega,@total,@anticipo,@estado,@usuario,@observaciones)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();
                



                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@consecutivo", Consecutivo);
                    cmd.Parameters.AddWithValue("@documento",Documento);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Fechaentrega", fechaentrega);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@anticipo",anticipo);
                    cmd.Parameters.AddWithValue("@estado",stadofactura);
                    cmd.Parameters.AddWithValue("@usuario",iusuario);
                    cmd.Parameters.AddWithValue("@observaciones", robservaciones);
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




                   string q = "insert into tblDetalleOrden(Codigo,referencia,Cantidad,Descuento,Valor,observaciones,Caracteristicas) values(@consecutivo,@referencia,@cantidad,@descuento,@valor,@observaciones,@caracteristicas)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();
                foreach (DataGridViewRow row in grdOrdenes.Rows)
                {
                 
               

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@consecutivo", Convert.ToString(row.Cells["Consecutivo"].Value));
            cmd.Parameters.AddWithValue("@referencia", Convert.ToString(row.Cells["Referencia"].Value));
            cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(row.Cells["Cantidad"].Value));
            cmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells["Descuento"].Value));
            cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(row.Cells["Valor"].Value));
            cmd.Parameters.AddWithValue("@observaciones", Convert.ToString(row.Cells["observaciones"].Value));
            cmd.Parameters.AddWithValue("@caracteristicas", Convert.ToString(row.Cells["Características"].Value));
            cmd.ExecuteNonQuery();

               }

                MessageBox.Show("registro almacenado");
               
                cmd.Connection.Close();
             
                //return true;

            }
               
            catch (Exception ex)
            {
                conexion.Close();
                //return false;
                MessageBox.Show(ex.Message);
               
             

            }



            }


        }
     


        private void borrargrid()
          {
             txttotalcancelado.Text = "0";
            txtTotal.Text = "0";
            txttotalcancelado.Text = "0";
            txtAnticipo.Text = "0";
            txtSaldopendiente.Text = "0";
            rtxtObservacionesgenerales.Text = "";
           

            foreach (DataGridViewRow c in grdOrdenes.Rows)
            {
                // Imaginando que el checkbox esta en la columna 1
               
                
                    grdOrdenes.Rows.Remove(c);
                
            }

          }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txttotalcancelado.Text))
            {
                this.txttotalcancelado.Text = "0";
            }
            if (string.IsNullOrEmpty(this.txtSaldopendiente.Text))
            {
                this.txtSaldopendiente.Text = "0";
            }
            if (string.IsNullOrEmpty(this.txtTotal.Text))
            {
                this.txtTotal.Text = "0";
            }
            if (string.IsNullOrEmpty(this.txtAnticipo.Text))
            {
                this.txtAnticipo.Text = "0";
            }
            mdescuento();
        }

        private void txttotalcancelado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txttotalcancelado.Text))
            {
                this.txttotalcancelado.Text = "0";
            }
            if (string.IsNullOrEmpty(this.txtSaldopendiente.Text))
            {
                this.txtSaldopendiente.Text = "0";
            }
            if (string.IsNullOrEmpty(this.txtTotal.Text))
            {
                this.txtTotal.Text = "0";
            }
            if (string.IsNullOrEmpty(this.txtAnticipo.Text))
            {
                this.txtAnticipo.Text = "0";
            }
            mdescuento();
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
         
            txtSaldopendiente.Text = "0";
            txtAnticipo.Text = "0";

            txtTotal.Text = "0";
            txttotalcancelado.Text = "0";
            rtxtObservacionesgenerales.Text = "";
            //borrargrid();
            grdOrdenes.Rows.Clear();
            ultimoregistro();
        }

        private void eliminarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarOrden elor = new EliminarOrden();
            elor.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EliminarOrden elor = new EliminarOrden();
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

        

       
     

    }

     
}
