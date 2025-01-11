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
    public partial class Acceso : Form
    {
        OleDbConnection conexion;

        public Acceso()
        {
            conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb");
           
            InitializeComponent();
        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            llenarcombo();
            
        }

        private void llenarcombo()
        {



            
                try
                {
                    string q = "SELECT Sucursal FROM tblSucursal";
                    OleDbCommand comando = new OleDbCommand(q, conexion);
                    comando.Connection.Open();


                    OleDbDataAdapter ad = new OleDbDataAdapter(comando);
                    DataTable pr = new DataTable("tblSucursal");
                    ad.Fill(pr);
                    cboUsuario.DataSource = pr;
                    cboUsuario.DisplayMember = "tblSucursal";
                    cboUsuario.ValueMember = "Sucursal";

                    comando.Connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexion.Close();
                }
            
     
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            string nombre = cboUsuario.Text;
            string password = txtContraseña.Text;

            if (Acceso.Autenticar(nombre, password))
            {
                this.DialogResult = DialogResult.OK;
                Form1 fr = new Form1();
                fr.acceso(nombre, password);
                this.Hide();

                fr.ShowDialog();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos");
            }

          
        }




        public static bool Autenticar(string usuario, string password)
        {
            try
            {

                string sql = @"SELECT COUNT(*) FROM tblSucursal WHERE Sucursal = @nombre AND Codigo = @password";


                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bdOrdenes.mdb"))
                {
                    conn.Open();

                    OleDbCommand command = new OleDbCommand(sql, conn);
                    command.Parameters.AddWithValue("@nombre", usuario);

                    //string hash = Helper.EncodePassword(string.Concat(usuario, password));
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0)
                        return false;
                    else
                        return true;

                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }



        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            

            }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string nombre = cboUsuario.Text;
                string password = txtContraseña.Text;

                if (Acceso.Autenticar(nombre, password))
                {
                    this.DialogResult = DialogResult.OK;
                    Form1 fr = new Form1();
                    fr.acceso(nombre, password);
                    this.Hide();

                    fr.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña inválidos");
                }
        }
        }

    }
}
