using System.Collections.Generic;

namespace WoaW.Models.Products.ProductCategories
{
    public sealed class ProductCategoryRollup
    {
        #region attributes
        private List<ProductCategory> _productCategories1;
        private List<ProductCategory> _productCategories2;
        #endregion

        #region properties
        public List<ProductCategory> ProductCategories1 { get { return _productCategories1; } set { _productCategories1 = value; } }
        public List<ProductCategory> ProductCategories2 { get { return _productCategories2; } set { _productCategories2 = value; } }

        #endregion
    }
}
