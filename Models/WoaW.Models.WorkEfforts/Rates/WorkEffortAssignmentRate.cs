using System;
using WoaW.Models.WorkEfforts.Assignments;

namespace WoaW.Models.WorkEfforts.Rates
{
    public sealed class WorkEffortAssignmentRate
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime tthruDate { get; set; }
        public float Rate { get; set; }

        public RateType RateType { get; set; }
        public WorkEffortPartyAssignment Party { get; set; }
        #endregion
    }
}
