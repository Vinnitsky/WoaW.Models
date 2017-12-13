namespace WoaW.Models.Shipments
{
    public sealed class ShipmentType
    {
        #region attributes
        public static readonly ShipmentType ByPostAddress = new ShipmentType() { Id = "1", DisplayName = "By Post Address" };
        public static readonly ShipmentType ByFileSystem = new ShipmentType() { Id = "2", DisplayName = "By File System" };
        public static readonly ShipmentType ByEMail = new ShipmentType() { Id = "3", DisplayName = "By Email" };
        public static readonly ShipmentType ByPhone = new ShipmentType() { Id = "4", DisplayName = "By Phone" };
        public static readonly ShipmentType BySMS = new ShipmentType() { Id = "5", DisplayName = "By SMS" };
        public static readonly ShipmentType ByMMS = new ShipmentType() { Id = "6", DisplayName = "By MMS" };
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
