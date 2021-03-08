using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Utilisateur
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual string NomImagePdp { get; set; }
        public virtual ICollection<Album> MesAlbums { get; set; }
        public virtual ICollection<Album> MesSouhaits { get; set; }

        public Utilisateur() { }

        public Utilisateur(int id, string login, string mdp, string nomImagePdp)
        {
            Id = id;
            Login = login;
            Mdp = mdp;
            NomImagePdp = nomImagePdp;
        }


        public override string ToString()
        {
            return Login; ;
        }
    }
}
