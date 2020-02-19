using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8080_Asssignment2
{
    class TriangleSolver
    {
        public static string Analyze(int firstDimension, int secondDimension, int thridDimension)
        {
            
            string opString = "These dimensions could not form a triangle";
            string triangleName;
            if (CheckValidityOfDimensions(firstDimension, secondDimension, thridDimension))
            {
                Console.WriteLine("\n These dimensions can form a triangle");
                triangleName = CheckTriangle(firstDimension, secondDimension, thridDimension);
                opString = triangleName;
                
            }
            else
            {
                //Console.WriteLine(opString);
            }
            return opString;
        }
        public bool IsTriangleValid(int sideOne, int sideTwo, int sideThree)
        {
            if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string CheckTriagnleType(int sideOne, int sideTwo, int sideThree)
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
            else
            {
                triangleType = "Scalene triangle";
            }
            return triangleType;
        }
    
}
}
