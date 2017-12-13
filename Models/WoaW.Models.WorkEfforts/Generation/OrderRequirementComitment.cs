using WoaW.Models.Common.Ordering;
using WoaW.Models.Requirements;

namespace WoaW.Models.WorkEfforts.Generation
{
    public class OrderRequirementComitment
    {
        #region properties
        public Requirement Requirement{ get; set; }
        public OrderItem OrderItem { get; set; }
        #endregion
    }
}
