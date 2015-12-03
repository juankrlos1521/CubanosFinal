using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Empleado
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
        public DateTime FechaIngreso { get; set; }
        public Decimal Salario { get; set; }
        public Int32 CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}
