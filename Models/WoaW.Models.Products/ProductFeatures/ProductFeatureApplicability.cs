﻿using System;
using System.Collections.Generic;

namespace WoaW.Models.Products.ProductFeatures
{
    /// <summary>
    /// показывает какие фичи к каким продуктам можно применять
    /// </summary>
    public sealed class ProductFeatureApplicability
    {
        #region properties
        public List<ProductFeature> ProductFeature { get; set; }
        public Product Product { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public FeatureApplicabilityType ApplicabilityType { get; set; }
        #endregion

        #region constructors
        public ProductFeatureApplicability()
        {
            ProductFeature = new List<ProductFeature>();
        }
        #endregion

        #region public API
        public void AddFeature(ProductFeature feature, FeatureApplicabilityType type)
        {
            if (feature == null)
                throw new ArgumentNullException(nameof(feature));
            if (type == null)
                throw new ArgumentNullException(nameof(type));
        }
        #endregion
    }
}
