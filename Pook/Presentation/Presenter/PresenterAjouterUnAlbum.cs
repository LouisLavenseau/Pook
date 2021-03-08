using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using DatabaseAccess;
using Model;
using System.Windows.Forms;
using Presentation.View;

namespace Presentation.Presenter
{
    public class PresenterAjouterUnAlbum
    {
        IAlbumRepository _albumRepository;
        IViewAjouterUnAlbum _viewAjouterUnAlbum;
        private int _compteurIdAlbums = 0;
        public FileDialog Dialog { get; set; }
        public string CheminImage { get; set; }
        public PresenterAjouterUnAlbum(IViewAjouterUnAlbum viewAjouterUnAlbum)
        {
            _viewAjouterUnAlbum = viewAjouterUnAlbum;
            _viewAjouterUnAlbum.PresenterAjouterUnAlbum = this;
            _albumRepository = PresenterConnexion._albumRepository;
            _viewAjouterUnAlbum = viewAjouterUnAlbum;
            _viewAjouterUnAlbum.PresenterAjouterUnAlbum = this;
        }


        public void AjouterLAlbum()
        {
            //création de l'album et export dans la bdd
            string nom = _viewAjouterUnAlbum.NomRentre.ToString();
            string auteur = _viewAjouterUnAlbum.AuteurRentre.ToString();
            string serie = _viewAjouterUnAlbum.SerieRentre.ToString();
            string genre = _viewAjouterUnAlbum.GenreRentre.ToString();
            string categorie = _viewAjouterUnAlbum.CategorieRentre.ToString();
            string editeur = _viewAjouterUnAlbum.EditeurRentre.ToString();

            Album album = new Album(5, nom, _viewAjouterUnAlbum.NomImageCouverture, serie, auteur, categorie, genre, editeur, false);
            PresenterConnexion._albumRepository.Save(album);
            Dialog = new OpenFileDialog();
            CheminImage = null;
            _viewAjouterUnAlbum.AdministrateurRentre = true;
            _compteurIdAlbums++;
        }

        public void ImporterImage()
        {
            //récupérer l'image importée
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image files (*.jpg, *.jpeg) | *.jpg; *.jpeg;";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                /*try
                {*/
                    CheminImage = Dialog.FileName;
                    _viewAjouterUnAlbum.NomImageCouverture = Path.GetFileName(CheminImage);
                    string nouveauChemin = Path.Combine("../../Resources/", Path.GetFileName(CheminImage));
                    File.Copy(CheminImage, nouveauChemin, true);

                    Image image = new Bitmap(Path.Combine("../../Resources/", Path.GetFileName(CheminImage)));
                    if (image.Width < image.Height)
                    {
                        _viewAjouterUnAlbum.PicBoxRentre.Image = new Bitmap(image, new Size((int)Math.Ceiling((double)image.Width / (image.Height / 137)), 137));
                    }
                    else
                    {
                        _viewAjouterUnAlbum.PicBoxRentre.Image = new Bitmap(image, new Size(170, (int)Math.Ceiling((double)image.Height / (image.Width / 170))));
                    }

                    _viewAjouterUnAlbum.PicBoxRentre.SizeMode = PictureBoxSizeMode.AutoSize;
                /*}
                catch (Exception)
                {
                    MessageBox.Show("Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }
    }
}
