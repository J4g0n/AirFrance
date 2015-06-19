namespace AirFrance_Desktop
{
    partial class FenAvions
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
            this.lbl_Avion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.lbl_NumeroSerie = new System.Windows.Forms.Label();
            this.lbl_nbPassagers = new System.Windows.Forms.Label();
            this.lbl_Modele = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cmb_NumeroSerie = new System.Windows.Forms.ComboBox();
            this.cmb_NbPassagers = new System.Windows.Forms.ComboBox();
            this.cmb_Modele = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Avion
            // 
            this.lbl_Avion.AutoSize = true;
            this.lbl_Avion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Avion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Avion.Location = new System.Drawing.Point(29, 18);
            this.lbl_Avion.Name = "lbl_Avion";
            this.lbl_Avion.Size = new System.Drawing.Size(97, 13);
            this.lbl_Avion.TabIndex = 0;
            this.lbl_Avion.Text = "Gestion des avions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(32, 368);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 2;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(113, 368);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(194, 368);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(275, 368);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_Quitter.TabIndex = 5;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            // 
            // lbl_NumeroSerie
            // 
            this.lbl_NumeroSerie.AutoSize = true;
            this.lbl_NumeroSerie.Location = new System.Drawing.Point(380, 61);
            this.lbl_NumeroSerie.Name = "lbl_NumeroSerie";
            this.lbl_NumeroSerie.Size = new System.Drawing.Size(84, 13);
            this.lbl_NumeroSerie.TabIndex = 6;
            this.lbl_NumeroSerie.Text = "Numero de série";
            // 
            // lbl_nbPassagers
            // 
            this.lbl_nbPassagers.AutoSize = true;
            this.lbl_nbPassagers.Location = new System.Drawing.Point(380, 159);
            this.lbl_nbPassagers.Name = "lbl_nbPassagers";
            this.lbl_nbPassagers.Size = new System.Drawing.Size(72, 13);
            this.lbl_nbPassagers.TabIndex = 7;
            this.lbl_nbPassagers.Text = "Nb passagers";
            // 
            // lbl_Modele
            // 
            this.lbl_Modele.AutoSize = true;
            this.lbl_Modele.Location = new System.Drawing.Point(380, 109);
            this.lbl_Modele.Name = "lbl_Modele";
            this.lbl_Modele.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modele.TabIndex = 8;
            this.lbl_Modele.Text = "Modele";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(475, 263);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 9;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            // 
            // cmb_NumeroSerie
            // 
            this.cmb_NumeroSerie.FormattingEnabled = true;
            this.cmb_NumeroSerie.Location = new System.Drawing.Point(530, 61);
            this.cmb_NumeroSerie.Name = "cmb_NumeroSerie";
            this.cmb_NumeroSerie.Size = new System.Drawing.Size(121, 21);
            this.cmb_NumeroSerie.TabIndex = 10;
            // 
            // cmb_NbPassagers
            // 
            this.cmb_NbPassagers.FormattingEnabled = true;
            this.cmb_NbPassagers.Location = new System.Drawing.Point(530, 159);
            this.cmb_NbPassagers.Name = "cmb_NbPassagers";
            this.cmb_NbPassagers.Size = new System.Drawing.Size(121, 21);
            this.cmb_NbPassagers.TabIndex = 11;
            // 
            // cmb_Modele
            // 
            this.cmb_Modele.FormattingEnabled = true;
            this.cmb_Modele.Location = new System.Drawing.Point(530, 109);
            this.cmb_Modele.Name = "cmb_Modele";
            this.cmb_Modele.Size = new System.Drawing.Size(121, 21);
            this.cmb_Modele.TabIndex = 12;
            // 
            // FenAvions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 424);
            this.Controls.Add(this.cmb_Modele);
            this.Controls.Add(this.cmb_NbPassagers);
            this.Controls.Add(this.cmb_NumeroSerie);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.lbl_Modele);
            this.Controls.Add(this.lbl_nbPassagers);
            this.Controls.Add(this.lbl_NumeroSerie);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Avion);
            this.Name = "FenAvions";
            this.Text = "FenAvions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Avion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Label lbl_NumeroSerie;
        private System.Windows.Forms.Label lbl_nbPassagers;
        private System.Windows.Forms.Label lbl_Modele;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cmb_NumeroSerie;
        private System.Windows.Forms.ComboBox cmb_NbPassagers;
        private System.Windows.Forms.ComboBox cmb_Modele;
    }
}