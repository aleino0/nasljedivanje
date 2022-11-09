using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje
{
    class Program
    {
        class Cat
        {
            bool opasna;
            public bool Opasna { get => opasna; set => opasna = value; }

            public virtual void Opasnost()
            {
                this.opasna = false;
            }
            public override string ToString()
            {
                return "Maca - opasnost = " + this.opasna;
            }
        }
        class Geopard : Cat
        {
            public override void Opasnost()
            {
                this.Opasna = true;
            }
            public override string ToString()
            {
                return "Geopard - opasnost: " + this.Opasna;
            }
        }
        static void Main(string[] args)
        {
            Geopard g = new Geopard();
            g.Opasnost();
            Console.WriteLine(g.ToString());

            Cat maca = new Cat();
            maca.Opasnost();
            Console.WriteLine(maca.ToString());

            Console.ReadKey();
        }
    }
}
