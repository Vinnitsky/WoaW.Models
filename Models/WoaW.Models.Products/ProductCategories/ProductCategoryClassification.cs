using System;

namespace WoaW.Models.Products.ProductCategories
{
    public sealed class ProductCategoryClassification
    {
        #region attributes
        private Product _product;
        private ProductCategory _productCategory;
        private DateTime _fromDate;
        private DateTime _thruDate;
        private int _primaryFlag;
        private string _comment;

        #endregion

        #region properties
        public Product Poduct{ get { return _product; } set { _product = value; } }
        public ProductCategory ProductCategory { get { return _productCategory; } set { _productCategory = value; } }
        
        public DateTime FromDate { get { return _fromDate; } set { _fromDate = value; } }
        public DateTime ThruDate { get { return _thruDate; } set { _thruDate = value; } }
        public int PrimaryFlag { get { return _primaryFlag; } set { _primaryFlag = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }
        #endregion
    }
}
