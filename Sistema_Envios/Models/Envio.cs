using Sistema_Envios.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Models
{
    public class Envio
    {
        public int ID_Pedido { get; set; }
        public int ID_Vehiculo { get; set; }
        public int ID_Empleado { get; set; }
        public DateTime Fecha_Envio { get; set; }
        public DateTime Fecha_Estimada_Entrega { get; set; }
        public DateTime Fecha_Real_Entrega { get; set; }
        public string Estado_envio { get; set; }
        public string Numero_Guia { get; set; }

        public static response AgregarEnvio(Envio envio)
        {
            var parametros = new List<Parametro>
            {
                new Parametro("@ID_Pedido",envio.ID_Pedido, SqlDbType.Int),
                new Parametro("@ID_Vehiculo",envio.ID_Vehiculo, SqlDbType.Int),
                new Parametro("@ID_Empleado",envio.ID_Empleado, SqlDbType.Int)
            };

            return Repositorio.EjecutarProcedimiento("RegistrarEnvio", parametros);
        }


    }
}
