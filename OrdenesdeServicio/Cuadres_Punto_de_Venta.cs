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
    public partial class Cuadres_Punto_de_Venta : Form
    {
        private string usuario;
        DataSet resultados1 = new DataSet();

        OleDbConnection conexion;
        public Cuadres_Punto_de_Venta(string user)
        {
            usuario = user;
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cuadres_Punto_de_Venta_Load(object sender, EventArgs e)
        {
            txtd8.Text="Consignaciones Megared";
            if (usuario == "Caja Menor")
            {
                label8.Text = "Caja Menor";
            }
            if (usuario == "Contador")
            {
                lblpuntoventa.Visible = false;
                txtSucrsalt.Visible = true;

              
                usuario = txtSucrsalt.Text;
            }
            if (usuario == "Tesorería")
            {
                lblpuntoventa.Visible = false;
                txtSucrsalt.Visible = true;

                txtSucrsalt.Text = usuario;
                usuario = txtSucrsalt.Text;
            }
            else
            {
                txtSucrsalt.Visible = false;
                lblpuntoventa.Visible = true;
                lblpuntoventa.Text = usuario;
              }
         
            txtd8.Enabled = false;
         
        double num = 0;
        
            txtg1.Text = num.ToString();
            txtg2.Text = num.ToString();
            txtg3.Text = num.ToString();
            txtg4.Text = num.ToString();
            txtg5.Text = num.ToString();
            txtg6.Text = num.ToString();
            txtg7.Text = num.ToString();
            txtg8.Text = num.ToString();
            txtg9.Text = num.ToString();
            txtg10.Text = num.ToString();
            txtcompa1.Text = num.ToString();
            txtcompa2.Text = num.ToString();
            txtcompa3.Text = num.ToString();
            txtcompa4.Text = num.ToString();
            txtcompa5.Text = num.ToString();
            txtcompa6.Text = num.ToString();
            txtcompa7.Text = num.ToString();
            txtcompa8.Text = num.ToString();
            txtsobrante.Text = num.ToString();
            txttotalformasdepago.Text = num.ToString();
            txttotalventas.Text = num.ToString();
            txtgastos.Enabled = false;
            txtCompras.Enabled = false;
            txttrasferencias.Text = num.ToString();
            txtEfectivo.Text = num.ToString();
            txtDatafono.Text = num.ToString();
            txtgastos.Text = num.ToString();
            txtCompras.Text = num.ToString();
            txttiendavirtual.Text = num.ToString();
            txtventassistecredito.Text = num.ToString();
            txtaplicaciopnant.Text = num.ToString();


            txtc1.Text= num.ToString();
            txtc2.Text = num.ToString();
            txtc3.Text = num.ToString();
            txtc4.Text = num.ToString(); ;
            txtanticipossiigo.Text = num.ToString();
            txttotalformasdepago.Enabled = false;
            txttotalventas.Enabled = false;
            txtsobrante.Enabled = false;

          
        }

        private void limpiar()
        {
           txtc1.Text= "0";
            rthObservaciones.Text="";
            txtg1.Text = "0";
            txtg2.Text = "0";
            txtg3.Text = "0";
            txtg4.Text = "0";
            txtg5.Text = "0";
            txtg6.Text = "0";
            txtg7.Text = "0";
            txtg8.Text = "0";
            txtg9.Text = "0";
            txtg10.Text = "0";
            txtcompa1.Text = "0";
            txtcompa2.Text = "0";
            txtcompa3.Text = "0";
            txtcompa4.Text = "0";
            txtcompa5.Text = "0";
            txtcompa6.Text = "0";
            txtcompa7.Text = "0";
            txtcompa8.Text = "0";
            txtsobrante.Text = "0";
            txttotalformasdepago.Text = "0";
            txttotalventas.Text = "0";
            txtEfectivo.Text = "0";
            txtDatafono.Text = "0";
            txtgastos.Text= "0";
            txtCompras.Text = "0";
            txttiendavirtual.Text = "0";
            txtventassistecredito.Text = "0";
            txttrasferencias.Text = "0";
            txtaplicaciopnant.Text = "0";
            txtd1.Text = "";
            txtd2.Text = "";
            txtd3.Text = "";
            txtd4.Text = "";
            txtd5.Text = "";
            txtd6.Text = "";
            txtd7.Text = "";
            txtd8.Text = "";
          txtdc1.Text = "";
            txtdc1.Text = "";
            txtdc2.Text = "";
            txtdc3.Text = "";
            txtdc4.Text = "";
            txtdc5.Text = "";
            txtdc6.Text = "";
            txtdc7.Text = "";
            txtdc8.Text = "";
            txtdc9.Text = "";
            txtdc10.Text = "";



            txtc2.Text = "0";
            txtc3.Text = "0";
            txtc4.Text = "0";
            txtanticipossiigo.Text = "0";

        }



        private bool CUADREEXISTE()

        {

          
            string FECHA1 = dtfecha.Text;

            string query = "SELECT COUNT(*) FROM tblCuadre WHERE FECHA=@Fecha and USUARIO=@Usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexion);

            cmd.Parameters.AddWithValue("@Fecha",FECHA1);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
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

        public void insertarregistrostesoreria()
        {
            double efectivo;
            string fecha, cajaorigen, cajadestino, usuario;
            DateTime localDate = DateTime.Now;
            fecha = localDate.ToString();
            efectivo = Convert.ToDouble(txtEfectivo.Text);
            cajaorigen = lblpuntoventa.Text;
            cajadestino = "Tesoreria";
            usuario = lblpuntoventa.Text;
            try
            {






                string q = "update TBLTESORERIA set Valor=Valor+'" + txtEfectivo.Text + "' where Tesoreria='" +usuario + "' ";

                OleDbCommand comando = new OleDbCommand(q, conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();




            }

            catch (Exception ex)
            {
                conexion.Close();
                return;
              

            }
            try
            {






                string q = "insert into TBLREGISTROSTESORERIA(Tesoreria,Valor,Fecha,Origen,Destino) values(@usuario,@efectivo,@fecha,@origen,@destino)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();




                cmd.Parameters.Clear();


                cmd.Parameters.AddWithValue("@usuario", usuario.ToString());
                cmd.Parameters.AddWithValue("@efectivo", efectivo);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@origen", cajaorigen);
                cmd.Parameters.AddWithValue("@destino", cajadestino);



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

        private void btnguardarcliente_Click(object sender, EventArgs e)
        {


            if (CUADREEXISTE() == true)
            {
                MessageBox.Show("El cuadre ya esta registrado");
                return;

            }

            if (MessageBox.Show("Desea guardar el registro", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            string descripciongasto1, descripciongasto2, descripciongasto3, descripciongasto4, descripciongasto5, descripciongasto6, descripciongasto7, descripciongasto8, descripciongasto9, descripciongasto10, observaciones;
            string descripcioncompra1, descripcioncompra2, descripcioncompra3, descripcioncompra4, descripcioncompra5, descripcioncompra6, descripcioncompra7, descripcioncompra8;
            double montogasto1, montogasto2, montogasto3, montogasto4, montogasto5, montogasto6, montogasto7, montogasto8, montogasto9, montogasto10;
            double montocompra1, montocompra2, montocompra3, montocompra4, montocompra5, montocompra6, montocompra7, montocompra8;
            double efectivo, datafono, compras, gastos, ventassistecredito, ventastiendavirtual, aplicacionanticipos, totalventas, totalmediospago, trasferencias;
            double caja1, caja2, caja3, caja4, caja5;
            montogasto1 = Convert.ToDouble(txtg1.Text);
            montogasto2 = Convert.ToDouble(txtg2.Text);
            montogasto3 = Convert.ToDouble(txtg3.Text);
            montogasto4 = Convert.ToDouble(txtg4.Text);
            montogasto5 = Convert.ToDouble(txtg5.Text);
            montogasto6 = Convert.ToDouble(txtg6.Text);
            montogasto7 = Convert.ToDouble(txtg7.Text);
            montogasto8 = Convert.ToDouble(txtg8.Text);
            montogasto9 = Convert.ToDouble(txtg9.Text);
            montogasto10 = Convert.ToDouble(txtg10.Text);
            montocompra1 = Convert.ToDouble(txtcompa1.Text);
            montocompra2 = Convert.ToDouble(txtcompa2.Text);
            montocompra3 = Convert.ToDouble(txtcompa3.Text);
            montocompra4 = Convert.ToDouble(txtcompa4.Text);
            montocompra5 = Convert.ToDouble(txtcompa5.Text);
            montocompra6 = Convert.ToDouble(txtcompa6.Text);
            montocompra7 = Convert.ToDouble(txtcompa7.Text);
            montocompra8 = Convert.ToDouble(txtcompa8.Text);
            efectivo = Convert.ToDouble(txtEfectivo.Text);
            datafono = Convert.ToDouble(txtDatafono.Text);
                observaciones = rthObservaciones.Text;
            ventassistecredito = Convert.ToDouble(txtventassistecredito.Text);
            ventastiendavirtual = Convert.ToDouble(txttiendavirtual.Text);
            aplicacionanticipos = Convert.ToDouble(txtaplicaciopnant.Text);
            caja1 = Convert.ToDouble(txtc1.Text);
            caja2 = Convert.ToDouble(txtc2.Text);
            caja3 = Convert.ToDouble(txtc3.Text);
            caja4 = Convert.ToDouble(txtc4.Text);
            caja5 = Convert.ToDouble(txtanticipossiigo.Text);
            trasferencias = Convert.ToDouble(txttrasferencias.Text);
            compras= Convert.ToDouble(txtCompras.Text);
            gastos = Convert.ToDouble(txtgastos.Text);

              descripcioncompra1=  txtd1.Text;
                descripcioncompra2 = txtd2.Text;
                descripcioncompra3 = txtd3.Text;
                descripcioncompra4 = txtd4.Text;
                descripcioncompra5 = txtd5.Text;
                descripcioncompra6 = txtd6.Text;
                descripcioncompra7 = txtd7.Text;
                descripcioncompra8 = txtd8.Text;
                descripciongasto1 = txtdc1.Text;
                descripciongasto2 = txtdc2.Text;
                descripciongasto3 = txtdc3.Text;
                descripciongasto4 = txtdc4.Text;
                descripciongasto5 = txtdc5.Text;
                descripciongasto6 = txtdc6.Text;
                descripciongasto7 = txtdc7.Text;
                descripciongasto8 = txtdc8.Text;
                descripciongasto9 = txtdc9.Text;
                descripciongasto10 = txtdc10.Text;





                string FECHA1 = dtfecha.Text;



           







            try
            {






                string q = "INSERT INTO tblCuadre (Fecha, C1, C2, C3, C4, C5, EFECTIVO, DATAFONO, GASTOS, COMPRAS, TRANSFERENCIAS, VENTASSISTECREDITO, VENTASTIENDA, APLICACIONANTICIPOS,OBSERVACIONES,USUARIO) values('" + FECHA1 + "','" + caja1 + "','" + caja2 + "','" + caja3 + "','" + caja4 + "','" + caja5 + "','" + efectivo + "','" + datafono+ "','" + gastos + "','" + compras + "','" +trasferencias + "','" + ventassistecredito + "','" + ventastiendavirtual + "','" + aplicacionanticipos + "','" + observaciones + "','" + usuario + "')";

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



                try
                {
                  
                   
                      {
                            string q= "INSERT INTO TBLCOMPRAS(TIPO1,TIPO2,TIPO3,TIPO4,TIPO5,TIPO6,TIPO7,TIPO8,COMPRA1,COMPRA2,COMPRA3,COMPRA4,COMPRA5,COMPRA6,COMPRA7,COMPRA8,FECHA,USUARIO) values('" + descripcioncompra1 + "','" + descripcioncompra2 + "','" + descripcioncompra3 + "','" + descripcioncompra4 + "','" + descripcioncompra5 + "','" + descripcioncompra6 + "','" + descripcioncompra7 + "','" + descripcioncompra8 + "','" + montocompra1 + "','" + montocompra2 + "','" + montocompra3 + "','" + montocompra4 + "','" + montocompra5 + "','" + montocompra6 + "','" + montocompra7 + "','" + montocompra8 + "','" + FECHA1 + "','" + usuario + "')";
                            OleDbCommand comando = new OleDbCommand(q, conexion);
                            comando.Connection.Open();
                            comando.ExecuteNonQuery();
                            comando.Connection.Close();
                        }

                      
                     
               
                }

                catch (Exception ex)
                {
                    conexion.Close();

                    MessageBox.Show(ex.Message);
                    return;


                }


                try
                {


                    {



                        string q10 = "INSERT INTO TBLGASTO(TIPO1,TIPO2,TIPO3,TIPO4,TIPO5,TIPO6,TIPO7,TIPO8,TIPO9,TIPO10,GASTO1,GASTO2,GASTO3,GASTO4,GASTO5,GASTO6,GASTO7,GASTO8,GASTO9,GASTO10,FECHA,USUARIO) values('" + descripciongasto1 + "','" + descripciongasto2 + "','" + descripciongasto3 + "','" + descripciongasto4 + "','" + descripciongasto5 + "','" + descripciongasto6 + "','" + descripciongasto7 + "','" + descripciongasto8 + "','" + descripciongasto9 + "','" + descripciongasto10 + "','" + montogasto1 + "','" + montogasto2 + "','" + montogasto3 + "','" + montogasto4 + "','" + montogasto5 + "','" + montogasto6 + "','" + montogasto7 + "','" + montogasto8 + "','" + montogasto9 + "','" + montogasto10 + "','" + FECHA1 + "','" + usuario + "')";
                        OleDbCommand comando = new OleDbCommand(q10, conexion);
                        comando.Connection.Open();
                        comando.ExecuteNonQuery();
                        comando.Connection.Close();
                    }



                  

                }

                catch (Exception ex)
                {
                    conexion.Close();

                    MessageBox.Show(ex.Message);
                    return;


                }



                MessageBox.Show("Registro Almacenado");
                insertarregistrostesoreria();

                limpiar();
            }
        }




    
    private void btnNuevaorden_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }


        private void calcular()
        {
            try
            {

                double montogasto1, montogasto2, montogasto3, montogasto4, montogasto5, montogasto6, montogasto7, montogasto8, montogasto9, montogasto10;
                double montocompra1, montocompra2, montocompra3, montocompra4, montocompra5, montocompra6, montocompra7, montocompra8;
                double efectivo, datafono, compras, gastos, ventassistecredito, ventastiendavirtual, aplicacionanticipos, totalventas, totalmediospago, trasferencias;
                double caja1, caja2, caja3, caja4, caja5;

                montogasto1 = Convert.ToDouble(txtg1.Text);
                montogasto2 = Convert.ToDouble(txtg2.Text);
                montogasto3 = Convert.ToDouble(txtg3.Text);
                montogasto4 = Convert.ToDouble(txtg4.Text);
                montogasto5 = Convert.ToDouble(txtg5.Text);
                montogasto6 = Convert.ToDouble(txtg6.Text);
                montogasto7 = Convert.ToDouble(txtg7.Text);
                montogasto8 = Convert.ToDouble(txtg8.Text);
                montogasto9 = Convert.ToDouble(txtg9.Text);
                montogasto10 = Convert.ToDouble(txtg10.Text);
                montocompra1 = Convert.ToDouble(txtcompa1.Text);
                montocompra2 = Convert.ToDouble(txtcompa2.Text);
                montocompra3 = Convert.ToDouble(txtcompa3.Text);
                montocompra4 = Convert.ToDouble(txtcompa4.Text);
                montocompra5 = Convert.ToDouble(txtcompa5.Text);
                montocompra6 = Convert.ToDouble(txtcompa6.Text);
                montocompra7 = Convert.ToDouble(txtcompa7.Text);
                montocompra8 = Convert.ToDouble(txtcompa8.Text);
                efectivo = Convert.ToDouble(txtEfectivo.Text);
                datafono = Convert.ToDouble(txtDatafono.Text);

                ventassistecredito = Convert.ToDouble(txtventassistecredito.Text);
                ventastiendavirtual = Convert.ToDouble(txttiendavirtual.Text);
                aplicacionanticipos = Convert.ToDouble(txtaplicaciopnant.Text);
                caja1 = Convert.ToDouble(txtc1.Text);
                caja2 = Convert.ToDouble(txtc2.Text);
                caja3 = Convert.ToDouble(txtc3.Text);
                caja4 = Convert.ToDouble(txtc4.Text);
                caja5 = Convert.ToDouble(txtanticipossiigo.Text);


                totalventas = caja1 + caja2 + caja3 + caja4 + caja5;
             
                compras = montocompra1 + montocompra2 + montocompra3 + montocompra4 + montocompra5 + montocompra6 + montocompra7;
                gastos = montogasto1 + montogasto2 + montogasto3 + montogasto4 + montogasto5 + montogasto6 + montogasto7 + montogasto8 + montogasto9 + montogasto10;
                txtCompras.Text = compras.ToString();
                trasferencias = Convert.ToDouble(txttrasferencias.Text);
                txtgastos.Text = gastos.ToString();
                totalmediospago = efectivo + datafono + compras + gastos + ventassistecredito + trasferencias + ventastiendavirtual - aplicacionanticipos;
                txttotalventas.Text = totalventas.ToString();
                txttotalformasdepago.Text = totalmediospago.ToString();
                txtsobrante.Text = (totalmediospago - totalventas).ToString();

                double numero = Convert.ToDouble(txttotalformasdepago.Text);

                txttotalformasdepago.Text = numero.ToString("N2");

                double numero1 = Convert.ToDouble(txttotalventas.Text);

                txttotalventas.Text = numero1.ToString("N2");


                double numero2 = Convert.ToDouble(txtgastos.Text);

                txtgastos.Text = numero2.ToString("N2");


                double numero3 = Convert.ToDouble(txtCompras.Text);

                txtCompras.Text = numero3.ToString("N2");

                double numero4 = Convert.ToDouble(txtsobrante.Text);

                txtsobrante.Text = numero4.ToString("N2");


                double numero5 = Convert.ToDouble(txtc1.Text);

                txtc1.Text = numero5.ToString("N2");


                double numero6 = Convert.ToDouble(txtc2.Text);

                txtc2.Text = numero6.ToString("N2");


                double numero7 = Convert.ToDouble(txtc3.Text);

                txtc3.Text = numero7.ToString("N2");

                double numero8 = Convert.ToDouble(txtc4.Text);

                txtc4.Text = numero8.ToString("N2");


                double numero9 = Convert.ToDouble(txtanticipossiigo.Text);

                txtanticipossiigo.Text = numero9.ToString("N2");


                double numero10 = Convert.ToDouble(txtEfectivo.Text);

                txtEfectivo.Text = numero10.ToString("N2");


                double numero11 = Convert.ToDouble(txtDatafono.Text);

                txtDatafono.Text = numero11.ToString("N2");



                double numero12 = Convert.ToDouble(txtgastos.Text);

                txtgastos.Text = numero12.ToString("N2");



                double numero13 = Convert.ToDouble(txtCompras.Text);

                txtCompras.Text = numero13.ToString("N2");



                double numero14 = Convert.ToDouble(txttrasferencias.Text);

                txttrasferencias.Text = numero14.ToString("N2");


                double numero15 = Convert.ToDouble(txtventassistecredito.Text);

                txtventassistecredito.Text = numero15.ToString("N2");


                double numero16 = Convert.ToDouble(txttiendavirtual.Text);

                txttiendavirtual.Text = numero16.ToString("N2");


                double numero18 = Convert.ToDouble(txtaplicaciopnant.Text);

                txtaplicaciopnant.Text = numero18.ToString("N2");



                double numero19 = Convert.ToDouble(txtcompa1.Text);

                txtcompa1.Text = numero19.ToString("N2");


                double numero20 = Convert.ToDouble(txtcompa2.Text);

                txtcompa2.Text = numero20.ToString("N2");


                double numero21 = Convert.ToDouble(txtcompa3.Text);

                txtcompa3.Text = numero21.ToString("N2");


                double numero22 = Convert.ToDouble(txtcompa4.Text);

                txtcompa4.Text = numero22.ToString("N2");


                double numero23 = Convert.ToDouble(txtcompa5.Text);

                txtcompa5.Text = numero23.ToString("N2");


                double numero24 = Convert.ToDouble(txtcompa6.Text);

                txtcompa6.Text = numero24.ToString("N2");



                double numero25 = Convert.ToDouble(txtcompa7.Text);

                txtcompa7.Text = numero25.ToString("N2");



                double numero26 = Convert.ToDouble(txtcompa8.Text);

                txtcompa8.Text = numero26.ToString("N2");



                double numero27 = Convert.ToDouble(txtg1.Text);

                txtg1.Text = numero27.ToString("N2");


                double numero28 = Convert.ToDouble(txtg2.Text);

                txtg2.Text = numero28.ToString("N2");



                double numero29 = Convert.ToDouble(txtg3.Text);

                txtg3.Text = numero29.ToString("N2");


                double numero30 = Convert.ToDouble(txtg4.Text);

                txtg4.Text = numero30.ToString("N2");



                double numero31 = Convert.ToDouble(txtg5.Text);

                txtg5.Text = numero31.ToString("N2");



                double numero32 = Convert.ToDouble(txtg6.Text);

                txtg6.Text = numero32.ToString("N2");



                double numero33 = Convert.ToDouble(txtg7.Text);

                txtg7.Text = numero33.ToString("N2");



                double numero34 = Convert.ToDouble(txtg8.Text);

                txtg8.Text = numero34.ToString("N2");



                double numero35 = Convert.ToDouble(txtg9.Text);

                txtg9.Text = numero35.ToString("N2");



                double numero36 = Convert.ToDouble(txtg10.Text);

                txtg10.Text = numero36.ToString("N2");


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


            }

            catch (Exception ex)
            {
                conexion.Close();

                MessageBox.Show("Verifica los valores ingrasados");



            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSucrsalt.Visible==true)
            {
                if (txtSucrsalt.Text == "")
                {
                    MessageBox.Show("Selecciona un punto de venta");
                    return;
                }
                usuario = txtSucrsalt.Text;

            }

        
            try
            {
                string q = "SELECT * from tblCuadre WHERE tblCuadre.FECHA=@Documento and tblCuadre.Usuario=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento",dtfecha.Text);
                comando.Parameters.AddWithValue("@Usuario", usuario);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                   txtc1.Text = dr["C1"].ToString();
                    txtc2.Text = dr["C2"].ToString();
                    txtc3.Text = dr["C3"].ToString();
                    txtc4.Text = dr["C4"].ToString();
                    txtanticipossiigo.Text = dr["C5"].ToString();
                    txtEfectivo.Text = dr["EFECTIVO"].ToString();
                    txtDatafono.Text = dr["DATAFONO"].ToString();
                    txtgastos.Text = dr["GASTOS"].ToString();
                    txtCompras.Text = dr["COMPRAS"].ToString();
                    txttrasferencias.Text = dr["TRANSFERENCIAS"].ToString();
                    txtventassistecredito.Text = dr["VENTASSISTECREDITO"].ToString();
                    txttiendavirtual.Text = dr["VENTASTIENDA"].ToString();
                    txtaplicaciopnant.Text = dr["APLICACIONANTICIPOS"].ToString();
                   rthObservaciones .Text = dr["OBSERVACIONES"].ToString();



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


            try
            {
                string q = "SELECT * from TBLGASTO WHERE TBLGASTO.FECHA=@Documento and  TBLGASTO.USUARIO=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", dtfecha.Text);
                comando.Parameters.AddWithValue("@Usuario", usuario);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtdc1.Text = dr["TIPO1"].ToString();
                    txtdc2.Text = dr["TIPO2"].ToString();
                    txtdc3.Text = dr["TIPO3"].ToString();
                    txtdc4.Text = dr["TIPO4"].ToString();
                    txtdc5.Text = dr["TIPO5"].ToString();
                    txtdc6.Text = dr["TIPO6"].ToString();
                    txtdc7.Text = dr["TIPO7"].ToString();
                    txtdc8.Text = dr["TIPO8"].ToString();
                    txtdc9.Text = dr["TIPO9"].ToString();
                    txtdc10.Text = dr["TIPO10"].ToString();
                    txtg1.Text = dr["GASTO1"].ToString();
                    txtg2.Text = dr["GASTO2"].ToString();
                    txtg3.Text = dr["GASTO3"].ToString();
                    txtg4.Text = dr["GASTO4"].ToString();
                    txtg5.Text = dr["GASTO5"].ToString();
                    txtg6.Text = dr["GASTO6"].ToString();
                    txtg7.Text = dr["GASTO7"].ToString();
                    txtg8.Text = dr["GASTO8"].ToString();
                    txtg9.Text = dr["GASTO9"].ToString();
                    txtg10.Text = dr["GASTO10"].ToString();



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

            try
            {
                string q = "SELECT * from TBLCOMPRAS WHERE TBLCOMPRAS.FECHA=@Documento AND TBLCOMPRAS.USUARIO=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", dtfecha.Text);
                comando.Parameters.AddWithValue("@Usuario", usuario);

                /// comando.Parameters.Add(new OleDbParameter("@fechafactura", OleDbType.Date));
                ///comando.Parameters["@fechafactura"].Value = fecha1;
                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtd1.Text = dr["TIPO1"].ToString();
                    txtd2.Text = dr["TIPO2"].ToString();
                    txtd3.Text = dr["TIPO3"].ToString();
                    txtd4.Text = dr["TIPO4"].ToString();
                    txtd5.Text = dr["TIPO5"].ToString();
                    txtd6.Text = dr["TIPO6"].ToString();
                    txtd7.Text = dr["TIPO7"].ToString();
                    txtd8.Text = dr["TIPO8"].ToString();

                    txtcompa1.Text = dr["COMPRA1"].ToString();
                    txtcompa2.Text = dr["COMPRA2"].ToString();
                    txtcompa3.Text = dr["COMPRA3"].ToString();
                    txtcompa4.Text = dr["COMPRA4"].ToString();
                    txtcompa5.Text = dr["COMPRA5"].ToString();
                    txtcompa6.Text = dr["COMPRA6"].ToString();
                    txtcompa7.Text = dr["COMPRA7"].ToString();
                    txtcompa8.Text = dr["COMPRA8"].ToString();




                }
                dr.Close();

                comando.Connection.Close();




                calcular();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
                string descripciongasto1, descripciongasto2, descripciongasto3, descripciongasto4, descripciongasto5, descripciongasto6, descripciongasto7, descripciongasto8, descripciongasto9, descripciongasto10, observaciones;
                string descripcioncompra1, descripcioncompra2, descripcioncompra3, descripcioncompra4, descripcioncompra5, descripcioncompra6, descripcioncompra7, descripcioncompra8;
                double montogasto1, montogasto2, montogasto3, montogasto4, montogasto5, montogasto6, montogasto7, montogasto8, montogasto9, montogasto10;
                double montocompra1, montocompra2, montocompra3, montocompra4, montocompra5, montocompra6, montocompra7, montocompra8;
                double efectivo, datafono, compras, gastos, ventassistecredito, ventastiendavirtual, aplicacionanticipos, totalventas, totalmediospago, trasferencias;
                double caja1, caja2, caja3, caja4, caja5;

                montogasto1 = Convert.ToDouble(txtg1.Text);
                montogasto2 = Convert.ToDouble(txtg2.Text);
                montogasto3 = Convert.ToDouble(txtg3.Text);
                montogasto4 = Convert.ToDouble(txtg4.Text);
                montogasto5 = Convert.ToDouble(txtg5.Text);
                montogasto6 = Convert.ToDouble(txtg6.Text);
                montogasto7 = Convert.ToDouble(txtg7.Text);
                montogasto8 = Convert.ToDouble(txtg8.Text);
                montogasto9 = Convert.ToDouble(txtg9.Text);
                montogasto10 = Convert.ToDouble(txtg10.Text);
                montocompra1 = Convert.ToDouble(txtcompa1.Text);
                montocompra2 = Convert.ToDouble(txtcompa2.Text);
                montocompra3 = Convert.ToDouble(txtcompa3.Text);
                montocompra4 = Convert.ToDouble(txtcompa4.Text);
                montocompra5 = Convert.ToDouble(txtcompa5.Text);
                montocompra6 = Convert.ToDouble(txtcompa6.Text);
                montocompra7 = Convert.ToDouble(txtcompa7.Text);
                montocompra8 = Convert.ToDouble(txtcompa8.Text);
                efectivo = Convert.ToDouble(txtEfectivo.Text);
                datafono = Convert.ToDouble(txtDatafono.Text);
            gastos = Convert.ToDouble(txtgastos.Text);
            compras = Convert.ToDouble(txtCompras.Text);
            String TRANSFERENCIAS = txttrasferencias.Text;
            ventassistecredito = Convert.ToDouble(txtventassistecredito.Text);
                ventastiendavirtual = Convert.ToDouble(txttiendavirtual.Text);
                aplicacionanticipos = Convert.ToDouble(txtaplicaciopnant.Text);
                caja1 = Convert.ToDouble(txtc1.Text);
                caja2 = Convert.ToDouble(txtc2.Text);
                caja3 = Convert.ToDouble(txtc3.Text);
                caja4 = Convert.ToDouble(txtc4.Text);
                caja5 = Convert.ToDouble(txtanticipossiigo.Text);


                descripcioncompra1 = txtd1.Text;
                descripcioncompra2 = txtd2.Text;
                descripcioncompra3 = txtd3.Text;
                descripcioncompra4 = txtd4.Text;
                descripcioncompra5 = txtd5.Text;
                descripcioncompra6 = txtd6.Text;
                descripcioncompra7 = txtd7.Text;
                descripcioncompra8 = txtd8.Text;
                descripciongasto1 = txtdc1.Text;
                descripciongasto2 = txtdc2.Text;
                descripciongasto3 = txtdc3.Text;
                descripciongasto4 = txtdc4.Text;
                descripciongasto5 = txtdc5.Text;
                descripciongasto6 = txtdc6.Text;
                descripciongasto7 = txtdc7.Text;
                descripciongasto8 = txtdc8.Text;
                descripciongasto9 = txtdc9.Text;
                descripciongasto10 = txtdc10.Text;

            observaciones = rthObservaciones.Text;

                string FECHA1 = dtfecha.Text;
            try
            {
                string q = "update tblCuadre set C1 ='" + caja1 + "',C2 ='" + caja2 + "',C3 ='" + caja3 + "',C4 ='" + caja4 + "',C5 ='" + caja5 + "',EFECTIVO ='" + efectivo + "',DATAFONO ='" + datafono + "',GASTOS ='" + gastos + "',TRANSFERENCIAS ='" +TRANSFERENCIAS+ "',VENTASSISTECREDITO ='" + ventassistecredito + "',VENTASTIENDA ='" + ventastiendavirtual + "',APLICACIONANTICIPOS ='" + aplicacionanticipos + "',Observaciones ='" + observaciones + "' where Documento=@Documento and  USUARIO=@USUARIO";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", FECHA1);
                comando.Parameters.AddWithValue("@USUARIO", usuario);


                comando.ExecuteNonQuery();
                comando.Connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }


            try
            {
                string q = "update TBLCOMPRAS set TIPO1 ='" +descripcioncompra1  + "',TIPO2 ='" + descripcioncompra2 + "',TIPO3 ='" + descripcioncompra3 + "',TIPO4 ='" + descripcioncompra4 + "',TIPO5 ='" + descripcioncompra5 + "',TIPO6 ='" + descripcioncompra6 + "',TIPO7 ='" + descripcioncompra7 + "',TIPO8 ='" + descripcioncompra8 + "',COMPRA1 ='" + montocompra1 + "',COMPRA2 ='" + montocompra2 + "',COMPRA3 ='" + montocompra3 + "',COMPRA4 ='" + montocompra4 + "',COMPRA5 ='" + montocompra5 + "',COMPRA6 ='" + montocompra6 + "',COMPRA7 ='" + montocompra7 + "',COMPRA8 ='" + montocompra8 + "' where Documento=@Documento";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", FECHA1);


                comando.ExecuteNonQuery();
                comando.Connection.Close();
               




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }

            try
            {
                string q = "update TBLGASTO set TIPO1 ='" + descripciongasto1+ "',TIPO2 ='" + descripciongasto2 + "',TIPO3 ='" + descripciongasto3 + "',TIPO4 ='" + descripciongasto4 + "',TIPO5 ='" + descripciongasto5 + "',TIPO6 ='" + descripciongasto6 + "',TIPO7 ='" + descripciongasto7 + "',TIPO8 ='" + descripciongasto8 + "',TIPO9 ='" + descripciongasto9 + "',TIPO10 ='" + descripciongasto10 + "',GASTO1 ='" + montogasto1 + "',GASTO2 ='" + montogasto2 + "',GASTO3 ='" + montogasto3 + "',GASTO4 ='" + montogasto4 + "',GASTO5 ='" + montogasto5 + "',GASTO6 ='" + montogasto6 + "',GASTO7 ='" + montogasto7 + "',GASTO8 ='" + montogasto8 + "',GASTO9 ='" + montogasto9 + "',GASTO10 ='" + montogasto10 + "' where Documento=@Documento";
                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Documento", FECHA1);


                comando.ExecuteNonQuery();
                comando.Connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return;
            }



            MessageBox.Show("Cuadre actualizado con éxito");
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Imprimir_Cuadre impcua = new Imprimir_Cuadre(usuario);
            impcua.Show();
        }

        private void Btnenviardinero_Click(object sender, EventArgs e)
        {
            Tesorería teso = new Tesorería(usuario);
            teso.Show();
        }

        private void Cuadres_Punto_de_Venta_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txttotalformasdepago.Text);

            txttotalformasdepago.Text = numero.ToString("N2");

            double numero1 = Convert.ToDouble(txttotalventas.Text);

            txttotalventas.Text = numero1.ToString("N2");


            double numero2 = Convert.ToDouble(txtgastos.Text);

            txtgastos.Text = numero2.ToString("N2");


            double numero3 = Convert.ToDouble(txtCompras.Text);

            txtCompras.Text = numero3.ToString("N2");

            double numero4 = Convert.ToDouble(txtsobrante.Text);

            txtsobrante.Text = numero4.ToString("N2");


            double numero5 = Convert.ToDouble(txtc1.Text);

            txtc1.Text = numero5.ToString("N2");


            double numero6 = Convert.ToDouble(txtc2.Text);

            txtc2.Text = numero6.ToString("N2");


            double numero7 = Convert.ToDouble(txtc3.Text);

            txtc3.Text = numero7.ToString("N2");

            double numero8 = Convert.ToDouble(txtc4.Text);

            txtc4.Text = numero8.ToString("N2");


            double numero9 = Convert.ToDouble(txtanticipossiigo.Text);

            txtanticipossiigo.Text = numero9.ToString("N2");


            double numero10 = Convert.ToDouble(txtEfectivo.Text);

            txtEfectivo.Text = numero10.ToString("N2");


            double numero11 = Convert.ToDouble(txtDatafono.Text);

            txtDatafono.Text = numero11.ToString("N2");



            double numero12 = Convert.ToDouble(txtgastos.Text);

            txtgastos.Text = numero12.ToString("N2");



            double numero13 = Convert.ToDouble(txtCompras.Text);

            txtCompras.Text = numero13.ToString("N2");



            double numero14 = Convert.ToDouble(txttrasferencias.Text);

            txttrasferencias.Text = numero14.ToString("N2");


            double numero15 = Convert.ToDouble(txtventassistecredito.Text);

            txtventassistecredito.Text = numero15.ToString("N2");


            double numero16 = Convert.ToDouble(txttiendavirtual.Text);

            txttiendavirtual.Text = numero16.ToString("N2");


            double numero18 = Convert.ToDouble(txtaplicaciopnant.Text);

            txtaplicaciopnant.Text = numero18.ToString("N2");



            double numero19 = Convert.ToDouble(txtcompa1.Text);

            txtcompa1.Text = numero19.ToString("N2");


            double numero20 = Convert.ToDouble(txtcompa2.Text);

            txtcompa2.Text = numero20.ToString("N2");


            double numero21 = Convert.ToDouble(txtcompa3.Text);

            txtcompa3.Text = numero21.ToString("N2");


            double numero22 = Convert.ToDouble(txtcompa4.Text);

            txtcompa4.Text = numero22.ToString("N2");


            double numero23 = Convert.ToDouble(txtcompa5.Text);

            txtcompa5.Text = numero23.ToString("N2");


            double numero24 = Convert.ToDouble(txtcompa6.Text);

            txtcompa6.Text = numero24.ToString("N2");



            double numero25 = Convert.ToDouble(txtcompa7.Text);

            txtcompa7.Text = numero25.ToString("N2");



            double numero26 = Convert.ToDouble(txtcompa8.Text);

            txtcompa8.Text = numero26.ToString("N2");



            double numero27 = Convert.ToDouble(txtg1.Text);

            txtg1.Text = numero27.ToString("N2");


            double numero28 = Convert.ToDouble(txtg2.Text);

            txtg2.Text = numero28.ToString("N2");



            double numero29 = Convert.ToDouble(txtg3.Text);

            txtg3.Text = numero29.ToString("N2");


            double numero30 = Convert.ToDouble(txtg4.Text);

            txtg4.Text = numero30.ToString("N2");



            double numero31 = Convert.ToDouble(txtg5.Text);

            txtg5.Text = numero31.ToString("N2");



            double numero32 = Convert.ToDouble(txtg6.Text);

            txtg6.Text = numero32.ToString("N2");



            double numero33 = Convert.ToDouble(txtg7.Text);

            txtg7.Text = numero33.ToString("N2");



            double numero34 = Convert.ToDouble(txtg8.Text);

            txtg8.Text = numero34.ToString("N2");



            double numero35 = Convert.ToDouble(txtg9.Text);

            txtg9.Text = numero35.ToString("N2");



            double numero36 = Convert.ToDouble(txtg10.Text);

            txtg10.Text = numero36.ToString("N2");
        }
    }
}
