using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {
            long fieldSize = long.Parse(Console.ReadLine());

            long[] bugPlaces = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] field = new long[fieldSize];

            for (long i = 0; i < fieldSize; i++)
            {
                if (bugPlaces.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var commandArgs = input.Split(' ');

                long bugPosition = long.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                long moves = long.Parse(commandArgs[2]);

                if (bugPosition < 0 || bugPosition >= field.Length)
                {
                    continue;
                }
                else if (field[bugPosition] == 0)
                {
                    continue;
                }
                else if (field[bugPosition] == 1)
                {
                    if (direction == "right")
                    {
                        if (moves > 0)
                        {
                            MoveRight(field, bugPosition, moves);
                        }
                        else
                        {
                            MoveLeft(field, bugPosition, Math.Abs(moves));
                        }
                    }
                    if (direction == "left")
                    {
                        if (moves > 0)
                        {
                            MoveLeft(field, bugPosition, moves);
                        }
                        else
                        {
                            MoveRight(field, bugPosition, Math.Abs(moves));
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", field));
        }

        static void MoveRight(long[] field, long bugPosition, long moves)
        {
            if (bugPosition + moves >= field.Length)
            {
                field[bugPosition] = 0;
            }
            else
            {
                field[bugPosition] = 0;
                for (long i = bugPosition + moves; i < field.Length; i += moves)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
        }

        static void MoveLeft(long[] field, long bugPosition, long moves)
        {
            if (bugPosition - moves < 0)
            {
                field[bugPosition] = 0;
            }
            else
            {
                field[bugPosition] = 0;
                for (long i = bugPosition - moves; i > -1; i -= moves)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
        }
    }
}
