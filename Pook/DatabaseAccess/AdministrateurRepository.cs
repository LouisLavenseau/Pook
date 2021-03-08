using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public class AdministrateurRepository : Repository, IAdministrateurRepository
    {
        public List<Administrateur> GetAll()
        {
            return Session.Query<Administrateur>().ToList();
        }
    }
}
