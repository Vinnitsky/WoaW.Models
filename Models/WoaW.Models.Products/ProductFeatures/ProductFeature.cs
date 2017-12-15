namespace WoaW.Models.Products.ProductFeatures
{
    public sealed class ProductFeature
    {
        /// <summary>
        /// for purpose only
        /// </summary>
        public static readonly ProductFeature Color = new ProductFeature() { Id = "1", Name = "Color"};
        public static readonly ProductFeature Quality = new ProductFeature() { Id = "2", Name = "Quality" };
        public static readonly ProductFeature Size = new ProductFeature() { Id = "3", Name = "Size" };
        public static readonly ProductFeature Brand = new ProductFeature() { Id = "4", Name = "Brand" };
        public static readonly ProductFeature SoftwareFeature = new ProductFeature() { Id = "5", Name = "Software Feature" };
        public static readonly ProductFeature HardwareFeature = new ProductFeature() { Id = "6", Name = "Hardware Feature" };

        #region properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductFeatureCategory ProductFeatureCategory { get; set; }
        #endregion
    }
}
