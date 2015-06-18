using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirFrance_BibliothequeDeClasse
{
    public class Escale
    {
        private int ordre;
        private string numeroVol;

        public string NumeroVol
        {
            get { return numeroVol; }
            set { numeroVol = value; }
        }

        public int Ordre
        {
            get { return ordre; }
            set { ordre = value; }
        }

        public Vol correspond
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Escale> lstEscales(int numeroVoyage)
        {
            throw new System.NotImplementedException();
        }
    }
}
