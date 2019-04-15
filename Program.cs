using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p = new Point(140,90);
            p.GetString();
            p1.GetString();
            p1.Deplacer(10.25f, -50.99f);
            p1.GetString();
            p.Deplacer(-120, 20);
            p.GetString();
            Point pSymetriqueOrdonee = new Point();
            pSymetriqueOrdonee = p.SymetrieAxeOrdonnee();
            pSymetriqueOrdonee.GetString();
            Point pSymetriqueAbscisse = new Point();
            pSymetriqueAbscisse = p.SymetrieAxeAbscisse();
            pSymetriqueAbscisse.GetString();
            Point pSymetriqueOrigine = new Point();
            pSymetriqueOrigine = p.SymetrieOrigine();
            pSymetriqueOrigine.GetString();
            p.Permuter();
            p.GetString();
        }
    }
}
