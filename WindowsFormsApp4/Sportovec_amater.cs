using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class Sportovec_amater
    {
        private string jmeno;
        int pocethodin;
        double obvodpasu;
        double vyska;
        public Sportovec_amater(string jmeno, double obvodpasu, double vyska, int pocethodin)
        {
            this.jmeno = jmeno;            
            this.obvodpasu = obvodpasu;
            this.vyska = vyska;
            this.pocethodin = 0;
        }
        public double WHtR(double Obvodpasu, double Vyska)
        {
            return obvodpasu / vyska;
        }
        public virtual int Trenuj()
        {
            pocethodin++;
            return pocethodin;
        }
        public bool JeObezni()
        {
            if(WHtR(Obvodpasu, Vyska) > 0.5778)
            {
                return true;   
            }
            else
            {
                return false;
            }
        }
        double Obvodpasu
        {
            get 
            {
                return obvodpasu;
            } 
            set
            {
                obvodpasu = value;
            }
        }
        double Vyska
        {
            get
            {
                if (vyska < 0)
                {

                }
                else
                {
                    if (vyska <= 3)
                    {
                        vyska = vyska * 100;
                    }
                    else if(vyska < 50 || vyska > 300)
                    {
                        vyska = 0;
                        MessageBox.Show("Chyba");
                    }
                }
                return vyska;
            }
            set
            {
                vyska = value;
            }
        }
        public override string ToString()
        {
            return "Jméno: " + jmeno + "\nObvod pasu: " + Obvodpasu + " cm" + "\nVýška: " + Vyska + " cm" + "\nPočet odtrénovaných hodin: " + pocethodin + "\nObvod pasu / výška: " + WHtR(Obvodpasu, Vyska) + "\nJe obézní: " + JeObezni();
        }
    }
}
