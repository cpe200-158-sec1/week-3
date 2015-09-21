using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private int _numer;
        private int _denom;
        private static int _count;

        public Fraction(Fraction numerator)
        {
            _numer = numerator._numer;
            _denom = numerator._denom;
            _count++;
        }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            _numer = numerator / GCD(numerator, denominator);
            _denom = denominator / GCD(numerator, denominator);
            _count++;
        }

        public Fraction setValue(int num, int den)
        {
            _numer = num;
            if (den == 0)
                _denom = 1;
            else _denom = den;
            return this;
        }

        public static float GCD(int num, int den)
        {
            if (num == 0)
                return den;
            else if (den == 0)
                return num;
            else if (num == den)
                return num;
            else if (num > den)
                return GCD(den, num % den);
            else
                return GCD(num, den % num);
        }

        public int Numer
        {
            get { return _numer; }
            set { _numer = value; }
        }

        public int Denom
        {
            get { return _denom; }
            set
            {
                if (value == 0)
                    _denom = 1;
                else
                    _denom = value;
            }
        }

        public static int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Fraction()
        {
            _numer = 0;
            _denom = 1;
            _count++;
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction((a._numer * 1) + (b * a._denom), a._denom * 1);
        }

        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction((a * b._denom) - (b._numer * 1), 1 * b._denom);
        }

        public static Fraction operator ++(Fraction a)
        {
            a._numer += a._denom;
            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction((a._numer * b._denom) + (b._numer * a._denom), a._denom * b._denom);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction((a._numer * b._denom) - (b._numer * a._denom), a._denom * b._denom);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a._numer / a._denom == b._numer / b._denom);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a._numer / a._denom != b._numer / b._denom);
        }

        public bool Equals(Fraction a)
        {
            return (this.Numer / this.Denom == a.Numer / a.Denom);
        }

        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", Numer, Denom, (double)Numer / Denom);
        }

    }
}
