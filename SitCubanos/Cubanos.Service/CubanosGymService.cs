using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cubanos.BusinessEntity;
using Cubanos.Repository;
using Microsoft.Practices.Unity;


namespace Cubanos.Service
{
    public class CubanosGymService : ICubanosGymService
    {
        [Dependency]
        public ICubanosGymRepository _cubanosGymRepository { get; set; }              

        //cliente
        public IEnumerable<Cliente> listarClientes(string criterio)     // Listar Cliente
        {
           return _cubanosGymRepository.listarClientes(criterio);
        }

        public void InsertarCliente(Cliente cliente)     // Registrar Cliente
        {
            _cubanosGymRepository.InsertarCliente(cliente);
        }

       public Cliente GetCliente(Int32 idCliente) 
        {
            return _cubanosGymRepository.GetCliente(idCliente);
        }

        public void Actualizar(Cliente cliente) 
        {
            _cubanosGymRepository.Actualizar(cliente);
        }

        public void EliminarCliente(Int32 IdCliente) 
        {
            _cubanosGymRepository.EliminarCliente(IdCliente);
        }


        //...........................................................

        //Paquete
        public IEnumerable<Paquete> ListarPaquete(string criterio, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return _cubanosGymRepository.ListarPaquete(criterio, fechaInicio, fechaFin);
        }
        //............................................................

        //Plan
        public IEnumerable<Plan> ListarPlan(DateTime? fechaInicio, DateTime? fechaFin)
        {
            return _cubanosGymRepository.ListarPlan(fechaInicio, fechaFin);
        }
        //.............................................................

        //Empleado
        public IEnumerable<Empleado> ListarEmpleado(string criterio)   //Listar empleado
        {
            return _cubanosGymRepository.ListarEmpleado(criterio);
        }

        public void InsertarEmpleado(Empleado empleado)     //Registrar Empleado
        {
            _cubanosGymRepository.InsertarEmpleado(empleado);
        }
        //............................................................

        //Inscripcion
        public IEnumerable<Inscripcion> ListarInscripcion(Int32? cursoxId)
        {
            return _cubanosGymRepository.ListarInscripcion(cursoxId);
        }
        //...........................................................

        //Asistencia
        public void RegisAsistencia(int AsisId, int incripcionId, bool asignado)
        {
            _cubanosGymRepository.RegisAsistencia(AsisId, incripcionId, asignado);
        }

        public IEnumerable<Asistencia> ListarAsistencias(Int32 clienteId)
        {
            return _cubanosGymRepository.ListarAsistencias(clienteId);
        }

        public IEnumerable<Asistencia> ListarAsistenciasPorCurso(int cursoId)
        {
            return _cubanosGymRepository.ListarAsistenciasPorCurso(cursoId);
        }

        public void UpdateAsistencia(int AsisId, bool asignado)
        {
            _cubanosGymRepository.UpdateAsistencia(AsisId, asignado);
        }
        //............................................................

        public IEnumerable<Pago> ListarPagoss(string criterio)
        {
            return _cubanosGymRepository.ListarPagoss(criterio);

        }

        //Rutina
        //public IEnumerable<Rutina> ListarRutina(string criterio)
        //{
        //    return _cubanosGymRepository.ListarRutina(criterio);
        //}
        //............................................................


        //-----

    }
}
