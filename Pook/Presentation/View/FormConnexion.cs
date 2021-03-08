using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccess;
using Model;
using Presentation.Presenter;
using Presentation.View;

namespace Presentation.View
{
    public partial class FormConnexion : Form, IViewConnexion
    {
        public IUtilisateurRepository UtilisateurRepository { get; set; }
        public IAlbumRepository AlbumRepository { get; set; }
        public IAdministrateurRepository AdministrateurRepository { get; set; }
        public FormAccueil FormAccueil { get; set; }
        public PresenterConnexion PresenterConnexion { get; set; }
        public string LoginRentre
        {
            get { return txtBoxLogin.Text; }
            set { txtBoxLogin.Text = value; }
        }
        public string MdpRentre
        {
            get { return txtBoxMdp.Text; }
            set { txtBoxMdp.Text = value; }
        }
        public string NomImagePdp { get; set; }
        public static int _idUtilisateur { get; set; }
        public static int _idAdministrateur { get; set; }
        public bool IsCompteUtilisateurExistant { get; set; }
        public bool IsCompteAdministrateurExistant { get; set; }
        public bool Test { get; set; }

        public FormConnexion(IUtilisateurRepository utilisateurRepository, IAlbumRepository albumRepository, IAdministrateurRepository administrateurRepository)
        {
            InitializeComponent();
            UtilisateurRepository = utilisateurRepository;
            AlbumRepository = albumRepository;
            AdministrateurRepository = administrateurRepository;
            IsCompteUtilisateurExistant = false;
            IsCompteAdministrateurExistant = false;
            Test = false;
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            PresenterConnexion.ConnecterAdministrateurOuUtilisateur();

        }

        private void btnCreerUnCompte_Click(object sender, EventArgs e)
        {
            PresenterConnexion.CreerCompte();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
