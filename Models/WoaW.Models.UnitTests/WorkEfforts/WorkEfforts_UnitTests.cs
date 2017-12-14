using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoaW.Models.Parties.Persons;
using WoaW.Models.Parties.Root;
using WoaW.Models.Products;
using WoaW.Models.Requirements;
using WoaW.Models.WorkEfforts.Assignments;
using WoaW.Models.WorkEfforts.Generation;
using WoaW.Models.WorkEfforts.WorkRequirements;

namespace WoaW.Models.UnitTests.WorkEfforts
{
    [TestClass]
    [TestCategory("WorkEfforts")]
    public class WorkEfforts_UnitTests
    {
        [TestMethod]
        public void CreateTask_Complicated_SuccessTest()
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
            /// описваем продукт
            var product = new Product()
            {
                Id = Guid.NewGuid().ToString("N"),
                DisplayName = "установка кондиционирования воздуха",
                Description = " установка кондиционирования воздуха N24F53 с рекуперацией воздуха",
                IntoductionDate = DateTime.Now,
                // дата когда продукт перестанет продаваться
                SalesDiscontinuationDate = new DateTime(DateTime.Now.Year + 3, DateTime.Now.Month, DateTime.Now.Day),
                // дата когда продукт перестанет поддерживаться команией
                SupportDiscontinuationDate = new DateTime(DateTime.Now.Year + 5, DateTime.Now.Month, DateTime.Now.Day)
            };
            #endregion

            #region define assets
            /// описваем все необходимые инструменты и другие основные средства находящиеся на балансе
            /// которые могут потребоваться для выполняние нашей работы по созданию установки 
            /// кондиционирования воздуха, это могут быть как станки, так и комплектующие которые мы 
            /// закупали
            var equipment1 = new FixedAsset()
            {
                Id = Guid.NewGuid().ToString("N"),
                DisplayName = "токорный странок NzK21",
                LastServicedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1, DateTime.Now.Day),
                NextServiceDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month+1, DateTime.Now.Day),
                ProductionCapasity = 10,
                UnitOfMeasure = UnitOfMeasure.Unit,
                AquiredDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                Description = "Херово работает проводка барахлит",
                FixedAssetType = FixedAssetType.Equipment
            };
            var laptop = new FixedAsset() { FixedAssetType = FixedAssetType.Equipment };
            #endregion

            #region define work requirement
            ///для выполнения заказа нужно собрать установку кондиционирования воздука, 
            ///или ее нужно собрать для выполнения плана
            ///или можут быть другие причины
            var needToDevelopUnit = new WorkRequirement()
            {
                Id = Guid.NewGuid().ToString("N"),
                Description = "Cоздать Установку",
                // тип требования - собрать продукт
                WorkRequirementType = WorkRequirementType.ProductionRun,
                /// требование относится к продукту который мы создаем
                /// здесь могут быть бизнес правила которые проверяют или мы создаем это продукт 
                /// или время когда компания создавала новые продукты уже закончилось 
                /// и на данный момент компания занимается только спаортом этого продукта 
                /// в таком случа должна известить что что-то не так и создавать новый нельзя 
                /// и т.д. правил может быть много поэтому мы связываем требование с продуктом.
                /// НО требования могут быть разные и они не обязаны быть толькло внечшними 
                /// и относится к продукту, это может быть внутренне требование на ремонт 
                /// оборудования.
                /// нужно понимать что мы связываем требование с продуктом для того чтобы потом 
                /// иметь представление какие работы возникали в рамках конкретного экземпляра 
                /// продукта. потому что разные экземпляры могут оличаться по требованием друг 
                /// от друга
                Product = product,
                CreationDate = DateTime.Now,
                /// количество продукции - это может быть как создать одну ракету
                /// так и сделать набор из 10 карандашей или создать партию карандашей 
                /// из 10 тысяч - это все может быть одно требование
                Quantity = 1,
                /// дата до которой это требование должно быть выполнено - до которой оно имеет смысл
                RequiredByDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1),
                /// иногда это важно ... это может быть как стабильно забито или может быть динамически
                /// расчинаная величина после того как будут подсчитаны другие составляющие требовния 
                /// это уже зависит от процесса. в данном случае мы исходим из того что эта величина 
                /// зараниее известна и мы ее устанавливем. 
                /// эта величина может быть исползована при индикатора KPI которые вычисляются 
                /// динамически и которые говорят что мы укладываемся в нужный бюджет или выходим 
                /// из него так же это значением может использоваться как желаемое значение к 
                /// котрому мы стремимся - это особенно актуально если речь идет о кустарном или разовм
                /// производсве
                EstimatedBudget = 20,
                /// поле описывает причину возниконовения этого треования - это поле связано с полем 
                /// тип требования. например если это требование по созданию продукта в рамках 
                /// выполнения плана тогда поняно что здесь просто выполнение плана. но если тип 
                /// требования другой например это поломка станка и его нужно поченить, то такое 
                /// требование покажет причину возникновения работы и раота эта уже будет внеплановая
                /// короче это поле покажет какова причина возникновения этого требования. 
                /// или нет на складе нужных запчастей и нужно дозаказать и это требование - сделать
                /// дозаказ, или нет запчастей больше сименс и мы ставим самсунг и т.д. 
                /// т.е. в одних случаях это поле будет неважно и может быть заполненно автоматом 
                /// а вдругих слечаях оно будет важным и по нему можно будет понять причину выполненных
                /// возникших незапланированых работ. 
                Reason = "обеспечить заказ клиента - создать установку",
                /// какие инструменты и копилектующие (основные средства) нужно(можно) использовать для 
                /// выполнения этого требования 
                FixedAsset = equipment1
            };

            /// при выявлении требований было обнаружено, что заказчик хочет чтобы установка
            /// была собрана с использованием схемы от производителя схем - сименс 
            var developSchema = new WorkRequirement()
            {
                Id = Guid.NewGuid().ToString("N"),
                Description = "Использовать микросхемы Сименс",
                WorkRequirementType = WorkRequirementType.CustomerRequirement,
                Product = product,
                CreationDate = DateTime.Now,
                Quantity = 1,
                RequiredByDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1),
                EstimatedBudget = 20,
                Reason = "потому что у него другое оборудование сименс",
                FixedAsset = equipment1,
                /// просто для того чтобы показать что требования могут быть составными и цепляться 
                /// в цепочки или состоять из набора других требований если у них оди общий владелец
                PertOf = needToDevelopUnit
            };

            /// добвляем подчиненное требование
            needToDevelopUnit.ComposedOf.Add(developSchema);

            /// TODO:здесь можно придумать херову тучу других требований разного типа, как 
            /// для создания установки, так и для поддержания оборудования и что угодно. 
            /// по большому счету многие из треований могет повторять шаги бизнес процесса
            /// если он есть, если его нет, то они попросту будут отсутствовать.
            #endregion

            #region define orderItem
            /// определяем ордера (работы) которые нужно выполнить чтобы получить устновку.
            /// это может быть много работ или если требование простое, то и ордер может быть один
            /// в качестве примера может быть следующий кейс: приходит запрос от клиента 
            /// необходимо повысить производительность системы. в этом случае мы записываем 
            /// requiement - "повысить производительность системы", и делаем ордера:
            /// order - выяснить место где наименьшая производительность
            /// order - понять ее причину
            /// order - изменить код так чтобы избавиться от баги
            /// order - протестировать
            /// order - задеплоить 
            /// order - известить заказчика о выполненой работе и выставить счет
            /// это похоже на SCRAM или на любой другой процесс
            var unitDevelopmentOrder = new WorkOrderItem()
            {
                ItemDescription = "Разработка установки"
            };
            #endregion

            #region bind orderItem with Requirements
            /// указываем, что этот ордер был сделан для реализации такого-то требования
            /// для создания задачи это не нужно, но для отслеживания зачем было потрачено время
            /// куда оно ушло это полезно. так же это полезно при формировании счета, так как 
            /// клиенту можно описать что его требование о повышении производительности вылилось 
            /// в такой-то список работ. 
            var comitmentForUnitDevelopment = new OrderRequirementComitment()
            {
                OrderItem = unitDevelopmentOrder,
                Requirement = needToDevelopUnit
            };
            #endregion

            #region define workEffort
            /// сама работа - это абстракция - клас связывающий все связанные с работой сущности
            /// или выступает один если система очень проста и в ней нет требований и всего остального
            var workEffort = new WorkEffort() { WorkEffortType = new WorkEffortType() };
            #endregion

            #region bind workEffort with requirements 
            /// указываем к какое требование мы выполняли этой работй 
            /// работа может быть связана непосредственно с требованием, а может быть 
            /// связана с order item. и это важно TODO:  пояснить почему так может быть. пока 
            /// могу сказать что связываение с OrderItem это говорит о том что процесс более 
            /// фомально оформлен, но иногда кастомер может что-то попросить или может быть 
            /// внутренняя потребность в работе - например поламался станок и его нужно поченить
            /// или что-то еще что не запланировано и не формализировано, но на него все рано 
            /// пришлось потратить время - хоть простей в пробке(если это ывжно)
            var requirementFulfilment = new WorkRequirementFulfilment();
            requirementFulfilment.WorkEfforts.Add(workEffort);
            requirementFulfilment.Requirements.Add(needToDevelopUnit);
            #endregion

            #region bind workEffort with workItem
            /// связываем работу с OrderItem.  в хорошем смысле любая выполняемая работа должна 
            /// быть выполнением ордера. т.е. наличие ордера говорит о запланированом процессе. 
            /// если вернуться к примеру с багой производительности, то это тот момент когда 
            /// принимается решение что да именно такие ордера и должны быть для того чтобы 
            /// выполнить требование
            var orderFulfilment = new WorkOrderItemFulfilment()
            {
                WorkEffort = workEffort
            };
            orderFulfilment.WorkOrderItems.Add(unitDevelopmentOrder);
            #endregion

            #region assigmen party to WorkOrder
            /// используя требование подбираем пользователя. так как требование должно быть
            /// формализировано например у нас есть требование чтобы установка была разработанна
            /// с использованием микроконтроллеров сименс, а так же у нас есть сотрудники которые
            /// имеют необходимый скилз как работа с микроконтроллерми сименс, то система на основе 
            /// этих формальных признаках может выбрать сотрудника. так де там может быть набор 
            /// фильтров который определен набором бизнес правил.
            var person = GetWorker(needToDevelopUnit, people);
            /// назначаем сотрудниа на конкретную работу
            var assigmenPersonToDevelopmentUnit = new WorkEffortPartyAssignment()
            {
                AllocatedParty = person,
                AssignedWorkEffort = workEffort,
                WorkEffortRoleType =  new WorkEffortRoleType()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    DisplayName = "name",
                    Description = "description"
                }
            };
            #endregion
        }

        [TestMethod]
        public void CreateTask_Simplest_SuccessTest()
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

            #region assigmen WorkOrder to a party
            var assigmenPetayToWork = new WorkEffortPartyAssignment();

            var person = people.OfType<Person>().SingleOrDefault(x => x.Id.Id == "Петя");
            assigmenPetayToWork.AllocatedParty = person;
            #endregion

            #region calculate work effort 
            var workEffort = new WorkEffort();

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
