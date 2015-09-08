using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private int _denom;
        private int _Numer; //GDC
        private static int _Count;

        public int Denom
        {
            get { return _denom; }
            set {
                if (value == 0)
                    _denom = 1;
                else _denom = value;
            }
        }

        public int Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }

        public static int Count
        {
                get { return _Count; }
                set { _Count = value; }
            }

        public Fraction()
        {
            Denom = 1;
            Numer = 0;
            Count++;

   
        }

        public Fraction(Fraction f)
        {
            Denom = f.Denom;
            Numer = f.Numer;
            Count++;
        }
        public Fraction(int f)
        {
            Numer = f;
            Denom = 1;
            
            Count++;
        }
        public Fraction(int n, int d)
        {
            Denom = d/GCD(n, d);
            Numer = n/GCD(n, d);
            Count++;

        }
        
        public  void setValue(int n, int d)
        {
            Denom = d ;
            Numer = n ;


        }

        public static int GCD(int n, int d)
        {
            int a = n, b = d;
           
            int tmp;
            while (a != 0)
            {
                tmp = b % a;
                b = a;
                a = tmp;
            }
            return b;

            

        }

        public static Fraction operator + ( Fraction a, Fraction b)
        {
            int x1 = a.Numer, y1 = a.Denom, x2 = b.Numer ,y2 = b.Denom;
            int x3 = (y2 * x1) + (y1 * x2), y3 = y1 * y2;
            x3 = x3 / GCD(x3, y3);
            y3 = y3 / GCD(x3, y3);
             

            return  new Fraction(x3, y3);

        }

        public static Fraction operator  - ( Fraction a, Fraction b)
        {
            int x1 = a.Numer, y1 = a.Denom, x2 = b.Numer, y2 = b.Denom;
            int x3 = (y2 * x1) - (y1 * x2), y3 = y1 * y2;
            x3 = x3 / GCD(x3, y3);
            y3 = y3 / GCD(x3, y3);
            return new Fraction(x3, y3);
        }

        public static bool operator == (Fraction a, Fraction b)
        {
            return (a.Denom == b.Denom && a.Numer == b.Numer);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.Denom != b.Denom || a.Numer != b.Numer);
        }

        public static Fraction operator ++(Fraction a)
        {
            int x = a.Numer, y = a.Denom;
            x = x + y;
            return new Fraction(x, y);

        }
        public static Fraction operator + (Fraction a,int b)
        {
            int x = a.Numer, y = a.Denom;
            x = x + (y * b);
            return new Fraction(x, y);

        }
        public static Fraction operator -( int b,Fraction a)
        {
            int x = a.Numer, y = a.Denom;
            x = (y * b)-x;
            return new Fraction(x, y);

        }
        public  bool Equals(Fraction a)
        {
            return (a.Denom == Denom && a.Numer == Numer);

        }

        public override string ToString()
        {
          //  float r = (float)Numer*1.00 / (float)Denom;
            return "[Rational:" + Numer + "/" + Denom + "], value=" + Numer * 1.00 / Denom + " ];";
        }
    }

}
