using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Rutina
    {
        public Int32 Id { get; set; }
        public Int32 PlanId { get; set; }
        public Plan Plan { get; set; }
        public Int32 NroOrden { get; set; }
        public String Descripcion { get; set; }
        public String Objetivo { get; set; }

        public List<DetalleEjercicioToRutina> DetalleEjercicioToRutina { get; set; }
    }
}
