using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Cargo
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}