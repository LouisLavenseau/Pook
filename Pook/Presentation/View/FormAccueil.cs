using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DatabaseAccess;
using Model;
using Presentation.Presenter;
using Presentation.View;
using System.Windows;

namespace Presentation.View
{
    public partial class FormAccueil : Form, IViewAccueil
    {
        public string Login { get; set; }
        public int IdUtilisateur { get; set; }
        public string NomImagePdp { get; set; }
        public PictureBox PicturePdp
        {
            get { return pictureUtilisateur; }
            set { pictureUtilisateur = value; }
        }
        public TextBox TxtBoxRechercheRealisee { get; set; }

        public Button BtnRechercher { get; set; }

        public Label LabTitre
        {
            get { return labTitre; }
            set { labTitre = value; }
        }
        public Panel PanelRechercher { get; set; }
        public int IdAlbumAAjouter { get; set; }
        public PresenterUserControl PresenterUserControlAlbumsDuMarche { get; set; }
        public PresenterUserControl PresenterUserControlMesAlbums { get; set; }
        public PresenterUserControl PresenterUserControlMesSouhaits { get; set; }
        IUtilisateurRepository _utilisateurRepository;
        IAlbumRepository _albumRepository;
        public PresenterAccueil PresenterAccueil { get; set; }

        public FormAccueil(string login, string nomImagePdp)
        {
            InitializeComponent();
            Login = login;
            NomImagePdp = nomImagePdp;
            //TxtBoxRechercheRealisee2 = new TextBox();
            IdUtilisateur = FormConnexion._idUtilisateur;
            labLoginAccueil.Text = login;
            _utilisateurRepository = PresenterConnexion._utilisateurRepository;
            _albumRepository = PresenterConnexion._albumRepository;

            string nomImage = NomImagePdp;
            Image image = new Bitmap("../../Resources/" + nomImage);
            pictureUtilisateur.Image = image;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureUtilisateur.Width, pictureUtilisateur.Height);
            Region rg = new Region(gp);
            pictureUtilisateur.Region = rg;

            /*UserControlAlbumsDuMarche.BackColor = Color.FromArgb(46, 51, 73);
            UserControlAlbumsDuMarche.ForeColor = Color.FromArgb(46, 51, 73);*/

            PresenterUserControlAlbumsDuMarche = new PresenterUserControl(UserControlAlbumsDuMarche, this);
            PresenterUserControlMesSouhaits = new PresenterUserControl(UserControlMesSouhaits, this);
            PresenterUserControlMesAlbums = new PresenterUserControl(UserControlMesAlbums, this);

            //disparition des mauvais et apparition du bon userControl
            /*UserControlMesAlbums.Hide();
            UserControlMesSouhaits.Hide();
            UserControlAlbumsDuMarche.Show();
            UserControlAlbumsDuMarche.BringToFront(); //Afficher au premier plan l'accueil
            PresenterAccueil.AfficherAlbumsDuMarche();*/
            //UserControlAccueil.Show();
            UserControlAlbumsDuMarche.Show();
            UserControlMesAlbums.Hide();
            UserControlMesSouhaits.Hide();
        }

        public void btn_AlbumsDuMarche_Click(object sender, EventArgs e)
        {
            //disparition des mauvais et apparition du bon userControl
            UserControlMesAlbums.Hide();
            UserControlMesSouhaits.Hide();
            UserControlAlbumsDuMarche.Show();
            UserControlAlbumsDuMarche.BringToFront(); //Afficher au premier plan l'accueil

            labTitre.Text = "ALBUMS DU MARCHE";
            //affichage des albums du marché
            PresenterAccueil.AfficherAlbumsDuMarche();
        }

        public void btn_MesAlbums_Click(object sender, EventArgs e)
        {
            //disparition des mauvais et apparition du bon userControl
            UserControlMesSouhaits.Hide();
            UserControlAlbumsDuMarche.Hide();
            userControlMesAlbums.Show();
            userControlMesAlbums.BringToFront();// Afficher au premier plan l'accueil

            labTitre.Text = "MES ALBUMS";
            //affichage des souhaits de mes albums
            PresenterAccueil.AfficherMesAlbums();          
        }

        public void btn_MesSouhaits_Click(object sender, EventArgs e)
        {
            //disparition des mauvais et apparition du bon userControl
            UserControlMesAlbums.Hide();
            UserControlAlbumsDuMarche.Hide();
            UserControlMesSouhaits.Show();
            UserControlMesSouhaits.BringToFront();

            labTitre.Text = "MES SOUHAITS";
            //affichage des souhaits
            PresenterAccueil.AfficherMesSouhaits();
        }

        public void btnAjouterMesAlbumsClick(object sender, EventArgs e)
        {
            IdAlbumAAjouter = int.Parse(((Button)(sender)).Name) + 1;

            PresenterAccueil.AjouterAMesAlbums();
        }

        public void btnSupprimerMesSouhaitsClick(object sender, EventArgs e)
        {
            IdAlbumAAjouter = int.Parse(((Button)(sender)).Name) + 1;

            PresenterAccueil.SupprimerMesSouhaits();
        }

        public void btnAjouterMesSouhaitsClick(object sender, EventArgs e)
        {
            IdAlbumAAjouter = int.Parse(((Button)(sender)).Name) + 1;

            PresenterAccueil.AjouterAMesSouhaits();
            
        }

        private void button_Deconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

