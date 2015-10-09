using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Niveau1.CalculatriceBasique
{
    public class Calcul
    {
        private int premierChiffre;
        private int secondChiffre;

        public Calcul(int premierChiffre, int secondChiffre)
        {
            this.premierChiffre = premierChiffre;
            this.secondChiffre = secondChiffre;
        }

        public int addition()
        {
            return premierChiffre + secondChiffre;
        }

    }
}
