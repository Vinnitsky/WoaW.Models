using System;
using System.Collections.Generic;
using System.Text;

namespace WoaW.Models.WorkEfforts.Generation
{
    public class WorkOrderItemFulfilment
    {
        #region properties
        public WorkOrderItem WorkOrderItem { get; set; }
        public WorkEffort WorkEffort { get; set; }
        #endregion
    }
}
