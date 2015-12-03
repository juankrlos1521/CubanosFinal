using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Pago
    {
        public Int32 Id { get; set; }
        public Int32 NroCuota { get; set; }
        public bool EstadoCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }

        public Int32 InscripcionId { get; set; }
        public Inscripcion Inscripcion { get; set; }
    }
}
