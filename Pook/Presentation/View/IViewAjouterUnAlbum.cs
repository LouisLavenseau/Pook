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
    public interface IViewAjouterUnAlbum
    {
        bool AdministrateurRentre { get; set; }
        string NomImageCouverture { get; set; }
        PresenterAjouterUnAlbum PresenterAjouterUnAlbum { get; set; }
        string NomRentre { get; set; }
        string AuteurRentre { get; set; }
        string SerieRentre { get; set; }
        string GenreRentre { get; set; }
        string CategorieRentre { get; set; }
        string EditeurRentre { get; set; }
        PictureBox PicBoxRentre { get; set; }
    }
}
