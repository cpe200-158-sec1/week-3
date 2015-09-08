using System;

namespace Lab301
{
    public class Fraction
    {
        private int Numer;
        private int Denom;
        private static int Count;

        public int numer
        {
            get { return Numer; }
            set { Numer = value; }
        }

        public int denom
        {
            get { return Denom; }
            set { Denom = (value != 0) ? value : 1; }
        }

        public static int count
        {
            get { return Count; }
            set { Count = value; }
        }

        public Fraction()
        {
            numer = 0;
            denom = 1;
            Count++;
        }

        public Fraction(int n)
        {
            numer = n;
            denom = 1;
            Count++;
        }

        public Fraction(int n, int d)
        {
            numer = n;
            denom = d;
            Count++;
        }

        public Fraction(Fraction a)
        {
            numer = a.numer;
            denom = a.denom;
        }

        public Fraction setValue(int a, int b)
        {
            this.numer = a;
            this.denom = b;
            return this;
        }


        public bool Equals(Fraction a)
        {
            return (this.numer / this.denom == a.numer / a.denom);
        }

        public static int GCD(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
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

        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", this.numer / GCD(this.numer, this.denom), this.denom / GCD(this.numer, this.denom), (double)this.numer / (double)this.denom);
        }
    }
}