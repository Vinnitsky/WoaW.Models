using System.Collections.Generic;

namespace WoaW.Models.Products.ProductCategories
{
    public sealed class ProductCategoryRollup
    {
        #region attributes
        private List<ProductCategory> _categoriesOwner;
        private List<ProductCategory> _categoriesChild;
        #endregion

        #region properties
        public List<ProductCategory> CategoriesOwner { get { return _categoriesOwner; } set { _categoriesOwner = value; } }
        public List<ProductCategory> CategoriesChild { get { return _categoriesChild; } set { _categoriesChild = value; } }
        public string Name { get; set; }

        #endregion
    }
}
