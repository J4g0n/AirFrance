using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFrance_BibliothequeDeClasse
{
    public class Voyage
    {
        private int numero;
        private List<Escale> escalesVoyage;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private List<Escale> EscalesVoyage 
        {
            get { return escalesVoyage; } 
        }
    
        public static List<Voyage> lstVoyages(string aeroportDepart, string aeroportArrivee)
        {
            throw new System.NotImplementedException();
        }
    }
}
