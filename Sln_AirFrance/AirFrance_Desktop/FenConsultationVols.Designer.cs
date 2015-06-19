namespace AirFrance_Desktop
{
    partial class FenConsultationVols
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
            this.txt_AeroportDepar = new System.Windows.Forms.Label();
            this.cmb_AeroportDepart = new System.Windows.Forms.ComboBox();
            this.lbl_AeroportArrivee = new System.Windows.Forms.Label();
            this.cmb_AeroportArrivee = new System.Windows.Forms.ComboBox();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AeroportDepar
            // 
            this.txt_AeroportDepar.AutoSize = true;
            this.txt_AeroportDepar.Location = new System.Drawing.Point(33, 37);
            this.txt_AeroportDepar.Name = "txt_AeroportDepar";
            this.txt_AeroportDepar.Size = new System.Drawing.Size(95, 13);
            this.txt_AeroportDepar.TabIndex = 0;
            this.txt_AeroportDepar.Text = "Aeroport de départ";
            // 
            // cmb_AeroportDepart
            // 
            this.cmb_AeroportDepart.FormattingEnabled = true;
            this.cmb_AeroportDepart.Location = new System.Drawing.Point(300, 37);
            this.cmb_AeroportDepart.Name = "cmb_AeroportDepart";
            this.cmb_AeroportDepart.Size = new System.Drawing.Size(162, 21);
            this.cmb_AeroportDepart.TabIndex = 1;
            // 
            // lbl_AeroportArrivee
            // 
            this.lbl_AeroportArrivee.AutoSize = true;
            this.lbl_AeroportArrivee.Location = new System.Drawing.Point(36, 82);
            this.lbl_AeroportArrivee.Name = "lbl_AeroportArrivee";
            this.lbl_AeroportArrivee.Size = new System.Drawing.Size(90, 13);
            this.lbl_AeroportArrivee.TabIndex = 2;
            this.lbl_AeroportArrivee.Text = "Aeroport d\'arrivee";
            // 
            // cmb_AeroportArrivee
            // 
            this.cmb_AeroportArrivee.FormattingEnabled = true;
            this.cmb_AeroportArrivee.Location = new System.Drawing.Point(300, 82);
            this.cmb_AeroportArrivee.Name = "cmb_AeroportArrivee";
            this.cmb_AeroportArrivee.Size = new System.Drawing.Size(162, 21);
            this.cmb_AeroportArrivee.TabIndex = 3;
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.BackColor = System.Drawing.Color.Red;
            this.btn_Rechercher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Rechercher.Location = new System.Drawing.Point(218, 136);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.btn_Rechercher.TabIndex = 4;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = false;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // FenConsultationVols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Rechercher);
            this.Controls.Add(this.cmb_AeroportArrivee);
            this.Controls.Add(this.lbl_AeroportArrivee);
            this.Controls.Add(this.cmb_AeroportDepart);
            this.Controls.Add(this.txt_AeroportDepar);
            this.Name = "FenConsultationVols";
            this.Text = "FenConsultationVols";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_AeroportDepar;
        private System.Windows.Forms.ComboBox cmb_AeroportDepart;
        private System.Windows.Forms.Label lbl_AeroportArrivee;
        private System.Windows.Forms.ComboBox cmb_AeroportArrivee;
        private System.Windows.Forms.Button btn_Rechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}