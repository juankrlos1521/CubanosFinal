using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Cubanos.BusinessEntity;
using Cubanos.Repository.Mapping;

namespace Cubanos.Repository
{
    public class DbCubanosContext:DbContext
    {
        public DbCubanosContext() 
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbCubanosContext>());
        }

        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Seguimiento> Seguimientos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }        
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }       
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<DetalleEjercicioToRutina> DetalleEjercicioToRutinas { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CargoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EmpleadoMap());
            modelBuilder.Configurations.Add(new SeguimientoMap());
            modelBuilder.Configurations.Add(new AsistenciaMap());
            modelBuilder.Configurations.Add(new PaqueteMap());
            modelBuilder.Configurations.Add(new InscripcionMap());            
            modelBuilder.Configurations.Add(new PagoMap());
            modelBuilder.Configurations.Add(new PlanMap());
            modelBuilder.Configurations.Add(new EjercicioMap());
            modelBuilder.Configurations.Add(new RutinaMap());
            modelBuilder.Configurations.Add(new DetalleEjercicioToRutinaMap());
        }
    }
}
