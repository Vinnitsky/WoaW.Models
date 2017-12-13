namespace WoaW.Models.Requirements
{
    public sealed class RequirementRoleType
    {
        #region attributes
        public static readonly RequirementRoleType Responsible = new RequirementRoleType() { Id = "1", DisplayName = "Responsible" };
        public static readonly RequirementRoleType Involved = new RequirementRoleType() { Id = "2", DisplayName = "Involved" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
