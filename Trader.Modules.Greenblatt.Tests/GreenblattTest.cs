using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trader.Modules.Greenblatt.Tests
{
    
    
    /// <summary>
    ///This is a test class for GreenblattTest and is intended
    ///to contain all GreenblattTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GreenblattTest
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
        ///A test for Greenblatt Constructor
        ///</summary>
        [TestMethod()]
        public void GreenblattConstructorTest()
        {
            IRegionManager regionManager = null; // TODO: Initialize to an appropriate value
            ILoggerFacade logger = null; // TODO: Initialize to an appropriate value
            IUnityContainer container = null; // TODO: Initialize to an appropriate value
            Greenblatt target = new Greenblatt(regionManager, logger, container);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            IRegionManager regionManager = null; // TODO: Initialize to an appropriate value
            ILoggerFacade logger = null; // TODO: Initialize to an appropriate value
            IUnityContainer container = null; // TODO: Initialize to an appropriate value
            Greenblatt target = new Greenblatt(regionManager, logger, container); // TODO: Initialize to an appropriate value
            target.Initialize();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
