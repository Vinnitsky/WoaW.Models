using System;
using WoaW.Models.WorkEfforts.Assignments;

namespace WoaW.Models.WorkEfforts.Standards
{
    public sealed class WorkEffortFixedAssetStandard
    {
        #region properties
        public uint EstimatedQuantity { get; set; }
        public TimeSpan EstimatedDuration { get; set; }

        public FixedAssetType FixedAssetType { get; set; }
        #endregion
    }
}
