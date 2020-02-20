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
            string result = CheckTriagnleType(sideOne, sideTwo, sideThree);
            return result;
        }

        public static string CheckTriagnleType(int sideOne, int sideTwo, int sideThree)
        {
            string triangleType = "nothing defined";
            if(sideOne == 0 || sideTwo == 0 || sideThree == 0)
            {
                triangleType = "No side of a triangle can be Zero\n----------------------\n";
            }
            else if (sideOne == sideTwo && sideTwo == sideThree)
            {
                Console.WriteLine("\n These dimensions can form a triangle\n");
                triangleType = "Equilateral triangle";
            }
            else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                if (sideOne + sideTwo >= sideThree && sideOne + sideThree >= sideTwo && sideTwo + sideThree >= sideOne)
                {
                    triangleType = "These dimensions can not form a triangle\n----------------------\n";
                }
                else
                {
                    triangleType = "These dimensions can form a triangle.\n Isosceles triangle\n----------------------\n";
                }
            }
            else if (sideOne != sideTwo || sideOne != sideThree || sideTwo != sideThree)
            {
                if (sideOne + sideTwo >= sideThree && sideOne + sideThree >= sideTwo && sideTwo + sideThree >= sideOne)
                {
                    triangleType = "These dimensions can not form a triangle\n----------------------\n";
                }
                else
                {
                    triangleType = "These dimensions can form a triangle.\nScalene triangle\n----------------------\n";
                }
            }
            return triangleType;
        }
    }
}
