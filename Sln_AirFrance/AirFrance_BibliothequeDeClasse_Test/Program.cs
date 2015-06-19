using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirFrance_BibliothequeDeClasse;

namespace AirFrance_BibliothequeDeClasse_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Avion a = new Avion();
            a.Consulter();*/

            List<Voyage> voy = Voyage.lstVoyages("CDG", "TKY");

            foreach (Voyage v in voy)
            {
                Console.WriteLine("Voyage n°" + v.Numero);

                foreach (Escale e in v.EscalesVoyage)
                {
                    Console.WriteLine("\tEtape n°" + e.Ordre + " vol n°" + e.NumeroVol);
                }
            }
            Console.ReadKey();
        }
    }
}
