namespace Presentation.View
{
    partial class userControlMesSouhaits
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
            this.flowLayoutPanelMesSouhaits = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMesSouhaits
            // 
            this.flowLayoutPanelMesSouhaits.AutoScroll = true;
            this.flowLayoutPanelMesSouhaits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.flowLayoutPanelMesSouhaits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMesSouhaits.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMesSouhaits.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanelMesSouhaits.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMesSouhaits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelMesSouhaits.Name = "flowLayoutPanelMesSouhaits";
            this.flowLayoutPanelMesSouhaits.Size = new System.Drawing.Size(1253, 743);
            this.flowLayoutPanelMesSouhaits.TabIndex = 4;
            this.flowLayoutPanelMesSouhaits.WrapContents = false;
            // 
            // userControlMesSouhaits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.flowLayoutPanelMesSouhaits);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userControlMesSouhaits";
            this.Size = new System.Drawing.Size(1253, 743);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMesSouhaits;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel
        {
            get { return flowLayoutPanelMesSouhaits; }
            set { flowLayoutPanelMesSouhaits = value; }
        }
    }
}
