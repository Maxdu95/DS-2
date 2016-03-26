using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_SLAM_2
{
    class Modele
    {
        private string nom;
        private double prix;
        private List<Option> optionsModele;

        public Modele(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionsModele = new List<Option>();
        }

        public double GetPrix
        {
            get { return prix; }
        }

        public void AddOption(Option option)
        {
            optionsModele.Add(option);
        }

        public Option this[int index]
        {
            get { return this.optionsModele[index]; }
        }

        public bool PossedeOption(string libelle)
        {
            // to do
            return true;
        }

        public int Count {
            get { return this.optionsModele.Count; }
            }

        public new string ToString()
        {
            string nom = this.nom;
            double prix = this.prix;
            string option = "";
            for (int i = 0; i < this.Count; i++)
            {
                option = option + "\n" + this[i].GetLibelle() + " " + this[i].GetPrix().ToString();
            }
            return String.Format("Modele : {0}  GetPrix : {1} {2}", nom, prix, option);
        }

    }
}
