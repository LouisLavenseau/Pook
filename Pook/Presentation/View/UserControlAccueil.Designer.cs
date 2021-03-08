namespace Presentation.UserControl
{
    partial class UserControlAccueil
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Acceuil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Acceuil
            // 
            this.lab_Acceuil.AutoSize = true;
            this.lab_Acceuil.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Acceuil.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lab_Acceuil.Location = new System.Drawing.Point(342, 10);
            this.lab_Acceuil.Name = "lab_Acceuil";
            this.lab_Acceuil.Size = new System.Drawing.Size(221, 65);
            this.lab_Acceuil.TabIndex = 0;
            this.lab_Acceuil.Text = "ACCUEIL";
            // 
            // UserControlAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.lab_Acceuil);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "UserControlAccueil";
            this.Size = new System.Drawing.Size(965, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Acceuil;
    }
}
