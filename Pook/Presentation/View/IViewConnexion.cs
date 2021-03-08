using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;
using Model;
using Presentation.Presenter;
using Presentation.View;

namespace Presentation.View
{
    public interface IViewConnexion
    {
        IUtilisateurRepository UtilisateurRepository { get; set; }
        IAlbumRepository AlbumRepository { get; set; }
        IAdministrateurRepository AdministrateurRepository { get; set; }
        FormAccueil FormAccueil { get; set; }
        PresenterConnexion PresenterConnexion { get; set; }
        string LoginRentre { get; set; }
        string MdpRentre { get; set; }
        string NomImagePdp { get; set; }
        bool IsCompteUtilisateurExistant { get; set; }
        bool IsCompteAdministrateurExistant { get; set; }
        bool Test { get; set; }

    }
}
