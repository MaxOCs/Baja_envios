using Sistema_Envios.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Models
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public int ID_Almacen { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Dimensiones { get; set; }
        public decimal Precio { get; set; }
        public int stock { get; set; }

        public static response Agregar(Producto producto)
        {
            var parametros = new List<Parametro>
            {
                new Parametro("@ID_Almacen", producto.ID_Almacen, SqlDbType.Int),
                new Parametro("@Nombre", producto.Nombre, SqlDbType.VarChar),
                new Parametro("@Descripcion", producto.Descripcion, SqlDbType.VarChar),
                new Parametro("@Dimensiones", producto.Dimensiones, SqlDbType.VarChar),
                new Parametro("@Precio", producto.Precio, SqlDbType.Decimal),
                new Parametro("@stock", producto.stock, SqlDbType.Int)
            };

            // Llamar a la función Ejecutar para ejecutar el procedimiento almacenado
            return Repositorio.EjecutarProcedimiento("RegistrarNuevoProducto", parametros);
        }
        public static response Editar(Producto producto)
        {
            var parametros = new List<Parametro>
            {
                new Parametro("@ID_Producto",producto.ID_Producto, SqlDbType.Int),
                new Parametro("@ID_Almacen", producto.ID_Almacen, SqlDbType.Int),
                new Parametro("@Nombre", producto.Nombre, SqlDbType.VarChar),
                new Parametro("@Descripcion", producto.Descripcion, SqlDbType.VarChar),
                new Parametro("@Dimensiones", producto.Dimensiones, SqlDbType.VarChar),
                new Parametro("@Precio", producto.Precio, SqlDbType.Decimal),
                new Parametro("@stock", producto.stock, SqlDbType.Int)
            };

            // Llamar a la función Ejecutar para ejecutar el procedimiento almacenado
            return Repositorio.EjecutarProcedimiento("ActualizarProducto", parametros);
        }
    }

    
}
