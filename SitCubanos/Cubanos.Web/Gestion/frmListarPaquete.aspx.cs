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

namespace Cubanos.Web.Gestion
{
    public partial class frmListarPaquete : System.Web.UI.Page
    {
        [Dependency]
        public ICubanosGymService _cubanosGymService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Paquete> ListarPaquete([Control("txtCriterio")]String criterio, 
                                           [Control("txtFechaInicio")]DateTime? fechaInicio, 
                                           [Control("txtFechaFin")]DateTime? fechaFin)
        {
            if (fechaInicio != null && fechaFin != null && criterio != null)
            {
                criterio = (criterio != null) ? "criterio" : criterio;
                return _cubanosGymService.ListarPaquete(criterio,fechaInicio, fechaFin);
            }

            else
            {
                fechaInicio = DateTime.MinValue;
                fechaFin = DateTime.MaxValue;
                criterio = (criterio == null) ? "" : criterio;
                return _cubanosGymService.ListarPaquete(criterio, fechaInicio, fechaFin);

            }

           


        }
    }
}