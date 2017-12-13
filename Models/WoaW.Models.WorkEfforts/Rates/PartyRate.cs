using System;
using WoaW.Models.Parties.Root;

namespace WoaW.Models.WorkEfforts.Rates
{
    public sealed class PartyRate
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime tthruDate { get; set; }
        public float Rate { get; set; }

        public RateType RateType { get; set; }
        public Party Party{ get; set; }
        #endregion
    }
}
