using System;

namespace WoaW.Models.WorkEfforts.WorkRequirements
{
    public class Deliverable
    {
        #region attributes
        private DeliverableType _deliverableType;
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DeliverableType DeliverableType
        {
            get { return _deliverableType; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(DeliverableType));
                else
                    _deliverableType = value;
            }
        }
        #endregion

    }
}
