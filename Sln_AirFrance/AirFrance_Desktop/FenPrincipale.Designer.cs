namespace AirFrance_Desktop
{
    partial class FenPrincipale
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterVolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acheterBilletToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.senregistrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.majDesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.majDesDonnéesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterVolsToolStripMenuItem1});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "&Reservation";
            // 
            // consulterVolsToolStripMenuItem1
            // 
            this.consulterVolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acheterBilletToolStripMenuItem1,
            this.senregistrerToolStripMenuItem1});
            this.consulterVolsToolStripMenuItem1.Name = "consulterVolsToolStripMenuItem1";
            this.consulterVolsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.consulterVolsToolStripMenuItem1.Text = "&Consulter vols";
            // 
            // acheterBilletToolStripMenuItem1
            // 
            this.acheterBilletToolStripMenuItem1.Name = "acheterBilletToolStripMenuItem1";
            this.acheterBilletToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.acheterBilletToolStripMenuItem1.Text = "&Acheter billet";
            this.acheterBilletToolStripMenuItem1.Click += new System.EventHandler(this.acheterBilletToolStripMenuItem1_Click);
            // 
            // senregistrerToolStripMenuItem1
            // 
            this.senregistrerToolStripMenuItem1.Name = "senregistrerToolStripMenuItem1";
            this.senregistrerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.senregistrerToolStripMenuItem1.Text = "&S\'enregistrer";
            // 
            // majDesDonnéesToolStripMenuItem
            // 
            this.majDesDonnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem});
            this.majDesDonnéesToolStripMenuItem.Name = "majDesDonnéesToolStripMenuItem";
            this.majDesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.majDesDonnéesToolStripMenuItem.Text = "&Maj des données";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // FenPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FenPrincipale";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FenPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acheterBilletToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem senregistrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem majDesDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
    }
}

