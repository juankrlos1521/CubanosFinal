using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;

namespace Cubanos.Repository
{
    public interface ICargoRepository
    {
        IEnumerable<Cargo> GetCargos(String criterio);
        Cargo GetCargo(Int32 idCargo);
        void AddCargo(Cargo cargo);
        void UpdateCargo(Cargo cargo);
        void RemoveCargo(Int32 idCargo);
        IEnumerable<Cargo> TraerCargos(); //para poder mostrarlo en la tabla registrar empleado
    }
}
