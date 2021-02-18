using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            TestComplex.Test(new Complex(1.0, 2.2) + new Complex(4.6, 5.8), new Complex(5.6,8.0), "test of +");
            TestComplex.Test(new Complex(1.0, 2.2) - new Complex(4.6, 5.8), new Complex(-3.6, -3.6), "test of -");
            TestComplex.Test(new Complex(1.0, 2.2) * new Complex(4.6, 5.8), new Complex(-8.16, 15.92), "test of *");
            TestComplex.Test(new Complex(1.0, 2.2) / new Complex(4.6, 5.8), new Complex(0.316788, 0.078832), "test of /");
            Console.WriteLine("{0}", new Complex(1.0, 2.2) == new Complex(4.6, 5.8));
            Console.WriteLine("{0}", new Complex(1.0, 2.2) != new Complex(4.6, 5.8));
            Console.WriteLine("{0:F6}", Complex.abs(new Complex(1.0, 2.2)));
            Console.WriteLine("{0:F6} rad", Complex.ph(new Complex(1.0, 2.2)));
            Console.ReadLine();
        }
    }
}
