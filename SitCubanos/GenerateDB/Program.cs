using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;
using Cubanos.Repository;

namespace GenerateDB
{
    class Program
    {
        static void Main(string[] args)
        {                      

            var cargo = new Cargo()
            {                
                Id = 1,
                Nombre = "Gerente",
                Descripcion = "Esta a cargo del negocio"
            };

            Console.WriteLine("Generando la Base de Datos");
            var context = new DbCubanosContext();            
            context.Cargos.Add(cargo);
            context.SaveChanges();

            Console.WriteLine("Base de Datos Creada...OK!!");
            Console.ReadLine();
        }
    }
}
