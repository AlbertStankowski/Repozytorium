using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstakcyjne.Klasy
{
    abstract class Bryla
    {
        protected double h;
        public Bryla(double h)
        {
            this.h = h;
        }
        public abstract double PolePodstawy();
        public abstract double PoleBoczne();
        public double PoleCalkowite()
        {
            return PoleBoczne() + PolePodstawy();
        }
        public double Objetosc()
        {
            return (PolePodstawy()*h)/3;
        }
    }
}
