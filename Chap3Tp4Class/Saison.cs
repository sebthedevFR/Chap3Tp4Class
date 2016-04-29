using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Tp4Class
{
    class Saison
    {
        // ATTRIBUTS
        private string nom;
        private float majoration;

        // CONSTRUCTEUR
        public Saison (string unNom, float uneMajoration)
        {
            unNom = nom;
            uneMajoration = majoration;
        }

        // ACCESEUR
        public void SetNom(string unNom)
        {
            unNom = nom;
        }
        public void SetMajoration(float uneMajoration)
        {
            uneMajoration = majoration;
        }
        public string GetNom()
        {
            return nom;
        }
        public float GetMajoration()
        {
            return majoration;
        }

        // METHODES
        public string GetNomSaison()
        {
            return nom;
        }
    }
}
