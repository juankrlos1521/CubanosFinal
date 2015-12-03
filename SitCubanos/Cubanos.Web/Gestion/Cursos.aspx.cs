using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cubanos.BusinessEntity;
using System.Web.ModelBinding;
using Microsoft.Practices.Unity;
using Cubanos.Service;

namespace Cubanos.Web.Gestion
{
    public partial class Cursos : System.Web.UI.Page
    {
        [Dependency]
        public ICursoService _CursoService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Curso> GetCursos([Control("txtCriterio")] String criterio) 
        {
            return _CursoService.GetCursos(criterio);
        }
    }
}