using AirFrance_BibliothequeDeClasse;
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
    public partial class FenConsultationVols : Form
    {
        public FenConsultationVols()
        {
            InitializeComponent();

            List<Aeroport> aeroports = Aeroport.lstAeroport();
            
            foreach (Aeroport a in aeroports) 
            {
                cmb_AeroportDepart.Items.Add(a.Code);
                cmb_AeroportArrivee.Items.Add(a.Code);
            }
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            string aeroportDepart = cmb_AeroportDepart.SelectedItem.ToString();
            string aeroportArrivee = cmb_AeroportArrivee.SelectedItem.ToString();

            List<Voyage> listVoyages = Voyage.lstVoyages(aeroportDepart, aeroportArrivee);

            grid_Voyages.Rows.Clear();
            foreach (Voyage v in listVoyages)
            {
                foreach (Escale escale in v.EscalesVoyage)
                {
                    string[] lignes = {
                        v.Numero.ToString(),
                        escale.Ordre.ToString(),
                        escale.NumeroVol
                    };
                    grid_Voyages.Rows.Add(lignes);
                }
            }
        }
    }
}
