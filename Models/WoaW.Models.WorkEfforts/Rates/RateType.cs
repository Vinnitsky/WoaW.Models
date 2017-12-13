namespace WoaW.Models.WorkEfforts.Rates
{
    public sealed class RateType
    {
        #region attributes
        public static readonly RateType Sample = new RateType() { Id = "1", DisplayName = "Sample" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion

    }
}
