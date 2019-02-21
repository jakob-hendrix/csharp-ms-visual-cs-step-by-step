using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public Complex(int real) : this(real, 0) { }

        // Type conversions
        public static implicit operator Complex(int from) => new Complex(from);
        public static explicit operator int(Complex from) => from.Real;

        public override string ToString() => $"({this.Real} + {this.Imaginary}i)";

        // Arithmetic operators
        public static Complex operator +(Complex lhs, Complex rhs) => new Complex(lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary);
        public static Complex operator -(Complex lhs, Complex rhs) => new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
        public static Complex operator *(Complex lhs, Complex rhs) => new Complex(lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary, lhs.Imaginary * rhs.Real + lhs.Real * rhs.Imaginary);
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int realElement = (lhs.Real * rhs.Real + lhs.Imaginary * rhs.Imaginary) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);
            int imaginaryElement = (lhs.Imaginary * rhs.Real - lhs.Real * rhs.Imaginary) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);

            return new Complex(realElement, imaginaryElement);
        }

        // Equality operators
        public static bool operator ==(Complex lhs, Complex rhs) => lhs.Equals(rhs);
        public static bool operator !=(Complex lhs, Complex rhs) => !(lhs.Equals(rhs));
        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                Complex compare = (Complex)obj;
                return (this.Real == compare.Real) && (this.Imaginary == compare.Imaginary);
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
