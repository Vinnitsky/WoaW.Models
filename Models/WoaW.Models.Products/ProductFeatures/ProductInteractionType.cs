namespace WoaW.Models.Products.ProductFeatures
{
    public sealed class ProductInteractionType
    {
        public static readonly ProductInteractionType Incompatibility = new ProductInteractionType() { Id = "1", Name= "Incompatibility" };
        public static readonly ProductInteractionType Dependency = new ProductInteractionType() { Id = "2", Name= "Dependency" };

        #region properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
