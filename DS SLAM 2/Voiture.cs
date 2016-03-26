using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_SLAM_2
{
    class Voiture : Vehicule
    {
        private string immatriculation;
        private Modele possede;

        public Voiture(Modele unModele, string immatriculation)
            : base(immatriculation)
        {
            this.possede = unModele;
        }

        public double CalculerPrix()
        {
            double prixVoiture;
            prixVoiture = this.possede.GetPrix;
            for (int i = 0; i < this.possede.Count; i++)
            {
                prixVoiture = prixVoiture + this.possede[i].GetPrix(); 
            }
            for (int i = 0; i < this.Count; i++)
            {
                prixVoiture = prixVoiture + this[i].GetPrix();
            }
            return prixVoiture;
        }

        public new string ToString()
        {
            string s = this.possede.ToString();
            string t = base.ToString();
            string m = " \nPrix total " + this.CalculerPrix().ToString();
            return s + t + m;
        }
    }
}
