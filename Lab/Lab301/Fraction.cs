using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        //propeties
        private int _numer;
        private static int _count;
        private int _denom; // !=0

        public int numer
        {
            get { return _numer; }
            set { _numer = value; }
        }

        public static int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public int denom
        {
            get { return _denom; }
            set { _denom = (value != 0) ? value : 1; }
             
        }

        //constructor
        
        public Fraction()
        {
            _numer = 0;
            _denom = 1;
            Count++;

        }

        public Fraction(int n)
        {
            _numer = n;
            _denom = 1;
            Count++;      
        }

        public Fraction(int n,int d)
        {
            _numer = n;
            _denom = d;
            Count++;

        }
        public Fraction(Fraction a)
        {
            _numer = a._numer;
            _denom = a._denom;

        }

        //Method
         public Fraction setValue(int n , int d)
        {
            this._numer = n;
            this._denom = d;
            return this;
        }

        public  static int GCD (int a, int b)
        {
            if (a == 0) return b;
               return GCD(b % a, a);
        }

        public bool Equals (Fraction a)
        {
            return (this._numer / this._denom == a._numer / a._denom);
                    
        }

        //overloading
        
        // +
        public static Fraction operator + (Fraction a, Fraction b)
        {
           return new Fraction((a._numer * b._denom) + (b._numer * a._denom), a._denom * b._denom);
        }
        public static Fraction operator ++ (Fraction a)
        {
           return new Fraction(a._numer + a._denom, a._denom);
        }
        public static Fraction operator + (Fraction a, int b)
        {
           return new Fraction(a._numer + (b * a._denom), a._denom);
        }
        public static Fraction operator + (int a ,Fraction b)
        {
           return new Fraction(b._numer + (a * b._denom), b._denom);
        }

        // -
        public static Fraction operator - (Fraction a, Fraction b)
        {
           return new Fraction((a._numer * b._denom) - (b._numer * a._denom), a._denom * b._denom);
        }
        public static Fraction operator -- (Fraction a)
        {
           return new Fraction(a._numer - a._denom, a._denom);
        }
        public static Fraction operator - (Fraction a, int b)
        {
           return new Fraction(a._numer - (b * a._denom), a._denom);
        }
        public static Fraction operator - (int a, Fraction b)
        {
           return new Fraction( (a* b.denom) - b.numer, b._denom);
        }

        // == and !=

        public static bool operator == (Fraction a , Fraction b)
        {
            return (a._numer / a._denom == b._numer / b._denom) ? true : false;
        }
        public static bool operator != (Fraction a, Fraction b)
        {
            return (a._numer / a._denom != b._numer / b._denom) ? true : false;
        }

        // to string

        public override string ToString()
        {
            return String.Format(" [Rational:{0}/{1}], value = {2}] ", 
                this._numer/GCD(this._numer,this._denom),//0
                this._denom / GCD(this._numer, this._denom),//1
                (double)this._numer/(double)this._denom /*2*/ );
        }

    }
 

            
      


         
          
                



    }
