using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public void Save(Utilisateur utilisateur)
        {
            Session.Save(utilisateur);
            Session.Flush();
        }


    }
}
