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
    public class PresenterAccueilAdmin
    {
        IViewAccueilAdmin _viewAccueilAdmin;

        public PresenterAccueilAdmin(IViewAccueilAdmin viewAccueilAdmin)
        {
            _viewAccueilAdmin = viewAccueilAdmin;
            _viewAccueilAdmin.PresenterAccueilAdmin = this;
            //remplit la dataGridView
            IAlbumRepository _albumRepository = PresenterConnexion._albumRepository;
            _viewAccueilAdmin.DGVAlbumsDuMarche.Rows.Clear();
            foreach (Album album in _albumRepository.GetAll())
            {
                _viewAccueilAdmin.DGVAlbumsDuMarche.Rows.Add(album.Decrire());
            }
        }

        public void AjouterUnAlbum()
        {
            //ouvre form pour ajouter un album
            FormAjouterUnAlbum formAjouterMesAlbums = new FormAjouterUnAlbum();
            PresenterAjouterUnAlbum presenterAjouterUnAlbum = new PresenterAjouterUnAlbum(formAjouterMesAlbums);
            formAjouterMesAlbums.ShowDialog();
            if (formAjouterMesAlbums.AdministrateurRentre)
            {
                //remplit la dataGridView
                IAlbumRepository _albumRepository = PresenterConnexion._albumRepository;
                _viewAccueilAdmin.DGVAlbumsDuMarche.Rows.Clear();
                foreach (Album album in _albumRepository.GetAll())
                {
                    _viewAccueilAdmin.DGVAlbumsDuMarche.Rows.Add(album.Decrire());
                }
            }
        }
    }
}
