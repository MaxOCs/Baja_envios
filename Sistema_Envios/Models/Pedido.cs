using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Models
{
     
    public class Pedido
    {
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime Fecha_pedido { get; set;}
        public string Estado_Pedido { get; set;}
        public decimal total { get; set;}
    }
}
