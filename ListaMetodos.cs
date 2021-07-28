using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Gimnasio
{
    class ListaMetodos : Conexion
    {
        public DataTable ConsultaFiltroNombre(string Buscar)
        {
            string Query = "select CodigoCliente,Nombre, Apellido, DNI, Telefono, Fecha_Nacimiento, Genero,Estado from Clientes where Nombre like '"+ Buscar +"%' and Estado like'H'";
            var da = new SqlDataAdapter(Query, conectar()); //conectar es el metodo heredado de la clase conexion. Que ese metodo es para conectar la base.
            var ds = new DataSet();
            da.Fill(ds);                // llenar el dataset con lo que tiene el data adapter, que seria la consulta y la conexion.
            DataTable dt = ds.Tables[0];// Al datatable lo lleno con el elemento de la primera fila.

            return dt;              //Devuelve el Datetable lleno con los datos de la consulta de SQL.
        }

        public DataTable ConsultaDeshabilitados()
        {
            string Query = "select CodigoCliente,Nombre, Apellido, DNI, Telefono, Fecha_Nacimiento, Genero,Estado from Clientes";
            var da = new SqlDataAdapter(Query, conectar()); //conectar es el metodo heredado de la clase conexion. Que ese metodo es para conectar la base.
            var ds = new DataSet();
            da.Fill(ds);                // llenar el dataset con lo que tiene el data adapter, que seria la consulta y la conexion.
            DataTable dt = ds.Tables[0];// Al datatable lo lleno con el elemento de la primera fila.

            return dt;              //Devuelve el Datetable lleno con los datos de la consulta de SQL.
        }

        public DataTable ConsultaDNI(string Buscar)
        {
            string Query = "select CodigoCliente,Nombre, Apellido, DNI, Telefono, Fecha_Nacimiento, Genero,Estado from Clientes where DNI like '" +Buscar+ "%' and Estado like'H'";
            var da = new SqlDataAdapter(Query, conectar()); //conectar es el metodo heredado de la clase conexion. Que ese metodo es para conectar la base.
            var ds = new DataSet();
            da.Fill(ds);                // llenar el dataset con lo que tiene el data adapter, que seria la consulta y la conexion.
            DataTable dt = ds.Tables[0];// Al datatable lo lleno con el elemento de la primera fila.

            return dt;              //Devuelve el Datetable lleno con los datos de la consulta de SQL.
        }

        public DataTable ConsultaGenero(string Buscar)
        {
            string Query = "select CodigoCliente,Nombre, Apellido, DNI, Telefono, Fecha_Nacimiento, Genero,Estado from Clientes where Genero like '" + Buscar + "' and Estado like'H'";
            var da = new SqlDataAdapter(Query, conectar()); //conectar es el metodo heredado de la clase conexion. Que ese metodo es para conectar la base.
            var ds = new DataSet();
            da.Fill(ds);                // llenar el dataset con lo que tiene el data adapter, que seria la consulta y la conexion.
            DataTable dt = ds.Tables[0];// Al datatable lo lleno con el elemento de la primera fila.

            return dt;              //Devuelve el Datetable lleno con los datos de la consulta de SQL.
        }
      

    }
}
