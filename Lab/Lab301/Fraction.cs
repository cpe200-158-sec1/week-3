using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        //propetie
        private int _Numerator;
        private int _Denominator;
        private static int _Count=0;

        public static int Count
        {
            get{ return _Count; }
        }
        public int Numerator
        {
            get { return _Numerator; }
            set
            {
                _Numerator = value;
            }
        } 
        public int Denominator
        {
            get { return _Denominator; }
            set
            {
                if (value != 0)
                {
                    _Denominator = value;
                }
                else
                {
                    _Denominator = 1;
                }
            }
        }
        //constructor
        public Fraction()
        {
            _Numerator = 0;
            _Denominator = 1;
            _Count++;
        }
        public Fraction(Fraction a)
        {
            _Numerator = a._Numerator;
            _Denominator = a._Denominator;
            _Count++;
        }
        public Fraction(int n)
        {
            _Count++ ;
            _Numerator = n;
            _Denominator = 1;
        }
        public Fraction(int n,int d)
        {
            _Count++;
            _Numerator = n;
            _Denominator = d;
        }
        
        //Method
        public void setValue(int n,int d)
        {          
            Denominator = d;
            Numerator = n;
        }
        public static int GCD(int a, int b)
        {                        
                if (a % b == 0)
                {
                    return b;
                }                             
                    return GCD(b, a % b);                           
        }
        public void lastnum(Fraction a)
        {
            int gcd = GCD(a.Numerator, a.Denominator);
            this._Numerator = a.Numerator / gcd;
            this._Denominator = a.Denominator / gcd;
        } 

        //overload
        public static Fraction operator +(Fraction a,Fraction b)
        {
            Fraction plus = new Fraction();
            
            plus.Numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
            plus.Denominator = a.Denominator * b.Denominator;          
            return plus;        
        } 
        public static Fraction operator +(Fraction a,int b)
        {
            Fraction plus = new Fraction();        
            plus.Numerator = (a.Numerator) + (b * a.Denominator);
            plus.Denominator = a.Denominator;
            return plus;          
        }
        public static Fraction operator ++(Fraction a)
        {        
            a = a + 1;           
            return a;
        }
        public static Fraction operator -(Fraction a,Fraction b)
        {
            Fraction minus = new Fraction();           
            minus.Numerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
            minus.Denominator = a.Denominator * b.Denominator;
            return minus;
        }
        public static Fraction operator -(int a,Fraction b)
        {
            Fraction minus = new Fraction();
            minus.Numerator = (a * b.Denominator) - b.Numerator;
            minus.Denominator = b.Denominator;
            return minus;
        }       
        public override string ToString()
        {
            string output;
            float x;
            lastnum(this);
            x =(float)Numerator / (float)Denominator;
            output = ("[Rational: "+Numerator+"/"+Denominator+", value = "+x+"]");
            return output;
        }
        public static explicit operator float(Fraction a)
        {
            return (float)a;
        }
        public static bool operator ==(Fraction a,Fraction b)
        {
            return (a.Numerator == b.Numerator && a.Denominator == b.Denominator);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.Numerator != b.Numerator || a.Denominator != b.Denominator);
        }
       public bool Equals(Fraction a)
        {
            return (a.Numerator == Numerator && a.Denominator == Denominator);           
        }

    }
}
