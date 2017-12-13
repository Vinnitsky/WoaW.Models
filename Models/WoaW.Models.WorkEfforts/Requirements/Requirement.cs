using System;

namespace WoaW.Models.Requirements
{
    public abstract class Requirement
    {
        #region properties
        public string Id { get; set; }
        public string Description{ get; set; }
        public DateTime CreationDate{ get; set; }
        public DateTime RequiredByDate{ get; set; }
        public float EstimatedBudget{ get; set; }
        public uint Quantity{ get; set; }
        public string Reason{ get; set; }
        #endregion
    }
}
