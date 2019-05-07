namespace PokeMon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;


    public class PokeMon
    {
        public static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            long Y = long.Parse(Console.ReadLine());

            long counter = 0;

            long nInHalf = N / 2;

            bool isTrue = true;
            
            while (isTrue)
            {
                N -= M;

                if (N == nInHalf && Y > 0)
                {
                    N /= Y;
                }

                counter++;

                if (N < M)
                {
                    isTrue = false;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}
