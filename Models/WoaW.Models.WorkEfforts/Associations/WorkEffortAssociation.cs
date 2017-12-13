using System;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Associations
{
    public class WorkEffortAssociation
    {
        #region attributes

        #endregion

        #region properties
        public DateTime EffectiveFromDate { get; set; }
        public DateTime EffectiveThruDate { get; set; }

        public WorkEffort From { get; set; }
        public WorkEffort To { get; set; }
        #endregion
    }
}
