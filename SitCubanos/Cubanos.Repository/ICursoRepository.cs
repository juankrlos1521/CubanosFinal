using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;

namespace Cubanos.Repository
{
    public interface ICursoRepository
    {
        IEnumerable<Curso> GetCursos(String criterio);
        Curso GetCurso(Int32 idCurso);
        void AddCurso(Curso curso);
        void UpdateCurso(Curso curso);
        void RemoveCurso(Int32 idCurso);
    }
}
