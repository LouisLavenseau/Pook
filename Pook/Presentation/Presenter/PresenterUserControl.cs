using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.View;
using Model;
using System.Windows.Forms;

namespace Presentation.Presenter
{
    public class PresenterUserControl
    {
        IViewUserControl _viewUserControl;
        IViewAccueil _viewAccueil;

        public PresenterUserControl(IViewUserControl viewUserControl, IViewAccueil viewAccueil)
        {
            _viewUserControl = viewUserControl;
            _viewUserControl.PresenterUserControl = this;
            _viewAccueil = viewAccueil;
        }

        public void TrouverRechercheDansAttribut(Album album, string recherche, string attribut)
        {
            for (int i = 0; i < attribut.Length; i++)
            {
                if (album.CorrespondALaRecherche) { break; }
                if (recherche[0] == attribut[i])
                {
                    album.CorrespondALaRecherche = true;
                    for (int j = 1; j < recherche.Length; j++)
                    {
                        if (i + j < attribut.Length)
                        {
                            if (recherche[j] != attribut[i + j])
                            {
                                album.CorrespondALaRecherche = false;
                                break;
                            }
                        }
                        else
                        {
                            album.CorrespondALaRecherche = false;
                        }
                    }
                }
            }
        }

        public void RechercherAlbums()
        {
            string recherche = _viewAccueil.TxtBoxRechercheRealisee.Text.ToLower();

            if (recherche != "")
            {
                foreach (Album album in PresenterConnexion._albumRepository.GetAll())
                {
                    string nom = album.Nom.ToLower();
                    string auteurs = album.Auteurs.ToLower();
                    string editeur = album.Editeur.ToLower();
                    string categorie = album.Categorie.ToLower();
                    string genre = album.Genre.ToLower();
                    string serie = album.Serie.ToLower();

                    //si la recherche correspond exactement à un des attributs
                    if (recherche != nom && recherche != auteurs && recherche != editeur &&
                        recherche != categorie && recherche != genre && recherche != serie)
                    {
                        album.CorrespondALaRecherche = false;

                        //sinon la recherche ne correspond pas exactement à un des attributs, on va chercher la recherche dans une partie des noms
                        TrouverRechercheDansAttribut(album, recherche, nom);

                        //sinon la recherche ne correspond pas exactement à un des attributs, on va chercher la recherche dans une partie des auteurs
                        TrouverRechercheDansAttribut(album, recherche, auteurs);                       

                        //sinon la recherche ne correspond pas exactement à un des attributs, on va chercher la recherche dans une partie des series
                        TrouverRechercheDansAttribut(album, recherche, serie);                       

                        //sinon la recherche ne correspond pas exactement à un des attributs, on va chercher la recherche dans une partie des éditeurs
                        TrouverRechercheDansAttribut(album, recherche, editeur);                      

                        //sinon la recherche ne correspond pas exactement à un des attributs, on va chercher la recherche dans une partie des categories
                        TrouverRechercheDansAttribut(album, recherche, categorie);                       

                        //sinon la recherche ne correspond pas exactement à un des attributs, on va chercher la recherche dans une partie des genres
                        TrouverRechercheDansAttribut(album, recherche, genre);                        
                    }
                }
            }
        }
    }
}
