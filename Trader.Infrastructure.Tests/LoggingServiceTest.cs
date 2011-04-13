using Microsoft.Practices.Prism.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trader.Infrastructure.Services;

namespace Trader.Infrastructure.Tests
{
    
    
    /// <summary>
    ///This is a test class for LoggingServiceTest and is intended
    ///to contain all LoggingServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LoggingServiceTest
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
        ///A test for LoggingService Constructor
        ///</summary>
        [TestMethod()]
        public void LoggingServiceConstructorTest()
        {
            LoggingService target = new LoggingService();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Log
        ///</summary>
        [TestMethod()]
        public void LogTest()
        {
            LoggingService target = new LoggingService(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            Category category = new Category(); // TODO: Initialize to an appropriate value
            Priority priority = new Priority(); // TODO: Initialize to an appropriate value
            target.Log(message, category, priority);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
