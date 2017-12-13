using System;

namespace WoaW.Models.WorkEfforts.Generation
{
    public class WorkEffort
    {
        #region attributes
        private WorkEffortType _workEffortType;
        #endregion

        #region properies
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DateTime ScheduledStartDate { get; set; }
        public DateTime ScheduledComplitionDate { get; set; }
        public float TotalMoneyAllowed { get; set; }
        public float TotalHoursAllowed { get; set; }
        public float EstimatedHours { get; set; }

        public DateTime ActualStartDate { get; set; }
        public DateTime ActualComplitionDate { get; set; }
        public float ActualHours { get; set; }

        public WorkEffortType WorkEffortType
        {
            get { return _workEffortType; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(WorkEffortType));
                else
                    _workEffortType = value;
            }
        }

        #endregion
    }
}
