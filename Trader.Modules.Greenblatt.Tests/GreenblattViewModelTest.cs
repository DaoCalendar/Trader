using System.Windows.Input;
using Microsoft.Practices.Prism.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trader.Modules.Greenblatt.Models;
using Trader.Modules.Greenblatt.ViewModels;

namespace Trader.Modules.Greenblatt.Tests
{
    
    
    /// <summary>
    ///This is a test class for GreenblattViewModelTest and is intended
    ///to contain all GreenblattViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GreenblattViewModelTest
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
        ///A test for GreenblattViewModel Constructor
        ///</summary>
        [TestMethod()]
        public void GreenblattViewModelConstructorTest()
        {
            IGreenblattModel model = null; // TODO: Initialize to an appropriate value
            GreenblattViewModel target = new GreenblattViewModel(model);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MyCommand
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Trader.Modules.Greenblatt.dll")]
        public void MyCommandTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            GreenblattViewModel_Accessor target = new GreenblattViewModel_Accessor(param0); // TODO: Initialize to an appropriate value
            target.MyCommand();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GoCommand
        ///</summary>
        [TestMethod()]
        public void GoCommandTest()
        {
            IGreenblattModel model = null; // TODO: Initialize to an appropriate value
            GreenblattViewModel target = new GreenblattViewModel(model); // TODO: Initialize to an appropriate value
            ICommand expected = null; // TODO: Initialize to an appropriate value
            ICommand actual;
            target.GoCommand = expected;
            actual = target.GoCommand;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Logger
        ///</summary>
        [TestMethod()]
        public void LoggerTest()
        {
            IGreenblattModel model = null; // TODO: Initialize to an appropriate value
            GreenblattViewModel target = new GreenblattViewModel(model); // TODO: Initialize to an appropriate value
            ILoggerFacade expected = null; // TODO: Initialize to an appropriate value
            ILoggerFacade actual;
            target.Logger = expected;
            actual = target.Logger;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Model
        ///</summary>
        [TestMethod()]
        public void ModelTest()
        {
            IGreenblattModel model = null; // TODO: Initialize to an appropriate value
            GreenblattViewModel target = new GreenblattViewModel(model); // TODO: Initialize to an appropriate value
            IGreenblattModel expected = null; // TODO: Initialize to an appropriate value
            IGreenblattModel actual;
            target.Model = expected;
            actual = target.Model;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Text
        ///</summary>
        [TestMethod()]
        public void TextTest()
        {
            IGreenblattModel model = null; // TODO: Initialize to an appropriate value
            GreenblattViewModel target = new GreenblattViewModel(model); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Text = expected;
            actual = target.Text;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
