using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8080_Asssignment2
{
    class TriangleSolver
    {
        public string CheckTriangle(int sideOne, int sideTwo, int sideThree)
        {
            
            string opString = "";
            string triangleName;
            if (IsTriangleSidesValid(sideOne, sideTwo, sideThree))
            {
                Console.WriteLine("\n These dimensions can form a triangle");
                triangleName = CheckTriangle(sideOne, sideTwo, sideThree);
                opString = triangleName;
                
            }
            else
            {
                opString = "These dimensions could not form a triangle";
            }
            return opString;
        }
        public bool IsTriangleSidesValid(int sideOne, int sideTwo, int sideThree)
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
