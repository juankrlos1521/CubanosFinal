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


            this.lvInscripcion.DataBind();
            int suma = 0;
            for (int i = 0; i < lvInscripcion.Items.Count; i++)
            {
                string idInscrip = Convert.ToString(lvInscripcion.DataKeys[i].Values["Id"]);

                string code = (Convert.ToString(DateTime.Now.ToString("ddMMyy")));

                int idgenerated = Convert.ToInt32(idInscrip + code);

                suma += Convert.ToInt32(lvInscripcion.DataKeys[i].Values["Id"]);

                _cubanosGymService.RegisAsistencia(idgenerated, Convert.ToInt32(lvInscripcion.DataKeys[i].Values["Id"]), false);
            }

            txtSubTotal.Text = suma.ToString();


        }
        public IEnumerable<Inscripcion> Listarinscripcion()
        {
            int x = Convert.ToInt32(Request["listClientes"]);

            return _cubanosGymService.ListarInscripcion(x);

        }
        public IEnumerable<Asistencia> ListarAsistenciasPorCurso()
        {
            int x = Convert.ToInt32(Request["listClientes"]);

            return _cubanosGymService.ListarAsistenciasPorCurso(x);

        }
        protected void asignarAsistencia_Check(object sender, EventArgs e)
        {
             
        }

        protected void lvAsistencia_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

            string name = (Convert.ToString(Request["name"])).ToUpper();
            string listClientes = (Convert.ToString(Request["listClientes"])).ToUpper();

            if (e.CommandName == "btnPresente1")
            {
                var idHabitacion = Int32.Parse(e.CommandArgument.ToString());

                _cubanosGymService.UpdateAsistencia(idHabitacion, true);

                Response.Redirect("frmRegistrarAsistencia.aspx?listClientes=" + listClientes + "&name="+name);


            }
            if (e.CommandName == "btnAusente1")
            {
                var idHabitacion = Int32.Parse(e.CommandArgument.ToString());

                _cubanosGymService.UpdateAsistencia(idHabitacion, false);

                Response.Redirect("frmRegistrarAsistencia.aspx?listClientes=" + listClientes + "&name=" + name);

            }
        }


    }
}