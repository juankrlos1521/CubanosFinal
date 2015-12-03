using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.BusinessEntity
{
    public class Curso
    {
        /*public Guid Id { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal Precio { get; set; }
        public List<Grupo> Grupos { get; set; }*/
        

        public Int32 Id { get; set; }
        public String Nombre { get; set; }      
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal Precio { get; set; }
        public List<Paquete> Paquetes { get; set; }
        //public List<Asistencia> Asistencia { get; set; }
    }
}
