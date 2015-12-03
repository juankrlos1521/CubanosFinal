using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cubanos.Repository;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;
using Cubanos.BusinessEntity;
using Cubanos.Service;

namespace Cubanos.Web.Clientes
{
    public partial class frmRegistrarEmpleado : System.Web.UI.Page
    {
        [Dependency]
        public ICubanosGymService _cubanosGymService { get; set; }
        [Dependency]
        public ICargoService _CargoService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void InsertarEmpleado(Empleado _empleado)
        {
            if (ModelState.IsValid)
            {
                using (var _bd = new DbCubanosContext())
                {
                    Empleado dni = _bd.Empleados.FirstOrDefault(x => x.Dni.ToUpper() == _empleado.Dni.ToUpper());
                    if (dni == null)
                    {
                        _cubanosGymService.InsertarEmpleado(_empleado);
                        Response.Redirect("frmListrarEmpleado.aspx");
                    }
                    else
                    {
                        ModelState.AddModelError("Dni", "Dni Duplicado");
                    }
                }
            }
        }
        public IEnumerable<Cargo> TraerCargos()
        {
            return _CargoService.TraerCargos();
        }
    }
}