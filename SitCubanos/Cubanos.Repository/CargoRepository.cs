using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;

namespace Cubanos.Repository
{
    public class CargoRepository:MasterRepository, ICargoRepository
    {
        public IEnumerable<Cargo> GetCargos(String criterio) 
        {
            var query = from c in Context.Cargos
                        select c;

            if (!String.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.Contains(criterio)
                        select c;
            }
            return Context.Cargos;
        }
        public Cargo GetCargo(Int32 idCargo)
        {
            var h = Context.Cargos.SingleOrDefault(c=>c.Id.Equals(idCargo));
            return h;
        }
        public void AddCargo(Cargo cargo) 
        {
            //cargo.Id = new Guid();
            Context.Cargos.Add(cargo);
            Context.SaveChanges();
        }

        public void UpdateCargo(Cargo cargo) 
        {
            Context.Entry(cargo).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }
        public void RemoveCargo(Int32 idCargo) 
        {
            var cargo = Context.Cargos.Find(idCargo);

            if (cargo!=null)
            {
                Context.Entry(cargo).State = System.Data.Entity.EntityState.Deleted;
                Context.SaveChanges();
            }
        }

        public IEnumerable<Cargo> TraerCargos()//para poder mostrar los cargos en el registrar empleado
        {
            return Context.Cargos;
        }
    }
}
