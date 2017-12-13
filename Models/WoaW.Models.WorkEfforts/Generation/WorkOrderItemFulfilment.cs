using System.Collections.Generic;

namespace WoaW.Models.WorkEfforts.Generation
{
    public class WorkOrderItemFulfilment
    {
        #region attributes
        private List<WorkOrderItem> _workOrderItems;
        #endregion

        #region properties
        public List<WorkOrderItem> WorkOrderItems { get { return _workOrderItems; } set { _workOrderItems = value; } }
        public WorkEffort WorkEffort { get; set; }
        #endregion

        #region constructors
        public WorkOrderItemFulfilment()
        {
            _workOrderItems = new List<WorkOrderItem>();
        }
        #endregion
    }
}
