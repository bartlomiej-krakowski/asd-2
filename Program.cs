using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] array = { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

        }


        bool isPrime(BigInteger[] Num)
        {
            if (Num < 2) return false;
            else if (Num % 2 == 0) return true;
            else
                for (BigInteger u = 3; u < Num / 2; u += 2)
                    if (Num % u == 0) return false;
            return true;
        }

    }
}
