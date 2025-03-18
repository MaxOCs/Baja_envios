using Sistema_Envios.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Models
{
     
    public class Pedido
    {
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string telefono { get; set; }
        public DateTime Fecha_pedido { get; set;}
        public string Estado_Pedido { get; set;}
        public decimal Total { get; set;}

        public static response EliminarPedido(int ID_Pedido)
        {
            var parametros = new List<Parametro>
            {
                new Parametro("@ID_Pedido",ID_Pedido, SqlDbType.Int),
            };

            return Repositorio.EjecutarProcedimiento("spDelete_Pedido", parametros);
        }
    }

    
}
