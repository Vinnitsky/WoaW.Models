using System;
using WoaW.Models.Parties.Root;

namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class PartyFixedAssetAssignment
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public uint AllocatedCost{ get; set; }
        public string Comment { get; set; }


        public PartyFixedAssetAssignmentStatusType StatusType { get; set; }
        public Party Party { get; set; }
        public FixedAsset FixedAsset { get; set; }
        #endregion
    }
}
