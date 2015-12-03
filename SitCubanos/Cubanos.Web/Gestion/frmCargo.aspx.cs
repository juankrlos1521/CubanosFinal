using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.Unity;
using Cubanos.BusinessEntity;
using Cubanos.Service;
using System.Web.ModelBinding;

namespace Cubanos.Web.Gestion
{
    public partial class frmCargo : System.Web.UI.Page
    {
        [Dependency]
        public ICargoService _CargoService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var acc = Request.QueryString["acc"];
            var id = Request.QueryString["id"];

            if (acc!=null && acc=="editar")
            {
                fvCargo.DefaultMode = FormViewMode.Edit;
            }
            else if(acc!=null && acc=="eliminar" && id!=null)
            {
                var idCargo = Int32.Parse(id.ToString());
                _CargoService.RemoveCargo(idCargo);
                Response.Redirect("Cargos.aspx");
            }
        }

        public void AddCargo(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                _CargoService.AddCargo(cargo);
                Response.Redirect("Cargos.aspx");
            }
        }

        public void UpdateCargo(Cargo cargo) 
        {
            if (ModelState.IsValid)
            {
                _CargoService.UpdateCargo(cargo);
                Response.Redirect("Cargos.aspx");
            }
        }

        public Cargo GetCargo([QueryString("id")] Int32 id)
        {
            var cargo = _CargoService.GetCargo(id);
            return cargo;
        }
    }
}