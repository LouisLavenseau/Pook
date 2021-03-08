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
using Presentation.View;
using DatabaseAccess;

namespace Presentation.View
{
    public partial class userControlAccueil : System.Windows.Forms.UserControl
    {
        private Label labAlbumMarche;
        private Label labAccueil;
        int _idUtilisateur;

        public userControlAccueil(int idUtilisateur)
        {
            _idUtilisateur = idUtilisateur;
            InitializeComponent();
        }



        private void InitializeComponent()
        {
            this.labAccueil = new System.Windows.Forms.Label();
            this.labAlbumMarche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAccueil
            // 
            this.labAccueil.AutoSize = true;
            this.labAccueil.Font = new System.Drawing.Font("Nirmala UI", 40F, System.Drawing.FontStyle.Bold);
            this.labAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.labAccueil.Location = new System.Drawing.Point(175, 141);
            this.labAccueil.Name = "labAccueil";
            this.labAccueil.Size = new System.Drawing.Size(698, 89);
            this.labAccueil.TabIndex = 0;
            this.labAccueil.Text = "Bienvenue sur Pook !";
            // 
            // labAlbumMarche
            // 
            this.labAlbumMarche.AutoSize = true;
            this.labAlbumMarche.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlbumMarche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.labAlbumMarche.Location = new System.Drawing.Point(195, 262);
            this.labAlbumMarche.Name = "labAlbumMarche";
            this.labAlbumMarche.Size = new System.Drawing.Size(665, 62);
            this.labAlbumMarche.TabIndex = 1;
            this.labAlbumMarche.Text = " Passez un agréable moment ";
            // 
            // userControlAccueil
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.labAlbumMarche);
            this.Controls.Add(this.labAccueil);
            this.Name = "userControlAccueil";
            this.Size = new System.Drawing.Size(1117, 643);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
