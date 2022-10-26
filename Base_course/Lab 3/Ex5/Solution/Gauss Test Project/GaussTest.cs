using GaussianElimination;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Gauss_Test_Project
{


    /// <summary>
    ///This is a test class for GaussTest and is intended
    ///to contain all GaussTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GaussTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SolveGaussian
        ///</summary>
        [TestMethod()]
        public void SolveGaussianTest()
        {
            double[,] coefficients = { { 2d, 1d, -1d, 1d }, { -3d, -1d, 2d, 1d }, { -2d, 1d, -2d, 0d }, { 3d, -1d, 2d, -2d } };
            double[] rhs = { 8d, -11d, -3d, -5d };
            double[] expected = { 4d, -17d, -11d, 6d };
            double[] actual;
            actual = Gauss.SolveGaussian(coefficients, rhs);
            Assert.AreEqual(expected[0], actual[0], 0.0001);
            Assert.AreEqual(expected[1], actual[1], 0.0001);
            Assert.AreEqual(expected[2], actual[2], 0.0001);
            Assert.AreEqual(expected[3], actual[3], 0.0001);
        }
        [TestMethod()]
        public void SolveGaussianTest1()
        {
            double[,] coefficients = 
    { 
        { 2d, 1d, -1d, 1d }, 
        { -3d, -1d, 2d, 1d }, 
        { -2d, 1d, -2d, 0d }, 
        { 3d, -1d, 2d, -2d } 
    };
            double[,] expected_coefficients = 
    { 
         { 2d, 1d, -1d, 1d }, 
         { -3d, -1d, 2d, 1d }, 
         { -2d, 1d, -2d, 0d }, 
         { 3d, -1d, 2d, -2d } 
    };
            double[] rhs = { 8d, -11d, -3d, -5d };
            double[] expected = { 4d, -17d, -11d, 6d };
            double[] actual;
            actual = Gauss.SolveGaussian(coefficients, rhs);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(expected_coefficients[i, j],
                        coefficients[i, j]);
                }
            }
        }

        [TestMethod()]
        public void SolveGaussianTest2()
        {
            double[,] coefficients = 
    { 
        { 2d, 1d, -1d, 1d }, 
        { -3d, -1d, 2d, 1d }, 
        { -2d, 1d, -2d, 0d }, 
        { 3d, -1d, 2d, -2d } 
    };
            double[] rhs = { 8d, -11d, -3d, -5d };
            double[] expected_rhs = { 8d, -11d, -3d, -5d };
            double[] expected = { 4d, -17d, -11d, 6d };
            double[] actual;
            actual = Gauss.SolveGaussian(coefficients, rhs);
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(expected_rhs[i], rhs[i]);
            }
        }

    }
}
