using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Asistencia
    {
        public Int32 Id { get; set; }        
        public DateTime Fecha { get; set; }
        public Boolean Estado { get; set; }
        public Int32 InscripcionId { get; set; }
        public Inscripcion Inscripcion { get; set; }
    }
}
