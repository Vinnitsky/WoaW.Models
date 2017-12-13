namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class UnitOfMeasure
    {
        #region attributes
        public static readonly FixedAssetType Meter = new FixedAssetType() { Id = "1", DisplayName = "Meter" };
        public static readonly FixedAssetType Milimeter = new FixedAssetType() { Id = "2", DisplayName = "Milimeter" };
        public static readonly FixedAssetType Santimeter = new FixedAssetType() { Id = "3", DisplayName = "Santimeter" };
        public static readonly FixedAssetType Kilogram = new FixedAssetType() { Id = "4", DisplayName = "Kilogram" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
