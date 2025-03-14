using Sistema_Envios.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class AlmacenServices
    {
        private Repositorio _repositorio;

        public AlmacenServices() { 

            _repositorio= new Repositorio();
        }
      
        // Método para obtener la lista de almacenes
        public List<Almacen> ObtenerAlmacenes()
        {
            string query = "SELECT ID_Almacen, Nombre FROM Almacen";
            Func<IDataReader, Almacen> mapper = reader => new Almacen
            {
                ID_Almacen = (int)reader["ID_Almacen"],
                Nombre = reader["Nombre"].ToString()
            };

            return _repositorio.ObtenerLista(query, mapper);
        }
    }
}
