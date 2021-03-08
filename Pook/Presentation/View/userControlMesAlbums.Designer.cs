namespace Presentation.View
{
    partial class userControlMesAlbums
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
            this.flowLayoutPanelMesAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMesAlbums
            // 
            this.flowLayoutPanelMesAlbums.AutoScroll = true;
            this.flowLayoutPanelMesAlbums.AutoSize = true;
            this.flowLayoutPanelMesAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.flowLayoutPanelMesAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMesAlbums.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMesAlbums.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelMesAlbums.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMesAlbums.Name = "flowLayoutPanelMesAlbums";
            this.flowLayoutPanelMesAlbums.Size = new System.Drawing.Size(1489, 840);
            this.flowLayoutPanelMesAlbums.TabIndex = 1;
            this.flowLayoutPanelMesAlbums.WrapContents = false;
            // 
            // userControlMesAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(36F, 81F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.flowLayoutPanelMesAlbums);
            this.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Name = "userControlMesAlbums";
            this.Size = new System.Drawing.Size(1489, 840);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageCouverture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMesAlbums;

        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel
        {
            get { return flowLayoutPanelMesAlbums; }
            set { flowLayoutPanelMesAlbums = value; }
        }
    }
}
