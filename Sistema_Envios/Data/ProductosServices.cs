using System;
using Sistema_Envios.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Envios.Data
{
    public class ProductosServices
    {
        private Repositorio _repositorio;

        public ProductosServices()
        {

            _repositorio = new Repositorio();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            string consulta = "SELECT * FROM producto WHERE ID_Producto = @ID";
            Repositorio repo = new Repositorio();
            Producto producto = repo.GetById<Producto>(consulta, idProducto);
            return producto;
        }

        
    }
}
