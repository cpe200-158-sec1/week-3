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
        public static int Count;
        public int Numer
        {
            get
            {
                return _Numer;
            }
            set
            {
                _Numer = value;
            }
        }
        public int Denom
        {
            get
            {
                return _Denom;
            }
            set
            {
                _Denom = (value != 0) ? value : 1; 
            }
        }
        public int count
        {
            get
            {
                return Count;
            }
            set
            {
                Count = value;
            }
        }

        public Fraction ()
        {
            Numer = 0;
            Denom = 1;
            count++;
        }

        public Fraction (int n)
        {
            Numer = n;
            Denom = 1;
            count++;
        }

        public Fraction (int n , int d )
        {
            Numer = n;
            Denom = d;
            count++;
        }

        public Fraction (Fraction a )
        {
            Numer = a._Numer;
            Denom = a._Denom;
           
        }

        public Fraction setValue (int a, int b)
        {
            this.Numer = a;
            this.Denom = b;
            return this;
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

        public bool Equals (Fraction a)
        {
            return (this.Numer / this.Denom == a.Numer / a.Denom);
        }

        public static Fraction operator + (Fraction a , Fraction b)
        {
            return new Fraction(a.Numer * b.Denom + b.Numer * a.Denom, a.Denom * b.Denom);
        }
        public static Fraction operator - (Fraction a , Fraction b)
        {
            return new Fraction(a.Numer * b.Denom - b.Numer * a.Denom, a.Denom * b.Denom);
        }
        public static Fraction operator ++ (Fraction a)
        {
            return new Fraction(a.Numer + a.Denom, a.Denom);
        }
        public static Fraction operator + (Fraction a , int b)
        {
            return new Fraction(a.Numer + a.Denom * b, a.Denom);
        }
        public static Fraction operator + (int a , Fraction b)
        {
            return new Fraction(a * b.Denom + b.Numer, b.Denom);
        }
        public static Fraction operator - (Fraction a , int b)
        {
            return new Fraction(a.Numer - a.Denom * b, a.Denom);
        }
        public static Fraction operator - (int a , Fraction b)
        {
            return new Fraction(a * b.Denom - b.Numer, b.Denom);
        }
        public static bool operator == (Fraction a , Fraction b)
        {
            return (a.Numer / a.Denom == b.Numer / b.Denom) ? true : false; ;
        }
        public static bool operator != (Fraction a , Fraction b)
        {
            return (a.Numer / a.Denom != b.Numer / b.Denom) ? true : false;
        }

        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", this.Numer / GCD(this.Numer, this.Denom), this.Denom / GCD(this.Numer, this.Denom), (double)this.Numer / (double)this.Denom);
        }
    }
}
