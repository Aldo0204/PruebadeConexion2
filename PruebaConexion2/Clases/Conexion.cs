using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace PruebaConexion2.Clases
{
    internal class Conexion
    {
        SqlConnection conex = new SqlConnection();

        static string servidor = "localhost";
        static string bd = "BaseDatosProyectoValencia";
        static string usuario = "adminbd";
        static string password = "CoNtR41234";
        static string puerto = "1433";

        string CadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = CadenaConexion;
                conex.Open();
                MessageBox.Show("Se conectó correctamente la base de datos");

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logró conectar la base de datos" + e.ToString());
            }
            return conex;
        }
    }
}
