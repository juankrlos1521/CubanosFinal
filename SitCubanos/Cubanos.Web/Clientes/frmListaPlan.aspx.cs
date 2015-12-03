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
    public partial class frmListaPlan : System.Web.UI.Page
    {
        [Dependency]
        public ICubanosGymService _cubanosGymService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Plan> ListarPlan([Control("txtFechaInicio")]DateTime? fechaInicio,
                                           [Control("txtFechaFin")]DateTime? fechaFin)
        {
            if (fechaInicio != null && fechaFin != null)
            {
                return _cubanosGymService.ListarPlan(fechaInicio, fechaFin);
            }

            else
            {
                fechaInicio = DateTime.MinValue;
                fechaFin = DateTime.MaxValue;
                return _cubanosGymService.ListarPlan(fechaInicio, fechaFin);

            }
        }
    }
}