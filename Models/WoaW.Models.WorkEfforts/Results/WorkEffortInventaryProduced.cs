using System.Collections.Generic;
using WoaW.Models.Common.Inventory;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Results
{
    public sealed class WorkEffortInventaryProduced
    {
        #region properties
        public IEnumerable<InventoryItem> InvetoryItems { get; set; }
        public WorkEffort WorkEffort { get; set; }
        #endregion
    }
}
