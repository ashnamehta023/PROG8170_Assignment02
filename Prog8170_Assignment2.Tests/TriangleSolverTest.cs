using System;
using NUnit.Framework;

namespace Prog8170_Assignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        string output;

        /*
         Test Case : 1
         Test Description : Analyze the length of three side lengths provided by the user.
         Input provided : 2,2,3
         Expected Output: Triangle can be formed. It will form Isosceles triangle
          */
        [Test]
        public void TestAnalyze_Input2_2_3_ExpectedOuptut_WillFormIsocelesTriangle()
        {
            output = TriangleSolver.Analyze(2,2,3);
            Assert.AreEqual("Triangle can be formed. It will form Isosceles triangle", output);
        }

        /*
         Test Case : 2
         Test Description : Analyze the length of three side lengths provided by the user.
         Input provided : 9,9,12
         Expected Output: Triangle can be formed. It will form Isosceles triangle
          */
        [Test]
        public void TestAnalyze_Input9_9_10_ExpectedOuptut_WillFormIsocelesTriangle()
        {
            output = TriangleSolver.Analyze(9,9,12);
            Assert.AreEqual("Triangle can be formed. It will form Isosceles triangle", output);
        }

        /*
         Test Case : 3
         Test Description : Analyze the length of three side lengths provided by the user.
         Input provided : 9,9,9
         Expected Output: Triangle can be formed. It will form Equilateral triangle
          */
        [Test]
        public void TestAnalyze_Input9_9_9_ExpectedOuptut_WillFormEquilateralTriangle()
        {
            output = TriangleSolver.Analyze(9,9,9);
            Assert.AreEqual("Triangle can be formed. It will form Equilateral triangle", output);
        }

        /*
         Test Case : 4
         Test Description : Analyze the length of three side lengths provided by the user.
         Input provided : 12,12,12
         Expected Output: Triangle can be formed. It will form Equilateral triangle
          */
        [Test]
        public void TestAnalyze_Input12_12_12_ExpectedOuptut_WillFormEquilateralTriangle()
        {
            output = TriangleSolver.Analyze(12,12,12);
            Assert.AreEqual("Triangle can be formed. It will form Equilateral triangle", output);
        }

        /*
         Test Case : 5
         Test Description : Analyze the length of three side lengths provided by the user.
         Input provided : 10,11,7
         Expected Output: Triangle can be formed. It will form Scalene triangle
          */
        [Test]
        public void TestAnalyze_Input10_11_7_ExpectedOuptut_WillFormSacaleneTriangle()
        {
            output = TriangleSolver.Analyze(10,11,7);
            Assert.AreEqual("Triangle can be formed. It will form Scalene triangle", output);
        }

        /*
         Test Case : 6
         Test Description : Analyze the length of three side lengths provided by the user.
         Input provided : 9,9,9
         Expected Output: Triangle can be formed. It will form Scalene triangle
          */
        [Test]
        public void TestAnalyze_Input5_9_6_ExpectedOuptut_WillFormSacaleneTriangle()
        {
            output = TriangleSolver.Analyze(5,9,6);
            Assert.AreEqual("Triangle can be formed. It will form Scalene triangle", output);
        }

        /*
        Test Case : 7
        Test Description : Analyze the length of three side lengths provided by the user.
        Input provided : 0,0,0
        Expected Output: No side of a triangle can be Zero or negative
         */
        [Test]
        public void TestAnalyzeInput_0_0_0_ExpectedOuptut_NotFormTriangle()
        {
            output = TriangleSolver.Analyze(0,0,0);
            Assert.AreEqual("No side of a triangle can be Zero or negative", output);
        }

        /*
        Test Case : 8
        Test Description : Analyze the length of three side lengths provided by the user.
        Input provided : -2,2,3
        Expected Output: No side of a triangle can be Zero or negative
         */
        [Test]
        public void TestAnalyze_Input_2_2_3_ExpectedOuptut_WillNotFormTriangle()
        {
            output = TriangleSolver.Analyze(-2,2,3);
            Assert.AreEqual("No side of a triangle can be Zero or negative", output);
        }
    }
}
