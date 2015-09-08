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
        private static int _Count;

        public int Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }
        public int Denom
        {
            get { return _Denom; }
            set { _Denom = (value != 0) ? value : 1; }
        }
        public static int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public Fraction()
        {
            Numer = 0;
            Denom = 1;
            Count++;

        }
        public Fraction(int n)
        {
            Numer = n;
            Denom = 1;
            Count++;
        }
        public Fraction(int n, int d)
        {
            Numer = n;
            Denom = d;
            Count++;
        }
        public Fraction(Fraction f)
        {
            Numer = f.Numer;
            Denom = f.Denom;
            Count++;
        }

        public Fraction setValue(int n, int d)
        {
            this.Numer = n;
            this.Denom = d;
            return this;
        }
        public bool Equals(Fraction e)
        {
            return (this.Numer / this.Denom == e.Numer / e.Denom);
        }
        public static int GCD(int n, int d)
        {
            if (n == 0) return d;
            return GCD(d % n, n);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Numer * b.Denom + a.Denom * b.Numer, a.Denom * b.Denom);

        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.Numer * b.Denom - a.Denom * b.Numer, a.Denom * b.Denom);
        }
        public static Fraction operator ++(Fraction a)
        {
            return new Fraction(a.Numer + a.Denom, a.Denom);
        }
        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a.Denom * b + a.Numer, a.Denom);
        }
        public static Fraction operator +(int a , Fraction b)
        {
            return new Fraction(b.Denom * a + b.Numer, b.Denom);
        }
        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(a.Denom * b - a.Numer, a.Denom);
        }
        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(b.Denom * a - b.Numer, b.Denom);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a.Numer / a.Denom == b.Numer / b.Denom) ? true : false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.Numer / a.Denom != b.Numer / b.Denom) ? true : false;
        }
        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", this.Numer / GCD(this.Numer, this.Denom), this.Denom / GCD(this.Numer, this.Denom), (double)this.Numer / (double)this.Denom);
        }
    }
}

