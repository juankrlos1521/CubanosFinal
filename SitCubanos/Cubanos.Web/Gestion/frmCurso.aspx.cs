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
    public partial class frmCurso : System.Web.UI.Page
    {
        [Dependency]
        public ICursoService _CursoService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var acc = Request.QueryString["acc"];
            var id = Request.QueryString["id"];

            if (acc!=null && acc=="editar")
            {
                fvCurso.DefaultMode = FormViewMode.Edit;
            }
            else if(acc!=null && acc=="eliminar" && id!=null)
            {
                var idCurso = Int32.Parse(id.ToString());
                _CursoService.RemoveCurso(idCurso);
                Response.Redirect("Cursos.aspx");
            }
        }

        public void AddCurso(Curso curso)
        {
            if (ModelState.IsValid)
            {
                _CursoService.AddCurso(curso);
                Response.Redirect("Cursos.aspx");
            }
        }

        public void UpdateCurso(Curso curso)
        {
            if (ModelState.IsValid)
            {
                _CursoService.UpdateCurso(curso);
                Response.Redirect("Cursos.aspx");
            }
        }

        public Curso GetCurso([QueryString("id")] Int32 id)
        {
            var curso = _CursoService.GetCurso(id);
            return curso;
        }

    }
}