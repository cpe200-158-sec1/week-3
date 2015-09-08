using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab301;

namespace Lab301
{
    class Fraction
    {
        private int _Numer;
        private int _Denom;
        private static int _Count;


        public Fraction()
        {
            _Numer = 0;
            _Denom = 1;
            _Count++ ;
        }

        public Fraction(int numer, int denom)
        {
            _Numer = numer;
            _Denom = denom;
            _Count++;
        }

        public Fraction(int numer)
        {
            _Numer = numer;
            _Denom = 1;
            _Count++;
        }

        public Fraction(Fraction a)
        {
            _Numer = a._Numer;
            _Denom = a._Denom;
            
        }

        public int Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }

        public int Denom
        {
            get { return _Denom; }+
            set
            {
                if ( _Denom > 0 )
                {
                    _Denom = value;
                }
                else
                {
                    _Denom = 1;
                }
            }
        }

        public static int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public void setValue(int numer, int denom)
        {
            _Numer = numer;
            _Denom = denom;

        }

        public static int GCD(int x, int y)
        {
            int gcd = 1;
            for (int i = x; i > 0; i--)
            {
                if ( x%i == 0 && y%i == 0)
                {
                        gcd = i;
                    break;
                }
            }

            return gcd;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numer1 = f1._Numer;
            int denom1 = f1._Denom;
            int numer2 = f2._Numer;
            int denom2 = f2._Denom;

            if ( denom1 != denom2 )
            {
                numer1 *= denom2;
                numer2 *= denom1;
                denom1 *= denom2;

                return new Fraction(numer1 + numer2, denom1);

            }

            else { return new Fraction(f1._Numer + f2._Numer, f1._Denom); }
        }

        public static Fraction operator +(Fraction f, int x)
        {
            return new Fraction(f._Numer + (f._Denom* x) , f._Denom );
        }

        public static Fraction operator +(int x, Fraction f)
        {
            return new Fraction(f._Numer + (x* f._Denom), f._Denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numer1 = f1._Numer;
            int denom1 = f1._Denom;
            int numer2 = f2._Numer;
            int denom2 = f2._Denom;

            if (denom1 != denom2)
            {
                numer1 *= denom2;
                numer2 *= denom1;
                denom1 *= denom2;
            }
            return new Fraction(numer1 - numer2, denom1);
        }

        public static Fraction operator -(Fraction f, int x)
        {
            return new Fraction(f._Numer - (x* f._Denom), f._Denom);
        }

        public static Fraction operator -(int x, Fraction f)
        {
            return new Fraction((x* f._Denom)- f._Numer, f._Denom);
        }

        public static Fraction operator ++(Fraction f)
        {
            return new Fraction(f._Numer + f._Denom, f._Denom);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if ((f1._Numer / f1._Denom) == (f2._Numer / f2._Denom))
            {
                return true;
            }

            else { return false; }
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if ((f1._Numer / f1._Denom) != (f2._Numer / f2._Denom))
            {
                return true;
            }

            else { return false; }
        }

        public bool Equals(Fraction f)
        {
            if ( (_Numer / _Denom) == (f._Numer/f._Denom))
            {
                return true;
            }
            else { return false; }
        }

        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", _Numer / GCD(_Numer, _Denom), _Denom / GCD(_Numer, _Denom), _Numer* 1.0 / _Denom);
        }
    }
}
