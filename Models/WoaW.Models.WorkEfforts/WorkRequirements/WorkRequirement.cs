using System;
using System.Collections.Generic;
using WoaW.Models.Products;
using WoaW.Models.Requirements;
using WoaW.Models.WorkEfforts.Assignments;

namespace WoaW.Models.WorkEfforts.WorkRequirements
{
    public sealed class WorkRequirement : Requirement
    {
        #region attributes
        private Product _product;
        private Deliverable _deliverable;
        private WorkRequirementType _workRequirementType;
        #endregion

        #region properties
        public WorkRequirement PertOf { get; set; }
        public IEnumerable<WorkRequirement> ComposedOf { get; set; }

        public WorkRequirementType WorkRequirementType
        {
            get { return _workRequirementType; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(WorkRequirementType));
                else
                    _workRequirementType = value;
            }
        }
        public Product Product
        {
            get { return _product; }
            set
            {
                if (Validate(value, Deliverable))
                    throw new ArgumentException(); _product = value;
            }
        }
        public FixedAsset FixedAsset { get; set; }
        public Deliverable Deliverable
        {
            get { return _deliverable; }
            set
            {
                if (Validate(Product, value))
                    throw new ArgumentException(); _deliverable = value;
            }
        }
        #endregion

        #region implementation
        private bool Validate(Product product, Deliverable deliverable)
        {
            if (product != null && deliverable != null)
                return false;
            else
                return true;
        }
        #endregion
    }
}
