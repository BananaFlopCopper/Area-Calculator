using System;
using System.Collections.Generic;

namespace CalcLibrary
{
    public static class AreaCalculator
    {
        private static List<string> numDictionary = new List<string> {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten"   
        };

        public const double Pi = Math.PI;
        // private const int MaxValue = 2147483647; no reason since double is larger than int
        //value of MaxValue^2, since this fits in a double there wont be overflow errors because of this 4611686014132420609
        public static double getSquareArea(int length)
        {   return length * length;   }
        public static double getSquareArea(string wordNum)
        {   //not possible for a fractional number
            int length = 0;
            wordNum = validateInput(wordNum);
            for(int i = 0; i < numDictionary.Count; i++) { 
                if (wordNum.Contains(numDictionary[i])) 
                { length = i; } 
            }

            return length*length;
        }

        public static double getRectangularArea (int height, int length)
        {   return height * length;   }

        public static double getParallelogramArea (int height, int length)
        { return getRectangularArea(height, length); }

        public static double getCircleRadius (int area)
        {
            if (area == 0)
            { return area; }

            double Sum = Math.Sqrt((area / Pi));
            Sum = Math.Round(Sum, 2);
            return Sum;
        }

        public static double getCircleDiameter (int area)
        {
            if (area == 0 ) 
            { return area; }

            double Sum = Math.Sqrt( (area / Pi)*2 );
            Sum = Math.Round(Sum, 2);
            return Sum;
        }

        private static string validateInput(string wordNum)
        {
            if(wordNum == null || wordNum == "")
            { wordNum = "zero"; }

            //wordNum.Trim();
            wordNum.ToLower();
            return wordNum;
        }
    }
}
