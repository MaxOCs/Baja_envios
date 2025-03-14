using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class response
    {
        public bool Success { get; set; } // Indica si la ejecución fue exitosa
        public string Message { get; set; } // Mensaje de error o éxito
        public object Data { get; set; } // Datos devueltos por el procedimiento almacenado (si aplica)

        public response(bool success, string message, object data = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
