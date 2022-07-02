using MeasuringDevice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Tests_for_Module_10
{
    /// <summary>
    ///This is a test class for MeasureDataDeviceTest and is intended
    ///to contain all MeasureDataDeviceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MeasureDataDeviceTest
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


        internal virtual MeasureDataDevice CreateMeasureDataDevice()
        {
            MeasureDataDevice target = new MeasureMassDevice(Units.Imperial, "TestLog.txt");
            return target;
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetLoggingFile
        ///</summary>
        [TestMethod()]
        public void GetLoggingFileTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            string expected = "TestLog.txt";
            string actual;
            actual = target.GetLoggingFile();
            Assert.AreEqual(expected, actual);
            target.Dispose();
        }

        /// <summary>
        ///A test for GetRawData
        ///</summary>
        [TestMethod()]
        public void GetRawDataTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.StartCollecting();
            int[] actual;
            actual = target.GetRawData();
            Assert.IsNotNull(actual);
            target.StopCollecting();
            target.Dispose();
        }

        /// <summary>
        ///A test for ImperialValue
        ///</summary>
        [TestMethod()]
        public void ImperialValueTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.StartCollecting();
            Decimal actual;
            actual = target.ImperialValue();
            Assert.IsNotNull(actual);
            target.StopCollecting();
            target.Dispose();
        }

        /// <summary>
        ///A test for MetricValue
        ///</summary>
        [TestMethod()]
        public void MetricValueTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.StartCollecting();   
            Decimal actual;
            actual = target.MetricValue();
            Assert.IsNotNull(actual);
            target.StopCollecting();
            target.Dispose();
        }

        /// <summary>
        ///A test for StartCollecting
        ///</summary>
        [TestMethod()]
        public void StartCollectingTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice(); 
            target.StartCollecting();
            target.StopCollecting();
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for StopCollecting
        ///</summary>
        [TestMethod()]
        public void StopCollectingTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.StartCollecting();
            target.StopCollecting();
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DataCaptured
        ///</summary>
        [TestMethod()]
        public void DataCapturedTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.StartCollecting();
            int[] actual;
            actual = target.DataCaptured;
            Assert.IsNotNull(actual);
            target.Dispose();
        }

        /// <summary>
        ///A test for LoggingFileName
        ///</summary>
        [TestMethod()]
        public void LoggingFileNameTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            string expected = "NewTestLogFile.txt";
            string actual;
            target.LoggingFileName = expected;
            actual = target.LoggingFileName;
            Assert.AreEqual(expected, actual);
            target.Dispose(); 
        }

        /// <summary>
        ///A test for MostRecentMeasure
        ///</summary>
        [TestMethod()]
        public void MostRecentMeasureTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            target.StartCollecting();
            int actual;
            actual = target.MostRecentMeasure;
            Assert.IsNotNull(actual);
            target.StopCollecting();
            target.Dispose();
        }

        /// <summary>
        ///A test for UnitsToUse
        ///</summary>
        [TestMethod()]
        public void UnitsToUseTest()
        {
            MeasureDataDevice target = CreateMeasureDataDevice();
            Units expected = Units.Imperial;
            Units actual;
            actual = target.UnitsToUse;
            Assert.AreEqual(expected, actual);
            target.Dispose();
        }
    }
}
