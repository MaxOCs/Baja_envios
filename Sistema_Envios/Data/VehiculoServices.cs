using Sistema_Envios.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class VehiculoServices
    {
        private Repositorio _repositorio;
        public VehiculoServices() 
        {
            _repositorio= new Repositorio();
        }
        public List<Vehiculo> ObtenerVehiculos()
        {
            string query = "SELECT ID_Vehiculo, Tipo , Placa FROM Vehiculo where Estado like 'Disponible'";
            Func < IDataReader, Vehiculo> mapper = reader => new Vehiculo
            {
                ID_Vehiculo = (int)reader["ID_Vehiculo"],
                Tipo = reader["Tipo"].ToString(),
                Placa = reader["Placa"].ToString(),

            };

            return _repositorio.ObtenerLista(query, mapper);
        }
    }
}
