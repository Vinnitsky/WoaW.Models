﻿using WoaW.Models.Products.Products;

namespace WoaW.Models.WorkEfforts.Standards
{
    public sealed class WorkEffortGoodStandard
    {
        #region properties
        public uint EstimatedQuantity { get; set; }
        public float EstimatedCost { get; set; }
        public Good Good { get; set; }
        #endregion
    }
}
