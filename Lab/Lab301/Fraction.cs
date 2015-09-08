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
                if (value == 0)
                    _denom = 1;
                else
                    _denom = value;
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
            ++_count;
        }
        public Fraction(Fraction obj)
        {
            _numer = obj._numer;
            _denom = obj._denom;
            ++_count;
        }
        public Fraction(int numer = 0, int denom = 1)
        {
            int a = GCD(numer, denom);
            _numer = numer/a;
            _denom = denom/a;
            ++_count;
        }

        public void setValue(int numer, int denom)
        {
            this.Numer = numer;
            this.Denom = denom;
        }

        public static int GCD(int a, int b)
        {
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            return (a < b) ? GCD(b % a, a) : GCD(a % b, b);
        }

        public static Fraction operator +(Fraction l, Fraction r)
        {
            return new Fraction((l._numer * r._denom) + (r._numer * l._denom), l._denom * r._denom);
        }
        public static Fraction operator +(Fraction l, int r)
        {
            return new Fraction((l._numer * 1) + (r * l._denom), l._denom *1);
        }
        public static Fraction operator -(Fraction l, Fraction r)
        {
            return new Fraction((l._numer * r._denom) - (r._numer * l._denom), l._denom * r._denom);
        }
        public static Fraction operator -(int l, Fraction r)
        {
            return new Fraction((l * r._denom) - (r._numer * 1), 1 * r._denom);
        }
        public static Fraction operator ++(Fraction l)
        {
            l._numer += l._denom;
            return l;
        }
        public static bool operator ==(Fraction l, Fraction r)
        {
            return (l._numer / l._denom == r._numer / r._denom);
        }
        public static bool operator !=(Fraction l, Fraction r)
        {
            return (l._numer / l._denom != r._numer / r._denom);
        }
        public bool Equals(Fraction obj)
        {
            return (this.Numer / this.Denom == obj.Numer / obj.Denom);
        }

        public override string ToString()
        {
            double val = (double)_numer / _denom;
            return string.Format("[Rational: {0}/{1}], value={2}]", _numer, _denom, val);
        }
       
    }
}
