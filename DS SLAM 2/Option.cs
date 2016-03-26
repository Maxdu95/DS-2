using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_SLAM_2
{
    class Option
    {
        private string libelle;
        private double prix;

        public Option(string libelle, double prix)
        {
            this.libelle = libelle;
            this.prix = prix;
        }

        public double GetPrix() { return prix; }
        public string GetLibelle() { return libelle; }
        public new string ToString() { return String.Format("{0} {1}", this.libelle, this.prix); }
    }
}
