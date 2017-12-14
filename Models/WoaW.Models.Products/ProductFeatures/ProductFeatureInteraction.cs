using System.Collections.Generic;

namespace WoaW.Models.Products.ProductFeatures
{
    public sealed class ProductFeatureInteraction
    {
        #region properties
        public ProductInteractionType ProductInteractionType { get; set; }
        public Product Product { get; set; }
        public List<ProductFeature> ProductFeatures1 { get; set; }
        public List<ProductFeature> ProductFeatures2 { get; set; }
        #endregion

        #region constructors
        public ProductFeatureInteraction()
        {
            ProductFeatures1 = new List<ProductFeature>();
            ProductFeatures2 = new List<ProductFeature>();
        }
        #endregion
    }
}
