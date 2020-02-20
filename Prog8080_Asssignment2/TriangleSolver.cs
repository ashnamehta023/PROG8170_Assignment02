using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8080_Asssignment2
{
    class TriangleSolver
    {
        public static string Analyze(int sideOne, int sideTwo, int sideThree)
        {
            string result = "";
            string traingleType;
            if (IsTriangleSidesValid(sideOne, sideTwo, sideThree)==0)
            {
                Console.WriteLine("\n These dimensions can form a triangle");
                traingleType = CheckTriagnleType(sideOne, sideTwo, sideThree);
                result = traingleType;
            }
            else
            {
                result = "These dimensions could not form a triangle";
            }
            return result;
        }
        public static int IsTriangleSidesValid(int sideOne, int sideTwo, int sideThree)
        {
            if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static string CheckTriagnleType(int sideOne, int sideTwo, int sideThree)
        {
            string triangleType = "nothing defined";
            if (sideOne == sideTwo && sideTwo == sideThree)
            {
                triangleType = "Equilateral triangle";
            }
            else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                triangleType = "Isosceles triangle";
            }
            else if(sideOne != sideTwo || sideOne != sideThree || sideTwo != sideThree)
            {
                triangleType = "Scalene triangle";
            }
            return triangleType;
        }
    }
}
