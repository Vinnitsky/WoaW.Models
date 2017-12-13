using System;
using WoaW.Models.Parties.Root;

namespace WoaW.Models.Requirements
{
    public class RequirementRole
    {
        #region attributes
        private RequirementRoleType _requirementRoleType;
        #endregion

        #region attributes
        public DateTime FromDate { get; set; }
        public DateTime TthruDate { get; set; }
        #endregion

        #region properties
        public Party Party { get; set; }
        public Requirement Requirement { get; set; }
        public RequirementRoleType RequirementRoleType
        {
            get { return _requirementRoleType; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(RequirementRoleType));
                else
                    _requirementRoleType = value;
            }
        }
        #endregion
    }
}
