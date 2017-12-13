using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoaW.Models.Parties.Persons;
using WoaW.Models.Parties.Root;
using WoaW.Models.Requirements;
using WoaW.Models.WorkEfforts.Assignments;
using WoaW.Models.WorkEfforts.Generation;
using WoaW.Models.WorkEfforts.WorkRequirements;

namespace WoaW.Models.UnitTests.WorkEfforts
{
    [TestClass]
    public class WorkEfforts_UnitTests
    {
        [TestMethod]
        public void CreateTask_SuccessTest()
        {

            #region define parties
            var petya = new Person() { Id = "Петя" };
            var simenceKnowlage = new SkillType() { Id = "1", DisplayName = "Знание Сименс контроллеров" };
            var knowSimence = new PartySkill() { Party = petya, Raiting = 3, SkillType = simenceKnowlage, YearsEcpirience = 1 };

            var vasya = new Person() { Id = "Вася" };
            var samsungKnowlage = new SkillType() { Id = "1", DisplayName = "Знание Самсунг контроллеров" };
            var knowSamsung = new PartySkill() { Party = vasya, Raiting = 2, SkillType = samsungKnowlage, YearsEcpirience = 3 };

            var dychenko = new Person() { Id = "Дыченко" };

            List<Party> people = new List<Party>();
            people.Add(petya);
            people.Add(vasya);
            people.Add(dychenko);
            #endregion

            #region define work requirement
            var toDevelpUnitRequirement = new WorkRequirement() { Description = "Cоздать Установку" };
            #endregion

            #region define workOrderitem
            var unitDevelopment = new WorkOrderItem() { ItemDescription = "Разработка установки" };
            #endregion

            #region bind WorkOrderItem for Requirements
            var comitmentForUnitDevelopment = new OrderRequirementComitment()
            {
                OrderItem = unitDevelopment,
                Requirement = toDevelpUnitRequirement
            };
            #endregion

            #region assigmen WorkOrder to a party
            var contollerProgramDevelopmentAssigment = new WorkEffortPartyAssignment();

            var person = GetWorker(toDevelpUnitRequirement, people);
            contollerProgramDevelopmentAssigment.AllocatedParty = person;
            #endregion

            #region calculate work effort 
            var workEffort = new WorkEffort();
            var requirementFulfilment = new WorkRequirementFulfilment();
            requirementFulfilment.WorkEfforts.Add(workEffort);
            requirementFulfilment.Requirements.Add(toDevelpUnitRequirement);

            var orderFulfilment = new WorkOrderItemFulfilment()
            {
                WorkEffort = workEffort
            };
            orderFulfilment.WorkOrderItems.Add(unitDevelopment);

            #endregion
        }

        Person GetWorker(Requirement req, IEnumerable<Party> people)
        {
            if (people == null)
                throw new ArgumentNullException(nameof(people));

            #region filter by price
            #endregion

            #region filter by skils
            #endregion

            return people.OfType<Person>().SingleOrDefault(x => x.Id.Id == "Петя"); //for test purpose only
        }
    }
}
