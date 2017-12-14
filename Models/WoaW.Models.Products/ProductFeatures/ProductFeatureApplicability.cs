using System.Collections.Generic;

namespace WoaW.Models.Products.ProductFeatures
{
    public sealed class ProductFeatureApplicability
    {
        #region properties
        public List<ProductFeature> ProductFeature { get; set; }
        public Product Product { get; set; }
        #endregion

        #region constructors
        public ProductFeatureApplicability()
        {
            ProductFeature = new List<ProductFeatures.ProductFeature>();
        }
        #endregion
    }
}
