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
        {   get
            { return _Numer; }
            set
            {

                _Numer = value; }
        }
        public int Denom
        {
            get
            { return _Denom; }
            set
            {
                
                _Denom = value; }

        }

        public static int Count
        {
            get
            { return _Count; }
           

        }


        public Fraction()
        {
            _Numer = 0;
            _Denom = 1;
            _Count++;
        }

        public Fraction(Fraction input_Frac)
        {
            _Numer = input_Frac.Numer;
            _Denom = input_Frac.Denom;

            _Count += 0;
        }

        public Fraction(int numerator, int denominator = 1)
        {
     

            setValue(numerator, denominator);
            _Count++;


        }


        public void setValue(int num , int denum)
        {
            _Numer = num;
            _Denom = denum;
            if(_Denom == 0)
            {
                _Denom = 1;
            }
            for(int i=2;i<=_Numer ;i++)
            {

                if(_Numer%i==0 && _Denom%i==0)
                {
                    _Numer /= i;
                    _Denom /= i;

                }
            }
        }

        public float returnValue()
        {
            float output_val = 0;
            output_val = (float)_Numer / _Denom;
            return output_val;
        }

        public static int GCD(int a,int b)
        {
            int output_GCD = 0;
            for (int i= a;i>0;i--)
            {

                if(a%i==0 && b%i==0)
                {
                    output_GCD = i;
                    break;
                }
            }

            return output_GCD;
        }

        //+
        public static Fraction operator +(Fraction a,Fraction b)
        {

            int a_num = a._Numer, a_denum = a._Denom, b_num = b._Numer, b_denum = b._Denom;
            if (a._Denom != b._Denom)
            {
                a_denum *= b._Denom;
                a_num *= b._Denom;

                b_denum *= a._Denom;
                b_num *= a._Denom;

                return new Fraction(a_num + b_num, a_denum);
            }
            else
            {
                return new Fraction(a_num + b_num, a_denum);
            }
        }

        public static Fraction operator +(Fraction a, int b)
        {

            return new Fraction(a._Numer + (b * a._Denom), a._Denom );
        }

        public static Fraction operator +(int a, Fraction b)
        {

            return new Fraction((a * b._Denom) + b._Numer,  b._Denom);
        }

        //-
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int a_num = a._Numer, a_denum = a._Denom, b_num= b._Numer, b_denum = b._Denom;
            if(a._Denom != b._Denom)
            {
                a_denum *= b._Denom;
                a_num *= b._Denom;

                b_denum *= a._Denom;
                b_num *= a._Denom;

                return new Fraction(a_num - b_num, a_denum);
            }
            else
            {
                return new Fraction(a_num - b_num, a_denum);
            }
           
        }

        public static Fraction operator -(Fraction a, int b)
        {

            return new Fraction(a._Numer - (b*a._Denom), a._Denom );
        }

        public static Fraction operator -(int a, Fraction b)
        {

            return new Fraction((a * b._Denom) - b._Numer  ,  b._Denom );
        }

        // *
        // /

        // ++ 
        public static Fraction operator ++(Fraction a)
        {


            return new Fraction(a._Numer+(a._Denom),a._Denom);

        }

        // true flase
        public static bool operator true(Fraction a)
        {


           if(a._Numer != 0 && a._Denom != 0)
            { return true; }
           else
            { return false; }

        }

        public static bool operator false(Fraction a)
        {
           


            if (a._Numer == 0 && a._Denom == 0)
            { return true; }
            else
            { return false; }

        }

        //equal
        public  bool Equals(Fraction a)
        {
           
            
            return (a._Numer == _Numer && a._Denom == _Denom);

        }



        // == 
        public static bool operator ==(Fraction a, Fraction b)
        {

           
                return (a._Numer == b._Numer && a._Denom == b._Denom);
           
        }

        // != 
        public static bool operator !=(Fraction a, Fraction b)
        {


            return !(a._Numer == b._Numer && a._Denom == b._Denom);

        }

        //[Rational: 6/5], value=1.2]
        public override string ToString()
        {
            string output = "";

            output += "[Rational: "+_Numer+"/"+_Denom+ "], value="+ returnValue()+ "]";
            return output;

        }

    }
}
