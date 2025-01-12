using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class ComplexNumber(int _real = 0, int _imaginary = 0) : IComparable<ComplexNumber>
    {
        public readonly int real = _real;
        public readonly int imaginary = _imaginary;

        public static ComplexNumber operator +(ComplexNumber cm1, ComplexNumber cm2) => new(cm1.real + cm2.real, cm1.imaginary + cm2.imaginary);


        public static bool operator >(ComplexNumber cm1, ComplexNumber cm2)
        {
            if (cm1.real > cm2.real)
                return true;
            else if (cm1.real == cm2.real)
                return cm1.imaginary > cm2.imaginary;
            else return false;
        }
        public static bool operator <(ComplexNumber cm1, ComplexNumber cm2) => !(cm1 > cm2);



        public static bool operator ==(ComplexNumber cm1, ComplexNumber cm2) => (cm1.real == cm2.real && cm1.imaginary == cm2.imaginary);
        public static bool operator !=(ComplexNumber cm1, ComplexNumber cm2) => cm1 == cm2;



        public static ComplexNumber operator ++(ComplexNumber cm) => new(cm.real + 1, cm.imaginary);
        public static ComplexNumber operator --(ComplexNumber cm) => new(cm.real - 1, cm.imaginary);



        public static explicit operator int(ComplexNumber cm) => cm.real;
        public static explicit operator ComplexNumber(int x) => new(x, 0);



        public override string ToString() => $"{real} + {imaginary}J";
        public override bool Equals(object? obj) => obj is ComplexNumber cm && (cm.real == real && cm.imaginary == imaginary);
        public int CompareTo(ComplexNumber? cm) => cm is not null ? (this > cm ? 1 : (this < cm ? -1 : 0)) : 1;

    }
}
