using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string hexaValue = Console.ReadLine();
            int i = Convert.ToInt32(hexaValue, 16);

            Console.WriteLine(i);

        }
    }
}
