using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;
using Cubanos.Repository;
using Microsoft.Practices.Unity;

namespace Cubanos.Service
{
    public class CursoService:ICursoService
    {
        [Dependency]
        public ICursoRepository _CursoRepository { get; set; }

        public IEnumerable<Curso> GetCursos(String criterio) 
        {
            return _CursoRepository.GetCursos(criterio);
        }
        public Curso GetCurso(Int32 idCurso) 
        {
            return _CursoRepository.GetCurso(idCurso);
        }
        public void AddCurso(Curso curso) 
        {
            _CursoRepository.AddCurso(curso);
        }
        public void UpdateCurso(Curso curso) 
        {
            _CursoRepository.UpdateCurso(curso);
        }
        public void RemoveCurso(Int32 idCurso) 
        {
            _CursoRepository.RemoveCurso(idCurso);
        }
    }
}
