namespace WoaW.Models.WorkEfforts.Rates
{
    public sealed class PositionType
    {
        #region attributes
        public static readonly PositionType Sample = new PositionType() { Id = "1", DisplayName = "Sample" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion

    }
}
