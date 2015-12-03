using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;

namespace Cubanos.Repository
{
    public interface ICubanosGymRepository
    {
        //Cliente
        IEnumerable<Cliente> listarClientes(String criterio); //listar Cliente
        void InsertarCliente(Cliente cliente); //Registrar Cliente
        Cliente GetCliente(Int32 idCliente);// apra traer al cliente para modficicar 
        void Actualizar(Cliente cliente);//Actualizar Cliente
        void EliminarCliente(Int32 IdCliente); //Eliminar cliente
        //.........................................................

        //Paquete
        IEnumerable<Paquete> ListarPaquete(String criterio, DateTime? fechaInicio, DateTime? fechaFin);
        //.........................................................

        //Plan
        IEnumerable<Plan> ListarPlan(DateTime? fechaInicio, DateTime? fechaFin);
        //.........................................................

        //Rutina
        //IEnumerable<Rutina> ListarRutina(String criterio);
        //.........................................................

        //Empleado
        IEnumerable<Empleado> ListarEmpleado(String criterio);
        void InsertarEmpleado(Empleado empleado);
        //.........................................................

        //Inscripcion
        IEnumerable<Inscripcion> ListarInscripcion(Int32? cursoxId);
        //.........................................................
        //asistencia
        void RegisAsistencia(Int32 AsisId, int incripcionId, bool asignado);
        //void RegisAsistencia(Asistencia asistencia);
        //.........................................................
    }
}
