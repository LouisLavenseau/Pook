using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.View;
using Presentation.Presenter;

namespace Presentation.View
{
    public partial class userControlAlbumsDuMarche : System.Windows.Forms.UserControl, IViewUserControl
    {
        public PresenterUserControl PresenterUserControl { get; set; }

        public userControlAlbumsDuMarche()
        {
            InitializeComponent();
            this.ForeColor = Color.Beige;
        }


        public void btnRechercherAlbumsDuMarche_Click(object sender, EventArgs e)
        {
            PresenterUserControl.RechercherAlbums();
            Program.formConnexion.FormAccueil.btn_AlbumsDuMarche_Click(sender, e);
        }
    }
}
