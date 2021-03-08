namespace Presentation.View
{
    partial class FormAccueilAdmin
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccueilAdmin = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageCouverture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterUnAlbumAccueilAdmin = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.labAdministrateur = new System.Windows.Forms.Label();
            this.labAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccueilAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccueilAdmin
            // 
            this.dgvAccueilAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccueilAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccueilAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccueilAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccueilAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.ImageCouverture,
            this.Serie,
            this.Auteurs,
            this.Categorie,
            this.Genre,
            this.Editeur});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccueilAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccueilAdmin.GridColor = System.Drawing.Color.White;
            this.dgvAccueilAdmin.Location = new System.Drawing.Point(80, 178);
            this.dgvAccueilAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccueilAdmin.Name = "dgvAccueilAdmin";
            this.dgvAccueilAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccueilAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccueilAdmin.RowHeadersVisible = false;
            this.dgvAccueilAdmin.Size = new System.Drawing.Size(642, 284);
            this.dgvAccueilAdmin.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // ImageCouverture
            // 
            this.ImageCouverture.HeaderText = "Identifiant";
            this.ImageCouverture.Name = "ImageCouverture";
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            // 
            // Auteurs
            // 
            this.Auteurs.HeaderText = "Auteur(s)";
            this.Auteurs.Name = "Auteurs";
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Catégorie";
            this.Categorie.Name = "Categorie";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Editeur
            // 
            this.Editeur.HeaderText = "Editeur";
            this.Editeur.Name = "Editeur";
            // 
            // btnAjouterUnAlbumAccueilAdmin
            // 
            this.btnAjouterUnAlbumAccueilAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouterUnAlbumAccueilAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouterUnAlbumAccueilAdmin.FlatAppearance.BorderSize = 2;
            this.btnAjouterUnAlbumAccueilAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterUnAlbumAccueilAdmin.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterUnAlbumAccueilAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAjouterUnAlbumAccueilAdmin.Location = new System.Drawing.Point(743, 237);
            this.btnAjouterUnAlbumAccueilAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterUnAlbumAccueilAdmin.Name = "btnAjouterUnAlbumAccueilAdmin";
            this.btnAjouterUnAlbumAccueilAdmin.Size = new System.Drawing.Size(119, 42);
            this.btnAjouterUnAlbumAccueilAdmin.TabIndex = 2;
            this.btnAjouterUnAlbumAccueilAdmin.Text = "Ajouter un album";
            this.btnAjouterUnAlbumAccueilAdmin.UseVisualStyleBackColor = false;
            this.btnAjouterUnAlbumAccueilAdmin.Click += new System.EventHandler(this.btnAjouterUnAlbumAccueilAdmin_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btnDeconnexion.FlatAppearance.BorderSize = 2;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(743, 345);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(119, 39);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // labAdministrateur
            // 
            this.labAdministrateur.AutoSize = true;
            this.labAdministrateur.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAdministrateur.ForeColor = System.Drawing.Color.White;
            this.labAdministrateur.Location = new System.Drawing.Point(71, 35);
            this.labAdministrateur.Name = "labAdministrateur";
            this.labAdministrateur.Size = new System.Drawing.Size(680, 50);
            this.labAdministrateur.TabIndex = 4;
            this.labAdministrateur.Text = "Bienvenue sur la page administrateur ";
            // 
            // labAdmin
            // 
            this.labAdmin.AutoSize = true;
            this.labAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAdmin.ForeColor = System.Drawing.Color.White;
            this.labAdmin.Location = new System.Drawing.Point(113, 119);
            this.labAdmin.Name = "labAdmin";
            this.labAdmin.Size = new System.Drawing.Size(561, 21);
            this.labAdmin.TabIndex = 6;
            this.labAdmin.Text = "Vous pouvez consulter les albums du marché ou en ajouter de nouveaux";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::App.Properties.Resources.Blanc_et_Rond_Rouge_Remise_en_Forme_Logo;
            this.pictureBox2.Image = global::App.Properties.Resources.Blanc_et_Rond_Rouge_Remise_en_Forme_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(743, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormAccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(890, 503);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labAdmin);
            this.Controls.Add(this.labAdministrateur);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnAjouterUnAlbumAccueilAdmin);
            this.Controls.Add(this.dgvAccueilAdmin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAccueilAdmin";
            this.Text = "FormAccueilAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccueilAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAccueilAdmin;
        private System.Windows.Forms.Button btnAjouterUnAlbumAccueilAdmin;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageCouverture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editeur;
        private System.Windows.Forms.Label labAdministrateur;
        private System.Windows.Forms.Label labAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}