using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;
using Model;
using Presentation.View;

namespace Presentation.Presenter
{
    public class PresenterConnexion
    {
        public static IUtilisateurRepository _utilisateurRepository;
        public static IAlbumRepository _albumRepository;
        public static IAdministrateurRepository _administrateurRepository;
        private int _compteurIdUtilisateur = 0;
        private IViewConnexion _viewConnexion;

        public PresenterConnexion(IAlbumRepository albumRepository, IUtilisateurRepository utilisateurRepository, IAdministrateurRepository administrateurRepository, IViewConnexion viewConnexion)
        {
            _utilisateurRepository = utilisateurRepository;
            _albumRepository = albumRepository;
            _administrateurRepository = administrateurRepository;
            _viewConnexion = viewConnexion;
            _viewConnexion.PresenterConnexion = this;
        }

        public void ConnecterAdministrateurOuUtilisateur()
        {
            //vérification de l'existence du compte associé aux identifiants
            List<Utilisateur> utilisateurs = _utilisateurRepository.GetAll();
            List<Administrateur> administrateurs = _administrateurRepository.GetAll();

            //parcours de tous les utilisateurs existant
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                // MessageBox.Show(utilisateur.Login);
                if (utilisateur.Login == _viewConnexion.LoginRentre && utilisateur.Mdp == _viewConnexion.MdpRentre)
                {
                    _viewConnexion.IsCompteUtilisateurExistant = true;
                    FormConnexion._idUtilisateur = utilisateur.Id;
                    _viewConnexion.NomImagePdp = utilisateur.NomImagePdp;
                }
            }

            //parcours de tous les administrateurs existant
            foreach (Administrateur administrateur in administrateurs)
            {
                _viewConnexion.Test = true;
                if (administrateur.Login == _viewConnexion.LoginRentre && administrateur.Mdp == _viewConnexion.MdpRentre)
                {
                    _viewConnexion.IsCompteAdministrateurExistant = true;
                    FormConnexion._idAdministrateur = administrateur.Id;
                }
            }

            //ouverture du form accueil si compte existant
            if (_viewConnexion.IsCompteUtilisateurExistant)
            {
                FormAccueil formAccueil = new FormAccueil(_viewConnexion.LoginRentre, _viewConnexion.NomImagePdp);
                _viewConnexion.FormAccueil = formAccueil;
                PresenterAccueil presenterAccueil = new PresenterAccueil(formAccueil);
                formAccueil.ShowDialog();
                _viewConnexion.IsCompteUtilisateurExistant = false;
            }

            //ouverture du form accueil admin si compte existant
            else if (_viewConnexion.IsCompteAdministrateurExistant)
            {
                FormAccueilAdmin formAccueilAdmin = new FormAccueilAdmin(_viewConnexion.LoginRentre, FormConnexion._idAdministrateur);
                PresenterAccueilAdmin presenterAccueilAdmin = new PresenterAccueilAdmin(formAccueilAdmin);
                formAccueilAdmin.ShowDialog();
                _viewConnexion.IsCompteAdministrateurExistant = false;
            }

            //sinon affichage d'un message d'erreur
            else
            {
                if (!_viewConnexion.Test)
                {
                    System.Windows.Forms.MessageBox.Show("Pas de compte admin :(");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Compte inexistant, veuillez rentrez des identifiants valides :)");
                }
            }

        }

        public void CreerCompte()
        {
            FormCreerCompte formCreerCompte = new FormCreerCompte();
            PresenterCreerCompte presenterCreerCompte = new PresenterCreerCompte(formCreerCompte);
            formCreerCompte.ShowDialog();
            if (formCreerCompte.AppuyeSurValide && formCreerCompte.IdentifiantsRentres)
            {       
                _utilisateurRepository.Save(new Utilisateur(_compteurIdUtilisateur, formCreerCompte.LoginRentre, formCreerCompte.MdpRentre, formCreerCompte.NomImageRentre));
            }
        }
    }
}
