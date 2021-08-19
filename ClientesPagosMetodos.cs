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
    class ClientesPagosMetodos:Conexion
    {
        public DataTable CargarComboCliente()
        {
            String consulta = "Select CodigoCliente, Nombre + ' ' + apellido 'NombreC' from Clientes order by Nombre ASC";
            var da = new SqlDataAdapter(consulta, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable CargarComboPlan()
        {
            String consulta = "Select Codigo_plan, Nombre_Plan, Precio from Planes where Estado like 'H' ";
            var da = new SqlDataAdapter(consulta, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dtpl = ds.Tables[0];
            return dtpl;
        }
        public DataTable CargarComboProducto()
        {
            String consulta = "select Nombre_Producto,Codigo_Producto from productos where Estado like 'H' order by Nombre_Producto asc ";
            var da = new SqlDataAdapter(consulta, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public string TotalPlan(Planes pl)
        {
            string Total = "0";
            try
            {
                var consulta = "select Precio from planes where Codigo_Plan like '" + pl.Codigo_Plan +"'";
                SqlCommand comando = new SqlCommand(consulta, conectar());
                Total = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            return Total;
        }
        public string TotalProducto(Productos pr)
        {
            string total = "0";
            try
            {
                var consulta = "select Precio_Producto from Productos where Codigo_Producto like '"+ pr.Codigo_Producto  +"'";
                SqlCommand comando = new SqlCommand(consulta,conectar());
                total = comando.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK);
            }
            return total;
        }

        public Boolean AgregarComprobante(Clientes Cl, Productos PR,ComprobanteProducto CP)
        {
            try
            {
                var query = "INSERT INTO ComprobanteProducto(NumComprobantepr,CodigoCliente,Codigo_Producto,Cantidad,PrecioTotalpr,FechaPago) Values ('" + CP.NumComprobantepr + "','" + Cl.CodigoCliente + "','" + PR.Codigo_Producto + "','" + CP.Cantidad + "','" + CP.PrecioTotalpr + "','" + "','" + CP.FechaPago + "')";

                SqlCommand Comando = new SqlCommand(query, conectar());
                Comando.ExecuteNonQuery();// Lo que ejecuto no es una consulta, es un COMANDO. (Comandos: Update, Insert y delete.)

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        public int CodigoNuevo()
        {
            int count = 0;
            try
            {
                var consulta = "Select MAX(NumComprobantepr + 1) 'Codigo nuevo' from ComprobanteProducto";
                SqlCommand comando = new SqlCommand(consulta, conectar());
                count = (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            return count;
        }


    }
}
