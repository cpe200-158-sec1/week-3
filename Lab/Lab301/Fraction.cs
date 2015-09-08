using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        //Properties

        //Numer: Numerator
        private int _Numer;
        //Denom: Denominator(default=1, cannot be 0)
        private int _Denom;
        //Count: counting #objects of this class (static)
        public static int Count=0;

        public int Numer{
            get { return _Numer; }
            set { _Numer = value; }
        }
        
        public int Denom{
            get { return _Denom; }
            set {
                if (value == 0)
                    _Denom = 1;
                else _Denom = value;
            }
        }
   
        
        //Constructors

        //Fraction() : default constructor
        public Fraction()
        {
            _Numer = 0;
            _Denom = 1;
            Count++;
        }
        public Fraction(int numerator)
        {
            _Numer = numerator;
            _Denom = 1;
            Count++;
        }
        //Fraction(Fraction a) : copy constructor
        public Fraction(Fraction a)
        {
            _Numer = a.Numer;
            _Denom = a.Denom;
            Count++;
            
        }
        //Fraction(numerator, denominator)
        public Fraction(int numerator, int denominator)
        {
            _Numer = numerator;
            _Denom = denominator;
            Count++;
        }

        //Methods
        
        //setValue: set fraction value
        public void setValue(int numerator, int denominator)
        {
                _Numer = numerator;
            if (denominator == 0)
                _Denom = 1;
            else 
                _Denom = denominator;  
         
        }         
        //GCD: calculate Greatest Common Divisor of two integers(static)
        public static int GCD(int a, int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }
        public bool Equals (Fraction f1)
        {
            return (f1.Numer == Numer && f1.Denom == Denom);
        }

        //[Rational: 0/1], value=0]
        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]",_Numer / GCD(_Numer,_Denom), _Denom / GCD(_Numer, _Denom), (double)_Numer/_Denom);
        }

        //overloading
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            return new Fraction(f1.Numer*f2.Denom + f2.Numer*f1.Denom, f1.Denom*f2.Denom);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numer * f2.Denom - f2.Numer * f1.Denom, f1.Denom * f2.Denom);
        }
        public static Fraction operator++(Fraction f)
        {
            f.Numer=f.Numer+f.Denom;
            
            return f;
        }
        public static Fraction operator -(int i, Fraction f)
        {
            return new Fraction(i*f.Denom - f.Numer, f.Denom);
        }
        public static Fraction operator +(Fraction f,int i)
        {
            return new Fraction(f.Numer + i * f.Denom, f.Denom);
        }
        public static bool operator ==(Fraction f1,Fraction f2)
        {
            return (f1.Numer == f2.Numer && f1.Denom == f2.Denom);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.Numer != f2.Numer || f1.Denom != f2.Denom);
        }

    }
}
