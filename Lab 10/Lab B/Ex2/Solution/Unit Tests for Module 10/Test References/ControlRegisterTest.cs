using ControlRegisterIndexing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Unit_Tests_for_Module_10
{


    /// <summary>
    ///This is a test class for ControlRegisterTest and is intended
    ///to contain all ControlRegisterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ControlRegisterTest
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
        ///A test for RegisterData
        ///</summary>
        [TestMethod()]
        public void RegisterDataTest()
        {
            ControlRegister target = new ControlRegister(); 
            int expected = 2; 
            int actual;
            target.RegisterData = expected;
            actual = target.RegisterData;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            ControlRegister target = new ControlRegister();
            target.RegisterData = 2;
            int index = 0; 
            int expected = 0;
            int actual;
            actual = target[index];
            Assert.AreEqual(expected, actual);
            index = 1;
            expected = 1;
            actual = target[index];
            Assert.AreEqual(expected, actual);
            index = 0;
            expected = 3;
            target[index] = 1;
            actual = target.RegisterData;
            Assert.AreEqual(expected, actual);
        }
    }
}
