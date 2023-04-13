using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstakcyjne.Klasy
{
    class Czworoscian : Bryla
    {
        private double a;
        public Czworoscian(double a, double h) : base(h)
        {
            this.a = a;
        }
        public override double PolePodstawy()
        {
            return (Math.Sqrt(3) * a * a) / 2;
        }
        public override double PoleBoczne()
        {
            return 3 * PolePodstawy();
        }
    }
}
