using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;

namespace Cubanos.Repository
{
    public class CursoRepository:MasterRepository,ICursoRepository
    {
        public IEnumerable<Curso> GetCursos(String criterio) 
        {
            var query = from c in Context.Cursos
                        select c;
            if(!String.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Nombre.Contains(criterio)
                        select c;
            }
            return query;
        }
        public Curso GetCurso(Int32 idCurso) 
        {
            var h = Context.Cursos.SingleOrDefault(c => c.Id.Equals(idCurso));
            return h;
        }
        public void AddCurso(Curso curso) 
        {
            Context.Cursos.Add(curso);
            Context.SaveChanges();
        }
        public void UpdateCurso(Curso curso) 
        {
            Context.Entry(curso).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }
        public void RemoveCurso(Int32 idCurso)
        {
            var curso = Context.Cursos.Find(idCurso);

            if (curso!=null)
            {
                Context.Entry(curso).State = System.Data.Entity.EntityState.Deleted;
                Context.SaveChanges();
            }
        }
    }
}
