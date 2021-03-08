using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presentation.Presenter;
using Presentation.View;
using DatabaseAccess;

namespace Presentation.View
{
    public partial class userControlMesSouhaits : System.Windows.Forms.UserControl, IViewUserControl
    {
        public PresenterUserControl PresenterUserControl { get; set; }            

        public userControlMesSouhaits()
        {
            InitializeComponent();
        }

        public void btnRechercherMesSouhaits_Click(object sender, EventArgs e)
        {
            PresenterUserControl.RechercherAlbums();

            Program.formConnexion.FormAccueil.btn_MesSouhaits_Click(sender, e);

        }

        
    }
}
