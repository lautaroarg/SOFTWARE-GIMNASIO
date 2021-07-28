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
    class PlanesMetodos:Conexion
    {
        public DataTable consultar()
        {
            string Consulta = "Select * from Planes where Estado like 'H'";
            var da = new SqlDataAdapter(Consulta,conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt; 
        }
        public Boolean AgregarPlan(Planes PL)
        {
            try
            {
                string consulta = "INSERT INTO Planes(Nombre_Plan,Dias,Precio,Duracion,Estado,Codigo_Plan) Values('" + PL.Nombre_Plan + "','" + PL.Dias + "','" + PL.Precio + "','" + PL.Duracion + "'," +PL.Estado+ "',"+PL.Codigo_Plan + "')";
                SqlCommand comando = new SqlCommand(consulta, conectar());
                comando.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public void Deshabilitar(Planes PL)
        {
            try
            {
                var query = "UPDATE Planes set Estado='" + PL.Estado + "' where Codigo_Plan ='" + PL.Codigo_Plan + "'";
                SqlCommand comando = new SqlCommand(query, conectar());
                comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);

            }

        }

        public void ModificarPlan(Planes PL)
        {
            try
            {
                var query = "UPDATE Planes set Dias ='" + PL.Dias + "', Nombre_Plan ='" + PL.Nombre_Plan + "',Precio='" + PL.Precio + "',Estado='" + PL.Estado + "', Duracion='" + PL.Duracion + "' where Codigo_Plan='"+PL.Codigo_Plan+"'";
                SqlCommand comando = new SqlCommand(query, conectar());
                comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        public DataTable consultarDeshabilitados()
        {
            string Consulta = "Select * from Planes";
            var da = new SqlDataAdapter(Consulta, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
