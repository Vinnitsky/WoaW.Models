using System.Collections.Generic;
using WoaW.Models.WorkEfforts.Generation;
using WoaW.Models.WorkEfforts.WorkRequirements;

namespace WoaW.Models.WorkEfforts.Results
{
    public sealed class WorkEffortDeliverfableProduced
    {
        #region properties
        public IEnumerable<Deliverable> DeliverableItems { get; set; }
        public WorkEffort WorkEffort { get; set; }
        #endregion
    }
}
