using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Presenter;
using Presentation.View;
using DatabaseAccess;

namespace Presentation
{
    public class Program
    {
        public static FormConnexion formConnexion { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            IAlbumRepository albumRepository = new AlbumRepository();
            IAdministrateurRepository administrateurRepository = new AdministrateurRepository();
            Program.formConnexion = new FormConnexion(utilisateurRepository, albumRepository, administrateurRepository);
            PresenterConnexion presenteurConnexion = new PresenterConnexion(albumRepository, utilisateurRepository, administrateurRepository, formConnexion);
            FormCreerCompte formCreerCompte = new FormCreerCompte();
            Application.Run(formConnexion);
        }
    }
}
