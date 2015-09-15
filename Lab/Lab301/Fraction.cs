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
        private static int _count = 0;

        public Fraction()
        {
            Numer = 0;
            Denom = 1;
            ++Count;
        }
        public Fraction(Fraction a)
        {
            Numer = a.Numer / GCD(a.Numer, a.Denom);
            Denom = a.Denom / GCD(a.Numer, a.Denom);
            ++Count;
        }
        public Fraction(int pNumer = 0, int pDenom = 1)
        {
            Numer = pNumer / GCD(pNumer, pDenom);
            Denom = pDenom / GCD(pNumer, pDenom);
            ++Count;
        }

        public override string ToString()
        {
            double value = (double)Numer / (double)Denom;
            return string.Format("[Rational: {0}/{1}], value={2}]", Numer, Denom, (double)value);
        }

        public void setValue(int pNumer, int pDenom)
        {
            Numer = pNumer / GCD(pNumer, pDenom);
            Denom = pDenom / GCD(pNumer, pDenom);
        }
        public static int GCD(int num1, int num2)
        {
            if (num2 == 0) return num1;
            return GCD(num2, num1 % num2);
        }

        public static Fraction operator ++(Fraction pFraction)
        {
            pFraction.Numer += pFraction.Denom;
            return pFraction;
        }
        public static Fraction operator +(Fraction f_left, Fraction f_right)
        {
            return new Fraction((f_left.Numer * f_right.Denom) + (f_right.Numer * f_left.Denom), f_left.Denom * f_right.Denom);
        }
        public static Fraction operator +(int num, Fraction f_right)
        {
            Fraction added = new Fraction();
            added.Numer = f_right.Numer + (num * f_right.Denom);
            added.Denom = f_right.Denom;
            return added;
        }
        public static Fraction operator -(int num, Fraction f_right)
        {
            Fraction added = new Fraction();
            added.Numer = (num * f_right.Denom) - f_right.Numer;
            added.Denom = f_right.Denom;
            return added;
        }
        public static Fraction operator +(Fraction f_left, int num)
        {
            Fraction added = new Fraction();
            added.Numer = f_left.Numer + (num * f_left.Denom);
            added.Denom = f_left.Denom;
            return added;
        }
        public static Fraction operator -(Fraction f_left, int num)
        {
            Fraction reduced = new Fraction();
            reduced.Numer = f_left.Numer - (num * f_left.Denom);
            reduced.Denom = f_left.Denom;
            return reduced;
        }
        public static Fraction operator -(Fraction f_left, Fraction f_right)
        {
            return new Fraction((f_left.Numer * f_right.Denom) - (f_right.Numer * f_left.Denom), f_left.Denom * f_right.Denom);
        }
        public static bool operator ==(Fraction f_left, Fraction f_right)
        {
            if (System.Object.ReferenceEquals(f_left, f_right))
            {
                return true;
            }
            
            if (((object)f_left == null) || ((object)f_right == null))
            {
                return false;
            }
            return ((f_left.Numer == f_right.Numer) && (f_left.Denom == f_right.Denom));
        }
        public override bool Equals(Object obj)
        {
            Fraction fractionObj = obj as Fraction;
            if (fractionObj == null)
                return false;
            else
                return (Numer.Equals(fractionObj.Numer) && Denom.Equals(fractionObj.Denom));
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public static bool operator !=(Fraction f_left, Fraction f_right)
        {
            return (f_left.Numer != f_right.Numer || f_left.Denom != f_right.Denom);
        }

        public int Numer
        {
            get;
            set;
        }
        public int Denom
        {
            get { return _denom;  }
            set
            {
                if (value != 0)
                {
                    _denom = value;
                }
                else
                {
                    _denom = 1;
                }
            }
        }
        public static int Count
        {
            get;
            set;
        }
    }
}
