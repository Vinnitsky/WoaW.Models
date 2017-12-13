using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoaW.Models.Parties.Persons;
using WoaW.Models.Parties.Relationship;
using WoaW.Models.Parties.CRM;
using System;

namespace WoaW.Models.Parties.UnitTests.CRM
{
    /// <summary>
    /// Summary description for CRM_UnitTests
    /// </summary>
    [TestClass]
    public class Communication_UnitTests
    {
        public Communication_UnitTests()
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
        public void AddCommunications_SuccessTest()
        {
            var customerRoleType = new PartyRoleType("Customer");
            var customerRole = new PartyRole(customerRoleType);
            var customerRelationshipType = new PartyRelationshipType("Customers relationship");
            var customerRelationship = new PartyRelationship(customerRelationshipType);
            customerRelationship.AddRole(customerRole);

            var vlad = new Person();
            customerRelationship.Assign(customerRole, vlad);
            var ilona = new Person();
            customerRelationship.Assign(customerRole, ilona);

            var customerServiceRepresentativeRoleType = new PartyRoleType("CustomerServiceRepresentative");
            var customerServiceRepresentativeRole = new PartyRole(customerServiceRepresentativeRoleType);
            var communicationRelationshipType = new PartyRelationshipType("Communication relationship");
            var communicationRelationship = new Communication(communicationRelationshipType);
            communicationRelationship.AddRole(customerServiceRepresentativeRole);

            communicationRelationship.Assign(customerServiceRepresentativeRole, vlad);
            communicationRelationship.Assign(customerServiceRepresentativeRole, ilona);

            var customerCommunicationManager = new CustomerCommunicationManager();
            var customerServiceCase = new CustomerServiceCase(new CustomerServiceCaseIdentifier(Guid.NewGuid()));
            customerCommunicationManager.AddCustomerServiceCases(customerServiceCase);
            var thread1 = new CommunicationThread();
            customerServiceCase.AddThread(thread1);
            var communication = new Communication(communicationRelationshipType);
            thread1.AddCommunication(communicationRelationship);


        }
    }
}
