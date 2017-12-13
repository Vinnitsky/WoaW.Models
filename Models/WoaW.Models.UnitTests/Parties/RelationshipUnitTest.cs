using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoaW.Models.Parties.Persons;
using WoaW.Models.Parties.Relationship;
using WoaW.Models.Rules;
using WoaW.Models.Parties.Organizations;

namespace WoaW.Models.Parties.UnitTests
{
    [TestClass]
    public class RelationshipUnitTest
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

        /// <summary>
        /// creates famaly from three persons: 
        ///     husband 1972 
        ///     whife  1976 
        ///     children 1996
        /// </summary>
        [TestCategory("Relationship")]
        [TestMethod]
        public void ValidateEntityValueConstraine_SuccessTest()
        {
            var husbandType = new PartyRoleType("Husband");
            var husbendMustBeOlderThen18 = new RuleSet(new Func<object, bool>((x) =>
            {
               var person = x as Person;
               if (person.Age > 18)
                   return true;
               else
                   return false;
            }));
            husbandType.AddRule(husbendMustBeOlderThen18);
            var husbandRole = new PartyRole(husbandType);

            var whifeType = new PartyRoleType("Whife");
            var whifeMustBeOlderThen16 = new RuleSet(new Func<object, bool>((x) =>
            {
               var person = x as Person;
               if (person.Age > 16)
                   return true;
               else
                   return false;
            }));
            whifeType.AddRule(whifeMustBeOlderThen16);
            var whifeRole = new PartyRole(whifeType);

            var childrenType = new PartyRoleType("Children");
            var childrenMustBeYangerThenParents = new RuleSet(new Func<object, bool>((x) =>
            {
               return true;
            }));
            childrenType.AddRule(childrenMustBeYangerThenParents);
            var childrenRole = new PartyRole(childrenType);

            var familyRelationshipTyp = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipTyp.AddConstraint(famalyCanHasHusband);
            var famalyCanHasWhife = new PartyRelationshipConstraint(whifeType);
            familyRelationshipTyp.AddConstraint(famalyCanHasWhife);
            var famalyCanHasChildren = new PartyRelationshipConstraint(childrenType);
            familyRelationshipTyp.AddConstraint(famalyCanHasChildren);

            var familyRelationship = new PartyRelationship(familyRelationshipTyp);
            familyRelationship.AddRole(husbandRole);
            familyRelationship.AddRole(whifeRole);
            familyRelationship.AddRole(childrenRole);

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, husbandRole.Type.Rules.Count());

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, whifeRole.Type.Rules.Count());

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, childrenRole.Type.Rules.Count());

            var john = new Person() { Birthdate = new DateTime(1972, 11, 4) };
            familyRelationship.Assign(husbandRole, john);
            var marry = new Person() { Birthdate = new DateTime(1976, 4, 16) };
            familyRelationship.Assign(whifeRole, marry);
            var gimmy = new Person() { Birthdate = new DateTime(1996, 4, 16) };
            familyRelationship.Assign(childrenRole, gimmy);

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(john).Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(marry).Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(gimmy).Count());
        }

        [TestCategory("Relationship")]
        [TestMethod]
        [ExpectedException(typeof(BreakPartyRulesException))]
        public void ValidateEntityValueConstraine_FailTest()
        {
            var husbandType = new PartyRoleType("Husband");
            var husbendMustBeOderThen18 = new RuleSet(new Func<object, bool>((x) =>
            {
                var person = x as Person;
                if (person.Age > 18)
                    return true;
                else
                    return false;
            }));
            husbandType.AddRule(husbendMustBeOderThen18);
            var husbandRole = new PartyRole(husbandType);

            var whifeType = new PartyRoleType("Whife");
            var whifeMustBeOderThen16 = new RuleSet(new Func<object, bool>((x) =>
            {
                var person = x as Person;
                if (person.Age > 16)
                    return true;
                else
                    return false;
            }));
            whifeType.AddRule(whifeMustBeOderThen16);
            var whifeRole = new PartyRole(whifeType);

            var childrenType = new PartyRoleType("Children");
            var childrenMustBeYangerThenParents = new RuleSet(new Func<object, bool>((x) =>
            {
                return true;
            }));
            childrenType.AddRule(childrenMustBeYangerThenParents);
            var childrenRole = new PartyRole(childrenType);

            var familyRelationshipTyp = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipTyp.AddConstraint(famalyCanHasHusband);
            var famalyCanHasWhife = new PartyRelationshipConstraint(whifeType);
            familyRelationshipTyp.AddConstraint(famalyCanHasWhife);
            var famalyCanHasChildren = new PartyRelationshipConstraint(childrenType);
            familyRelationshipTyp.AddConstraint(famalyCanHasChildren);

            var familyRelationship = new PartyRelationship(familyRelationshipTyp);
            familyRelationship.AddRole(husbandRole);
            familyRelationship.AddRole(whifeRole);
            familyRelationship.AddRole(childrenRole);

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, husbandRole.Type.Rules.Count());

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, whifeRole.Type.Rules.Count());

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, childrenRole.Type.Rules.Count());

            var john = new Person() { Birthdate = new DateTime(1972, 11, 4) };
            familyRelationship.Assign(husbandRole,john);
            var marry = new Person() { Birthdate = new DateTime(2006, 4, 16) };
            familyRelationship.Assign(whifeRole, marry);
            var gimmy = new Person() { Birthdate = new DateTime(1996, 4, 16) };
            familyRelationship.Assign(childrenRole, gimmy);

            Assert.AreEqual(3, familyRelationship.Roles.Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(john).Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(marry).Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(gimmy).Count());
        }

        /// <summary>
        /// test validates type of party which allows for RoleType
        /// </summary>
        [TestCategory("Relationship")]
        [TestMethod]
        public void ValidateRoleConstraint_SuccessTest()
        {
            var husbandCanBePersonOnly = new PartyRoleConstraint(typeof(Person));
            var husbandType = new PartyRoleType("Husband");
            husbandType.AddConstraint(husbandCanBePersonOnly);
            var husbandRole = new PartyRole(husbandType);

            var whifeCanBePersonOnly = new PartyRoleConstraint(typeof(Person));
            var whifeType = new PartyRoleType("Whife");
            whifeType.AddConstraint(whifeCanBePersonOnly);
            var whifeRole = new PartyRole(whifeType);

            var familyRelationshipTyp = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipTyp.AddConstraint(famalyCanHasHusband);
            var famalyCanHasWhife = new PartyRelationshipConstraint(whifeType);
            familyRelationshipTyp.AddConstraint(famalyCanHasWhife);

            var familyRelationship = new PartyRelationship(familyRelationshipTyp);
            familyRelationship.AddRole(husbandRole);
            familyRelationship.AddRole(whifeRole);

            Assert.AreEqual(2, familyRelationship.Roles.Count());
            Assert.AreEqual(1, husbandRole.Type.RoleConstraints.Count());
            Assert.AreEqual(0, husbandRole.Type.Rules.Count());

            Assert.AreEqual(2, familyRelationship.Roles.Count());
            Assert.AreEqual(1, whifeRole.Type.RoleConstraints.Count());
            Assert.AreEqual(0, whifeRole.Type.Rules.Count());

            var john = new Person() { Birthdate = new DateTime(1972, 11, 4) };
            familyRelationship.Assign(husbandRole, john);
            var marry = new Person() { Birthdate = new DateTime(1976, 4, 16) };
            familyRelationship.Assign(whifeRole, marry);

            Assert.AreEqual(2, familyRelationship.Roles.Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(john).Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(marry).Count());
        }

        /// <summary>
        ///  test validates type of party which allows for RoleType. In this test whife is Organization it is 
        ///  breaks party role type contraint 
        /// </summary>
        [TestCategory("Relationship")]
        [TestMethod]
        [ExpectedException(typeof(BreakPartyRoleConstraintException))]
        public void ValidateRoleConstraint_FailTest()
        {
            var husbandCanBePersonOnly = new PartyRoleConstraint(typeof(Person));
            var husbandType = new PartyRoleType("Husband");
            husbandType.AddConstraint(husbandCanBePersonOnly);
            var husbandRole = new PartyRole(husbandType);

            var whifeCanBePersonOnly = new PartyRoleConstraint(typeof(Person));
            var whifeType = new PartyRoleType("Whife");
            whifeType.AddConstraint(whifeCanBePersonOnly);
            var whifeRole = new PartyRole(whifeType);

            var familyRelationshipTyp = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipTyp.AddConstraint(famalyCanHasHusband);
            var famalyCanHasWhife = new PartyRelationshipConstraint(whifeType);
            familyRelationshipTyp.AddConstraint(famalyCanHasWhife);

            var familyRelationship = new PartyRelationship(familyRelationshipTyp);
            familyRelationship.AddRole(husbandRole);
            familyRelationship.AddRole(whifeRole);

            Assert.AreEqual(2, familyRelationship.Roles.Count());
            Assert.AreEqual(1, husbandRole.Type.RoleConstraints.Count());
            Assert.AreEqual(0, husbandRole.Type.Rules.Count());

            Assert.AreEqual(2, familyRelationship.Roles.Count());
            Assert.AreEqual(1, whifeRole.Type.RoleConstraints.Count());
            Assert.AreEqual(0, whifeRole.Type.Rules.Count());

            var john = new Person() { Birthdate = new DateTime(1972, 11, 4) };
            familyRelationship.Assign(husbandRole, john);
            var marry = new Organization() { FromDate = new DateTime(1976, 4, 16) };
            familyRelationship.Assign(whifeRole, marry);
        }

        [TestCategory("Relationship")]
        [TestMethod]
        [ExpectedException(typeof(BreakPartyRelationshipConstraintException))]
        public void AddSameRoleIntoRelationship_FailTest()
        {
            var husbandType = new PartyRoleType("Husband");
            var husbandRole = new PartyRole(husbandType);
            var familyRelationshipType = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipType.AddConstraint(famalyCanHasHusband);
            var familyCanHaveOnlyOneHusband = new PartyRelationshipConstraint(familyRelationshipType,
                new Func<PartyRelationship, PartyRole, bool>((relationship, role) =>
           {
               var c = relationship.Roles.Count(r => r.Id == role.Id);
               if (c == 0)
                   return true;
               else
                   return false;
           }));
            familyRelationshipType.AddConstraint(familyCanHaveOnlyOneHusband);


            var familyRelationship = new PartyRelationship(familyRelationshipType);
            familyRelationship.AddRole(husbandRole);
            familyRelationship.AddRole(husbandRole);
        }

        [TestCategory("Relationship")]
        [TestMethod]
        public void AddRightRoleIntoRelationship_FailTest()
        {
            var husbandType = new PartyRoleType("Husband");
            var husbandRole = new PartyRole(husbandType);

            var whifeType = new PartyRoleType("Whife");
            var whifeRole = new PartyRole(whifeType);

            var familyRelationshipTyp = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipTyp.AddConstraint(famalyCanHasHusband);
            var famalyCanHasWhife = new PartyRelationshipConstraint(whifeType);
            familyRelationshipTyp.AddConstraint(famalyCanHasWhife);

            var familyRelationship = new PartyRelationship(familyRelationshipTyp);
            familyRelationship.AddRole(husbandRole);
            familyRelationship.AddRole(whifeRole);

            var john = new Person() { Birthdate = new DateTime(1972, 11, 4) };
            familyRelationship.Assign(husbandRole, john);
            var marry = new Person() { Birthdate = new DateTime(1976, 4, 16) };
            familyRelationship.Assign(whifeRole, marry);

            Assert.AreEqual(2, familyRelationship.Roles.Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(john).Count());
            Assert.AreEqual(1, familyRelationship.GetRoles(marry).Count());
        }

        [TestCategory("Relationship")]
        [TestMethod]
        [ExpectedException(typeof(BreakPartyRelationshipConstraintException))]
        public void AddWrongRoleIntoRelationship_FailTest()
        {
            var husbandType = new PartyRoleType("Husband");
            var husbandRole = new PartyRole(husbandType);

            var whifeType = new PartyRoleType("Whife");
            var whifeRole = new PartyRole(whifeType);

            var familyRelationshipTyp = new PartyRelationshipType("Family");
            var famalyCanHasHusband = new PartyRelationshipConstraint(husbandType);
            familyRelationshipTyp.AddConstraint(famalyCanHasHusband);
            var famalyCanHasWhife = new PartyRelationshipConstraint(whifeType);
            familyRelationshipTyp.AddConstraint(famalyCanHasWhife);

            var familyRelationship = new PartyRelationship(familyRelationshipTyp);
            familyRelationship.AddRole(husbandRole);

            var familyRelationshipType2 = new PartyRelationshipType("Family2");
            var familyRelationship2 = new PartyRelationship(familyRelationshipType2);
            familyRelationship2.AddRole(whifeRole);

            var john = new Person() { Birthdate = new DateTime(1972, 11, 4) };
            familyRelationship.Assign(husbandRole, john);
            var marry = new Person() { Birthdate = new DateTime(1976, 4, 16) };
            familyRelationship.Assign( whifeRole, marry);
        }
    }
}
