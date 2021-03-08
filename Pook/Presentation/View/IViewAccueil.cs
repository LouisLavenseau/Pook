using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Presenter;
using Presentation.View;

namespace Presentation.View
{
    public interface IViewAccueil
    {
        string Login { get; set; }
        int IdUtilisateur { get; set; }
        int IdAlbumAAjouter { get; set; }
        PresenterAccueil PresenterAccueil { get; set; }
        PictureBox PicturePdp { get; set; }
        TextBox TxtBoxRechercheRealisee { get; set; }
        Button BtnRechercher { get; set; }
        Label LabTitre { get; set; }
        Panel PanelRechercher { get; set; }
        userControlAlbumsDuMarche UserControlAlbumsDuMarche { get; set; }
        userControlMesAlbums UserControlMesAlbums { get; set; }
        userControlMesSouhaits UserControlMesSouhaits { get; set; }
        PresenterUserControl PresenterUserControlAlbumsDuMarche { get; set; }
        PresenterUserControl PresenterUserControlMesAlbums { get; set; }
        PresenterUserControl PresenterUserControlMesSouhaits { get; set; }
        void btnAjouterMesAlbumsClick(object sender, EventArgs e);
        void btnAjouterMesSouhaitsClick(object sender, EventArgs e);
        void btn_MesSouhaits_Click(object sender, EventArgs e);
        void btnSupprimerMesSouhaitsClick(object sender, EventArgs e);

    }
}
