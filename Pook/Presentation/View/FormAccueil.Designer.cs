using Presentation.Presenter;
using System.Drawing;
using System.Windows;
namespace Presentation.View
{
    partial class FormAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private System.Windows.Forms.Panel panelGauche;
        private System.Windows.Forms.Panel panelHautGauche;
        private System.Windows.Forms.PictureBox pictureUtilisateur;
        private System.Windows.Forms.Label labLoginAccueil;
        private System.Windows.Forms.Button button_Deconnexion;
        private System.Windows.Forms.Button btn_MesAlbums;
        private System.Windows.Forms.Button btn_AlbumsDuMarche;
        private System.Windows.Forms.Button btn_MesSouhaits;
        private System.Windows.Forms.Panel panelSuperieur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private System.Windows.Forms.Panel pannel_Slide;
        public userControlAlbumsDuMarche UserControlAlbumsDuMarche
        {
            get { return userControlAlbumsDuMarche; }
            set { userControlAlbumsDuMarche = value; }
        }
        public userControlMesAlbums UserControlMesAlbums
        {
            get { return userControlMesAlbums; }
            set { userControlMesAlbums = value; }
        }
        public userControlMesSouhaits UserControlMesSouhaits
        {
            get { return userControlMesSouhaits; }
            set { userControlMesSouhaits = value; }
        }

        private void InitializeComponent()
        {
            this.panelGauche = new System.Windows.Forms.Panel();
            this.button_Deconnexion = new System.Windows.Forms.Button();
            this.btn_MesSouhaits = new System.Windows.Forms.Button();
            this.btn_MesAlbums = new System.Windows.Forms.Button();
            this.btn_AlbumsDuMarche = new System.Windows.Forms.Button();
            this.panelHautGauche = new System.Windows.Forms.Panel();
            this.labLoginAccueil = new System.Windows.Forms.Label();
            this.pictureUtilisateur = new System.Windows.Forms.PictureBox();
            this.panelSuperieur = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.labTitre = new System.Windows.Forms.Label();
            this.userControlMesSouhaits = new Presentation.View.userControlMesSouhaits();
            this.userControlAlbumsDuMarche = new Presentation.View.userControlAlbumsDuMarche();
            this.userControlMesAlbums = new Presentation.View.userControlMesAlbums();
            this.panelGauche.SuspendLayout();
            this.panelHautGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUtilisateur)).BeginInit();
            this.panelSuperieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGauche
            // 
            this.panelGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.panelGauche.Controls.Add(this.button_Deconnexion);
            this.panelGauche.Controls.Add(this.btn_MesSouhaits);
            this.panelGauche.Controls.Add(this.btn_MesAlbums);
            this.panelGauche.Controls.Add(this.btn_AlbumsDuMarche);
            this.panelGauche.Controls.Add(this.panelHautGauche);
            this.panelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGauche.ForeColor = System.Drawing.Color.White;
            this.panelGauche.Location = new System.Drawing.Point(0, 0);
            this.panelGauche.Margin = new System.Windows.Forms.Padding(20);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(247, 881);
            this.panelGauche.TabIndex = 0;
            // 
            // button_Deconnexion
            // 
            this.button_Deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.button_Deconnexion.FlatAppearance.BorderSize = 0;
            this.button_Deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Deconnexion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Deconnexion.ForeColor = System.Drawing.Color.White;
            this.button_Deconnexion.Image = global::App.Properties.Resources.icons8_fermer_52;
            this.button_Deconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Deconnexion.Location = new System.Drawing.Point(0, 326);
            this.button_Deconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.button_Deconnexion.Name = "button_Deconnexion";
            this.button_Deconnexion.Size = new System.Drawing.Size(247, 59);
            this.button_Deconnexion.TabIndex = 2;
            this.button_Deconnexion.Text = "   Déconnexion";
            this.button_Deconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Deconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Deconnexion.UseVisualStyleBackColor = false;
            this.button_Deconnexion.Click += new System.EventHandler(this.button_Deconnexion_Click);
            // 
            // btn_MesSouhaits
            // 
            this.btn_MesSouhaits.FlatAppearance.BorderSize = 0;
            this.btn_MesSouhaits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MesSouhaits.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_MesSouhaits.ForeColor = System.Drawing.Color.White;
            this.btn_MesSouhaits.Image = global::App.Properties.Resources.icons8_liste_de_souhaits_96;
            this.btn_MesSouhaits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MesSouhaits.Location = new System.Drawing.Point(0, 267);
            this.btn_MesSouhaits.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MesSouhaits.Name = "btn_MesSouhaits";
            this.btn_MesSouhaits.Size = new System.Drawing.Size(247, 59);
            this.btn_MesSouhaits.TabIndex = 5;
            this.btn_MesSouhaits.Text = "   Mes souhaits";
            this.btn_MesSouhaits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MesSouhaits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MesSouhaits.UseVisualStyleBackColor = true;
            this.btn_MesSouhaits.Click += new System.EventHandler(this.btn_MesSouhaits_Click);
            // 
            // btn_MesAlbums
            // 
            this.btn_MesAlbums.FlatAppearance.BorderSize = 0;
            this.btn_MesAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MesAlbums.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_MesAlbums.ForeColor = System.Drawing.Color.White;
            this.btn_MesAlbums.Image = global::App.Properties.Resources.icons8_livre_ouvert_90;
            this.btn_MesAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MesAlbums.Location = new System.Drawing.Point(0, 208);
            this.btn_MesAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MesAlbums.Name = "btn_MesAlbums";
            this.btn_MesAlbums.Size = new System.Drawing.Size(247, 59);
            this.btn_MesAlbums.TabIndex = 3;
            this.btn_MesAlbums.Text = "   Mes albums";
            this.btn_MesAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MesAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MesAlbums.UseVisualStyleBackColor = true;
            this.btn_MesAlbums.Click += new System.EventHandler(this.btn_MesAlbums_Click);
            // 
            // btn_AlbumsDuMarche
            // 
            this.btn_AlbumsDuMarche.FlatAppearance.BorderSize = 0;
            this.btn_AlbumsDuMarche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlbumsDuMarche.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_AlbumsDuMarche.ForeColor = System.Drawing.Color.White;
            this.btn_AlbumsDuMarche.Image = global::App.Properties.Resources.icons8_acheter_52;
            this.btn_AlbumsDuMarche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AlbumsDuMarche.Location = new System.Drawing.Point(0, 149);
            this.btn_AlbumsDuMarche.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AlbumsDuMarche.Name = "btn_AlbumsDuMarche";
            this.btn_AlbumsDuMarche.Size = new System.Drawing.Size(247, 59);
            this.btn_AlbumsDuMarche.TabIndex = 2;
            this.btn_AlbumsDuMarche.Text = "   Albums du marché";
            this.btn_AlbumsDuMarche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AlbumsDuMarche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AlbumsDuMarche.UseVisualStyleBackColor = true;
            this.btn_AlbumsDuMarche.Click += new System.EventHandler(this.btn_AlbumsDuMarche_Click);
            // 
            // panelHautGauche
            // 
            this.panelHautGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panelHautGauche.Controls.Add(this.labLoginAccueil);
            this.panelHautGauche.Controls.Add(this.pictureUtilisateur);
            this.panelHautGauche.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHautGauche.Location = new System.Drawing.Point(0, 0);
            this.panelHautGauche.Margin = new System.Windows.Forms.Padding(20);
            this.panelHautGauche.Name = "panelHautGauche";
            this.panelHautGauche.Size = new System.Drawing.Size(247, 125);
            this.panelHautGauche.TabIndex = 1;
            // 
            // labLoginAccueil
            // 
            this.labLoginAccueil.AutoSize = true;
            this.labLoginAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginAccueil.ForeColor = System.Drawing.Color.White;
            this.labLoginAccueil.Location = new System.Drawing.Point(80, 52);
            this.labLoginAccueil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLoginAccueil.Name = "labLoginAccueil";
            this.labLoginAccueil.Size = new System.Drawing.Size(65, 25);
            this.labLoginAccueil.TabIndex = 1;
            this.labLoginAccueil.Text = "Login";
            // 
            // pictureUtilisateur
            // 
            this.pictureUtilisateur.Image = global::App.Properties.Resources.Username;
            this.pictureUtilisateur.InitialImage = global::App.Properties.Resources.Username;
            this.pictureUtilisateur.Location = new System.Drawing.Point(13, 37);
            this.pictureUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.pictureUtilisateur.Name = "pictureUtilisateur";
            this.pictureUtilisateur.Size = new System.Drawing.Size(59, 58);
            this.pictureUtilisateur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUtilisateur.TabIndex = 0;
            this.pictureUtilisateur.TabStop = false;
            // 
            // panelSuperieur
            // 
            this.panelSuperieur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.panelSuperieur.Controls.Add(this.picBoxLogo);
            this.panelSuperieur.Controls.Add(this.labTitre);
            this.panelSuperieur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperieur.Location = new System.Drawing.Point(247, 0);
            this.panelSuperieur.Margin = new System.Windows.Forms.Padding(20);
            this.panelSuperieur.Name = "panelSuperieur";
            this.panelSuperieur.Size = new System.Drawing.Size(1509, 123);
            this.panelSuperieur.TabIndex = 1;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::App.Properties.Resources.Blanc_et_Rond_Rouge_Remise_en_Forme_Logo;
            this.picBoxLogo.InitialImage = global::App.Properties.Resources.Blanc_et_Rond_Rouge_Remise_en_Forme_Logo;
            this.picBoxLogo.Location = new System.Drawing.Point(23, 20);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(80, 80);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 5;
            this.picBoxLogo.TabStop = false;
            // 
            // labTitre
            // 
            this.labTitre.BackColor = System.Drawing.Color.Transparent;
            this.labTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitre.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitre.ForeColor = System.Drawing.Color.Snow;
            this.labTitre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labTitre.Location = new System.Drawing.Point(0, 0);
            this.labTitre.Name = "labTitre";
            this.labTitre.Padding = new System.Windows.Forms.Padding(20);
            this.labTitre.Size = new System.Drawing.Size(1509, 125);
            this.labTitre.TabIndex = 0;
            this.labTitre.Text = "ALBUMS DU MARCHE";
            this.labTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControlMesSouhaits
            // 
            this.userControlMesSouhaits.AutoSize = true;
            this.userControlMesSouhaits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.userControlMesSouhaits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMesSouhaits.ForeColor = System.Drawing.Color.MidnightBlue;
            this.userControlMesSouhaits.Location = new System.Drawing.Point(247, 123);
            this.userControlMesSouhaits.Margin = new System.Windows.Forms.Padding(5);
            this.userControlMesSouhaits.Name = "userControlMesSouhaits";
            this.userControlMesSouhaits.PresenterUserControl = null;
            this.userControlMesSouhaits.Size = new System.Drawing.Size(1509, 758);
            this.userControlMesSouhaits.TabIndex = 4;
            // 
            // userControlAlbumsDuMarche
            // 
            this.userControlAlbumsDuMarche.AutoSize = true;
            this.userControlAlbumsDuMarche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.userControlAlbumsDuMarche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAlbumsDuMarche.ForeColor = System.Drawing.Color.Transparent;
            this.userControlAlbumsDuMarche.Location = new System.Drawing.Point(247, 123);
            this.userControlAlbumsDuMarche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlAlbumsDuMarche.Name = "userControlAlbumsDuMarche";
            this.userControlAlbumsDuMarche.PresenterUserControl = null;
            this.userControlAlbumsDuMarche.Size = new System.Drawing.Size(1509, 758);
            this.userControlAlbumsDuMarche.TabIndex = 3;
            // 
            // userControlMesAlbums
            // 
            this.userControlMesAlbums.AutoSize = true;
            this.userControlMesAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.userControlMesAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMesAlbums.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold);
            this.userControlMesAlbums.ForeColor = System.Drawing.Color.White;
            this.userControlMesAlbums.Location = new System.Drawing.Point(247, 123);
            this.userControlMesAlbums.Margin = new System.Windows.Forms.Padding(20);
            this.userControlMesAlbums.Name = "userControlMesAlbums";
            this.userControlMesAlbums.PresenterUserControl = null;
            this.userControlMesAlbums.Size = new System.Drawing.Size(1509, 758);
            this.userControlMesAlbums.TabIndex = 3;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1756, 881);
            this.Controls.Add(this.userControlMesSouhaits);
            this.Controls.Add(this.userControlAlbumsDuMarche);
            this.Controls.Add(this.userControlMesAlbums);
            this.Controls.Add(this.panelSuperieur);
            this.Controls.Add(this.panelGauche);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelGauche.ResumeLayout(false);
            this.panelHautGauche.ResumeLayout(false);
            this.panelHautGauche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUtilisateur)).EndInit();
            this.panelSuperieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControlMesAlbums userControlMesAlbums;
        private userControlAlbumsDuMarche userControlAlbumsDuMarche;
        private userControlMesSouhaits userControlMesSouhaits;
        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.PictureBox picBoxLogo;
    }
}