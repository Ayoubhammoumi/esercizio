using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio
{
    internal class Vettore
    {
        public double X { get; }
        public double Y { get; }

        public Vettore(double x, double y)
        {
            X = x; Y = y;
        }

        public static double operator *(Vettore v1, Vettore v2)
        {
            double prodotto = v1.X * v2.X + v1.Y * v2.Y;
            return prodotto;
        }

        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);

        }

        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);

        }

        public static Vettore operator *(Vettore v, double s)
        {
            return new Vettore(v.X * s, v.Y * s);
        }
        public static Vettore operator *(double s, Vettore v)
        {
            return new Vettore(s * v.X, s * v.Y);
        }

        public static Vettore operator /(Vettore v, double s)
        {
            return new Vettore(v.X / s, v.Y / s);
        }

        public static double Modulo(Vettore v)
        {

            double modulo = Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2));
            return modulo;
        }


        public static bool eguaglianza(Vettore v1, Vettore v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool diseguaglianza(Vettore v1, Vettore v2)
        {
            if (v1.X != v2.X && v1.Y != v2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vettore opposto (Vettore v1)
        {

            return new Vettore(v1.X * (-1), v1.Y);
        }

        public override string ToString()
        {
            return string.Format("{0} , {1}", X, Y);
        }
       








    }

}
