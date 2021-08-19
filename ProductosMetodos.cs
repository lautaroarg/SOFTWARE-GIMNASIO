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
    class ProductosMetodos:Conexion
    {
        public DataTable consultar()
        {
            string Consulta = "Select * from Productos where Estado like 'H'";
            var da = new SqlDataAdapter(Consulta, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public Boolean AgregarProducto(Productos PR)
        {
            try
            {
                string consulta = "INSERT INTO Productos(Nombre_Producto,Cantidad_disponible,Precio_Producto,Categoria_Producto,Estado) Values('" + PR.Nombre_Producto + "','" + PR.Cantidad_disponible + "','" + PR.Precio_Producto + "','" + PR.Categoria_Producto + "','" + PR.Estado + "')";
                SqlCommand comando = new SqlCommand(consulta, conectar());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Deshabilitar(Productos PR)
        {
            try
            {
                var query = "UPDATE Productos set Estado='" + PR.Estado + "' where Codigo_Producto ='" + PR.Codigo_Producto + "'";
                SqlCommand comando = new SqlCommand(query, conectar());
                comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);

            }

        }

        public void ModificarProductos(Productos PR)
        {
            try
            {
                var query = "UPDATE Productos set Cantidad_disponible ='" + PR.Cantidad_disponible + "', Nombre_Producto ='" + PR.Nombre_Producto + "',Precio_Producto='" + PR.Precio_Producto + "',Estado='" + PR.Estado + "', Categoria_Producto='" + PR.Categoria_Producto + "' where Codigo_Producto='" + PR.Codigo_Producto + "'";
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
            string Consulta = "Select * from Productos";
            var da = new SqlDataAdapter(Consulta, conectar());
            var ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public int CodigoNuevo()
        {
            int Cod = 0;
            try
            { var consulta = "Select MAX (Codigo_Producto + 1) 'Codigo nuevo' from Productos ";
                SqlCommand comando = new SqlCommand(consulta,conectar());
                Cod = (int)comando.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
            }
            return Cod;
        }


    }
}
