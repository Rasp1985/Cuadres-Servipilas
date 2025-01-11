using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrdenesdeServicio
{
    public partial class NuevaOrden : Form
    {
        
        public NuevaOrden()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string referencia = txtReferencia.Text;
            int caja = 0;
            string cajarayada = "", cajaquebrada = "", cajaenbuenestado = "", cajaporosa = "", cajasintornillo = "", cajamanchada = "";
            if (chkcajarayada.Checked == true)
            {   cajarayada=chkcajarayada.Text;
                caja = 1;

            }
            if (chkCajaquebrada.Checked == true)
            {
                cajaquebrada=chkCajaquebrada.Text;
                caja = 1;
            }
            if (chkcajabuenestado.Checked == true)
            {
                cajaenbuenestado=chkcristalbuenestado.Text;
                caja = 1;
            }
            if (chkcajaporosa.Checked == true)
            {
                cajaporosa=chkcajaporosa.Text;
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

            if (txtCantidad.Text == "0")
            {
                MessageBox.Show("Ingrese la cantidad");
                return;
            }

            if (txtValor.Text == "0")
            {
                MessageBox.Show("Ingrese el valor");
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
            string caracteristicas = "" + cajarayada + " " + cajaquebrada + " " + cajaenbuenestado + " " + cajaporosa + " " + cajasintornillo + " " + cajamanchada + " " + cristalbuenestado + " " + cristaldespicado + " " + cristalhumedad + " " + cristalmanchado + " " + cristalquebrado + " " + cristalrayado + " " + escafandrabuenestado + " " + escafandranumeracion + " " + escafandrapintada + " " + escafandrarayada + " " + escafandrasuelta + " " + sinescafandra + " " + tablerobuenestado + " " + tableromanchado + " " + tableronumero + " " + tableroquebrado + " " + tablerorayado + " " + tablerosinsegundero + " " + funcionaanalogo + " " + funcionadigital + " " + nofuncionananalogo + " " + nofuncionadigital + " " + garantiaimpermeabilidad + " " + nogarantiaimpermeabilidad + " " + original + " " + imitacion + " " + pulsopartido + " " + pulsorayado + " " + pulsosinhebilla + " " + pulsobuenestado + " " + pulsodespintado + "";
            string observaciones="";
            observaciones = rtxtObservaciones.Text;
        
        
            //Form1 consultar = new Form1();
            //consultar.ShowDialog();

          
            //this.Close();

            


        }



      
        private void NuevaOrden_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = "1";
            txtValor.Text = "0";
            txtdescuento.Text = "0";
            chkReparación.Checked = true;

            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
