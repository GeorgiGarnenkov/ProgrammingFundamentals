namespace Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;


    public class Weathers
    {
        public string City { get; set; }

        public string Temperature { get; set; }

        public string WeatherType { get; set; }

    }

    public class Weather
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([A-Z]{2})(\d{2}\.\d{1,2})(\w+[A-Za-z])\|";

            List<Weathers> weathersValues = new List<Weathers>();

            while (input != "End" && input != "end")
            {

                MatchCollection take = Regex.Matches(input, pattern);


                Weathers weatherr = new Weathers();
                
                foreach (Match w in take)
                {
                    if (!weathersValues.Any(c => c.City == w.Groups[1].Value))
                    {
                        weatherr.City = w.Groups[1].Value;
                        weatherr.Temperature = w.Groups[2].Value;
                        weatherr.WeatherType = w.Groups[3].Value;
                        weathersValues.Add(weatherr);
                    }
                    else if (weathersValues.Any(c => c.City == w.Groups[1].Value))
                    {
                        for (int i = 0; i < weathersValues.Count; i++)
                        {
                            if (weathersValues[i].City.Contains(w.Groups[1].Value))
                            {
                                weathersValues[i].City = w.Groups[1].Value;
                                weathersValues[i].Temperature = w.Groups[2].Value;
                                weathersValues[i].WeatherType = w.Groups[3].Value;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var weather in weathersValues
                .OrderBy(s => s.Temperature)
                .Distinct()
                .ToList())
            {
                Console.WriteLine($"{weather.City} => {double.Parse(weather.Temperature):f2} => {weather.WeatherType}");
            }
        }
    }
}
