using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        public int Numer;
        public int Denom;   
        static public int Count=0;

        public  Fraction()
        {           
            Numer = 0;
            Denom = 1;
            Count++;
        }
        
        public  Fraction(Fraction a)
        {
            Numer = a.Numer;
            Denom = a.Denom;
            Count++;
        

        }

        public Fraction(int numerator,int denominator=1)
        {
            Numer = numerator;
            Denom = denominator;
            for (int i = 2; i <= Numer; i++)
            {

                if (Numer % i == 0 && Denom % i == 0)
                {
                    Numer /= i;
                    Denom /= i;
                }
            }
            Count++;
        }

        public void setValue(int numerator,int denominator)
        {
            Numer = numerator;
            Denom = denominator;
            if (Denom == 0) {
                Denom = 1;
            }
            for (int i = 2; i <= Numer; i++)
            {

                if (Numer % i == 0 && Denom % i == 0)
                {
                    Numer /= i;
                    Denom /= i;
                }
            }
        }

        public static int GCD(int x, int y) {
            int max = 0, min = 0;
            int ans = 0;
            if (x > y)//check max number
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            //solve
            for (int i = 2; i <= min; i++)
            {
                if(min%i == 0 && max%i == 0)
                {
                    ans = i;
                }
            }
            return ans;
        }

        //ปัดเศษอย่างต่ำ
        public Fraction Pudsad(Fraction f)
        {
            for (int i = 2; i <= f.Numer; i++)
            {

                if (f.Numer % i == 0 && f.Denom% i == 0)
                {
                    f.Numer /= i;
                    f.Denom /= i;
                }
            }
            return f;
        }

        //+
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            int a=0,b=0;            
            a = (f1.Numer * f2.Denom) + (f2.Numer * f1.Denom);
            b = f1.Denom * f2.Denom;
            Fraction f = new Fraction(a,b);
            f = f.Pudsad(f);
            return f;
        }

        //-
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int a = 0, b = 0;
            a = (f1.Numer * f2.Denom) - (f2.Numer * f1.Denom);
            b = f1.Denom * f2.Denom;
            Fraction f = new Fraction(a, b);
            f = f.Pudsad(f);
            return f;
        }

        //++
        public static Fraction operator ++(Fraction f)
        {
            int a = 0, b = 0;
            a = (f.Denom * 1) + f.Numer;
            b = f.Denom;
            Fraction c = new Fraction(a, b);
            c = c.Pudsad(c);
            return c;
        }

        //int-Fraction
        public static Fraction operator -(int f1,Fraction f2)
        {
            int a = 0, b = 0;
            a = (f1 * f2.Denom) - f2.Numer;
            b = f2.Denom;
            Fraction f = new Fraction(a, b);
            f = f.Pudsad(f);
            return f;
        }

        //fraction+int
        public static Fraction operator +(Fraction f1, int f2)
        {
            int a = 0, b = 0;
            a = (f2 * f1.Denom) + f1.Numer;
            b = f1.Denom;
            Fraction f = new Fraction(a, b);
            f = f.Pudsad(f);
            return f;
        }

        //==
        public static bool operator ==(Fraction f1,Fraction f2)
        {
            return (f1.Numer == f2.Numer && f1.Denom == f2.Denom) ;
        }

        //equals
        public  bool Equals(Fraction f1)
        {
            return (Numer == f1.Numer && Denom == f1.Denom);
        }

        //!=
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.Numer != f2.Numer || f1.Denom != f2.Denom);
        }

        //output
        public override string ToString()
        {
            string s = "[Rational: "+Numer+"/"+Denom+ "], value="+(double)Numer/Denom+"]";
            return s;
        }
    }
    }

