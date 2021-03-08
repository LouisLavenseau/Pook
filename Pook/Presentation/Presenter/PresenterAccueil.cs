using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DatabaseAccess;
using Model;
using Presentation.View;


namespace Presentation.Presenter
{
    public class PresenterAccueil
    {
        IUtilisateurRepository _utilisateurRepository;
        IAlbumRepository _albumRepository;
        IViewAccueil _viewAccueil;

        public PresenterAccueil(IViewAccueil vueAccueil)
        {
            _viewAccueil = vueAccueil;
            _utilisateurRepository = PresenterConnexion._utilisateurRepository;
            _albumRepository = PresenterConnexion._albumRepository;
            _viewAccueil.PresenterAccueil = this;

        }

        public void AfficherAlbumsDuMarche()
        {
            //récupération des albums de la liste des albums du marché de la BDD 
            IList<Album> albumsAAfficher = _albumRepository.GetAll();

            //affichage des albums du marché
            AfficherAlbums("userControlAlbumsDuMarche", _viewAccueil.UserControlAlbumsDuMarche, _viewAccueil.UserControlAlbumsDuMarche.FlowLayoutPanel,
                            new System.EventHandler(_viewAccueil.UserControlAlbumsDuMarche.btnRechercherAlbumsDuMarche_Click), albumsAAfficher);
        }

        public void AfficherMesAlbums()
        {
            //récupération des albums de la liste de mes albums de la BDD et conversion en type album
            IList<Object> albumsBDD = _albumRepository.GetMesAlbums(_viewAccueil.IdUtilisateur);
            List<Album> albumsAAfficher = new List<Album> { };
            foreach (Object album in albumsBDD)
            {
                albumsAAfficher.Add((Album)album);
            }

            //affichage de mes albums
            AfficherAlbums("userControlMesAlbums", _viewAccueil.UserControlMesAlbums, _viewAccueil.UserControlMesAlbums.FlowLayoutPanel,
                            new System.EventHandler(_viewAccueil.UserControlMesAlbums.btnRechercherMesAlbums_Click), albumsAAfficher);
        }

        public void AfficherMesSouhaits()
        {
            //récupération des albums de la liste des souhaits de la BDD et conversion en type album
            IList<Object> albumsBDD = _albumRepository.GetMesSouhaits(_viewAccueil.IdUtilisateur);
            List<Album> albumsAAfficher = new List<Album> { };
            foreach (Object album in albumsBDD)
            {
                albumsAAfficher.Add((Album)album);
            }

            //affichage des albums
            AfficherAlbums("userControlMesSouhaits", _viewAccueil.UserControlMesSouhaits, _viewAccueil.UserControlMesSouhaits.FlowLayoutPanel,
                            new System.EventHandler(_viewAccueil.UserControlMesSouhaits.btnRechercherMesSouhaits_Click), albumsAAfficher);

        }

        public void CustomiserLabel(ref Label label, int cpt, Album album, Size size, Point point, int taillePolice)
        {
            label.Font = new Font("Microsoft Sans Serif", taillePolice);
            label.Size = size;
            label.Location = point;
            /*if (cpt % 2 == 1) {*/
            label.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78))))); /*}*/
        }

        public void AfficherAlbums(string userControl, System.Windows.Forms.UserControl refUserControl, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler,
                                   IList<Album> albumsAAfficher)
        {
            //met le flowlayoutpanel dans le user control et enlève tous les albums qu'il y avait déjà de-dans
            refUserControl.Controls.Add(flowLayoutPanel);
            flowLayoutPanel.Controls.Clear();
            //_viewAccueil.UserControlMesSouhaits.txtBoxRechercherMesSouhaits.Clear();

            //remise à zéro de la textbox et du bouton pour faire une recherche
            _viewAccueil.TxtBoxRechercheRealisee = new TextBox();
            _viewAccueil.BtnRechercher = new Button();
            _viewAccueil.PanelRechercher = new Panel();



            //ajout barre de recherche / bouton rechercher
            Panel panelRecherche = new Panel();
            panelRecherche.Size = new Size(2000, 50);
            flowLayoutPanel.Controls.Add(panelRecherche);       
            _viewAccueil.TxtBoxRechercheRealisee.Size = new Size(100, 25);
            _viewAccueil.TxtBoxRechercheRealisee.Location = new Point(100, 17);
            _viewAccueil.TxtBoxRechercheRealisee.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            _viewAccueil.BtnRechercher.Size = new Size(100, 25);
            _viewAccueil.BtnRechercher.Location = new Point(220, 15);
            _viewAccueil.BtnRechercher.Text = "Rechercher";
            _viewAccueil.BtnRechercher.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));

            _viewAccueil.BtnRechercher.Click += eventHandler;

            // panelRecherche.Controls.Add(_viewAccueil.PanelRechercher);
            panelRecherche.Controls.Add(_viewAccueil.BtnRechercher);
            panelRecherche.Controls.Add(_viewAccueil.TxtBoxRechercheRealisee);


            int cpt = 0;
            int cpt2 = 0;

            //creation des listes qui vont contenir tous les controles pour chaque album
            List<Panel> panels = new List<Panel> { };
            List<PictureBox> picturesBox = new List<PictureBox> { };
            List<Button> boutons = new List<Button> { };
            List<Button> boutons2 = new List<Button> { };
            List<Label> labsNoms = new List<Label> { };
            List<Label> labsAuteurs = new List<Label> { };
            List<Label> labsEditeur = new List<Label> { };
            List<Label> labsCategorie = new List<Label> { };
            List<Label> labsGenre = new List<Label> { };
            List<Label> labsSerie = new List<Label> { };

            //instanciation du label qu'on passera en paramètre ref de la fonction CustomiserLabel
            Label labelAPasserEnParametre = new Label();

            foreach (Album album in albumsAAfficher)
            {
                //on crée les controles
                panels.Add(new Panel());
                picturesBox.Add(new PictureBox());
                labsNoms.Add(new Label());
                labsAuteurs.Add(new Label());
                labsEditeur.Add(new Label());
                labsCategorie.Add(new Label());
                labsGenre.Add(new Label());
                labsSerie.Add(new Label());
                boutons.Add(new Button());
                boutons2.Add(new Button());

                if (album.CorrespondALaRecherche)
                {
                    //on ajoute les panels
                    panels[cpt].Size = new Size(2000, 150);

                    // panels[cpt].Height = 300;
                    //panels[cpt].Anchor = AnchorStyles.Right;
                    // panels[cpt].Anchor = AnchorStyles.Left;
                    /* panels[cpt].Dock = DockStyle.Right;
                     panels[cpt].Dock = DockStyle.Left;*/
                    /*panels[cpt].Dock = DockStyle.Top;
                    panels[cpt].Dock = DockStyle.Bottom;*/
                    //panels[cpt].Dock = DockStyle.Fill;
                    //Color.FromArgb(41, 53, 100);
                    /*if (cpt2 % 2 == 0) {*/
                    panels[cpt].BackColor = Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(209)))), ((int)(((byte)(211)))));/* }
                    else { panels[cpt].BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138))))); }*/
                    flowLayoutPanel.Controls.Add(panels[cpt]);

                    //on ajoute les images des albums
                    panels[cpt].Controls.Add(picturesBox[cpt]);
                    string nomImage = album.ImageCouverture;
                    Image image = new Bitmap(Path.Combine("../../Resources/", nomImage));
                    if (image.Width < image.Height)
                    {
                        image = new Bitmap(image, new Size((int)Math.Floor((double)image.Width / (image.Height / 100)), 100));
                    }
                    else
                    {
                        image = new Bitmap(image, new Size(85, (int)Math.Ceiling((double)image.Height / (image.Width / 85))));
                    }
                    picturesBox[cpt].Image = image;
                    picturesBox[cpt].Location = new Point(40, 25);
                    picturesBox[cpt].SizeMode = PictureBoxSizeMode.AutoSize;

                    //on ajoute les labels noms
                    panels[cpt].Controls.Add(labsNoms[cpt]);
                    labsNoms[cpt].Text = album.Nom;
                    labelAPasserEnParametre = labsNoms[cpt];
                    CustomiserLabel(ref labelAPasserEnParametre, cpt2, album, new Size(400, 29), new Point(168, 25), 15);
                    labelAPasserEnParametre.Font = new Font(labelAPasserEnParametre.Font, FontStyle.Bold);

                    //on ajoute les labels auteurs
                    panels[cpt].Controls.Add(labsAuteurs[cpt]);
                    labsAuteurs[cpt].Text = "Auteur(s) : " + album.Auteurs;
                    labelAPasserEnParametre = labsAuteurs[cpt];
                    CustomiserLabel(ref labelAPasserEnParametre, cpt2, album, new Size(300, 15), new Point(170, 52), 9);

                    //on ajoute les labels editeur
                    panels[cpt].Controls.Add(labsEditeur[cpt]);
                    labsEditeur[cpt].Text = "Editeur : " + album.Editeur;
                    labelAPasserEnParametre = labsEditeur[cpt];
                    CustomiserLabel(ref labelAPasserEnParametre, cpt2, album, new Size(300, 15), new Point(170, 67), 9);

                    //on ajoute les labels categorie
                    panels[cpt].Controls.Add(labsCategorie[cpt]);
                    labsCategorie[cpt].Text = "Catégorie : " + album.Categorie;
                    labelAPasserEnParametre = labsCategorie[cpt];
                    CustomiserLabel(ref labelAPasserEnParametre, cpt2, album, new Size(300, 15), new Point(170, 82), 9);

                    //on ajoute les labels genre
                    panels[cpt].Controls.Add(labsGenre[cpt]);
                    labsGenre[cpt].Text = "Genre : " + album.Genre;
                    labelAPasserEnParametre = labsGenre[cpt];
                    CustomiserLabel(ref labelAPasserEnParametre, cpt2, album, new Size(300, 15), new Point(170, 97), 9);

                    //on ajoute les labels serie
                    panels[cpt].Controls.Add(labsSerie[cpt]);
                    labsSerie[cpt].Text = "Serie : " + album.Serie;
                    labelAPasserEnParametre = labsSerie[cpt];
                    CustomiserLabel(ref labelAPasserEnParametre, cpt2, album, new Size(300, 15), new Point(170, 112), 9);

                    if (userControl == "userControlMesSouhaits")
                    {
                        //on ajoute le bouton
                        panels[cpt].Controls.Add(boutons[cpt]);
                        boutons[cpt].FlatAppearance.BorderSize = 0;
                        boutons[cpt].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        boutons[cpt].Size = new System.Drawing.Size(42, 42);
                        boutons[cpt].UseVisualStyleBackColor = true;
                        boutons[cpt].Name = (album.Id - 1).ToString();
                        boutons[cpt].Location = new Point(500, 50);
                        boutons[cpt].Click += new System.EventHandler(_viewAccueil.btnAjouterMesAlbumsClick);
                        boutons[cpt].Click += new System.EventHandler(_viewAccueil.btnSupprimerMesSouhaitsClick);
                        boutons[cpt].Click += new System.EventHandler(_viewAccueil.btn_MesSouhaits_Click);
                        boutons[cpt].Image = global::App.Properties.Resources.caddy;

                        //Ajout du bouton 
                        panels[cpt].Controls.Add(boutons2[cpt]);

                        boutons2[cpt].FlatAppearance.BorderSize = 0;
                        boutons2[cpt].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        boutons2[cpt].Size = new System.Drawing.Size(42, 42);
                        boutons2[cpt].UseVisualStyleBackColor = true;
                        boutons2[cpt].Name = (album.Id - 1).ToString();
                        boutons2[cpt].Size = new Size(42, 42);
                        boutons2[cpt].Location = new Point(500, 100);
                        boutons2[cpt].Click += new System.EventHandler(_viewAccueil.btnSupprimerMesSouhaitsClick);
                        boutons2[cpt].Click += new System.EventHandler(_viewAccueil.btn_MesSouhaits_Click);
                        boutons2[cpt].Image = global::App.Properties.Resources.croix;
                    }

                    else if (userControl == "userControlAlbumsDuMarche")
                    {
                        //on ajoute le bouton
                        panels[cpt].Controls.Add(boutons[cpt]);
                        boutons[cpt].FlatAppearance.BorderSize = 0;
                        boutons[cpt].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        boutons[cpt].Size = new System.Drawing.Size(42, 42);
                        boutons[cpt].UseVisualStyleBackColor = true;                        
                        boutons[cpt].Name = (album.Id - 1).ToString();
                        boutons[cpt].Location = new Point(500, 50);
                        boutons[cpt].Click += new System.EventHandler(_viewAccueil.btnAjouterMesAlbumsClick);
                        boutons[cpt].Image = global::App.Properties.Resources.caddy;

                        //Ajout du bouton mes Souhaits
                        panels[cpt].Controls.Add(boutons2[cpt]);
                        boutons2[cpt].FlatAppearance.BorderSize = 0;
                        boutons2[cpt].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        boutons2[cpt].Size = new System.Drawing.Size(42, 42);
                        boutons2[cpt].UseVisualStyleBackColor = true;
                        boutons2[cpt].Name = (album.Id - 1).ToString();
                        boutons2[cpt].Name = (album.Id - 1).ToString();
                        boutons2[cpt].Size = new Size(42, 42);
                        boutons2[cpt].Location = new Point(500, 100);
                        boutons2[cpt].Click += new System.EventHandler(_viewAccueil.btnAjouterMesSouhaitsClick);
                        boutons2[cpt].Image = global::App.Properties.Resources.heart2;
                    }
                    cpt2++;
                }
                cpt++;
                album.CorrespondALaRecherche = true;
            }
        }

        public void SupprimerMesSouhaits()
        {
            PresenterConnexion._albumRepository.SupprimerMesSouhaits(_viewAccueil.IdUtilisateur, _viewAccueil.IdAlbumAAjouter);
        }
        public void AjouterAMesAlbums()
        {
            PresenterConnexion._albumRepository.SaveMesAlbums(_viewAccueil.IdUtilisateur, _viewAccueil.IdAlbumAAjouter);
        }

        public void AjouterAMesSouhaits()
        {
            PresenterConnexion._albumRepository.SaveMesSouhaits(_viewAccueil.IdUtilisateur, _viewAccueil.IdAlbumAAjouter);
        }

    }
}
