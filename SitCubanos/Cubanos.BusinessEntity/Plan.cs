using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Plan
    {
        public Int32 Id { get; set; }
        public Int32 ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public List<Rutina> Rutina { get; set; }
    }
}
