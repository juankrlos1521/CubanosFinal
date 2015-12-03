using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cubanos.BusinessEntity;
using System.Data.Entity;

namespace Cubanos.Repository
{
    public class CubanosGymRepository : MasterRepository, ICubanosGymRepository
    {        
        //Cliente
        public IEnumerable<Cliente> listarClientes(string criterio)      // Listar Cliente
        {
            return Context.Clientes.Where(x => (x.Nombres.Contains(criterio) ||
                                                x.ApellidoPaterno.Contains(criterio) ||
                                                x.ApellidoMaterno.Contains(criterio) ||
                                                x.Dni.Contains(criterio))).OrderBy(o => o.ApellidoPaterno).ToList();
        }

        public void InsertarCliente(Cliente cliente)          // Registrar Cliente
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
        }

        public Cliente GetCliente(Int32 idCliente) 
        {
            var h = Context.Clientes.SingleOrDefault(c=>c.Id.Equals(idCliente));
            return h;
        }

        public void Actualizar(Cliente cliente) 
        {
            Context.Entry(cliente).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarCliente(Int32 IdCliente) 
        {
            var cliente = Context.Clientes.Find(IdCliente);

            if (cliente != null)
            {
                Context.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                Context.SaveChanges();
            }
        }
        //.......................................................................

        //Paquete
        public IEnumerable<Paquete> ListarPaquete(string criterio, DateTime? fechaInicio, DateTime? fechaFin)  //listar Cliente
        {
            
            return Context.Paquetes.Where(x => (x.Nombre.Contains(criterio)) && (x.FechaRegistro >= fechaInicio && x.FechaVencimiento <= fechaFin))
                                   .OrderBy(o => o.Nombre);
        }
        //........................................................................

        //plan
        public IEnumerable<Plan> ListarPlan(DateTime? fechaInicio, DateTime? fechaFin)    //listar Plan
        {
            return Context.Planes.Include("Cliente")
                .Where(x => (x.FechaInicio >= fechaInicio && x.FechaFin <= fechaFin));

        }
        //..........................................................................

        //Empleado
        public IEnumerable<Empleado> ListarEmpleado(string criterio)     //Listar empleado
        {
            return Context.Empleados.Include("Cargo")
                                    .Where(x => (x.Nombres.Contains(criterio) ||
                                                 x.ApellidoPaterno.Contains(criterio) ||
                                                 x.ApellidoMaterno.Contains(criterio) ||
                                                 x.Dni.Contains(criterio)||
                                                 x.Cargo.Nombre.Contains(criterio))).OrderBy(o => o.ApellidoPaterno).ToList();
        }

        public void InsertarEmpleado(Empleado empleado)  //Registrar Empleado
        {
            Context.Empleados.Add(empleado);
            Context.SaveChanges();
        }
        //.........................................................................

        //Inscripcion
        public IEnumerable<Inscripcion> ListarInscripcion(Int32? cursoxId)
        {
            return Context.Inscripciones.Include("Cliente").Include("Curso")
                .Where(x => x.CursoId == cursoxId); 
        }

        public void RegisAsistencia(int AsisId, int incripcionId, bool asignado)
        {
            var result = new Asistencia()
            {
                InscripcionId = incripcionId,
                Estado = asignado,
                Fecha = DateTime.Now
            };

            Context.Asistencias.Add(result);
            Context.SaveChanges();
        }
        //
        //Asistencia
        public IEnumerable<Asistencia> ListarAsistencias(Int32 clienteId)
        {
            return Context.Asistencias.Include("Inscripcion").
                Where(x => (x.Inscripcion.ClienteId == clienteId));
        }

        public IEnumerable<Asistencia> ListarAsistenciasPorCurso(int cursoId)
        {
            return Context.Asistencias.Where(x => (x.Inscripcion.CursoId == cursoId));
        }
        //.........................................................................

        //Rutina
        //public IEnumerable<Rutina> ListarRutina(string criterio)
        //{
        //    return Context.Rutinas.Where(x => (x.Objetivo.Contains(criterio))).OrderBy(o => o.Objetivo);
        //}
        //.........................................................................




    }
        //...............................................................................
    
}
