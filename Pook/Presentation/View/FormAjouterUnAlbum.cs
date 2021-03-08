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

namespace Presentation.View
{
    public partial class FormAjouterUnAlbum : Form, IViewAjouterUnAlbum
    {
        public bool AdministrateurRentre { get; set; }
        public PresenterAjouterUnAlbum PresenterAjouterUnAlbum { get; set; }
        public string NomImageCouverture { get; set; }
        public string NomRentre
        {
            get { return txtBoxNomAccueilAdmin.Text; }
            set { txtBoxNomAccueilAdmin.Text = value; }
        }
        public string AuteurRentre
        {
            get { return txtBoxAuteurAccueilAdmin.Text; }
            set { txtBoxAuteurAccueilAdmin.Text = value; }
        }
        public string SerieRentre
        {
            get { return txtBoxSerieAccueilAdmin.Text; }
            set { txtBoxSerieAccueilAdmin.Text = value; }
        }
        public string GenreRentre
        {
            get { return txtBoxGenreAccueilAdmin.Text; }
            set { txtBoxGenreAccueilAdmin.Text = value; }
        }
        public string CategorieRentre
        {
            get { return txtBoxCategorieAccueilAdmin.Text; }
            set { txtBoxCategorieAccueilAdmin.Text = value; }
        }
        public string EditeurRentre
        {
            get { return txtBoxEditeurAccueilAdmin.Text; }
            set { txtBoxEditeurAccueilAdmin.Text = value; }
        }
        public PictureBox PicBoxRentre
        {
            get { return picBoxTestUpload; }
            set { picBoxTestUpload = value; }
        }

        public FormAjouterUnAlbum()
        {
            InitializeComponent();
            AdministrateurRentre = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (PresenterAjouterUnAlbum.CheminImage != null && NomRentre != "" && AuteurRentre != "" && SerieRentre != "" && GenreRentre != ""
                && CategorieRentre != "" && EditeurRentre != "")
            {
                PresenterAjouterUnAlbum.AjouterLAlbum();
                PresenterAjouterUnAlbum.CheminImage = null;
                Close();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli toutes les informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnImporterImage_Click(object sender, EventArgs e)
        {
            PresenterAjouterUnAlbum.ImporterImage();

        }
    }
}
