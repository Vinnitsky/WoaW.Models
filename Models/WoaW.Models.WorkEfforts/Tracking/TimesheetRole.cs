using WoaW.Models.Parties.Root;

namespace WoaW.Models.WorkEfforts.Tracking
{
    public class TimesheetRole
    {
        #region properties
        public TimesheetRoleType TimesheetRoleType { get; set; }
        public Party Party { get; set; }
        public Timesheet Timesheet { get; set; }

        #endregion
    }
}
