using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio
{
    internal class Conexion
    {
        private SqlConnection sqlconexion = new SqlConnection();
        private string ConsultaConexion = "Data Source=DESKTOP-OJTKK35\\SQLEXPRESS;Integrated Security=SSPI;Initial catalog=Gimnasio";
        public SqlConnection conectar()
        {
            try // Se ejecuta todo esto si es que no hay error.
            {
                sqlconexion = new SqlConnection(ConsultaConexion);
                if (sqlconexion.State.Equals(ConnectionState.Open))// Si sqlconexion tiene un estado abierto, se cierra.
                {
                    sqlconexion.Close();
                }
                else
                {
                    sqlconexion.Open();
                }
            }
            catch (Exception Ex) // Si se produce un error, mostra el error.
            {
                MessageBox.Show(Ex.Message);
            }

            return sqlconexion;
        }
    }
}
