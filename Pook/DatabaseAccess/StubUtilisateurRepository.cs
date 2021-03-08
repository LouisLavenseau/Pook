using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DatabaseAccess
{
    public class StubUtilisateurRepository : Repository, IUtilisateurRepository
    {
        List<Utilisateur> _utilisateurs = new List<Utilisateur> { };

        public StubUtilisateurRepository()
        {
            _utilisateurs.Add(new Utilisateur(0, "louloulala", "mdp","Lavenseau_Louis.jpg"));
            _utilisateurs.Add(new Utilisateur(1, "cloclobribri", "mdp2","Brissaud_Cloe.jpg"));
        }

        public List<Utilisateur> GetAll()
        {
            return _utilisateurs;
        }

        public void Save(Utilisateur utilisateur)
        {
            _utilisateurs.Add(utilisateur);
        }
    }
}
