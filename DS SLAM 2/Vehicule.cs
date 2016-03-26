using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_SLAM_2
{
    class Vehicule
    {
        private string immatriculation;
        private List<Option> optionsBase;

        public Vehicule(string immatriculation)
        {
            this.immatriculation = immatriculation;
            optionsBase = new List<Option>();
        }

        public void AddOption(Option option)
        {
            optionsBase.Add(option);
        }

        public bool possedeOption(string libelle){
            //to do
            return true;
        }

        public Option this[int index]
        {
            get { return this.optionsBase[index]; }
        }

        public int Count { get { return this.optionsBase.Count; } }

        public new string ToString()
        {
            string immatriculation = this.immatriculation;
            string option = "";
            for (int i = 0; i < this.Count; i++)
            {
                option = option + "\n" + this[i].GetLibelle() + " " + this[i].GetPrix().ToString();
            }
            return String.Format(" \nVehicule : {0} {1} ", immatriculation, option);
        }
    }
}
