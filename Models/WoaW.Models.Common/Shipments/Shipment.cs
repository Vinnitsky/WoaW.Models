using System;

namespace WoaW.Models.Shipments
{
    public class Shipment
    {
        #region attributes
        private ShipmentType _shipmentType;
        #endregion

        #region properties
        public ShipmentType ShipmentType
        {
            get { return _shipmentType; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                else
                    _shipmentType = value;
            }
        }
        #endregion

    }
}
