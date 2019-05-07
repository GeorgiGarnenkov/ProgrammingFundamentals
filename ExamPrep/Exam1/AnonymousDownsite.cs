using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class AnonymousDownsite
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal securityKey = decimal.Parse(Console.ReadLine());


            List<string> sites = new List<string>();
            decimal siteLoss = 0;
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var siteVisits = decimal.Parse(data[1]);
                var siteCommercialPricePerVisit = decimal.Parse(data[2]);
                siteLoss += siteVisits * siteCommercialPricePerVisit;
                sites.Add(data[0]);
            }
            foreach (var s in sites)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < n; i++)
            {
                securityKey *= securityKey;
            }

            Console.WriteLine($"Total Loss: {siteLoss:f20}");

            Console.WriteLine($"Security Token: {securityKey}");
        }
    }
}
