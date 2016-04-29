using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Tp4Class
{
    public class Proprietaire
    {
        // ATTRIBUTS
        private int numero;
        private string nom;

        // CONSTRUCTEUR
        public Proprietaire (int unNumero, string unNom)
        {
            unNumero = numero;
            unNom = nom;
        }

        // ACCESEUR
        public void SetNumero(int unNumero)
        {
            unNumero = numero;
        }
        public void SetNom(string unNom)
        {
            unNom = nom;
        }
        public int GetNumero()
        {
            return numero;
        }
        public string GetNom()
        {
            return nom;
        }

        // METHODE
    }
}
