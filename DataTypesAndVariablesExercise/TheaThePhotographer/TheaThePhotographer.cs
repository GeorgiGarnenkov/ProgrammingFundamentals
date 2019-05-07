using System;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            
            long filteredPictures = (long)(Math.Ceiling(numberOfPictures * filterFactor / 100d));
            long totalPicturesSec = numberOfPictures * filterTime;
            long filteredPicturesSec = filteredPictures * uploadTime;
            long totalSecs = totalPicturesSec + filteredPicturesSec;

            TimeSpan allTime = TimeSpan.FromSeconds(totalSecs);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                allTime.Days,
                allTime.Hours,
                allTime.Minutes,
                allTime.Seconds);
        }
    }
}
