using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.Serialization.ISerializable;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    public class Album
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public virtual string ImageCouverture { get; set; }
        public virtual string Serie { get; set; }
        public virtual string Auteurs { get; set; }
        public virtual string Categorie { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Editeur { get; set; }
        public virtual ICollection<Utilisateur> Possesseurs { get; set; }
        public virtual ICollection<Utilisateur> PotentielsPossesseurs { get; set; }
        public virtual bool CorrespondALaRecherche { get; set; }

        public Album() { }

        public Album(int id, string nom, string imageCouverture, string serie, string auteurs, string categorie, string genre, string editeur, bool correspondALaRecherche)
        {
            Id = id;
            Nom = nom;
            ImageCouverture = imageCouverture;
            Serie = serie;
            Auteurs = auteurs;
            Categorie = categorie;
            Genre = genre;
            Editeur = editeur;
            CorrespondALaRecherche = correspondALaRecherche;

        }

        public virtual string[] Decrire()
        {
            return new string[] { Nom, Id.ToString(), Serie, Auteurs, Categorie, Genre, Editeur };
        }

    }

}
