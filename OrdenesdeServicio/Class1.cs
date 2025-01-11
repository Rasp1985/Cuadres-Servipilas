using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace OrdenesdeServicio
{
    class Class1
    {
        private string usuario,fecha,cajadestino,cajaorigen,empleado;
        private double montotrasladar;
      private  OleDbConnection conexion;
        public double Montotrasladar
        {
            get
            {
                return montotrasladar;
            }

            set
            {
                montotrasladar = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Cajadestino
        {
            get
            {
                return cajadestino;
            }

            set
            {
                cajadestino = value;
            }
        }

        public string Cajaorigen
        {
            get
            {
                return cajaorigen;
            }

            set
            {
                cajaorigen = value;
            }

        }

        public OleDbConnection Conexion
        {
            get
            {
                return conexion;
            }

            set
            {
                conexion = value;
            }
        }

        public string Empleado
        {
            get
            {
                return empleado;
            }

            set
            {
                empleado = value;
            }
        }

        public void trasladarsaldo()
        {
            string documentoc = usuario;
            try
            {






                string q = "update TBLTESORERIA set Valor=Valor+'" + montotrasladar + "' where Tesoreria='" + Cajadestino + "' ";

                OleDbCommand comando = new OleDbCommand(q, Conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();



          

            }

            catch (Exception ex)
            {
                Conexion.Close();

                return;

            }
        }

        public bool restarsaldo()
        {
            string documentoc = usuario;
            try
            {


             



                string q = "update TBLTESORERIA set Valor=Valor-'" + montotrasladar+ "' where Tesoreria='" +cajaorigen+ "' ";

                OleDbCommand comando = new OleDbCommand(q, Conexion);



                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();



               Montotrasladar = 0;
                return true;

            }

            catch (Exception ex)
            {
                Conexion.Close();

                return false;

            }
        }

    }


}
