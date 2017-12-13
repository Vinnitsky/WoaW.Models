using System;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class WorkEffortFixedAssetAssignment
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public float AllocatedCost { get; set; }
        public string Comment { get; set; }

        public FixedAsset FixedAsset { get; set; }
        public WorkEffort WorkEffort { get; set; }
        public WorkEffortAssetAssignmentStatusType StatusType { get; set; }

        #endregion
    }
}
