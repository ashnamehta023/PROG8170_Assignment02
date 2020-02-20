using System;
using NUnit.Framework;

namespace Prog8170_Assignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        string output;
        
        [Test]
        public void TestAnalyze_Input2_2_3_ExpectedOuptut_WillFormIsocelesTriangle()
        {
            output = TriangleSolver.Analyze(2,2,3);
            Assert.AreEqual("Triangle can be formed. It will form Isosceles triangle", output);
        }

        [Test]
        public void TestAnalyze_Input9_9_10_ExpectedOuptut_WillFormIsocelesTriangle()
        {
            output = TriangleSolver.Analyze(9,9,12);
            Assert.AreEqual("Triangle can be formed. It will form Isosceles triangle", output);
        }

        [Test]
        public void TestAnalyze_Input9_9_9_ExpectedOuptut_WillFormEquilateralTriangle()
        {
            output = TriangleSolver.Analyze(9,9,9);
            Assert.AreEqual("Triangle can be formed. It will form Equilateral triangle", output);
        }
       
        [Test]
        public void TestAnalyze_Input12_12_12_ExpectedOuptut_WillFormEquilateralTriangle()
        {
            output = TriangleSolver.Analyze(12,12,12);
            Assert.AreEqual("Triangle can be formed. It will form Equilateral triangle", output);
        }
        [Test]
        public void TestAnalyze_Input10_11_7_ExpectedOuptut_WillFormSacaleneTriangle()
        {
            output = TriangleSolver.Analyze(10,11,7);
            Assert.AreEqual("Triangle can be formed. It will form Scalene triangle", output);
        }
        [Test]
        public void TestAnalyze_Input5_9_6_ExpectedOuptut_WillFormSacaleneTriangle()
        {
            output = TriangleSolver.Analyze(5,9,6);
            Assert.AreEqual("Triangle can be formed. It will form Scalene triangle", output);
        }

        [Test]
        public void TestAnalyzeInput_0_0_0_ExpectedOuptut_NotFormTriangle()
        {
            output = TriangleSolver.Analyze(0,0,0);
            Assert.AreEqual("No side of a triangle can be Zero", output);
        }
        [Test]
        public void TestAnalyze_Input_2_2_3_ExpectedOuptut_WillNotFormTriangle()
        {
            output = TriangleSolver.Analyze(-2,2,3);
            Assert.AreEqual("Will not form a triangle. Sum of 2 sides should be greater than the largest side", output);
        }
    }
}
