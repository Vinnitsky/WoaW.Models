using System;

namespace WoaW.Models.Common.Ordering
{
    public class OrderItem
    {
        #region properties
        public string Id { get; set; }
        public uint SiquenceNumber { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public uint Quantity { get; set; }
        public float UnitPrice { get; set; }
        public string ShipmentInstruction { get; set; }
        public string Comment { get; set; }
        public string ItemDescription { get; set; }
        #endregion
    }
}
