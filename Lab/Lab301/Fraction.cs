using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double num;
        private double denum;
       
        public double Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public double Denum
        {
            get
            {
                return denum;
            }
            set
            {
                denum = value;
            }
        }
        private static int count = 0;
        public static int Count
        {
            get
            {
                return count;
            }
        }

 
        public Fraction()
        {
            Num = 0;
            Denum = 1;
            count++;

        }
        public Fraction(double num)
        {
            Num = num;
            Denum = 1;
            count++;
        }

        public Fraction(double num, double denum)
        {
            this.Num = num / Fraction.GCD(num, denum);
            this.Denum = denum / Fraction.GCD(num, denum);
            count++;
        }

        public Fraction(Fraction x)
        {
            this.Num = x.Num;
            this.Denum = x.Denum;
        }

        public static Fraction operator +(Fraction x, int a)
        {
            return new Fraction((x.Num + (x.Denum * a)), (x.Denum));
        }

        public static Fraction operator +(int a, Fraction x)
        {
            return new Fraction((x.Num + (x.Denum * a)), (x.Denum));
        }

        public static Fraction operator +(Fraction x1, Fraction x2)
        {
            return new Fraction((x1.Num * x2.Denum) + (x2.Num * x1.Denum), (x1.Denum * x2.Denum));
       }

        public static Fraction operator -(Fraction x, int a)
        {
            return new Fraction((x.Num - (x.Denum * a)), (x.Denum));
        }

        public static Fraction operator -(int a, Fraction x)
        {
            return new Fraction(((x.Denum * a) - x.Num), (x.Denum));
        }

        public static Fraction operator -(Fraction x1, Fraction x2)
        {
           return new Fraction((x1.Num * x2.Denum) - (x2.Num * x1.Denum), (x1.Denum * x2.Denum));
        }

        public static Fraction operator ++(Fraction x)
        {
            return new Fraction((x.Num + x.Denum), x.Denum);
        }
        public static Fraction operator --(Fraction x)
        {
            return new Fraction((x.Num - x.Denum), x.Denum);
        }


        public void setValue(int x, int y)
        {
            num = x;
            if (y == 0)
                denum = 1;
            else
                denum = y;
        }


        public static bool operator ==(Fraction x1, Fraction x2)
        {
            return (x1.Num == x2.Num && x1.Denum == x2.Denum);
        }
        public static bool operator !=(Fraction x1, Fraction x2)
        {
            return (x1.Num != x2.Num || x1.Denum != x2.Denum);
        }
        public bool Equals(Fraction x)
        {
            return (this.Num / this.denum == x.Num / x.Denum);
        }
        

        public static int GCD(double x, double y)
        {
            int gcd = 1;
            for (int z = 1; (z <= x) && (z <= y); z++)
            {
                if ((x % z == 0) && (y % z == 0))
                {
                    gcd = z;
                }
            }
            return gcd;
        }
        public override string ToString()
        {
            string x = "[Rational: " + this.Num + "/" + this.Denum + "], value=" + (this.Num / this.Denum) + "]";
            return x;
        }

    }
}