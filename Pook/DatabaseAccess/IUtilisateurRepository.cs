using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public interface IUtilisateurRepository
    {
        List<Utilisateur> GetAll();
        void Save(Utilisateur utilisateur);

    }
}
