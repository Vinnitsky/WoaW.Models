using System.Collections.Generic;
using WoaW.Models.Products;
using WoaW.Models.WorkEfforts.Standards;
using WoaW.Models.WorkEfforts.WorkRequirements;

namespace WoaW.Models.WorkEfforts.Generation
{
    public class WorkEffortType
    {
        #region attributes
        public static readonly WorkEffortType Program = new WorkEffortType() { Id = "1", DisplayName = "Program" };
        public static readonly WorkEffortType Project = new WorkEffortType() { Id = "2", DisplayName = "Project" };
        public static readonly WorkEffortType Phase = new WorkEffortType() { Id = "3", DisplayName = "Phase" };
        public static readonly WorkEffortType Task = new WorkEffortType() { Id = "4", DisplayName = "Task" };
        public static readonly WorkEffortType Activity = new WorkEffortType() { Id = "5", DisplayName = "Activity" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public float StandardWorkHours { get; set; }

        public IEnumerable<WorkEffortSkillStandard> SkillStandards { get; set; }
        public IEnumerable<WorkEffortGoodStandard> GoodStandards { get; set; }
        public IEnumerable<WorkEffortFixedAssetStandard> FixedAssetStandards { get; set; }

        public IEnumerable<DeliverableType> DeliverableTypeStandards { get; set; }
        public IEnumerable<Product> UseToProduce { get; set; }
        #endregion

    }
}
