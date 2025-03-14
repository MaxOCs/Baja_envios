using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class Parametro
    {
        public string Nombre { get; set; } // Nombre del parámetro en el procedimiento almacenado
        public object Valor { get; set; } // Valor del parámetro
        public SqlDbType Tipo { get; set; } // Tipo de dato del parámetro
        public ParameterDirection Direccion { get; set; } // Dirección del parámetro (Input, Output, etc.)

        public Parametro(string nombre, object valor, SqlDbType tipo, ParameterDirection direccion = ParameterDirection.Input)
        {
            Nombre = nombre;
            Valor = valor;
            Tipo = tipo;
            Direccion = direccion;
        }
    }
}
