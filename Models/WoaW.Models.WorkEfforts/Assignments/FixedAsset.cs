using System;
using WoaW.Models.Common;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class FixedAsset
    {
        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public DateTime AquiredDate { get; set; }
        public DateTime LastServicedDate { get; set; }
        public DateTime NextServiceDate { get; set; }
        public uint ProductionCapasity { get; set; }
        public string Description { get; set; }

        public UnitOfMeasure UnitOfMeasure { get; set; }
        public FixedAssetType FixedAssetType { get; set; }
        #endregion
    }
}
