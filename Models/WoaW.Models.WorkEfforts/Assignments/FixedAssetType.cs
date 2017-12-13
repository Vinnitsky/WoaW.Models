namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class FixedAssetType
    {
        #region attributes
        public static readonly FixedAssetType Property = new FixedAssetType() { Id = "1", DisplayName = "Property" };
        public static readonly FixedAssetType Vehical = new FixedAssetType() { Id = "2", DisplayName = "Vehical" };
        public static readonly FixedAssetType Equipment = new FixedAssetType() { Id = "3", DisplayName = "Equipment" };
        public static readonly FixedAssetType OtherFixedAsset = new FixedAssetType() { Id = "4", DisplayName = "OtherFixedAsset" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }

        public FixedAssetType SubType { get; set; }
        #endregion

    }
}
