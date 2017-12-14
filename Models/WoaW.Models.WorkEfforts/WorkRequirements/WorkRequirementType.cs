namespace WoaW.Models.WorkEfforts.WorkRequirements
{
    public sealed class WorkRequirementType
    {
        #region attributes
        public static readonly WorkRequirementType CustomerRequirement = new WorkRequirementType() { Id = "1", DisplayName = "Customer Requirement" };
        public static readonly WorkRequirementType ProductionRun = new WorkRequirementType() { Id = "2", DisplayName = "Production Run" };
        public static readonly WorkRequirementType InternalProject = new WorkRequirementType() { Id = "3", DisplayName = "Internal Project" };
        public static readonly WorkRequirementType Maintanence = new WorkRequirementType() { Id = "4", DisplayName = "Maintanence" };
        public static readonly WorkRequirementType Repair = new WorkRequirementType() { Id = "5", DisplayName = "Repair" };

        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
