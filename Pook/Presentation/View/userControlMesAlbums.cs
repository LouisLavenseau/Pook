using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Presenter;

namespace Presentation.View
{
    public partial class userControlMesAlbums : System.Windows.Forms.UserControl, IViewUserControl
    {
        public PresenterUserControl PresenterUserControl { get; set; }

        public userControlMesAlbums()
        {
            InitializeComponent();
        }

        public void btnRechercherMesAlbums_Click(object sender, EventArgs e)
        {
            PresenterUserControl.RechercherAlbums();
            Program.formConnexion.FormAccueil.btn_MesAlbums_Click(sender, e);
        }
    }
}
