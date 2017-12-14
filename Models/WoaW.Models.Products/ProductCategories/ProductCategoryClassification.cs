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
        /// <summary>
        /// так как один продукт может быть в нескольких категория, то было бы полезно 
        /// определить главную или основную категорию для продукта.
        /// </summary>
        private bool _primaryFlag;
        private string _comment;

        #endregion

        #region properties
        public Product Product{ get { return _product; } set { _product = value; } }
        public ProductCategory ProductCategory { get { return _productCategory; } set { _productCategory = value; } }
        
        public DateTime FromDate { get { return _fromDate; } set { _fromDate = value; } }
        public DateTime ThruDate { get { return _thruDate; } set { _thruDate = value; } }
        public bool PrimaryFlag { get { return _primaryFlag; } set { _primaryFlag = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }
        #endregion
    }
}
