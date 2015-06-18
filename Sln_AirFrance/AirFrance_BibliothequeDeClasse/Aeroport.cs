using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirFrance_BibliothequeDeClasse
{
    public class Aeroport
    {
        private string nom;
        private string ville;
        private string pays;
        private string code;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}
