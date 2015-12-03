using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Inscripcion
    {
        public Int32 Id { get; set; }
        public Int32 ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Int32 CursoId { get; set; }
        public Curso Curso { get; set; }        
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal Pago { get; set; }
        //public Int32 NroCuotas { get; set; }
        public Boolean Estado { get; set; }
        public List<Pago> Pagos { get; set; }
        public List<Asistencia> Asistencia { get; set; }
    }
}
