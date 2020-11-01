using System;
using System.IO;
using static System.Math;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllText(@"Triangles.txt").Split("\r\n");

            foreach(string line in lines)
            {
                if (line[0] == '#')
                {
                    Console.WriteLine(line);
                }
                else
                {
                    string[] lentghsAsStrings = line.Split(" ");
                    Console.WriteLine(TriangleUtility.DetectTriangleType(
                        int.Parse(lentghsAsStrings[0]),
                        int.Parse(lentghsAsStrings[1]),
                        int.Parse(lentghsAsStrings[2])));
                }
            }
            Console.ReadKey();
        }
    }
}
