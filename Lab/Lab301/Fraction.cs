using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private int number;
        private int denom;
        private static int count;

      
        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", number / GCD(number, denom), denom / GCD(number, denom), (double)number / (double)denom);
        }
 
        public Fraction()
        {
            Number = 0;
            Denom = 1;
            Count++;
        }
        public Fraction(Fraction a)
        {
            Number = a.number;
            Denom = a.denom;
            Count++;
        }
        public Fraction(int _number = 0,int _denom = 1)
        {
            Number = _number;
            Denom = _denom;
            Count++;
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public int Denom
        {
            get
            {
                return denom;
            }
            set
            {
                if (value == 0)
                    denom = 1;
                else denom = value;
            }
        }
        public static int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public  void setValue(int _number, int _denom)
        {
            Number = _number;
            Denom = _denom;
         }
        public static int GCD(int a, int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }
         public bool Equals(Fraction c)
        {
            return (number == c.number && denom == c.denom);
        }
        public static Fraction operator +(Fraction c1, Fraction c2)
        {
            return new Fraction(c1.number * c2.denom + c1.denom * c2.number, c1.denom* c2.denom);
        }

        public static Fraction operator -(Fraction c1, Fraction c2)
        {
            return new Fraction(c1.number * c2.denom - c1.denom * c2.number, c1.denom* c2.denom);
        }
        public static Fraction operator ++(Fraction c)
        {
            c.number += c.denom;
            return c;
        }
    public static Fraction operator +(Fraction c, int b)
        {
            return new Fraction(c.denom* b + c.number, c.denom);
        }

        public static Fraction operator +(int a, Fraction c)
        {
            return new Fraction(a* c.denom + c.number, c.denom);
        }

        public static Fraction operator -(Fraction c, int b)
        {
            return new Fraction(c.number - b* c.denom, c.denom);
        }

        public static Fraction operator -(int a, Fraction c)
        {
            return new Fraction(a* c.denom - c.number, c.denom);
        }
        public static bool operator ==(Fraction c1, Fraction c2)
        {
            return (c1.number == c2.number && c1.denom == c2.denom);
        }
        public static bool operator !=(Fraction c1, Fraction c2)
        {
            return (c1.number != c2.number && c1.denom != c2.denom);
        }
    }
}
