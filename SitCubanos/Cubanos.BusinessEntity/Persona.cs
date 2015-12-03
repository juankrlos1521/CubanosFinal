using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public abstract class Persona
    {
        public Int32 Id { get; set; }
        public String Dni { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public Boolean Sexo { get; set; }
        public Boolean Estado { get; set; }
    }
}
