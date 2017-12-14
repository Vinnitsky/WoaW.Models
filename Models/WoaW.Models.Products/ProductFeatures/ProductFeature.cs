namespace WoaW.Models.Products.ProductFeatures
{
    public sealed class ProductFeature
    {
        #region properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductFeatureCategory ProductFeatureCategory { get; set; }
        #endregion
    }
}
