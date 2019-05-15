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
            int count = 1;

            Console.WriteLine("Lp;      T;      Result;");
            BigInteger[] array = { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            for (int i = 0; i < array.Length; i++)
            {
                var time = new System.Diagnostics.Stopwatch();
                time.Start();

                isPrime(array[i]);
                time.Stop();

                long timeDiff = time.ElapsedTicks;

                Console.WriteLine((array[i]) + ";" + time.ElapsedTicks + ";" + isPrimeInstr(array[i], count));
            }
        }

        static bool isPrime(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else
                for (BigInteger u = 3; u < Num / 2; u += 2)
                {
                    if (Num % u == 0) return false;
                }

            return true;
        }

        static int isPrimeInstr(BigInteger Num, int count)
        {
            for (BigInteger u = 3; u < Num / 2; u += 2)
            {
                count++;
            }
            return count;
        }
    }
}
