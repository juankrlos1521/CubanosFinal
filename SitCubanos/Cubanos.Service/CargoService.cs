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
    public class CargoService:ICargoService
    {
        [Dependency]
        public ICargoRepository _CargoRepository { get; set; }
        
       public IEnumerable<Cargo> GetCargos(String criterio) 
        {
            return _CargoRepository.GetCargos(criterio);
        }
        public Cargo GetCargo(Int32 idCargo)
        {
            return _CargoRepository.GetCargo(idCargo);
        }
        public void AddCargo(Cargo cargo) 
        {
            _CargoRepository.AddCargo(cargo);
        }
        public void UpdateCargo(Cargo cargo)
        {
            _CargoRepository.UpdateCargo(cargo);
        }
        public void RemoveCargo(Int32 idCargo) 
        {
            _CargoRepository.RemoveCargo(idCargo);
        }

        public IEnumerable<Cargo> TraerCargos()//para poder mostrar los cargos en el registrar Empleado
        {
            return _CargoRepository.TraerCargos();
        }
    }
}
