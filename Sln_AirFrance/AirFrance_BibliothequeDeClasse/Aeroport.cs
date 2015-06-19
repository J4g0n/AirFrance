using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public static List<Aeroport> lstAeroport()
        {
            string requete = "select * from aeroport";

            ParametresBD_SQLServer par = new ParametresBD_SQLServer("S24POSTE09", "AirFrance");
            SqlDataReader reader = par.ExecuterRequete(requete);
            List<Aeroport> aeroports = new List<Aeroport>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    Aeroport a = new Aeroport();
                    a.Code = (string) reader["code"];
                    a.Nom = (string) reader["nom"];
                    a.Ville = (string) reader["ville"];
                    a.Pays = (string) reader["pays"];

                    aeroports.Add(a);
                }
            }

            return aeroports;
        }
    }
}
