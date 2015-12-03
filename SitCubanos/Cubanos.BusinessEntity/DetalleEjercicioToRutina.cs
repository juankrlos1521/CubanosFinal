using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class DetalleEjercicioToRutina
    {
        public Int32 EjercicioId { get; set; }
        public Ejercicio Ejercicio { get; set; }
        public Int32 RutinaId { get; set; }
        public Rutina Rutina { get; set; }
        public Int32 NroOrden { get; set; }
        public Int32 NroRepeticiones { get; set; }
        public Int32 NroSeries { get; set; }
    }
}
