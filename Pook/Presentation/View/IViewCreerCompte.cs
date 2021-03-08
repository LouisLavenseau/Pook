using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Presenter;
using System.Windows.Forms;
namespace Presentation.View
{
    public interface IViewCreerCompte
    {
        string LoginRentre { get; set; }
        string MdpRentre { get; set; }
        string NomImageRentre { get; set; }
        PictureBox pictureBoxPdp { get; set; }
        bool IdentifiantsRentres { get; set; }
        bool AppuyeSurValide { get; set; }
        PresenterCreerCompte PresenterCreerCompte { get; set; }
    }
}
