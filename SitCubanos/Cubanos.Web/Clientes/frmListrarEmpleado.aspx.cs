using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cubanos.BusinessEntity;
using Cubanos.Service;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;

namespace Cubanos.Web.Clientes
{
    
    
    public partial class frmListrarEmpleado : System.Web.UI.Page
    {
        [Dependency]
        public ICubanosGymService _cubanosGymService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Empleado> ListarEmpleado([Control("txtCriterio")] string criterio)
        {
            criterio = (criterio == null) ? "" : criterio;
            return _cubanosGymService.ListarEmpleado(criterio);

        }

    }
}