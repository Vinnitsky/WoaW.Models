using System;
using WoaW.Models.Parties.Root;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public class WorkEffortPartyAssignment
    {
        #region properties
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }

        public WorkEffortRoleType WorkEffortRoleType { get; set; }
        public Facility Facility { get; set; }
        public WorkEffort AssignedWorkEffort { get; set; }
        public Party AllocatedParty { get; set; }
        #endregion
    }
}
