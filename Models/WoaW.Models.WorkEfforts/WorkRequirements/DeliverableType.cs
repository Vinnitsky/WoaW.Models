namespace WoaW.Models.WorkEfforts.WorkRequirements
{
    public class DeliverableType
    {
        #region attributes
        public static readonly DeliverableType ProjectPlan = new DeliverableType() {Id="1", DisplayName="Project Plan"};
        public static readonly DeliverableType Presentation = new DeliverableType() {Id="2", DisplayName="Presentation"};
        public static readonly DeliverableType Report = new DeliverableType() {Id="3", DisplayName="Report"};
        #endregion

        #region properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
