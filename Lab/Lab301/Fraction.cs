using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    public class Fraction
    {
        private int _numer;
        private int _denom;
        private static int _count;

        public int numer
        {
            get { return  _numer; }
            set { _numer = value; }
        }

        public int denom
        {
            get { return _denom; }
            set { _denom = (value != 0) ? value : 1; }
        }

        public static int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        //Constructor
        public Fraction ()
        {
            numer = 0;
            denom = 1;
            Count++;
        }

        public Fraction (int a)
        {
            numer = a;
            denom = 1;
            Count++;
        }

        public Fraction(int a,int b)
        {
            numer = a;
            denom = b;
            Count++;
        }

        public Fraction(Fraction a)
        {
            numer = a.numer;
            denom = a.denom;
        }

    //Methods
    public Fraction setValue(int a,int b)
        {
            this.numer = a;
            this.denom = b;
            return this;
        }

        public static int GCD(int a,int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }

        public bool Equals(Fraction a)
       {
            return (this.numer / this.denom == a.numer / a.denom);
       }

    //Operator overloading
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.numer * b.denom + a.denom * b.numer, a.denom * b.denom);
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a.denom * b + a.numer, a.denom);
        }

        public static Fraction operator +(int a, Fraction b)
        {
            return new Fraction(a * b.denom + b.numer, b.denom);
        }

        public static Fraction operator ++(Fraction a)
        {
            return new Fraction(a.denom + a.numer, a.denom);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.numer * b.denom - a.denom * b.numer, a.denom * b.denom);
        }

        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(a.numer - b * a.denom, a.denom);
        }

        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a * b.denom - b.numer, b.denom);
        }

        public static bool operator == (Fraction a, Fraction b)
        {
            return (a.numer / a.denom == b.numer / b.denom) ? true : false;
        }

        public static bool operator != (Fraction a, Fraction b)
        {
            return (a.numer / a.denom != b.numer / b.denom) ? true : false;
        }

        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", this.numer / GCD(this.numer, this.denom), this.denom / GCD(this.numer, this.denom), (double)this.numer / (double)this.denom);
        }
    }
}
