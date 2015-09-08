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
        private static int _Count=0;

       

        public int Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }
        
        public int Denom
        {
            get { return _Denom; }
            set
            {
                if (value == 0)
                    _Denom = 1; 
                else
                    _Denom = value;
            }
        }
  
        public static int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public Fraction()
        {
            _Numer = 0;
            _Denom = 1;
            _Count++;
        }

        public Fraction(Fraction a)
        {
            _Numer = a._Numer;
            _Denom = a._Denom;
        }

        public Fraction(int numer)
        {
            _Numer = numer;
            _Denom = 1;
            _Count++;
        }

        public Fraction(int numer, int denom)
        {
            _Numer = numer;
            _Denom = denom;
            _Count++;
        }

        public  void setValue(int numer, int denom)
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


        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction((a._Numer * b._Denom) + (b._Numer * a._Denom), a._Denom * b._Denom);
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a._Numer + (b * a._Denom), a._Denom);
        }

        public static Fraction operator +(int a, Fraction b)
        {
            return new Fraction((a * b._Denom) + b._Numer, b._Denom);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction((a._Numer * b._Denom) - (b._Numer * a._Denom), a._Denom * b._Denom);
        }

        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(a._Numer - (b * a._Denom), a._Denom);
        }

        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction((a * b._Denom) - b._Numer, b._Denom);
        }

        public static Fraction operator ++(Fraction a)
        {
            return new Fraction(a._Numer + (a._Denom), a._Denom);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a._Numer / a._Denom == b._Numer / b._Denom) ? true : false;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a._Numer / a._Denom != b._Numer / b._Denom) ? true : false;
        }

        public bool Equals(Fraction obj)
        {
            return (this.Numer / this.Denom == obj.Numer / obj.Denom) ? true : false;
        }

        public override string ToString()
        {
            double val = (double)_Numer / _Denom;
            return string.Format("[Rational: {0}/{1}], value={2}]", _Numer / GCD(_Numer, _Denom), _Denom / GCD(_Numer, _Denom), val);
        }
    }
}
