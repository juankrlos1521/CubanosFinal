using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubanos.Repository
{
    public abstract class MasterRepository
    {
        private DbCubanosContext _context;
        protected MasterRepository() 
        {
            if (_context == null)
            {
                _context = new DbCubanosContext();
            }
        }

        protected DbCubanosContext Context
        {
            get { return _context; }
        }
    }
}
