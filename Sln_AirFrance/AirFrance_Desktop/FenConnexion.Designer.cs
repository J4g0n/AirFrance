namespace AirFrance_Desktop
{
    partial class FenConnexion
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
            this.lbl_Identifiant = new System.Windows.Forms.Label();
            this.lbl_MotDePasse = new System.Windows.Forms.Label();
            this.cmb_Identifiant = new System.Windows.Forms.ComboBox();
            this.cmb_MotDePasse = new System.Windows.Forms.ComboBox();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Identifiant
            // 
            this.lbl_Identifiant.AutoSize = true;
            this.lbl_Identifiant.Location = new System.Drawing.Point(21, 24);
            this.lbl_Identifiant.Name = "lbl_Identifiant";
            this.lbl_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.lbl_Identifiant.TabIndex = 0;
            this.lbl_Identifiant.Text = "Identifiant";
            // 
            // lbl_MotDePasse
            // 
            this.lbl_MotDePasse.AutoSize = true;
            this.lbl_MotDePasse.Location = new System.Drawing.Point(24, 107);
            this.lbl_MotDePasse.Name = "lbl_MotDePasse";
            this.lbl_MotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lbl_MotDePasse.TabIndex = 1;
            this.lbl_MotDePasse.Text = "Mot de passe";
            // 
            // cmb_Identifiant
            // 
            this.cmb_Identifiant.FormattingEnabled = true;
            this.cmb_Identifiant.Location = new System.Drawing.Point(147, 24);
            this.cmb_Identifiant.Name = "cmb_Identifiant";
            this.cmb_Identifiant.Size = new System.Drawing.Size(121, 21);
            this.cmb_Identifiant.TabIndex = 2;
            // 
            // cmb_MotDePasse
            // 
            this.cmb_MotDePasse.FormattingEnabled = true;
            this.cmb_MotDePasse.Location = new System.Drawing.Point(147, 98);
            this.cmb_MotDePasse.Name = "cmb_MotDePasse";
            this.cmb_MotDePasse.Size = new System.Drawing.Size(121, 21);
            this.cmb_MotDePasse.TabIndex = 3;
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(107, 179);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(75, 23);
            this.btn_Connexion.TabIndex = 4;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            // 
            // FenConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.cmb_MotDePasse);
            this.Controls.Add(this.cmb_Identifiant);
            this.Controls.Add(this.lbl_MotDePasse);
            this.Controls.Add(this.lbl_Identifiant);
            this.Name = "FenConnexion";
            this.Text = "FenConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Identifiant;
        private System.Windows.Forms.Label lbl_MotDePasse;
        private System.Windows.Forms.ComboBox cmb_Identifiant;
        private System.Windows.Forms.ComboBox cmb_MotDePasse;
        private System.Windows.Forms.Button btn_Connexion;
    }
}