using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirFrance_Desktop
{
    public partial class FenPrincipale : Form
    {
        public FenPrincipale()
        {
            InitializeComponent();
        }

        private void FenPrincipale_Load(object sender, EventArgs e)
        {
            this.Text = ParametresIHM.TitreAppli;
            this.BackColor = ParametresIHM.CouleurFond;

            this.Width = 600;
            this.Height = 600;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acheterBilletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FenConsultationVols fenConsultation = new FenConsultationVols();
            fenConsultation.Show();
        }
    }
}
