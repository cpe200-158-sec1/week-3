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
        private int _Demon;
        private static int _Count;


        public int Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }
        public int Demon
        {
            get { return _Demon; }
            set { _Demon = (value != 0) ? value : 1; }
        }
        public static int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public Fraction()
        {
            Numer = 0;
            Demon = 1;
            Count++;
        }
        public Fraction(int n)
        {
            Numer = n;
            Demon = 1;
            Count++;
        }
        public Fraction(int n , int d)
        {
            Numer = n;
            Demon = d;
            Count++;
        }
        public Fraction(Fraction a)
        {
            Numer = a.Numer;
            Demon = a.Demon;
            Count++;
        }

        public static Fraction operator +(Fraction a , Fraction b)
        {
            return new Fraction(a.Numer * b.Demon + b.Numer * a.Demon, a.Demon * b.Demon);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.Numer * b.Demon - b.Numer * a.Demon, a.Demon * b.Demon);
        }
        public static Fraction operator ++(Fraction a)
        {
            return new Fraction(a.Numer + a.Demon,a.Demon );
        }
        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(a.Numer - b * a.Demon, a.Demon);
        }
        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a.Numer + b * a.Demon, a.Demon);
        }
        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a * b.Demon - b.Numer, b.Demon);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a.Numer / a.Demon == b.Numer / b.Demon) ? true : false;
        }
        public static bool operator != (Fraction a,Fraction b)
        {
            return (a.Numer / a.Demon != b.Numer / b.Demon) ? true : false;
        }
        public bool Equals(Fraction a)
        {
            return (this.Numer / this.Demon == a.Numer/ a.Demon);
        }
        public Fraction setValue(int a, int b)
        {
            this.Numer = a;
            this.Demon = b;
            return this;

        }
        public static int GCD(int a, int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }
        public override string ToString()
        {
             return string.Format("[Rational: {0}/{1}], value={2}]", this.Numer / GCD(this.Numer, this.Demon), this.Demon / GCD(this.Numer, this.Demon), (double)this.Numer / (double)this.Demon);
        }





    }
}
