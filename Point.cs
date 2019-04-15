using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point
{
    public class Point
    {
        private float x;
        private float y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(float _x,float _y)
        {
            x = _x;
            y = _y;
        }

        public void Deplacer(float _x, float _y)
        {
            x += _x;
            y += _y;
        }

        public void Permuter()
        {
            float temp = x;
            x = y;
            y = temp;
        }

        public Point SymetrieAxeAbscisse()
        {
            Point p = new Point(x,-y);
            return p;
        }

        public Point SymetrieAxeOrdonnee()
        {
            Point p = new Point(-x,y);
            return p;
        }

        public Point SymetrieOrigine()
        {
            Point p = new Point(-x, -y);
            return p;
        }

        public void GetString()
        {
            Console.WriteLine("mon abscisse est de : {0} mon ordonnee est de : {1}", x, y);
        }
    }
}