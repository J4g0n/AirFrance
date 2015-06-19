using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFrance_BibliothequeDeClasse
{
    public class Voyage
    {
        private int numero;
        private List<Escale> escalesVoyage = new List<Escale>();

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public List<Escale> EscalesVoyage 
        {
            get { return escalesVoyage; } 
        }
    
        public static List<Voyage> lstVoyages(string aeroportDepart, string aeroportArrivee)
        {
            string requete = 
                "select v.numero, " +
                    "vo.aeroportDepart, " +
                    "vo.aeroportArrivee, " + 
                    "e.ordre, " +
                    "e.numeroVol, " +
                    "vo.heureDepart, " +
                    "vo.heureArrivee, " +
                    "ad.nom as AeroportDepart, " + 
                    "ad.ville as VilleDepart, " +
                    "ad.Pays as PaysDepart " +
                "from voyage as v " +
                    "join escale as e on v.numero = e.numeroVoyage " + 
                    "join vol as vo on e.numeroVol = vo.numero " +
                    "join aeroport as ad on ad.code = vo.aeroportDepart " +
                "where v.aeroportDepart = '" + aeroportDepart + "' " +
                    "and v.aeroportArrivee = '" + aeroportArrivee + "' " +
                "order by e.ordre";

            ParametresBD_SQLServer par = new ParametresBD_SQLServer("S24POSTE09", "AirFrance");
            SqlDataReader reader = par.ExecuterRequete(requete);
            List<Voyage> voyages = new List<Voyage>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    int numeroVoyage = (int) reader["numero"];

                    Voyage voyage = null;
                    foreach (Voyage v1 in voyages)
                    {
                        if (v1.Numero == numeroVoyage)
                        {
                            voyage = v1;
                            break;
                        }
                    }

                    if (voyage == null)
                    {
                        // créer le voyage
                        voyage = new Voyage();
                        voyage.Numero = (int)reader["numero"];
                        voyages.Add(voyage);
                    } 

                    // ajouter une étape
                    Escale e = new Escale();
                    e.Ordre = (int)reader["ordre"];
                    e.NumeroVol = (string)reader["numeroVol"];
                    voyage.EscalesVoyage.Add(e);
                }
            }

            return voyages;
        }
    }
}
