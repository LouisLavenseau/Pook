namespace Presentation.View
{
    partial class FormConnexion
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
            this.grpBoxConnexion = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labMdp = new System.Windows.Forms.Label();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnCreerUnCompte = new System.Windows.Forms.Button();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxConnexion
            // 
            this.grpBoxConnexion.Controls.Add(this.pictureBox3);
            this.grpBoxConnexion.Controls.Add(this.pictureBox2);
            this.grpBoxConnexion.Controls.Add(this.labMdp);
            this.grpBoxConnexion.Controls.Add(this.btnSeConnecter);
            this.grpBoxConnexion.Controls.Add(this.btnCreerUnCompte);
            this.grpBoxConnexion.Controls.Add(this.txtBoxMdp);
            this.grpBoxConnexion.Controls.Add(this.txtBoxLogin);
            this.grpBoxConnexion.Controls.Add(this.labLogin);
            this.grpBoxConnexion.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxConnexion.ForeColor = System.Drawing.Color.White;
            this.grpBoxConnexion.Location = new System.Drawing.Point(21, 174);
            this.grpBoxConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxConnexion.Name = "grpBoxConnexion";
            this.grpBoxConnexion.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxConnexion.Size = new System.Drawing.Size(430, 267);
            this.grpBoxConnexion.TabIndex = 0;
            this.grpBoxConnexion.TabStop = false;
            this.grpBoxConnexion.Text = "Entrez vos identifiants";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::App.Properties.Resources.icons8_mot_de_passe_1_64;
            this.pictureBox3.Location = new System.Drawing.Point(11, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::App.Properties.Resources.icons8_utilisateur_100;
            this.pictureBox2.Location = new System.Drawing.Point(11, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // labMdp
            // 
            this.labMdp.AutoSize = true;
            this.labMdp.ForeColor = System.Drawing.Color.White;
            this.labMdp.Location = new System.Drawing.Point(46, 120);
            this.labMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMdp.Name = "labMdp";
            this.labMdp.Size = new System.Drawing.Size(129, 25);
            this.labMdp.TabIndex = 5;
            this.labMdp.Text = "Mot de passe";
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btnSeConnecter.FlatAppearance.BorderSize = 2;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeConnecter.Location = new System.Drawing.Point(274, 188);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(98, 47);
            this.btnSeConnecter.TabIndex = 4;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnValiderConnexion_Click);
            // 
            // btnCreerUnCompte
            // 
            this.btnCreerUnCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.btnCreerUnCompte.FlatAppearance.BorderSize = 2;
            this.btnCreerUnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreerUnCompte.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerUnCompte.Location = new System.Drawing.Point(61, 188);
            this.btnCreerUnCompte.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreerUnCompte.Name = "btnCreerUnCompte";
            this.btnCreerUnCompte.Size = new System.Drawing.Size(95, 47);
            this.btnCreerUnCompte.TabIndex = 3;
            this.btnCreerUnCompte.Text = "Créer un compte";
            this.btnCreerUnCompte.UseVisualStyleBackColor = false;
            this.btnCreerUnCompte.Click += new System.EventHandler(this.btnCreerUnCompte_Click);
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(247, 118);
            this.txtBoxMdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.Size = new System.Drawing.Size(146, 33);
            this.txtBoxMdp.TabIndex = 2;
            this.txtBoxMdp.PasswordChar = '*';
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(247, 68);
            this.txtBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(146, 33);
            this.txtBoxLogin.TabIndex = 1;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.ForeColor = System.Drawing.Color.White;
            this.labLogin.Location = new System.Drawing.Point(46, 71);
            this.labLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(63, 25);
            this.labLogin.TabIndex = 0;
            this.labLogin.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::App.Properties.Resources.Blanc_et_Rond_Rouge_Remise_en_Forme_Logo;
            this.pictureBox1.Image = global::App.Properties.Resources.Blanc_et_Rond_Rouge_Remise_en_Forme_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(159, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(476, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBoxConnexion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormConnexion2";
            this.grpBoxConnexion.ResumeLayout(false);
            this.grpBoxConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxConnexion;
        private System.Windows.Forms.Label labMdp;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Button btnCreerUnCompte;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}