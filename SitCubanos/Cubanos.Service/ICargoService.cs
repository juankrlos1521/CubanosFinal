using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;

namespace Cubanos.Service
{
    public interface ICargoService
    {
        IEnumerable<Cargo> GetCargos(String criterio);
        Cargo GetCargo(Int32 idCargo);
        void AddCargo(Cargo cargo);
        void UpdateCargo(Cargo cargo);
        void RemoveCargo(Int32 idCargo);
        IEnumerable<Cargo> TraerCargos();//para poder mostraar el cargo en el registrar Empleado
    }
}
