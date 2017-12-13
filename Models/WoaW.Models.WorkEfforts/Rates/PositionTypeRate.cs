using System;

namespace WoaW.Models.WorkEfforts.Rates
{
    public sealed class PositionTypeRate
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime tthruDate { get; set; }
        public float Rate { get; set; }

        public PositionType PositionType { get; set; }
        public RateType RateType { get; set; }
        #endregion
    }
}
