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
    public partial class frmListarInscripcion : System.Web.UI.Page
    {
        [Dependency]
        public ICubanosGymService _cubanosGymService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = (Convert.ToString(Request["name"])).ToUpper();
                lblCurso.Text = name;
            }
            catch (Exception)
            {

                lblCurso.Text = "Default";
            }

            var acc = Request.QueryString["acc"];

            //if (acc != null && acc == "eliminar" && id != null)
            //{
            //    var idCurso = Int32.Parse(id.ToString());
            //    _cubanosGymService.RemoveCurso(idCurso);
            //    Response.Redirect("Cursos.aspx");
            //}

        }
        public IEnumerable<Inscripcion> Listarinscripcion()
        {
            int x = Convert.ToInt32(Request["listClientes"]);

            return _cubanosGymService.ListarInscripcion(x);

        }
        protected void asignarAsistencia_Check(object sender, EventArgs e)
        {
             
        }
        
    }
}