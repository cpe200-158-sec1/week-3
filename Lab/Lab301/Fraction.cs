using System;

namespace Lab301
{
	class Fraction
	{

		private double _Numer;
		private double _Denom;
		private static int  _Count=0;

		//overloading
		public static bool operator ==(Fraction f1,Fraction f2)
		{
			return (f2._Numer / f2._Denom == f1._Numer / f1._Denom);
		}

		public static bool operator !=(Fraction f1,Fraction f2)
		{
			return (f2._Numer / f2._Denom != f1._Numer / f1._Denom);
		}

		public static Fraction operator +(Fraction f1,Fraction f2)
		{
			return new Fraction ( f1._Numer * f2._Denom + f1._Denom * f2._Numer, f1._Denom * f2._Denom );
		}

		public static Fraction operator +(int n,Fraction f2)
		{
			return new Fraction ( n * f2._Denom + f2._Numer , f2._Denom );
		}

		public static Fraction operator +(Fraction f2,int n)
		{
			return new Fraction ( n * f2._Denom + f2._Numer , f2._Denom );
		}


		public static Fraction operator -(Fraction f1,Fraction f2)
		{
			return new Fraction ((f1._Numer*f2._Denom - f2._Numer*f1._Denom) , f1._Denom*f2._Denom);
		}

		public static Fraction operator -(int n,Fraction f2)
		{
			return new Fraction (n * f2._Denom - f2._Numer , f2._Denom);
		}

		public static Fraction operator -(Fraction f2,int n)
		{
			return new Fraction (f2._Numer - n * f2._Denom  , f2._Denom);
		}

		public static Fraction operator ++(Fraction f)
		{
			return new Fraction (f._Numer + f._Denom  , f._Denom);
		}

		public bool Equals(Fraction a)
		{
			return (this._Numer / this._Denom == a._Numer / a._Denom);
		}


		public double Numer
		{
			get { return _Numer;}
			set 
			{
				_Numer = value;
			}

		}

		public double Denom
		{
			get { return _Denom;}
			set 
			{
				if (value != 0)
					_Denom = value;
				else
					_Denom = 1;
			}
		}

		public static int Count
		 {
		get { return _Count; }
		set { _Count = value; }
		}

		public Fraction()
		{
			_Count++;
			_Denom = 1;
			_Numer = 0;
		}

		public Fraction(Fraction a)
		{
			
			_Denom = a._Denom;
			_Numer = a._Numer;
		}

		public Fraction (double numer,double denom)
		{
			_Count++;
			_Denom = denom;
			_Numer = numer;
		}

		public Fraction (double numer)
		{
			_Count++;
			_Denom = 1;
			_Numer = numer;
		}

		//method

		public Fraction setValue(double numer,double denom)
		{
			if(denom!=0)
			_Denom = denom;
			else _Denom = 1;
			_Numer = numer;	
			return this;
		}


		public static int GCD(int n1,int n2)
		{
			if (n1 == 0)
				return n2;
			return GCD (n2%n1,n1);
		}

		public override string ToString ()
		{
			return string.Format ("[Rational: {0}/{1}], value={2}]", this._Numer / GCD((int)_Numer,(int)_Denom), this._Denom /  GCD((int)_Numer,(int)_Denom), this._Numer / this._Denom);
		}



	}



}
