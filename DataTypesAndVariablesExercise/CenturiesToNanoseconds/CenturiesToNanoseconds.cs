using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            short centuries = short.Parse(Console.ReadLine());
            
            int years = centuries * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = Math.Floor(days * 24);
            double minutes = hours * 60;
            decimal seconds = (decimal)(minutes * 60);
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} " +
                $"seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");



        }
    }
}
