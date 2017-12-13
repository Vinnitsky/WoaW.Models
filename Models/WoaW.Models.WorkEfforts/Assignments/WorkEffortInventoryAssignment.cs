using WoaW.Models.Common.Inventory;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class WorkEffortInventoryAssignment
    {
        #region properties
        public uint Quantity { get; set; }

        public WorkEffort WorkEffort { get; set; }
        public InventoryItem InventoryItem { get; set; }
        #endregion
    }
}
