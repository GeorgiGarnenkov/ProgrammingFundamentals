namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class Files
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> allFiles = new List<string>();

            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string filter = Console.ReadLine();
            var filterTokens = filter.Split(new string[] {" in "}, StringSplitOptions.RemoveEmptyEntries);
            var filterExt = "." + filterTokens[0];
            var filterRoots = filterTokens[1] + @"\";

            Dictionary<string, int> fileSize = new Dictionary<string, int>();

            foreach (var f in allFiles)
            {
                var filePlusSize = f.Split(';');
                var size = int.Parse(filePlusSize[1]);
                var path = filePlusSize[0];

                if (path.StartsWith(filterRoots) && path.EndsWith(filterExt))
                {
                    var tokens = path.Split('\\');
                    var fileName = tokens[tokens.Length - 1];
                    fileSize[fileName] = size;
                }
            }
            var sortedOutputFiles = fileSize
                .OrderByDescending(fs => fs.Value)
                .ThenBy(fs => fs.Key);

            foreach (var file in sortedOutputFiles)
            {
                Console.WriteLine(file.Key + " - " + file.Value + " KB");
            }
            if (sortedOutputFiles.Count() == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
