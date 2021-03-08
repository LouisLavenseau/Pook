using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Administrateur
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        
        public Administrateur() { }
        
        public Administrateur (string login, string mdp)
        {
            Login = login;
            Mdp = mdp;
        } 
    }
}
