using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class Sportovec_profesional : Sportovec_amater
    {
        private DateTime datumvzniku;
        double bazal;
        int stupenvykonnosti;
        int pocethodin;
        public Sportovec_profesional(string jmeno, double obvodpasu, double vyska, DateTime datumvzniku, double bazal, int stupenvykonnosti, int pocethodin) : base(jmeno, obvodpasu, vyska, pocethodin)
        {
            this.datumvzniku = datumvzniku;
            this.bazal = bazal;
            this.stupenvykonnosti = stupenvykonnosti;
            this.pocethodin = pocethodin;
        }
        public bool MaNarokNaSlevu()
        {
            if(((DateTime.Now - datumvzniku).TotalDays / 365) >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int Trenuj()
        {
            pocethodin++;
            if(pocethodin > 100)
            {
                bazal *= 1.1;
            }
            return pocethodin;
        }
        int Stupenvykonnosti
        {
            get
            {
                if (stupenvykonnosti < 1 || stupenvykonnosti > 7)
                {
                    MessageBox.Show("Neproběhla klasifikace stupně výkonnosti", "Chyba");
                    stupenvykonnosti = 0;
                }
                return stupenvykonnosti;
            }
            set 
            {
                stupenvykonnosti = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\nDatum vzniku členství: " + datumvzniku + "\nBazální metabolismus: " + bazal + " kcal/h" + "\nNárok na slevu: " + MaNarokNaSlevu() + "\nStupěň výkonnosti: " + Stupenvykonnosti;
        }
    }
}
