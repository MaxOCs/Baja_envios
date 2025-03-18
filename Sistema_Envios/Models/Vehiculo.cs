using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Models
{
    public class Vehiculo
    {
        public int ID_Vehiculo { get; set; }
        public string Tipo { get; set; }
        public string Placa { get; set; }
        public string Estado { get; set; }
        public string DisplayText => $"{Tipo} - {Placa}";


    }
}
