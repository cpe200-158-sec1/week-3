using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab301
{
    public class Fraction
    {
        private double Numer;
        private double Denom;
        private static double Count;

        public double numer
        {
            get { return Numer; }
            set { Numer = value; }
        }
        public double denom
        {
            get { return Denom; }
            set { Denom = (value != 0) ? value : 1; }
        }

        public static double count
        {
            get { return Count; }
            set { Count = value; }
        }

        public Fraction()
        {
            numer = 0;
            denom = 1;
            count++;
        }

        public Fraction(double num)
        {
            numer = num;
            denom = 1;
            count++;
        }
        public Fraction(double num, double dem)
        {
            numer = num;
            denom = dem;
            count++;
        }
        public Fraction(Fraction a)
        {
            numer = a.numer;
            denom = a.denom;
        }

        public void setValue(double num, double dem)
        {
            this.numer = num;
            this.denom = dem;

        }

        public static double GCD(double a, double b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }

        public override string ToString()
        {
            double result = numer / denom;
            string s = "[Rational: " + Numer + "/" + Denom + "], value=" + result + "]";
            return s;
        }
        public bool Equals(Fraction a)
        {
            return (this.numer / this.denom == a.numer / a.denom);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.numer * b.denom + a.denom * b.numer, a.denom * b.denom);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.numer * b.denom - a.denom * b.numer, a.denom * b.denom);
        }
        public static Fraction operator ++(Fraction a)
        {
            return new Fraction(a.denom + a.numer, a.denom);
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a.denom * b + a.numer, a.denom);
        }
        public static Fraction operator +(int a, Fraction b)
        {
            return new Fraction(a * b.denom + b.numer, b.denom);
        }

        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(a.numer - b * a.denom, a.denom);
        }
        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a * b.denom - b.numer, b.denom);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a.numer / a.denom == b.numer / b.denom) ? true : false;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.numer / a.denom != b.numer / b.denom) ? true : false;
        }
    }
}
