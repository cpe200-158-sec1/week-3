using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private int _Numer;
        private int _Denom;
        private static int _Count = 0;

        public Fraction()
        {
            _Numer = 0;
            _Denom = 1;
            _Count++;
        }
        public Fraction(Fraction a)
        {
            _Numer = a._Numer;
            if (a.Denom == 0)
                _Denom = 1;
            else
                _Denom = a.Denom;
            _Count++;
        }
        public Fraction(int numerator)
        {
            _Numer = numerator;
            _Denom = 1;
            _Count++;
        }
        public Fraction(int numerator, int denominator)
        {
            _Numer = numerator;
            if (denominator == 0)
                _Denom = 1;
            else
                _Denom = denominator;
            _Count++;
        }
        public int Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }
        public int Denom
        {
            get { return _Denom; }
            set { _Denom = value; }
        }
        public static int Count
        {
            get { return _Count; }
        }
        public Fraction setValue(int nu, int de)
        {
            _Numer = nu;
            if(de==0)
                _Denom = 1;
            else _Denom = de;
            return this;
        }
        public static float GCD(int nu, int de)
        {
            if (nu == 0) return de;
            else if (de == 0) return nu;
            else if (nu > de)
                return GCD(de, nu % de);
            else
                return GCD(nu, de % nu);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int mul;
            if (a.Denom > b.Denom)
            {
                mul = a.Denom / b.Denom;
                return new Fraction(b.Numer * mul + a.Numer, a.Denom);
            }
            else if (b.Denom > a.Denom)
            {
                mul = b.Denom / a.Denom;
                return new Fraction(a.Numer * mul + b.Numer, b.Denom);
            }
            else
                return new Fraction(a.Numer + b.Numer, a.Denom);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int mul;
            if (a.Denom > b.Denom)
            {
                mul = a.Denom / b.Denom;
                return new Fraction(b.Numer * mul - a.Numer, a.Denom);
            }
            else if (b.Denom > a.Denom)
            {
                mul = b.Denom / a.Denom;
                return new Fraction(a.Numer * mul - b.Numer, b.Denom);
            }
            else
                return new Fraction(a.Numer - b.Numer, a.Denom);
        }
        public static Fraction operator +(Fraction a, int b)
        {
            int mul;
            mul = a.Denom;
            return new Fraction(b * mul + a.Numer, a.Denom);
        }
        public static Fraction operator -(int a, Fraction b)
        {
            int mul;
            mul = b.Denom;
            return new Fraction(a*mul - b.Numer, b.Denom);
        }
        public static Fraction operator ++(Fraction a)
        {
            a.Numer =a.Numer + a.Denom;
            return a;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            double c, d;
            c = a.Numer / a.Denom;
                d = b.Numer / b.Denom;
            return ( c == d);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            double c, d;
            c = a.Numer / a.Denom;
            d = b.Numer / b.Denom;
            return (c != d);
        }
        public bool Equals(Fraction a)
        {
            return (a.Numer == Numer && a.Denom == Denom);
        }
        public override string ToString()
        {
            string print = "[Rational: " + Numer/Fraction.GCD(Numer, Denom) + "/" + Denom/Fraction.GCD(Numer, Denom) + "], value=" + Numer*1.00/Denom +"]";
            return print;
        }
    }
}
