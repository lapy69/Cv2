using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2
{
    class Complex
    {
        public double Real;
        public double Imaginar;

        public Complex(double real = 0.0, double imaginar = 0.0)
        {
            Real = real;
            Imaginar = imaginar;
        }

        //Operators
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginar + b.Imaginar);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginar - b.Imaginar);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginar * b.Imaginar, a.Real * b.Imaginar + b.Real * a.Imaginar);
        }
        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.Real * b.Real + a.Imaginar * b.Imaginar) / (b.Real * b.Real + b.Imaginar * b.Imaginar), (a.Imaginar * b.Real - a.Real * b.Imaginar) / (b.Real * b.Real + b.Imaginar * b.Imaginar));
        }
        public static Complex operator -(Complex a)
        {
            return new Complex(-a.Real, -a.Imaginar);
        }

        //Equal/not equal
        public static double epsilon = 0.000001;
        public static bool operator !=(Complex a, Complex b)
        {

            if ((Math.Abs(a.Real - b.Real) < epsilon) && (Math.Abs(a.Imaginar - b.Imaginar) < epsilon))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Complex a, Complex b)
        {
            if ((Math.Abs(a.Real - b.Real) < epsilon) && (Math.Abs(a.Imaginar - b.Imaginar) < epsilon))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Conjugate
        public static Complex conjugate(Complex a)
        {
            return new Complex(a.Real, -a.Imaginar);
        }

        //Absolute and phase
        public static double abs(Complex a)
        {
            return (Math.Sqrt(a.Real * a.Real + a.Imaginar * a.Imaginar));
        }
        public static double ph(Complex a)
        {
            return (Math.Atan(a.Imaginar / a.Real));
        }

        public override string ToString()
        {
            if (Imaginar < 0)
            {
                return string.Format("{0}-j{1}", Real, -Imaginar);
            }
            else
            {
                return string.Format("{0}+j{1}", Real, Imaginar);
            }
        }
    }
}
