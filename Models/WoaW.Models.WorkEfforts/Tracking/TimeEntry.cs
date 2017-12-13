using System;
using WoaW.Models.WorkEfforts.Generation;

namespace WoaW.Models.WorkEfforts.Tracking
{
    public class TimeEntry
    {
        #region properties
        public string Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public float Hours { get; set; }
        public string Comment { get; set; }
        public WorkEffort WorkEffort { get; set; }
        #endregion
    }
}
