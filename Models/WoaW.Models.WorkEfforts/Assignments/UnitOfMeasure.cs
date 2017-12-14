namespace WoaW.Models.WorkEfforts.Assignments
{
    public sealed class UnitOfMeasure
    {
        #region attributes
        public static readonly UnitOfMeasure Meter = new UnitOfMeasure() { Id = "1", DisplayName = "Meter" };
        public static readonly UnitOfMeasure Milimeter = new UnitOfMeasure() { Id = "2", DisplayName = "Milimeter" };
        public static readonly UnitOfMeasure Santimeter = new UnitOfMeasure() { Id = "3", DisplayName = "Santimeter" };
        public static readonly UnitOfMeasure Kilogram = new UnitOfMeasure() { Id = "4", DisplayName = "Kilogram" };
        public static readonly UnitOfMeasure Unit = new UnitOfMeasure() { Id = "5", DisplayName = "Unit" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
