using System;
using System.Collections.Generic;
using System.Text;

namespace WoaW.Models.Products.ProductFeatures
{
    public sealed class FeatureApplicabilityType
    {
        public static readonly FeatureApplicabilityType RequiredFeature = new FeatureApplicabilityType() { Id=1, Name= "Required Feature" };
        public static readonly FeatureApplicabilityType StandardFeature = new FeatureApplicabilityType() { Id=2, Name= "Standardre Feature" };
        public static readonly FeatureApplicabilityType OptionalFeature = new FeatureApplicabilityType() { Id=3, Name= "Optional Feature" };

        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
