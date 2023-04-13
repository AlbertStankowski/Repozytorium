using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstakcyjne.Klasy
{
    class Stozek : Bryla
    {
            private double r;
            public Stozek(double r, double h) : base(h)
            {
                this.r = r;
            }
        public override double PolePodstawy()
        {
            return Math.PI * r * r;
        }
        public override double PoleBoczne()
        {
            return Math.PI * r * Math.Sqrt(h * h + r * r);
        }
    }
}
