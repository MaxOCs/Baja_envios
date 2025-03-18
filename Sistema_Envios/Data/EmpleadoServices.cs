using Sistema_Envios.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class EmpleadoServices
    {
        private Repositorio _repositorio;

        public EmpleadoServices()
        {

            _repositorio = new Repositorio();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            string query = "SELECT ID_Empleado, Nombre FROM Empleado";
            Func<IDataReader, Empleado> mapper = reader => new Empleado
            {
                Id_Empleado = (int)reader["ID_Almacen"],
                Nombre = reader["Nombre"].ToString()
            };

            return _repositorio.ObtenerLista(query, mapper);
        }

    }
}
