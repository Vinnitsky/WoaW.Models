using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoaW.Models.Parties.Persons;
using WoaW.Models.Parties.Relationship;

namespace WoaW.Models.Parties.UnitTests.CRM
{
    /// <summary>
    /// Summary description for CRM_UnitTests
    /// </summary>
    [TestClass]
    public class CRM_UnitTests
    {
        public CRM_UnitTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestCategory("CRM")]
        [TestMethod]
        public void AddCustomer_SuccessTest()
        {
            var customerRoleType = new PartyRoleType("Customer");
            var customerRole = new PartyRole(customerRoleType);

            var customerRelationshipType = new PartyRelationshipType("Customers relationship");
            var customerRelationship = new PartyRelationship(customerRelationshipType);
            customerRelationship.AddRole(customerRole);

            var vlad = new Person();
            customerRelationship.Assign(customerRole,vlad);

            var ilona = new Person();
            customerRelationship.Assign(customerRole,ilona);
        }
    }
}
