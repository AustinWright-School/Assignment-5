using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;

namespace Assignment_5
{
    public static class TriangleUtility
    {
        public static string DetectTriangleType(int s1, int s2, int s3)
        {
            string typeString = "";
            List<int> sides = new List<int>();
            
            sides.Add(s1);
            sides.Add(s2);
            sides.Add(s3);
            sides.Sort();

            if ((sides[0] + sides[1]) <= sides[2]) return "Not a triangle";

            //trinagle by sides
            if (s1 == s2 && s2 == s3)
            {
                typeString += "Equilateral ";
            } 
            else if ( s1 == s2 || s2 == s3 || s3 == s1)
            {
                typeString =  "Isosceles ";
            }
            else if (s1 != s2 && s2 != s3 && s3 != s1)
            {
                typeString = "Scalene ";
            }

            int hypotenuseSquared = sides[2] * sides[2];
            int sumShorterSquared = (sides[1] * sides[1]) + (sides[0] * sides[0]);

            //triangle by corner radius
            if (hypotenuseSquared > sumShorterSquared)
            {
                typeString += "Obtuse ";
            }
            else if (hypotenuseSquared < sumShorterSquared)
            {
                typeString += "Acute ";
            }
            else if (hypotenuseSquared == sumShorterSquared)
            {
                typeString += "Right ";
            }

            return typeString += "Triangle";
        }
    }
}
