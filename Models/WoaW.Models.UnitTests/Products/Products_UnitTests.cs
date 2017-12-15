using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WoaW.Models.Common;
using WoaW.Models.Products.ProductCategories;
using WoaW.Models.Products.ProductFeatures;
using WoaW.Models.Products.Products;

namespace WoaW.Models.UnitTests.Products
{
    [TestClass]
    public class Products_UnitTests
    {
        [TestMethod]
        public void CreateProduct_SuccessTest()
        {
            #region define product
            var product = new Good();
            #endregion

            #region define product category
            var category1 = new ProductCategory() { Name = "Category 1" };
            var category1_1 = new ProductCategory() { Name = "Category 1.1" };
            var category2 = new ProductCategory() { Name = "Category 2" };
            #endregion

            #region bind categories with product
            var clasificatin1 = new ProductCategoryClassification();
            clasificatin1.ProductCategory = category1_1;
            clasificatin1.Product = product;
            clasificatin1.FromDate = DateTime.Now;
            clasificatin1.ThruDate = DateTime.Now;

            var clasificatin2 = new ProductCategoryClassification();
            clasificatin2.ProductCategory = category2;
            clasificatin2.Product = product;
            clasificatin2.FromDate = DateTime.Now;
            clasificatin2.ThruDate = DateTime.Now;
            clasificatin2.PrimaryFlag = true;
            #endregion

            #region define subcategory
            var rollup = new ProductCategoryRollup
            {
                Name = "Subcategory"
            };
            rollup.CategoriesOwner.Add(category1);
            rollup.CategoriesChild.Add(category1_1);
            #endregion

            #region define product features
            var featureCategory = new ProductFeatureCategory() { Id = "1", Name = "feature category" };

            var optionalFeatures = new ProductFeatureApplicability
            {
                Product = product,
                ApplicabilityType = FeatureApplicabilityType.OptionalFeature
            };
            var colorFeature = new ProductFeature
            {
                Name = "Color",
                ProductFeatureCategory = featureCategory
            };
            //colorFeature.UnitOfMeasure = UnitOfMeasure.
            optionalFeatures.ProductFeature.Add(colorFeature);

            var sizeFeature = new ProductFeature
            {
                Name = "Size",
                ProductFeatureCategory = featureCategory
            };
            sizeFeature.UnitOfMeasure = UnitOfMeasure.Santimeter;
            optionalFeatures.ProductFeature.Add(sizeFeature);

            var hardwareFeatures = new ProductFeatureApplicability
            {
                Product = product,
                ApplicabilityType = FeatureApplicabilityType.RequiredFeature
            };
            hardwareFeatures.ProductFeature.Add(ProductFeature.HardwareFeature);
            #endregion

            #region define relationship dependence for product features
            var c = new ProductFeatureInteraction
            {
                Product = product
            };
            c.ProductFeatures1.Add(colorFeature);
            c.ProductFeatures2.Add(sizeFeature);
            c.ProductInteractionType = ProductInteractionType.Dependency;
            #endregion

        }
    }
}
