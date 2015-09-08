using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        /*## Propeties:
            - Numer: Numerator
            - Denom: Denominator(default=1, cannot be 0)
            - Count: counting #objects of this class (static)
        */
        private double _num;
        private double _den;

        public static int Count;

        public double  Numer
        {
            get { return _num; }
            set { _num = value; }
        }
        public double Denom
        {
            get { return _den;}
            set
            {
                if(value ==0)
                {
                    _den = 1;
                }
                else { _den = value; }
            }
        }

        /*
        ## Constructors:
        note: increment the Count property when an object is created
        */
        public Fraction()
        {
            Numer = 0;
            Denom = 1;
            Count++;
        }
        public Fraction(Fraction a)
        {
            Numer = a.Numer;
            Denom = a.Denom;
            Count++;
        }
        public Fraction(double n,double d=1)
        {
            
            Numer = n/ GCD(n, d);
            Denom = d/GCD(n, d);
            Count++;
        }
        
        /*## Methods
                - setValue: set fraction value
                - GCD: calculate Greatest Common Divisor of two integers (static)
        */
        public void setValue(double n,double d)
        {
            Numer = n;
            Denom = d;
        }
        public static double GCD(double a,double b)
        {
            //if(a==b) return a;reurn(a
            double tmp;
            while(b!=0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }
        public override string ToString()
        {
            //[Rational: 0/1], value=0]
            double result = Numer / Denom;
            return "[Rational: " + Numer + "/" + Denom + "], value="+result+"]";
        }
        public bool Equals(Fraction a)
        {
            return (Numer == a.Numer && Denom == a.Denom);
        }
        //## Operator Overloading:
        public static bool operator ==(Fraction a,Fraction b)
        {
            return (a.Numer == b.Numer && a.Denom == b.Denom);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.Numer != b.Numer || a.Denom != b.Denom);
        }
        public static Fraction operator +(Fraction a,Fraction b)
        {
            double newn = (a.Numer * b.Denom) + (b.Numer  * a.Denom);
            double newd = (a.Denom * b.Denom) / GCD(newn, a.Denom * b.Denom);
            return new Fraction(newn / GCD(newn, a.Denom * b.Denom), newd);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            double newn = (a.Numer * b.Denom) - (b.Numer * a.Denom);
            double newd = (a.Denom * b.Denom);
            return new Fraction(newn / GCD(newn, newd), newd / GCD(newn, newd));
        }
        public static Fraction operator -(double a, Fraction b)
        {
            double newn = a - (b.Numer / b.Denom);
            return new Fraction(newn / b.Denom, b.Denom);
        }
        public static Fraction operator +(Fraction a, double b)
        {
            double newn = a.Numer +(b*a.Denom) ;
            double newd = a.Denom / GCD(a.Denom, newn);
            return new Fraction(newn / GCD(a.Denom, newn), newd);
        }
        public static Fraction operator++(Fraction a)
        {
            double newn = a.Numer + a.Denom;
            a.Numer = newn / GCD(a.Denom, newn);
            a.Denom = a.Denom / GCD(a.Denom, newn);
            return new Fraction(a.Numer, a.Denom);
        }
    }
}
