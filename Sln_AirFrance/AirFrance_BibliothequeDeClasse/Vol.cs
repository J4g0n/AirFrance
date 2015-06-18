using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFrance_BibliothequeDeClasse
{
    public class Vol
    {
        private string numero;
        private string aeroportDepart;
        private string aeroportArrivee;
        private DateTime heureDepart;
        private DateTime heureArrivee;


        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string AeroportDepart
        {
            get { return aeroportDepart; }
            set { aeroportDepart = value; }
        }

        public string AeroportArrivee
        {
            get { return aeroportArrivee; }
            set { aeroportArrivee = value; }
        }

        public DateTime HeureDepart
        {
            get { return heureDepart; }
            set { heureDepart = value; }
        }

        public DateTime HeureArrivee
        {
            get { return heureArrivee; }
            set { heureArrivee = value; }
        }

        public Vol Consulter()
        {
            throw new System.NotImplementedException();
        }
    }
}
