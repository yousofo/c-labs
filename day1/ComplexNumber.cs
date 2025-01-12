using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class ComplexNumber
    {
        int _real;
        public int Real
        {
            get
            {
                return _real;
            }
            private set
            {
                _real = value;
            }
        }
        public int Imaginary { get; private set; }


        //public ComplexNumber(int real) : this(real, 0) { }
        public ComplexNumber(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public static ComplexNumber operator +(ComplexNumber d1, ComplexNumber d2) =>
            new ComplexNumber(d1._real + d2.Real, d1.Imaginary + d2.Imaginary);


        public static bool operator >(ComplexNumber d1, ComplexNumber d2)
        {
            if (d1.Real > d2.Real)
                return true;
            else if (d1.Real == d2.Real)
                return d1.Imaginary > d2.Imaginary;
            else return false;
        }
        public static bool operator <(ComplexNumber d1, ComplexNumber d2) => !(d1 > d2);



        public static bool operator ==(ComplexNumber d1, ComplexNumber d2) =>
            (d1.Real == d2.Real && d1.Imaginary == d2.Imaginary);

        public static bool operator !=(ComplexNumber d1, ComplexNumber d2) => d1 == d2;


        public static ComplexNumber operator ++(ComplexNumber d) =>
            new(d.Real + 1, d.Imaginary);
        public static ComplexNumber operator --(ComplexNumber d) =>
            new(d.Real - 1, d.Imaginary);



        public static explicit operator int(ComplexNumber d) => d.Real;
        public static explicit operator ComplexNumber(int d) => new ComplexNumber(d, 0);
        public override string ToString()
        {
            return $"{Real} + {Imaginary}J";
        }

        public override bool Equals(object? obj)
        {
            if (obj is ComplexNumber d)
            {
                return (d.Real == Real && d.Imaginary == Imaginary);
            }
            return false;
        }

    }
}
