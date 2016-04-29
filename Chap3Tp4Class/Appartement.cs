using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Tp4Class
{
    class Appartement
    {
        // ATTRIBUTS
        private int numero;
        private float prix;

        private Proprietaire leProprietaire;
        private List<Semaine> lesSemainesLouees;
        private List<Semaine> lesSemainesProprio;

        // CONSTRUCTEUR
        public Appartement(int unNumero, float unPrix, Proprietaire unProprietaire)
        {
            unNumero = numero;
            unPrix = prix;
            unProprietaire = leProprietaire;
        }

        // METHODES
        public string GetProprio()
        {
            return leProprietaire.GetNom();
        }
        public List<Semaine> GetLesSemainesProprio()
        {
            return lesSemainesProprio;
        }
        public bool SemaineLibre(int unNum)
        {
            // Une méthode bien chiante.
            int ind = 0;
            bool trouve = false;

            while (trouve == false && ind < lesSemainesLouees.Count())
            {
                if (lesSemainesLouees[ind].GetNumSemaine() == unNum)
                {
                    trouve = true;
                }
                else
                {
                    ind++;
                }
            }

            if (trouve == true)
            {
                return false;
            }

            ind = 0;
            while (trouve == false && ind < lesSemainesProprio.Count())
            {
                if (lesSemainesProprio[ind].GetNumSemaine() == unNum)
                {
                    trouve = true;
                }
                else
                {
                    ind++;
                }
            }

            if (trouve == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool AjouteSemaineLouee(Semaine sem)
        {
            if (SemaineLibre(sem.GetNumSemaine()) == true )
            {
                lesSemainesLouees.Add(sem);
                return true;
            }
            return false;
           
        }
        public float MontantTotalPercu(string nomSaison)
        {
            float txMajo = 0;
            string nomS;
            float TotalPercu = 0;

            foreach (Semaine uneSemaine in lesSemainesLouees)
            {
                nomS = uneSemaine.GetLaSaison().GetNomSaison();
                txMajo = uneSemaine.GetLaSaison().GetMajoration();

                if (nomS == nomSaison)
                {
                    TotalPercu = TotalPercu + (prix + prix * txMajo);
                }
            }
            return TotalPercu;
        }
        public int nbSemainesProprioSaison(Saison uneSaison)
        {
            int compter = 0;
            foreach (Semaine uneSemaine in lesSemainesProprio)
            {
                if (uneSemaine.GetLaSaison() == uneSaison)
                {
                    compter = compter + 1;
                }
            }
            return compter;
        }
    }
}
