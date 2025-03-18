using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Models
{
    internal class Empleado
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public int Licencia { get; set; }
        
        public string Telefono { get; set; }
    }
}
