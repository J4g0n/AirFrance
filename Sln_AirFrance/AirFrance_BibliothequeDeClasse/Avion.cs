using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFrance_BibliothequeDeClasse
{
    public class Avion
    {
        private int numeroSerie;
        private int nbPassagers;
        private string modele;


        public int NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }

        public int NbPassagers
        {
            get { return nbPassagers; }
            set { nbPassagers = value; }
        }

        public void Creer()
        {
            throw new System.NotImplementedException();
        }

        public void Modifier()
        {
            throw new System.NotImplementedException();
        }

        public void Supprimer()
        {
            throw new System.NotImplementedException();
        }

        public void Consulter()
        {
            throw new System.NotImplementedException();
        }

        public List<Avion> lstAvion()
        {
            return null;
        }
    }
}
