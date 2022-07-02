using MatrixOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Unit_Tests_for_Module_10
{


    /// <summary>
    ///This is a test class for MatrixTest and is intended
    ///to contain all MatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MatrixTest
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
        ///A test for Matrix Constructor
        ///</summary>
        [TestMethod()]
        public void MatrixConstructorTest()
        {
            int Size = 3;
            Matrix target = new Matrix(Size);
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int Size = 3;
            Matrix target = new Matrix(Size);
            target[0, 0] = 1;
            target[0, 1] = 1;
            target[0, 2] = 1;
            target[1, 0] = 1;
            target[1, 1] = 1;
            target[1, 2] = 1;
            target[2, 0] = 1;
            target[2, 1] = 1;
            target[2, 2] = 1;

            string expected = System.String.Format("1\t1\t1{0}1\t1\t1{0}1\t1\t1", System.Environment.NewLine);
            string actual;
            actual = target.ToString();
            StringAssert.Equals(expected, actual);
        }

        /// <summary>
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest()
        {
            Matrix Matrix1 = new Matrix(3);
            Matrix1[0, 0] = 1;
            Matrix1[0, 1] = 1;
            Matrix1[0, 2] = 1;
            Matrix1[1, 0] = 1;
            Matrix1[1, 1] = 1;
            Matrix1[1, 2] = 1;
            Matrix1[2, 0] = 1;
            Matrix1[2, 1] = 1;
            Matrix1[2, 2] = 1;
            Matrix Matrix2 = new Matrix(3);
            Matrix2[0, 0] = 1;
            Matrix2[0, 1] = 1;
            Matrix2[0, 2] = 1;
            Matrix2[1, 0] = 1;
            Matrix2[1, 1] = 1;
            Matrix2[1, 2] = 1;
            Matrix2[2, 0] = 1;
            Matrix2[2, 1] = 1;
            Matrix2[2, 2] = 1;
            Matrix expected = new Matrix(3);
            expected[0, 0] = 2;
            expected[0, 1] = 2;
            expected[0, 2] = 2;
            expected[1, 0] = 2;
            expected[1, 1] = 2;
            expected[1, 2] = 2;
            expected[2, 0] = 2;
            expected[2, 1] = 2;
            expected[2, 2] = 2;
            Matrix actual;
            actual = (Matrix1 + Matrix2);
            Assert.AreEqual(expected[0, 0], actual[0, 0]);
            Assert.AreEqual(expected[0, 2], actual[0, 2]);
            Assert.AreEqual(expected[0, 1], actual[0, 1]);
            Assert.AreEqual(expected[2, 2], actual[2, 2]);

            try
            {
                Matrix Matrix4 = new Matrix(4);
                Matrix Matrix5 = new Matrix(5);
                Matrix Matrix6 = Matrix4 + Matrix5;
            }
            catch (MatrixNotCompatibleException)
            {
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest()
        {
            Matrix Matrix1 = new Matrix(3);
            Matrix1[0, 0] = 1;
            Matrix1[0, 1] = 1;
            Matrix1[0, 2] = 1;
            Matrix1[1, 0] = 1;
            Matrix1[1, 1] = 1;
            Matrix1[1, 2] = 1;
            Matrix1[2, 0] = 1;
            Matrix1[2, 1] = 1;
            Matrix1[2, 2] = 1;
            Matrix Matrix2 = new Matrix(3);
            Matrix2[0, 0] = 1;
            Matrix2[0, 1] = 1;
            Matrix2[0, 2] = 1;
            Matrix2[1, 0] = 1;
            Matrix2[1, 1] = 1;
            Matrix2[1, 2] = 1;
            Matrix2[2, 0] = 1;
            Matrix2[2, 1] = 1;
            Matrix2[2, 2] = 1;
            Matrix expected = new Matrix(3);
            expected[0, 0] = 3;
            expected[0, 1] = 3;
            expected[0, 2] = 3;
            expected[1, 0] = 3;
            expected[1, 1] = 3;
            expected[1, 2] = 3;
            expected[2, 0] = 3;
            expected[2, 1] = 3;
            expected[2, 2] = 3;
            Matrix actual;
            actual = (Matrix1 * Matrix2);
            Assert.AreEqual(expected[0, 0], actual[0, 0]);
            Assert.AreEqual(expected[0, 2], actual[0, 2]);
            Assert.AreEqual(expected[0, 1], actual[0, 1]);
            Assert.AreEqual(expected[2, 2], actual[2, 2]);

            try
            {
                Matrix Matrix4 = new Matrix(4);
                Matrix Matrix5 = new Matrix(5);
                Matrix Matrix6 = Matrix4 * Matrix5;
            }
            catch (MatrixNotCompatibleException)
            {
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        ///A test for op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest()
        {
            Matrix Matrix1 = new Matrix(3);
            Matrix1[0, 0] = 1;
            Matrix1[0, 1] = 1;
            Matrix1[0, 2] = 1;
            Matrix1[1, 0] = 1;
            Matrix1[1, 1] = 1;
            Matrix1[1, 2] = 1;
            Matrix1[2, 0] = 1;
            Matrix1[2, 1] = 1;
            Matrix1[2, 2] = 1;
            Matrix Matrix2 = new Matrix(3);
            Matrix2[0, 0] = 1;
            Matrix2[0, 1] = 1;
            Matrix2[0, 2] = 1;
            Matrix2[1, 0] = 1;
            Matrix2[1, 1] = 1;
            Matrix2[1, 2] = 1;
            Matrix2[2, 0] = 1;
            Matrix2[2, 1] = 1;
            Matrix2[2, 2] = 1;
            Matrix expected = new Matrix(3);
            expected[0, 0] = 0;
            expected[0, 1] = 0;
            expected[0, 2] = 0;
            expected[1, 0] = 0;
            expected[1, 1] = 0;
            expected[1, 2] = 0;
            expected[2, 0] = 0;
            expected[2, 1] = 0;
            expected[2, 2] = 0;
            Matrix actual;
            actual = (Matrix1 - Matrix2);
            Assert.AreEqual(expected[0, 0], actual[0, 0]);
            Assert.AreEqual(expected[0, 2], actual[0, 2]);
            Assert.AreEqual(expected[0, 1], actual[0, 1]);
            Assert.AreEqual(expected[2, 2], actual[2, 2]);

            try
            {
                Matrix Matrix4 = new Matrix(4);
                Matrix Matrix5 = new Matrix(5);
                Matrix Matrix6 = Matrix4 - Matrix5;
            }
            catch (MatrixNotCompatibleException)
            {
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            int Size = 2;
            Matrix target = new Matrix(Size);
            target[0, 0] = 0;
            target[0, 1] = 1;
            target[1, 0] = 2;
            target[1, 1] = 3;

            int RowIndex = 0;
            int ColumnIndex = 0;
            int expected = 0;
            int actual;
            target[RowIndex, ColumnIndex] = expected;
            actual = target[RowIndex, ColumnIndex];
            Assert.AreEqual(expected, actual);
            RowIndex = 1;
            ColumnIndex = 1;
            expected = 3;
            target[RowIndex, ColumnIndex] = expected;
            actual = target[RowIndex, ColumnIndex];
            Assert.AreEqual(expected, actual);
        }
    }
}
