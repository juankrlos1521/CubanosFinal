using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cubanos.BusinessEntity;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;
using Cubanos.Service;

namespace Cubanos.Web.Gestion
{    
    public partial class Cargos : System.Web.UI.Page
    {
        [Dependency]
        public ICargoService _CargoService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Cargo> GetCargos([Control("txtCriterio")] String criterio)
        {
            return _CargoService.GetCargos(criterio);
        }
    }
}