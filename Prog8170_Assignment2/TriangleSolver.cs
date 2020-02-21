using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment2
{
    public class TriangleSolver
    {
        public static string Analyze(int sideOne, int sideTwo, int sideThree)
        {
            string triangleType = "No data for side length available";
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                triangleType = "No side of a triangle can be Zero or negative";
            }
            else if (sideOne == sideTwo && sideTwo == sideThree)
            {
                triangleType = "Triangle can be formed. It will form Equilateral triangle";
            }
            else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
                {
                    triangleType = "Will not form a triangle. Sum of 2 sides should be greater than the largest side";
                }
                else
                {
                    triangleType = "Triangle can be formed. It will form Isosceles triangle";
                }
            }
            else if (sideOne != sideTwo || sideOne != sideThree || sideTwo != sideThree)
            {
                if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
                {
                    triangleType = "Will not form a triangle. Sum of 2 sides should be greater than the largest side";

                }
                else
                {
                    triangleType = "Triangle can be formed. It will form Scalene triangle";
                }
            }
            return triangleType;
        }
    }
}
