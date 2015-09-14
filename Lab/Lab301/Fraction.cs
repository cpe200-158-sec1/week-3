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

        public int Numer
        {
            get
            {
                return _numer;
            }
            set
            {
                _numer = value;
            }
        }
        public int Denom  
        {
            get
            {
                return _denom;
            }
            set
            {
                if(value == 0)
                {
                    _denom = 1;
                }
                else
                {
                    _denom = value;
                }
            }
        }
        public static int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public Fraction()
        {
            _numer = 0;
            _denom = 1;
            _count++;
        }
        public Fraction(Fraction n)
        {
            _numer = n._numer;
            _denom = n._denom;
            _count++;
        }
        public Fraction(int numer = 0, int denom = 1)
        {
            int n = GCD(numer, denom);
            _numer = numer / n;
            _denom = denom / n;
            _count++;
        }
        public void setValue(int numer, int denom)
        {
            this.Numer = numer;
            this.Denom = denom;
        }
        public static int GCD(int numer, int denom)
        {
            if(numer == denom)
            {
                return numer;
            }
            else if(numer == 0)
            {
                return denom;
            }
            else if(denom == 0)
            {
                return numer;
            }
            return (numer < denom) ? GCD(denom % numer, numer) : GCD(numer % denom, denom);
        }
        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction((left._numer * right._denom) + (right._numer * left._denom), left._denom * right._denom);
        }
        public static Fraction operator +(Fraction left, int right)
        {
            return new Fraction((left._numer * 1) + (left._denom), left._denom * 1);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            return new Fraction((left._numer * right._denom) - (right._numer * left._denom), left._denom * right._denom);
        }
        public static Fraction operator -(int left, Fraction right)
        {
            return new Fraction((left * right._denom) - (right._numer * 1), 1 * right._denom);
        }
        public static Fraction operator ++(Fraction left)
        {
            left._numer += left._denom;
            return left;
        }
        public static bool operator ==(Fraction left, Fraction right)
        {
            return (left._numer / left._denom == right._numer / right._denom);
        }
        public static bool operator !=(Fraction left, Fraction right)
        {
            return (left._numer / left._denom != right._numer / right._denom);
        }
        public bool Equals(Fraction n)
        {
            return (this.Numer / this.Denom == n.Numer / n.Denom);
        }
        public override string ToString()
        {
            double value = (double)_numer / _denom;
            return string.Format("[Rational: {0}/{1}], value={2}]", _numer, _denom, value);
        }



    }
}
