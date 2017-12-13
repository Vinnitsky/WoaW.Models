using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoaW.Models.WorkEfforts.WorkRequirements;
using WoaW.Models.Products;
using WoaW.Models.Requirements;
using System.Collections.Generic;
using WoaW.Models.WorkEfforts.Generation;
using WoaW.Models.WorkEfforts.Assignments;
using WoaW.Models.WorkEfforts.Standards;
using WoaW.Models.WorkEfforts.Associations;
using WoaW.Models.Parties.Persons;
using WoaW.Models.Parties.Root;

namespace WoaW.Models.UnitTests
{
    [TestClass]
    [TestCategory("WorkEfforts")]
    public class WorkEffortsRequirements_UnitTests
    {
        /// <summary>
        /// есть очень простой процесс-задача
        /// Цель - разработать программу для контроллера
        /// Входные данные - тип контроллера, технический характеристике вент установки
        /// Исполнитель - определяется динамически, на основании типа контроллера.
        /// Т.е.Сименс делают одни ребата, Самсунг другие.
        /// Приоритет - определяется датой.
        /// 
        /// Завершение задачи
        /// а) выполненно
        /// б) не ясно ТЗ, необходимо уточнить.Уточняет другой человек которому надо поставить
        /// на это задачу (это уже другая история)
        /// 
        /// вот простейший кейс. это атомарная часть для компании Дыченко. Он хочет из таких 
        /// блоков динамически строить процессы. в частности для сервиса
        /// </summary>
        [TestMethod]
        public void TestMethod1()
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

            #region define product
            var unit = new Product() { Id = "1", DisplayName = "Щит" };
            var samsungController = new Product() { Id = "1", DisplayName = "Самсунг контроллер" };
            var simenceController = new Product() { Id = "1", DisplayName = "Сименс контроллер" };

            var samsungControllerProgramm = new Product() { Id = "1", DisplayName = "программа для самсунг контроллера" };
            var simenceControllerProgramm = new Product() { Id = "1", DisplayName = "программа для сименс контроллера" };
            #endregion

            #region define assets
            var leptop1 = new FixedAsset() { Id = "1", DisplayName = "leptop 1", ProductionCapasity = 1 };
            #endregion

            #region define work requirement
            var toDevelpUnitRequirement = new WorkRequirement() { Description = "создать Установку" };
            
            var toDevelpControllerProgram = new WorkRequirement() { Description = "нужно разработать программу для контроллера" };
            toDevelpControllerProgram.WorkRequirementType = WorkRequirementType.ProductionRun;
            toDevelpControllerProgram.CreationDate = DateTime.Now;
            toDevelpControllerProgram.Product = unit;
            toDevelpControllerProgram.Quantity = 1;
            toDevelpControllerProgram.EstimatedBudget = 10;
            toDevelpControllerProgram.FixedAsset = leptop1;
            toDevelpControllerProgram.Reason = "для ...";
            toDevelpControllerProgram.RequiredByDate = DateTime.Now + new TimeSpan(1, 0, 0, 0);
            
            //TODO: здесь должна быть связь между требованиями 
            #endregion

            #region define work order item
            var unitDevelopment = new WorkOrderItem() { ItemDescription = "разработка установки" };
            var contollerProgramDevelopment = new WorkOrderItem() { ItemDescription = "разработка программы для контроллера" };

            var a = new OrderRequirementComitment()
            {
                OrderItem = contollerProgramDevelopment,
                Requirement = toDevelpControllerProgram
            };
            #endregion

            #region define work effort party assigment
            var contollerProgramDevelopmentAssigment = new WorkEffortPartyAssignment();
            var samsungControllerFacility = new Facility();
            contollerProgramDevelopmentAssigment.Facility = samsungControllerFacility;

            var person2 = GetWorker(toDevelpControllerProgram, people);
            contollerProgramDevelopmentAssigment.AllocatedParty = person2;
            //TODO: define the role for person whihc assigned a work order item

            //contollerProgramDevelopmentAssigment.AllocatedParty = manager;
            //contollerProgramDevelopmentAssigment.AllocatedParty.Add(worker);
            #endregion

            #region define work effort types
            var we = new WorkEffort();
            contollerProgramDevelopmentAssigment.AssignedWorkEffort = we;

            //разработка установки 
            var developmentUnitWorkEffortType = new WorkEffortType();
            var developmentUnitWorkEffort = new WorkEffort() {  WorkEffortType = developmentUnitWorkEffortType};

            //разработка программы для контроллеров самсунг
            var developmentSamsungControllerProgrmaWorkEffortType = new WorkEffortType()
            {
                SkillStandards = new List<WorkEffortSkillStandard>()
                {
                    new WorkEffortSkillStandard() { SkillType = samsungKnowlage, EstimatedCost = 10, EstimatedDuration = new TimeSpan(5, 0, 0), EstimatedNumberofPeople = 1 }
                },
                UseToProduce = new List<Product>() { samsungControllerProgramm }
            };
            var we1 = new WorkEffort() { WorkEffortType = developmentSamsungControllerProgrmaWorkEffortType };
            var wea1 = new WorkEffortConcurrency() {From =  developmentUnitWorkEffort, To = we1};

            //разработка программы для контроллеров мименс
            var developmentSimenceControllerProgrmaWorkEffortType = new WorkEffortType()
            {
                SkillStandards = new List<WorkEffortSkillStandard>()
                {
                    new WorkEffortSkillStandard() { SkillType = simenceKnowlage, EstimatedCost = 15, EstimatedDuration = new TimeSpan(9, 0, 0), EstimatedNumberofPeople = 1 }
                },
                UseToProduce = new List<Product>() { simenceControllerProgramm }
            };
            var we2 = new WorkEffort() { WorkEffortType = developmentSimenceControllerProgrmaWorkEffortType };
            var wea2 = new WorkEffortConcurrency() {From =  developmentUnitWorkEffort, To = we2};
            #endregion

            #region define party roles
            var person1 = GetManager(toDevelpControllerProgram, people);
            var manager = new RequirementRole()
            {
                FromDate = DateTime.Now,
                Party = person1,
                Requirement = toDevelpControllerProgram,
                RequirementRoleType = RequirementRoleType.Involved
            };

            var worker = new RequirementRole()
            {
                FromDate = DateTime.Now,
                Party = person2,
                Requirement = toDevelpControllerProgram,
                RequirementRoleType = RequirementRoleType.Responsible
            };
            #endregion

            #region commitment
            var comitmentForUnitDevelopment = new OrderRequirementComitment() { OrderItem = unitDevelopment, Requirement= toDevelpUnitRequirement };

            var comitmentForDevelpControllerProgram = new OrderRequirementComitment() { OrderItem = contollerProgramDevelopment, Requirement= toDevelpUnitRequirement };
            #endregion

            #region calculate work effort 
            //var a1 = new WorkOrderItemFulfillment();
            //a1.OrderItem = contollerProgramDevelopment;
            #endregion
        }

        Person GetWorker(Requirement req, IEnumerable<Party> peole)
        {
            var vasya = new Person() { Id = "Вася Пупкин" };

            #region filter by price
            #endregion

            #region filter by skils
            #endregion

            return vasya;
        }
        Person GetManager(Requirement req, IEnumerable<Party> peole)
        {
            var dychenko = new Person() { Id = "Дыченко" };
            return dychenko;
        }

    }
}
