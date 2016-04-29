using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Tp4Class
{
    class Semaine
    {
        // ATTRIBUTS
        private int numSemaine;
        private Saison laSaison;

        // CONSTRUCTEUR
        public Semaine(int unNom, Saison uneSaison)
        {
            unNom = numSemaine;
            uneSaison = laSaison;
        }

        // ACCESSEUR
        public void SetNom(int unNom)
        {
            unNom = numSemaine;
        }
        
        // METHODES
        public int GetNumSemaine()
        {
            return numSemaine;
        }
        public Saison GetLaSaison()
        {
            return laSaison;
        }
    }
}
