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
                suma += Convert.ToInt32(lvInscripcion.DataKeys[i].Values["Id"]);
                _cubanosGymService.RegisAsistencia(1, Convert.ToInt32(lvInscripcion.DataKeys[i].Values["Id"]), true);
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

        protected void lvDetalleInscripcion_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "hola")
            {
                var idHabitacion = Int32.Parse(e.CommandArgument.ToString());

                _cubanosGymService.RegisAsistencia(1, idHabitacion, true);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Guardardo : " + idHabitacion + "');", true);
                //var idHabitacion = Int32.Parse(e.CommandArgument.ToString());

                //var reserva = Cache.Get("reserva") as Reserva;

                //var existe = reserva.DetalleReserva.SingleOrDefault(d => d.IdHabitacion.Equals(idHabitacion));

                //if (existe != null)
                //{
                //    reserva.DetalleReserva.Remove(existe);

                //    CalcularTotales(reserva);

                //    lvDetalleReserva.DataSource = reserva.DetalleReserva;
                //    lvDetalleReserva.DataBind();

                //    Cache.Insert("reserva", reserva);
                //}

            }
        }


    }
}