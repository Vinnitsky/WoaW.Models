using System;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public class WorkEffortStatus
    {
        #region properties
        public DateTime Date { get; set; }

        public WorkEffort WorkEffort { get; set; }
        public WorkEffortStatusType WorkEffortStatusType { get; set; }
        #endregion
    }
}
