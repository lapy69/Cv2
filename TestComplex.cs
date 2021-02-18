using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2
{
    class TestComplex
    {
        public static void Test(Complex a, Complex b, string name)
        {
            if (a == b)
            {
                Console.WriteLine("{0} - OK", name);
            }
            else
            {
                Console.WriteLine("{0} - Error, Expected value: {1}, Real value {2}", name, a, b);
            }
        }
    }
}
