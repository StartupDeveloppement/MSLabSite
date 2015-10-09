using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Niveau1.CalculatriceBasique
{
    public class Affichage
    {
        public static void Afficher(string texte)
        {
            Console.WriteLine(texte);
        }

        public static void AfficherSansRetourLigne(string texte)
        {
            Console.Write(texte);
        }
    }
}
