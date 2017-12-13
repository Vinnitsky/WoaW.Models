using WoaW.Models.Parties.Root;

namespace WoaW.Models.WorkEfforts.Rates
{
    public sealed class Position
    {
        #region properties
        public PositionType PositionType { get; set; }
        public Party Party { get; set; }
        #endregion
    }
}
