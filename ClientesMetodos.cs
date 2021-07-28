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
    class ClientesMetodos : Conexion
    {
        public DataTable Consultar()
        {
            string Query = "select CodigoCliente,Nombre, Apellido, DNI, Telefono, Fecha_Nacimiento, Genero,Estado from Clientes where Estado like 'H'";
            var da = new SqlDataAdapter(Query, conectar()); //conectar es el metodo heredado de la clase conexion. Que ese metodo es para conectar la base.
            var ds = new DataSet();

            da.Fill(ds);                // llenar el dataset con lo que tiene el data adapter, que seria la consulta y la conexion.
            DataTable dt = ds.Tables[0];// Al datatable lo lleno con el elemento de la primera fila.
            
            return dt;              //Devuelve el Datetable lleno con los datos de la consulta de SQL.

        }
        public Boolean AgregarCliente(Clientes Cl)
        {
            try
            {
                var query = "INSERT INTO Clientes(DNI,Nombre,Apellido,Telefono,Fecha_Nacimiento,Genero,Estado,CodigoCliente) Values ('" + Cl.DNI + "','" + Cl.Nombre + "','" + Cl.Apellido + "','" + Cl.Telefono + "','" + Cl.Fecha_Nacimiento + "','" + Cl.genero + "','"+Cl.CodigoCliente   +"','" + Cl.Estado + "')";
                            
                SqlCommand Comando = new SqlCommand(query, conectar());
                Comando.ExecuteNonQuery();// Lo que ejecuto no es una consulta, es un COMANDO. (Comandos: Update, Insert y delete.)

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public void Deshabilitar(Clientes CL)
        {
            try
            {
                var query = "UPDATE Clientes set Estado='" + CL.Estado + "' where CodigoCliente ='" + CL.CodigoCliente+"'";
                SqlCommand comando = new SqlCommand(query,conectar());
                comando.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message,"Error",MessageBoxButtons.OK);

            }
        }
        public void ModificarCliente(Clientes CL)
        {
            try
            {
                var query ="UPDATE Clientes set DNI ='"+CL.DNI+"', Nombre ='"+CL.Nombre+"',Apellido='"+CL.Apellido+"',Estado='"+CL.Estado+"', Telefono='"+CL.Telefono+ "',Fecha_Nacimiento='" + CL.Fecha_Nacimiento+"',Genero='"+CL.genero+ "' where CodigoCliente='"+CL.CodigoCliente+"'";
                SqlCommand comando = new SqlCommand(query,conectar());
                comando.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

    }
}
