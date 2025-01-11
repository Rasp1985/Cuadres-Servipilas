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
    public partial class Tesorería : Form
    {
        OleDbConnection conexion;
        private int a;
        private int b;
        private int c;
        private int d;
        private int f;
        private int g;
        private int h;
        private int i;
        private int j;
        private string usuario1;
        private int k;
        double efectivo = 0;
        string fecha = "", cajaorigen = "", cajadestino = "", usuario = "", empleado = "", si = "";

        public Tesorería(string user)
        {
            usuario1 = user;
            InitializeComponent();
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
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
                cbonombre.DataSource = pr;
                cbonombre.DisplayMember = "tblvendedor";
                cbonombre.ValueMember = "Vendedor";

                comando.Connection.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }


        }
        private void Tesorería_Load(object sender, EventArgs e)
        {
            llenarcombo();
            txtmontotrasladar.Text = "0";
            LLENARREGISTRO();
            TOTALREGISTRO();
            sumacentral();
            sumamayorca();
            sumamolinos();
            sumasandiego();
            sumatesoreria();
            double numero1 = Convert.ToDouble(txtmayorca.Text);
            txtmayorca.Text = numero1.ToString("N2");
            double numero2 = Convert.ToDouble(txtmolinos.Text);
            txtmolinos.Text = numero2.ToString("N2");
            double numero3 = Convert.ToDouble(txtsandiego.Text);
            txtsandiego.Text = numero3.ToString("N2");
            double numero4 = Convert.ToDouble(txtcental.Text);
            txtcental.Text = numero4.ToString("N2");
            double numero5 = Convert.ToDouble(txttesoreria.Text);
            txttesoreria.Text = numero5.ToString("N2");

        }
        public void LLENARREGISTRO()
        {
            

            try
            {
                string q = "SELECT * FROM TBLTESORERIA";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();

             
                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdusuarios.DataSource = pr.Tables[0];

                grdusuarios.Columns[0].Width = 25;
                grdusuarios.Columns[1].Width = 130;
                grdusuarios.Columns[2].Width = 130;



                conexion.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }


        public void TOTALREGISTRO()
        {


            try
            {
                string q = "SELECT * FROM TBLREGISTROSTESORERIA";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdtesoreria.DataSource = pr.Tables[0];

                grdtesoreria.Columns[0].Width = 25;
                grdtesoreria.Columns[1].Width = 150;
                grdtesoreria.Columns[2].Width = 150;
                grdtesoreria.Columns[3].Width = 150;


                grdtesoreria.Columns[4].Width = 150;


                grdtesoreria.Columns[5].Width = 420;
                conexion.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }


        public void insertarregistros()
        {
        //    double efectivo;
        //string fecha, cajaorigen, cajadestino, usuario;
        DateTime localDate = DateTime.Now;
        fecha = localDate.ToString();
            //efectivo =Convert.ToDouble(txtmontotrasladar.Text);
            //cajaorigen = txtSucrsalt1.Text;
            //cajadestino = txtsucuarsal2.Text;
            //usuario = cbonombre.Text;

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


        public void insertartemporal()
        {
            double efectivo;
            string fecha, cajaorigen, cajadestino, usuario;
            DateTime localDate = DateTime.Now;
            fecha = localDate.ToString();
            efectivo = Convert.ToDouble(txtmontotrasladar.Text);
            cajaorigen = txtSucrsalt1.Text;
            cajadestino = txtsucuarsal2.Text;
            usuario = cbonombre.Text;
            string sino="";


            try
            {






                string q = "insert into TBLTEMPORAL(Usuario,Valor,Fecha,Empleado,Confirmacion,Origen,Destino) values(@usuario,@efectivo,@fecha,Empleado,@si,@origen,@Destino)";

                OleDbCommand cmd = new OleDbCommand(q, conexion);
                cmd.Connection.Open();




                cmd.Parameters.Clear();


                cmd.Parameters.AddWithValue("@usuario", cajadestino);
                cmd.Parameters.AddWithValue("@efectivo", efectivo);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@origen", usuario);
           
                cmd.Parameters.AddWithValue("@si", sino);
                cmd.Parameters.AddWithValue("@Origen", cajaorigen);
                cmd.Parameters.AddWithValue("@Destino", cajadestino);



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


        public void sumasandiego()
        {

            String usuario = "San Diego";
            try
            {
                string q = "SELECT Valor FROM TBLTESORERIA WHERE TBLTESORERIA.Tesoreria=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Usuario", usuario);

                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtsandiego.Text = dr["Valor"].ToString();




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



        public void sumamayorca()
        {
            String usuario = "Mayorca";

            try
            {
                string q = "SELECT Valor FROM TBLTESORERIA WHERE TBLTESORERIA.Tesoreria=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Usuario", usuario);

                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtmayorca.Text = dr["Valor"].ToString();




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

        public void sumamolinos()
        {
            String usuario = "Molinos";

            try
            {
                string q = "SELECT Valor FROM TBLTESORERIA WHERE TBLTESORERIA.Tesoreria=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Usuario", usuario);

                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtmolinos.Text = dr["Valor"].ToString();
                    



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

        public void sumacentral()
        {
            String usuario = "La Central";

            try
            {
                string q = "SELECT Valor FROM TBLTESORERIA WHERE TBLTESORERIA.Tesoreria=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Usuario", usuario);

                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txtcental.Text = dr["Valor"].ToString();

                 
               

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

        public void sumatesoreria()
        {
            String usuario = "Tesorería";

            try
            {
                string q = "SELECT Valor FROM TBLTESORERIA WHERE TBLTESORERIA.Tesoreria=@Usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@Usuario", usuario);

                OleDbDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    txttesoreria.Text = dr["Valor"].ToString();




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
        private void Btnenviardinero_Click(object sender, EventArgs e)
        {
            double efectivo;
            string fecha, cajaorigen, cajadestino, usuario,empleado;
            int a = 0, b = 0, c = 0, d = 0, f = 0, g = 0,h = 0, i = 0, j = 0, k = 0;
            Class1 clase = new Class1();
            DateTime localDate = DateTime.Now;
            fecha = localDate.ToString();
            efectivo = Convert.ToDouble(txtmontotrasladar.Text);
            cajaorigen = txtSucrsalt1.Text;
            cajadestino = txtsucuarsal2.Text;
            empleado = cbonombre.Text;
            usuario = usuario1;

            if (cajadestino == ""&&cajaorigen !="Tesorería")
            {
                MessageBox.Show("Ingresa la caja de destino");
                return;
            }
            if (empleado == "" && cajaorigen == ""&& efectivo==0)
            {
                MessageBox.Show("Ingrasa la caja de origen, Empleado ó Monto a trasladar");
                return;
            }
            clase.Empleado = empleado;
            clase.Cajaorigen=cajaorigen ;
            clase.Cajadestino= cajadestino;
            clase.Usuario=usuario;
            clase.Montotrasladar=efectivo;
            clase.Fecha=fecha;

            clase.Conexion = conexion;


            if (txtSucrsalt1.Text == "Tesorería"&&txtsucuarsal2.Text=="")
            {
                if (MessageBox.Show("Salida de dinero Tesorería: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    k = 1;
                    insertartemporal();
                    LLENARTEMPORAL();
                    clase.trasladarsaldo();
                    insertarregistros();
                    borrartemporal();
                    LLENARREGISTRO();
                    TOTALREGISTRO();
                    sumacentral();
                    sumamayorca();
                    sumamolinos();
                    sumasandiego();
                    sumatesoreria();
                    return;
                }
            }
            if (txtsucuarsal2.Text == "San Diego")

            {
                if (MessageBox.Show("Traslado de: "+cajaorigen+" a "+cajadestino+" Por valor de "+efectivo.ToString("N2"), " Hecho por: "+empleado+" Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    a = 1;
                    insertartemporal();
                    LLENARTEMPORAL();
                }
               
            }
          
            if (txtsucuarsal2.Text == "Mayorca")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), "Hecho por: " + empleado + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    b = 1;
                    insertartemporal();
                    LLENARTEMPORAL();
                }
              
            }
         
            if (txtsucuarsal2.Text == "Molinos")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    c = 1;
                    insertartemporal();
                    LLENARTEMPORAL();
                    //clase.trasladarsaldo();
                    //insertarregistros();
                }

            }
      
            if (txtsucuarsal2.Text == "La Central")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a  " + cajadestino + " Por valor de  " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d = 1;
                    insertartemporal();
                    LLENARTEMPORAL();
                    //clase.trasladarsaldo();
                    //insertarregistros();
                }
               
            }
       
            if (txtsucuarsal2.Text == "Tesorería")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    k = 1;
                    insertartemporal();
                    LLENARTEMPORAL();
                    //clase.trasladarsaldo();
                    //insertarregistros();
                }
               
            }
       
            
          
            if (txtSucrsalt1.Text == "San Diego")
            {
                f = 1;
               
                LLENARTEMPORAL();

                //clase.restarsaldo();

            }
            if (txtSucrsalt1.Text == "Mayorca")
            {
                
                LLENARTEMPORAL();
                //clase.restarsaldo();
                g = 1;
            }
            if (txtSucrsalt1.Text == "Molinos")
            {
                h = 1;
               
                LLENARTEMPORAL();
                //clase.restarsaldo();

            }
            if (txtSucrsalt1.Text == "La Central")
            {
                i = 1;
               
                LLENARTEMPORAL();
                //clase.restarsaldo();
            }
            if (txtSucrsalt1.Text == "Tesoreria")
            {
                j = 1;
              
                LLENARTEMPORAL();
                //clase.restarsaldo();
            }
            LLENARREGISTRO();
            TOTALREGISTRO();
            sumacentral();
            sumamayorca();
            sumamolinos();
            sumasandiego();
            sumatesoreria();
        

    
        }
        public void LLENARTEMPORAL()
        {


            try
            {
                string q = "SELECT * FROM TBLTEMPORAL WHERE Usuario=@usuario";

                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();
                comando.Parameters.AddWithValue("@usuario",usuario1);

                OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                DataSet pr = new DataSet();
                ad.Fill(pr);
                grdAprobaciones.DataSource = pr.Tables[0];

                grdAprobaciones.Columns[0].Width = 15;
                grdAprobaciones.Columns[1].Width = 110;
                grdAprobaciones.Columns[2].Width = 110;
                grdAprobaciones.Columns[3].Width = 140;
                grdAprobaciones.Columns[4].Width = 180;
                grdAprobaciones.Columns[5].Width = 30;


                conexion.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }
        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            LLENARTEMPORAL();
            llenarcombo();
            LLENARREGISTRO();
            sumacentral();
            sumamayorca();
            sumamolinos();
            sumasandiego();
            sumatesoreria();
            double numero1 = Convert.ToDouble(txtmayorca.Text);
            txtmayorca.Text = numero1.ToString("N2");
            double numero2 = Convert.ToDouble(txtmolinos.Text);
          txtmolinos.Text = numero2.ToString("N2");
            double numero3 = Convert.ToDouble(txtsandiego.Text);
            txtsandiego.Text = numero3.ToString("N2");
            double numero4 = Convert.ToDouble(txtcental.Text);
            txtcental.Text = numero4.ToString("N2");
            double numero5 = Convert.ToDouble(txttesoreria.Text);
            txttesoreria.Text = numero5.ToString("N2");
        }

        private void txtSucrsalt1_Click(object sender, EventArgs e)
        {
            double numero1 =Convert.ToDouble(txtmontotrasladar.Text);
           txtmontotrasladar.Text = numero1.ToString("N2");
        }

        private void btnAprobaciones_Click(object sender, EventArgs e)
        {
            

            foreach (DataGridViewRow row in grdAprobaciones.Rows)
            {

                usuario += Convert.ToString(row.Cells[1].Value);
                if(usuario=="")
                {

                    //MessageBox.Show("No hay ninguna transacción");
                    break; 
                }
           

                si += Convert.ToString(row.Cells[5].Value);
                if(si=="")
                     {

                    //MessageBox.Show("No hay ninguna transacción");
                    break;
                }

                efectivo += Convert.ToDouble(row.Cells[2].Value);
                  
      
          

                    fecha += Convert.ToString(row.Cells[3].Value);
            
      

               empleado += Convert.ToString(row.Cells[4].Value);

              cajaorigen += Convert.ToString(row.Cells[6].Value);
              cajadestino += Convert.ToString(row.Cells[7].Value);


                Class1 clase = new Class1();
          
            clase.Cajaorigen = cajaorigen;
            clase.Cajadestino = cajadestino;
            clase.Usuario = usuario;
            clase.Montotrasladar = efectivo;
            clase.Fecha = fecha;

            clase.Conexion = conexion;

            if (cajadestino== "San Diego")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    c = 1;
                    clase.trasladarsaldo();
                    insertarregistros();
                }

            }

            if (cajadestino == "Mayorca")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a  " + cajadestino + " Por valor de  " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    d = 1;
                    clase.trasladarsaldo();
                    insertarregistros();
                }

            }

            if (cajadestino == "Molinos")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    h = 1;
                    clase.trasladarsaldo();
                    insertarregistros();
                }

            }
            if (cajadestino == "La Central")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a  " + cajadestino + " Por valor de  " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    clase.trasladarsaldo();
                    insertarregistros();
                }

            }

            if (cajadestino == "Tesorería")
            {
                if (MessageBox.Show("Traslado de: " + cajaorigen + " a " + cajadestino + " Por valor de " + efectivo.ToString("N2"), " Hecho por: " + usuario + " Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    h = 1;
                    clase.trasladarsaldo();
                    insertarregistros();
                }

            }


            if (cajaorigen == "San Diego")
            {
                f = 1;

                clase.restarsaldo();

            }
            if (cajaorigen == "Mayorca")
            {
                clase.restarsaldo();

            }
            if (cajaorigen == "Molinos")
            {
                h = 1;
                clase.restarsaldo();

            }
            if (cajaorigen == "La Central")
            {

                clase.restarsaldo();
            }
            if (cajaorigen == "Tesorería")
            {

                clase.restarsaldo();
            }
                efectivo = 0;
                fecha = "";
                cajaorigen = "";
                cajadestino = "";
                usuario = "";
                empleado = "";
                si = "";

        
            }

           
            LLENARREGISTRO();
            TOTALREGISTRO();
            sumacentral();
            sumamayorca();
            sumamolinos();
            sumasandiego();
            sumatesoreria();
            LLENARTEMPORAL();
            borrartemporal();
            double numero1 = Convert.ToDouble(txtmayorca.Text);
            txtmayorca.Text = numero1.ToString("N2");
            double numero2 = Convert.ToDouble(txtmolinos.Text);
            txtmolinos.Text = numero2.ToString("N2");
            double numero3 = Convert.ToDouble(txtsandiego.Text);
            txtsandiego.Text = numero3.ToString("N2");
            double numero4 = Convert.ToDouble(txtcental.Text);
            txtcental.Text = numero4.ToString("N2");
            double numero5 = Convert.ToDouble(txttesoreria.Text);
            txttesoreria.Text = numero5.ToString("N2");
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            h = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            j = 0;

        }


        private void borrartemporal()
        {
            try
            {
                string q = "delete TBLTEMPORAL.* from TBLTEMPORAL WHERE TBLTEMPORAL.Usuario=@usuario";


                OleDbCommand comando = new OleDbCommand(q, conexion);
                comando.Connection.Open();


                comando.Parameters.AddWithValue("@Numero", usuario1);

                OleDbDataReader dr = comando.ExecuteReader();



                comando.Connection.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }

        private void Tesorería_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtmontotrasladar.Text);
            txtmontotrasladar.Text = numero1.ToString("N2");
        }
    }
}
